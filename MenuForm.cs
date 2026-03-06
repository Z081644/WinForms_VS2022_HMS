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
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            BillingForm bf = new BillingForm();
            Hide();
            bf.ShowDialog();
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
            this.Hide();
            rf.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PharmacyForm phf = new PharmacyForm();
            Hide();
            phf.Show();
            Show();
        }
    }
}
