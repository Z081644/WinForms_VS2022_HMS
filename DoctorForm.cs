using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HMS
{
    public partial class DoctorForm : Form
    {
        private readonly string constr = "Data Source=Localhost:1521/XE;User Id=system;Password=int123;";

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctorData();
        }

        private void LoadDoctorData()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT DOCTOR_ID, DOC_NAME, SPECIALIZATION, PHONE, EMAIL FROM DOCTORS", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvDoctors.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateDoctorInputs(true)) return;

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO DOCTORS (DOCTOR_ID, DOC_NAME, SPECIALIZATION, PHONE, EMAIL)
VALUES (:Id, :Name, :Spec, :Phone, :Email)";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("Id", OracleDbType.Varchar2).Value = txtDoctorId.Text.Trim();
                    cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = txtDocName.Text.Trim();
                    cmd.Parameters.Add("Spec", OracleDbType.Varchar2).Value = txtSpecialization.Text.Trim();
                    cmd.Parameters.Add("Phone", OracleDbType.Varchar2).Value = txtPhone.Text.Trim();
                    cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = txtEmail.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0) throw new InvalidOperationException("No rows inserted.");
                }

                LoadDoctorData();
                ClearInputs();
                MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateDoctorInputs(true)) return;

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE DOCTORS SET DOC_NAME=:Name, SPECIALIZATION=:Spec, PHONE=:Phone, EMAIL=:Email WHERE DOCTOR_ID=:Id";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = txtDocName.Text.Trim();
                    cmd.Parameters.Add("Spec", OracleDbType.Varchar2).Value = txtSpecialization.Text.Trim();
                    cmd.Parameters.Add("Phone", OracleDbType.Varchar2).Value = txtPhone.Text.Trim();
                    cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = txtEmail.Text.Trim();
                    cmd.Parameters.Add("Id", OracleDbType.Varchar2).Value = txtDoctorId.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0) MessageBox.Show("Doctor ID not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        LoadDoctorData();
                        ClearInputs();
                        MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating doctor: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoctorId.Text))
            {
                MessageBox.Show("Please select a doctor to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM DOCTORS WHERE DOCTOR_ID=:Id";
                    cmd.BindByName = true;
                    cmd.Parameters.Add("Id", OracleDbType.Varchar2).Value = txtDoctorId.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0) MessageBox.Show("Doctor ID not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        LoadDoctorData();
                        ClearInputs();
                        MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting doctor: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtDoctorId.Clear();
            txtDocName.Clear();
            txtSpecialization.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtDoctorId.Focus();
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDoctors.Rows[e.RowIndex];
            txtDoctorId.Text = GetCellValue(row, "DOCTOR_ID");
            txtDocName.Text = GetCellValue(row, "DOC_NAME");
            txtSpecialization.Text = GetCellValue(row, "SPECIALIZATION");
            txtPhone.Text = GetCellValue(row, "PHONE");
            txtEmail.Text = GetCellValue(row, "EMAIL");
        }

        private static string GetCellValue(DataGridViewRow row, string columnName)
        {
            if (row?.DataGridView == null) return string.Empty;
            if (!row.DataGridView.Columns.Contains(columnName)) return string.Empty;
            return row.Cells[columnName]?.Value?.ToString() ?? string.Empty;
        }

        private bool ValidateDoctorInputs(bool requireId)
        {
            if (requireId && string.IsNullOrWhiteSpace(txtDoctorId.Text))
            {
                MessageBox.Show("Doctor ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoctorId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocName.Text))
            {
                MessageBox.Show("Doctor name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocName.Focus();
                return false;
            }

            return true;
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}