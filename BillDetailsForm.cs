using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HMS
{
    public partial class BillDetailsForm : Form
    {
        string searchBillNo;
        string constr = "Data Source=localhost:1521/xe;User Id=system;Password=int123;";
        public BillDetailsForm(string bNo)
        {
            InitializeComponent();
            searchBillNo = bNo;
        }

        private void BillDetailsForm_Load(object sender, EventArgs e)
        {
            LoadBillData();
        }

        private void LoadBillData()
        {
            using (OracleConnection conn = new OracleConnection(constr))
            {
                try
                {
                    conn.Open();

                    // --- 1. BILL HEADER aur PATIENT ka Data Laana (JOIN lagakar) ---
                    string headerQuery = @"SELECT h.BILL_NO, h.SUB_TOTAL, h.TAX_AMOUNT, h.DISCOUNT, 
                                          h.NET_AMOUNT, h.PAYMENT_METHOD, p.PAT_NAME 
                                   FROM BILL_HEADER h 
                                   JOIN PATIENTS p ON h.PID = p.PATIENT_ID 
                                   WHERE h.BILL_NO = :bno";

                    OracleCommand cmdHeader = new OracleCommand(headerQuery, conn);
                    cmdHeader.Parameters.Add(":bno", searchBillNo);

                    using (OracleDataReader reader = cmdHeader.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Labels mein data set karna
                            lblBillNo.Text = "Bill No: " + reader["BILL_NO"].ToString();
                            lblPatientName.Text = "Patient Name: " + reader["PAT_NAME"].ToString();

                            // Agar aapke database mein Doctor ka table hai, toh yahan column name likhein
                            // Filhal ke liye main ek placeholder lagaya hai.
                            lblDoctorName.Text = "Doctor Name: Dr. Assigned Doctor";

                            lblSubTotal.Text = "Sub Total: ₹" + reader["SUB_TOTAL"].ToString();
                            lblTax.Text = "Tax: ₹" + reader["TAX_AMOUNT"].ToString();
                            lblDiscount.Text = "Discount: ₹" + reader["DISCOUNT"].ToString();
                            lblNet.Text = "Net Amount: ₹" + reader["NET_AMOUNT"].ToString();
                            lblPayment.Text = "Payment Mode: " + reader["PAYMENT_METHOD"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Is Bill Number ka koi record nahi mila!");
                            this.Close();
                            return;
                        }
                    }

                    // --- 2. BILL DETAILS KA DATA LAANA (Grid ke liye) ---
                    string detailQuery = "SELECT SERVICE_DESC, QTY, RATE, LINE_TOTAL FROM BILL_DETAILS WHERE BILL_NO = :bno";
                    OracleDataAdapter da = new OracleDataAdapter(detailQuery, conn);
                    da.SelectCommand.Parameters.Add(":bno", searchBillNo);

                    DataTable dtDetails = new DataTable();
                    da.Fill(dtDetails);

                    dgvBillItems.DataSource = dtDetails;

                    // Grid Styling
                    dgvBillItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvBillItems.AllowUserToAddRows = false;
                    dgvBillItems.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bill: " + ex.Message);
                }
            }
        }
    }
}
