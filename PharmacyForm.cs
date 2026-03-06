using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS
{
    public partial class PharmacyForm : Form
    {
        private readonly string constr = "Data Source=localhost:1521/xe;User Id=system;Password=int123;";

        public PharmacyForm()
        {
            InitializeComponent();
        }

        private void PharmacyForm_Load(object sender, EventArgs e)
        {
            LoadPharmacyForm();
        }

        private void LoadPharmacyForm()
        {
            try
            {
                using (var con = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT MEDICINE_ID, MED_NAME, MED_TYPE, MANU_DATE, EXP_DATE, PRICE FROM pharmacy", con))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvmedi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Pharmacy:{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePharmacyInputs(bool requireId)
        {
            if (requireId && string.IsNullOrWhiteSpace(txtmed_id.Text))
            {
                MessageBox.Show("Medicine ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmed_id.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtmed_name.Text))
            {
                MessageBox.Show("Medicine Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmed_name.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidatePharmacyInputs(requireId: true)) return;

            if (!decimal.TryParse(txtmed_price.Text.Trim(), out var price))
            {
                MessageBox.Show("Invalid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmed_price.Focus();
                return;
            }

            try
            {
                using (var con = new OracleConnection(constr))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO pharmacy (medicine_id, med_name, med_type, manu_date, exp_date, price) VALUES (:medid, :medname, :type, :manudate, :expdate, :price)";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("medid", OracleDbType.Varchar2).Value = txtmed_id.Text.Trim();
                    cmd.Parameters.Add("medname", OracleDbType.Varchar2).Value = txtmed_name.Text.Trim();
                    cmd.Parameters.Add("type", OracleDbType.Varchar2).Value = cmbmed_type.SelectedItem?.ToString() ?? string.Empty;
                    cmd.Parameters.Add("manudate", OracleDbType.Date).Value = manu_date.Value.Date;
                    cmd.Parameters.Add("expdate", OracleDbType.Date).Value = exp_date.Value.Date;
                    cmd.Parameters.Add("price", OracleDbType.Decimal).Value = price;

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0) throw new InvalidOperationException("No rows inserted.");
                }

                LoadPharmacyForm();
                btnClear_Click_1(this, EventArgs.Empty);
                MessageBox.Show("Medicine added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding Medicine: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtmed_id.Clear();
            txtmed_name.Clear();
            cmbmed_type.SelectedIndex = -1;
            manu_date.Value = DateTime.Now;
            exp_date.Value = DateTime.Now;
            txtmed_price.Clear();
            txtmed_id.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidatePharmacyInputs(requireId: true)) return;

            if (!decimal.TryParse(txtmed_price.Text.Trim(), out var price))
            {
                MessageBox.Show("Invalid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmed_price.Focus();
                return;
            }

            try
            {
                using (var con = new OracleConnection(constr))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE pharmacy SET med_name=:medname, med_type=:type, manu_date=:manudate, exp_date=:expdate, price=:price WHERE medicine_id=:medid";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("medname", OracleDbType.Varchar2).Value = txtmed_name.Text.Trim();
                    cmd.Parameters.Add("type", OracleDbType.Varchar2).Value = cmbmed_type.SelectedItem?.ToString() ?? string.Empty;
                    cmd.Parameters.Add("manudate", OracleDbType.Date).Value = manu_date.Value.Date;
                    cmd.Parameters.Add("expdate", OracleDbType.Date).Value = exp_date.Value.Date;
                    cmd.Parameters.Add("price", OracleDbType.Decimal).Value = price;
                    cmd.Parameters.Add("medid", OracleDbType.Varchar2).Value = txtmed_id.Text.Trim();

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Medicine updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Medicine ID not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadPharmacyForm();
                btnClear_Click_1(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating Medicine: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmed_id.Text))
            {
                MessageBox.Show("Please Select a Medicine to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                using (var con = new OracleConnection(constr))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM pharmacy WHERE medicine_id=:medid";
                    cmd.BindByName = true;
                    cmd.Parameters.Add("medid", OracleDbType.Varchar2).Value = txtmed_id.Text.Trim();

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0) MessageBox.Show("Medicine ID not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        LoadPharmacyForm();
                        btnClear_Click_1(this, EventArgs.Empty);
                        MessageBox.Show("Medicine deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Medicine: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvmedi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvmedi.Rows[e.RowIndex];

            txtmed_id.Text = row.Cells["medicine_id"].Value?.ToString() ?? string.Empty;
            txtmed_name.Text = row.Cells["med_name"].Value?.ToString() ?? string.Empty;
            cmbmed_type.SelectedItem = row.Cells["med_type"].Value?.ToString();
            manu_date.Value = Convert.ToDateTime(row.Cells["manu_date"].Value ?? DateTime.Now);
            exp_date.Value = Convert.ToDateTime(row.Cells["exp_date"].Value ?? DateTime.Now);
            txtmed_price.Text = row.Cells["price"].Value?.ToString() ?? string.Empty;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            LoginForm lf = new LoginForm();
            Hide();
            lf.ShowDialog();
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Menuform mf = new Menuform();
            Hide();
            mf.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            Hide();
            pf.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorForm df = new DoctorForm();
            Hide();
            df.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppointmentForm af = new AppointmentForm();
            Hide();
            af.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoomForm rf = new RoomForm();
            Hide();
            rf.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in the Pharmacy section.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillingForm bf = new BillingForm();
            Hide();
            bf.ShowDialog();
            Show();
        }
    }
}
