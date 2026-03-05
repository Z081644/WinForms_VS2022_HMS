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
        }
        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorForm df = new DoctorForm();
            df.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillingForm bf = new BillingForm();
            bf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppointmentForm af = new AppointmentForm();
            af.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoomForm rf = new RoomForm();
            rf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PharmacyForm phf = new PharmacyForm();
            phf.Show();
            this.Hide();
        }
    }
}
