using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HMS
{
    public partial class AppointmentForm : Form
    {
        private readonly string constr = "Data Source=localhost:1521/XE;User Id=system;Password=int123;";

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWard();
            LoadPatients();
            LoadDoctors();
            LoadGrid();
        }

        private void LoadWard()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT ward_id FROM ward", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    cmbroom.DataSource = dt;
                    cmbroom.DisplayMember = "ward_id";
                    cmbroom.ValueMember = "ward_id";
                    cmbroom.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading wards: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPatients()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT PATIENT_ID FROM PATIENTS", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    // Use the actual column name as DisplayMember/ValueMember
                    cmbpatient.DataSource = dt;
                    cmbpatient.DisplayMember = "PATIENT_ID";
                    cmbpatient.ValueMember = "PATIENT_ID";
                    cmbpatient.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT DOCTOR_ID FROM DOCTORS", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    cmbdoc.DataSource = dt;
                    cmbdoc.DisplayMember = "DOCTOR_ID";
                    cmbdoc.ValueMember = "DOCTOR_ID";
                    cmbdoc.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGrid()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT * FROM appointment", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the Appointment No.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patVal = cmbpatient.SelectedValue?.ToString();
            var docVal = cmbdoc.SelectedValue?.ToString();
            var wardVal = cmbroom.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(patVal) || string.IsNullOrEmpty(docVal) || string.IsNullOrEmpty(wardVal))
            {
                MessageBox.Show("Please select Patient, Doctor and Room.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO appointment (appointment_no, pat_id, doc_id, appointment_date, ward_id)
VALUES (:appNo, :patId, :docId, :appointmentDate, :wardId)";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("appNo", OracleDbType.Varchar2).Value = textBox1.Text.Trim();
                    cmd.Parameters.Add("patId", OracleDbType.Varchar2).Value = Convert.ToString(cmbpatient.SelectedValue);
                    cmd.Parameters.Add("docId", OracleDbType.Varchar2).Value = Convert.ToString(cmbdoc.SelectedValue);
                    cmd.Parameters.Add("appointmentDate", OracleDbType.Date).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("wardId", OracleDbType.Varchar2).Value = Convert.ToString(cmbroom.SelectedValue);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Appointment inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Insert failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting appointment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the Appointment No.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patVal = cmbpatient.SelectedValue?.ToString();
            var docVal = cmbdoc.SelectedValue?.ToString();
            var wardVal = cmbroom.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(patVal) || string.IsNullOrEmpty(docVal) || string.IsNullOrEmpty(wardVal))
            {
                MessageBox.Show("Please select Patient, Doctor and Room.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE appointment
SET pat_id = :patId,
    doc_id = :docId,
    appointment_date = :appointmentDate,
    ward_id = :wardId
WHERE appointment_no = :appNo";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("patId", OracleDbType.Varchar2).Value = patVal;
                    cmd.Parameters.Add("docId", OracleDbType.Varchar2).Value = docVal;
                    cmd.Parameters.Add("appointmentDate", OracleDbType.Date).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("wardId", OracleDbType.Varchar2).Value = wardVal;
                    cmd.Parameters.Add("appNo", OracleDbType.Varchar2).Value = textBox1.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Appointment updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Appointment No not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating appointment: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM appointment WHERE appointment_no = :appNo";
                    cmd.BindByName = true;
                    cmd.Parameters.Add("appNo", OracleDbType.Varchar2).Value = textBox1.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Appointment deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Appointment ID not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting appointment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Defensive clear: avoid NullReferenceException if a control is null
            textBox1?.Clear();

            if (dateTimePicker1 != null)
                dateTimePicker1.Value = DateTime.Now;

            // Avoid triggering grid events by clearing selection
            dataGridView1?.ClearSelection();

            if (cmbroom != null && cmbroom.Items.Count > 0) cmbroom.SelectedIndex = -1;
            else if (cmbroom != null) cmbroom.SelectedIndex = -1; // still safe

            if (cmbpatient != null && cmbpatient.Items.Count > 0) cmbpatient.SelectedIndex = -1;
            else if (cmbpatient != null) cmbpatient.SelectedIndex = -1;

            if (cmbdoc != null && cmbdoc.Items.Count > 0) cmbdoc.SelectedIndex = -1;
            else if (cmbdoc != null) cmbdoc.SelectedIndex = -1;

            textBox1?.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1?.Rows[e.RowIndex];
            if (row == null || row.IsNewRow) return;

            if (dataGridView1!.Columns.Contains("appointment_no"))
            {
                var cell = row.Cells["appointment_no"];
                if (cell != null && cell.Value != null)
                    textBox1.Text = cell.Value.ToString();
            }

            if (dataGridView1.Columns.Contains("pat_id"))
            {
                var cell = row.Cells["pat_id"];
                if (cell != null)
                    cmbpatient.SelectedValue = cell.Value;
            }

            if (dataGridView1.Columns.Contains("doc_id"))
            {
                var cell = row.Cells["doc_id"];
                if (cell != null)
                    cmbdoc.SelectedValue = cell.Value;
            }

            if (dataGridView1.Columns.Contains("appointment_date"))
            {
                var cell = row.Cells["appointment_date"];
                if (cell != null && cell.Value != null)
                    dateTimePicker1.Value = Convert.ToDateTime(cell.Value);
            }

            if (dataGridView1.Columns.Contains("ward_id"))
            {
                var cell = row.Cells["ward_id"];
                if (cell != null)
                    cmbroom.SelectedValue = cell.Value;
            }
        }
    }
}
