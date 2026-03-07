using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace HMS
{
    public partial class PatientForm : Form
    {
        private readonly string constr = "Data Source=Localhost:1521/XE;User Id=system;Password=int123;";

        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            LoadPatientData();
            LoadDoctorsIntoCombo();
        }

        private void LoadPatientData()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT PATIENT_ID, PAT_NAME, GENDER, DOB, AGE, CONTACT, ADDRESS, DOC_ID FROM PATIENTS", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvPatients.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctorsIntoCombo()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT DOCTOR_ID, DOC_NAME FROM DOCTORS", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "DOC_NAME";
                    comboBox1.ValueMember = "DOCTOR_ID";
                    comboBox1.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedGender()
        {
            if (rdoMale.Checked) return "Male";
            if (rdoFemale.Checked) return "Female";
            return string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPid.Text) || string.IsNullOrWhiteSpace(txtPName.Text))
            {
                MessageBox.Show("Patient ID and Name are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO PATIENTS (PATIENT_ID, PAT_NAME, GENDER, DOB, AGE, CONTACT, ADDRESS, DOC_ID)
VALUES (:Id, :Name, :Gender, :dob, :Age, :Contact, :Address, :doc_id)";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("Id", OracleDbType.Varchar2).Value = txtPid.Text.Trim();
                    cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = txtPName.Text.Trim();
                    cmd.Parameters.Add("Gender", OracleDbType.Varchar2).Value = GetSelectedGender();
                    cmd.Parameters.Add("dob", OracleDbType.Date).Value = dateTimePicker1.Value;

                    if (int.TryParse(txtAge.Text.Trim(), out var ageVal))
                        cmd.Parameters.Add("Age", OracleDbType.Int32).Value = ageVal;
                    else
                        cmd.Parameters.Add("Age", OracleDbType.Int32).Value = DBNull.Value;

                    cmd.Parameters.Add("Contact", OracleDbType.Varchar2).Value = txtContact.Text.Trim();
                    cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = txtAddress.Text.Trim();

                    // pass the doctor ID (ValueMember from the doctors combo)
                    var docVal = comboBox1.SelectedValue;
                    cmd.Parameters.Add("doc_id", OracleDbType.Varchar2).Value =
                        (docVal == null || docVal == DBNull.Value) ? DBNull.Value : docVal.ToString();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0) throw new InvalidOperationException("No rows inserted.");
                }

                LoadPatientData();
                btnClear_Click(this, EventArgs.Empty);
                MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPid.Text))
            {
                MessageBox.Show("Please select a patient to update (PID is required).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE PATIENTS SET PAT_NAME=:Name, GENDER=:Gender, DOB=:dob, AGE=:Age, CONTACT=:Contact, ADDRESS=:Address, DOC_ID=:doc_id WHERE PATIENT_ID=:Id";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("Name", OracleDbType.Varchar2).Value = txtPName.Text.Trim();
                    cmd.Parameters.Add("Gender", OracleDbType.Varchar2).Value = GetSelectedGender();
                    cmd.Parameters.Add("dob", OracleDbType.Date).Value = dateTimePicker1.Value;

                    if (int.TryParse(txtAge.Text.Trim(), out var ageVal))
                        cmd.Parameters.Add("Age", OracleDbType.Int32).Value = ageVal;
                    else
                        cmd.Parameters.Add("Age", OracleDbType.Int32).Value = DBNull.Value;

                    cmd.Parameters.Add("Contact", OracleDbType.Varchar2).Value = txtContact.Text.Trim();
                    cmd.Parameters.Add("Address", OracleDbType.Varchar2).Value = txtAddress.Text.Trim();

                    var docVal = comboBox1.SelectedValue;
                    cmd.Parameters.Add("doc_id", OracleDbType.Varchar2).Value =
                        (docVal == null || docVal == DBNull.Value) ? DBNull.Value : docVal.ToString();

                    cmd.Parameters.Add("Id", OracleDbType.Varchar2).Value = txtPid.Text.Trim();

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Patient updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Patient ID not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadPatientData();
                btnClear_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPid.Text))
            {
                MessageBox.Show("Please select a patient to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM PATIENTS WHERE PATIENT_ID=:Id";
                    cmd.BindByName = true;
                    cmd.Parameters.Add("Id", OracleDbType.Varchar2).Value = txtPid.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows <= 0) MessageBox.Show("Patient ID not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadPatientData();
                btnClear_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPid.Clear();
            txtPName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtAge.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            txtPid.Focus();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPatients.Rows[e.RowIndex];

            txtPid.Text = row.Cells["PATIENT_ID"].Value?.ToString() ?? "";
            txtPName.Text = row.Cells["PAT_NAME"].Value?.ToString() ?? "";

            string gender = row.Cells["GENDER"].Value?.ToString() ?? "";
            rdoMale.Checked = gender == "Male";
            rdoFemale.Checked = gender == "Female";

            dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DOB"].Value ?? DateTime.Now);
            txtAge.Text = row.Cells["AGE"].Value?.ToString() ?? "";
            txtContact.Text = row.Cells["CONTACT"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["ADDRESS"].Value?.ToString() ?? "";

            // use DOC_ID column (same as the PATIENTS table column we selected)
            if (dgvPatients.Columns.Contains("DOC_ID") && row.Cells["DOC_ID"].Value != null)
            {
                try { comboBox1.SelectedValue = row.Cells["DOC_ID"].Value; }
                catch { comboBox1.SelectedIndex = -1; }
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            DateTime now = DateTime.Now;
            int age = now.Year - dob.Year;
            if (now < dob.AddYears(age)) age--;
            txtAge.Text = age.ToString();
        }
    }
}