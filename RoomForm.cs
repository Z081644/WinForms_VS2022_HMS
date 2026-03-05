using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HMS
{
    public partial class RoomForm : Form
    {
        private readonly string constr = "User Id=System;Password=int123;Data Source=localhost:1521/XE;";

        public RoomForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            try
            {
                using (var conn = new OracleConnection(constr))
                using (var da = new OracleDataAdapter("SELECT ward_id, ward_name, ward_type, total_beds, avail_beds FROM ward", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading wards: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (dataGridView1.Columns.Contains("ward_id"))
                textBox1.Text = row.Cells["ward_id"].Value?.ToString() ?? string.Empty;
            if (dataGridView1.Columns.Contains("ward_name"))
                textBox2.Text = row.Cells["ward_name"].Value?.ToString() ?? string.Empty;
            if (dataGridView1.Columns.Contains("ward_type"))
                comboBox1.Text = row.Cells["ward_type"].Value?.ToString() ?? string.Empty;

            var totalBedsVal = dataGridView1.Columns.Contains("total_beds") ? row.Cells["total_beds"].Value?.ToString() : null;
            if (int.TryParse(totalBedsVal, out var tb))
            {
                radioButton1.Checked = tb == int.Parse(radioButton1.Text);
                radioButton2.Checked = tb == int.Parse(radioButton2.Text);
                radioButton3.Checked = tb == int.Parse(radioButton3.Text);
                radioButton4.Checked = tb == int.Parse(radioButton4.Text);
            }
            else
            {
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            }

            if (dataGridView1.Columns.Contains("avail_beds"))
                textBox4.Text = row.Cells["avail_beds"].Value?.ToString() ?? string.Empty;
        }

        private int GetSelectedBedCount()
        {
            if (radioButton1.Checked && int.TryParse(radioButton1.Text, out var v1)) return v1;
            if (radioButton2.Checked && int.TryParse(radioButton2.Text, out var v2)) return v2;
            if (radioButton3.Checked && int.TryParse(radioButton3.Text, out var v3)) return v3;
            if (radioButton4.Checked && int.TryParse(radioButton4.Text, out var v4)) return v4;
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ward ID and Name required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalBeds = GetSelectedBedCount();
            if (totalBeds == 0)
            {
                MessageBox.Show("Select total beds.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO ward (ward_id, ward_name, ward_type, total_beds, avail_beds)
VALUES (:wid, :wname, :wtype, :tbeds, :abeds)";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("wid", OracleDbType.Varchar2).Value = textBox1.Text.Trim();
                    cmd.Parameters.Add("wname", OracleDbType.Varchar2).Value = textBox2.Text.Trim();
                    cmd.Parameters.Add("wtype", OracleDbType.Varchar2).Value = comboBox1.Text.Trim();
                    cmd.Parameters.Add("tbeds", OracleDbType.Decimal).Value = totalBeds;
                    cmd.Parameters.Add("abeds", OracleDbType.Decimal).Value = decimal.TryParse(textBox4.Text, out var ab) ? ab : 0m;

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Ward Inserted");
                    else MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting ward: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ward ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalBeds = GetSelectedBedCount();
            if (totalBeds == 0)
            {
                MessageBox.Show("Select total beds.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE ward
SET ward_name = :wname,
    ward_type = :wtype,
    total_beds = :tbeds,
    avail_beds = :abeds
WHERE ward_id = :wid";
                    cmd.BindByName = true;

                    cmd.Parameters.Add("wname", OracleDbType.Varchar2).Value = textBox2.Text.Trim();
                    cmd.Parameters.Add("wtype", OracleDbType.Varchar2).Value = comboBox1.Text.Trim();
                    cmd.Parameters.Add("tbeds", OracleDbType.Decimal).Value = totalBeds;
                    cmd.Parameters.Add("abeds", OracleDbType.Decimal).Value = decimal.TryParse(textBox4.Text, out var ab) ? ab : 0m;
                    cmd.Parameters.Add("wid", OracleDbType.Varchar2).Value = textBox1.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Ward Updated");
                    else MessageBox.Show("Ward not found", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating ward: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter/select Ward ID to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this ward?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new OracleConnection(constr))
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM ward WHERE ward_id = :wid";
                    cmd.BindByName = true;
                    cmd.Parameters.Add("wid", OracleDbType.Varchar2).Value = textBox1.Text.Trim();

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Ward Deleted");
                    else MessageBox.Show("Ward not found", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting ward: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            textBox1.Focus();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Menuform mf = new Menuform();
            mf.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DoctorForm df = new DoctorForm();
            df.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppointmentForm af = new AppointmentForm();
            af.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in the Room management section.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PharmacyForm phf = new PharmacyForm();
            phf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillingForm bf = new BillingForm();
            bf.Show();
            this.Hide();
        }
    }
}
