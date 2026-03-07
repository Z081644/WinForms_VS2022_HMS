using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
            LoadFormInPanel(new DashboardForm(this)); // Default me Dashboard khulega
        }

        public void LoadFormInPanel(Form childForm)
        {
            mainPanel.Controls.Clear(); // Pehle se open form ko hata dega
            childForm.TopLevel = false; // Alag window banne se rokega
            childForm.FormBorderStyle = FormBorderStyle.None; // Border hata dega
            childForm.Dock = DockStyle.Fill; // Panel ki puri jagah le lega

            mainPanel.Controls.Add(childForm); // Panel me form daal dega
            childForm.Show(); // Form ko dikhayega
        }
        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            var login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new PatientForm()); // Patient form panel me khulega
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new DoctorForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new BillingForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AppointmentForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new RoomForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new PharmacyForm());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoadFormInPanel(new DashboardForm(this));
        }
    }
}
