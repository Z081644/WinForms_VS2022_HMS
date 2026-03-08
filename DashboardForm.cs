using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HMS
{
    public partial class DashboardForm : Form
    {
        Menuform mf;
        private readonly string constr = "Data Source= localhost:1521/XE;User Id=system;Password=int123;";
        public DashboardForm(Menuform parentForm)
        {
            InitializeComponent();
            mf = parentForm;
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadRealTimeData();
        }

        private void LoadRealTimeData()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(constr))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Patients";
                    OracleCommand cmdP = new OracleCommand(query, conn);
                    int patCount = Convert.ToInt32(cmdP.ExecuteScalar());
                    label2.Text = patCount.ToString();

                    query = "SELECT COUNT(*) FROM Doctors";
                    OracleCommand cmdD = new OracleCommand(query, conn);
                    int docCount = Convert.ToInt32(cmdD.ExecuteScalar());
                    label3.Text = docCount.ToString();

                    query = "SELECT COUNT(*) FROM Appointment where appointment_date >= TRUNC(SYSDATE)";
                    OracleCommand cmdA = new OracleCommand(query, conn);
                    int pendingApp = Convert.ToInt32(cmdA.ExecuteScalar());
                    label5.Text = pendingApp.ToString();

                    query = "SELECT COUNT(*) FROM Ward where avail_beds >0";
                    OracleCommand cmdW = new OracleCommand(query, conn);
                    int availBeds = Convert.ToInt32(cmdW.ExecuteScalar());
                    label9.Text = availBeds.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void rdpPatient_Click(object sender, EventArgs e)
        {
            mf.LoadFormInPanel(new PatientForm());
        }

        private void roundedPanel1_Click(object sender, EventArgs e)
        {
            mf.LoadFormInPanel(new DoctorForm());
        }

        private void roundedPanel2_Click(object sender, EventArgs e)
        {
            mf.LoadFormInPanel(new AppointmentForm());
        }

        private void roundedPanel3_Click(object sender, EventArgs e)
        {
            mf.LoadFormInPanel(new RoomForm());
        }

        private void roundedPanel4_Click(object sender, EventArgs e)
        {
            mf.LoadFormInPanel(new PharmacyForm());
        }

        private void roundedPanel5_Click(object sender, EventArgs e)
        {
            mf.LoadFormInPanel(new BillingForm());   
        }
    }
}
