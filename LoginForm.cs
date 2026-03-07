using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuserid?.Text?.Trim() ?? "";
            string password = txtpassword?.Text ?? "";

            // 1. Validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a user name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuserid?.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword?.Focus();
                return;
            }

            // 2. Disable buttons so the user can't double-click
            btnlogin.Enabled = false;
            btnclear.Enabled = false;

            try
            {
                // 3. Simple, Synchronous Authentication Check
                bool isAuthenticated = Authenticate(username, password);

                if (isAuthenticated)
                {
                    // Perfect navigation pattern (Hide -> ShowDialog -> Show)
                    var menu = new Menuform();
                    this.Hide();
                    menu.ShowDialog();

                    // Once Menuform closes, clear the login fields and show LoginForm again
                    txtpassword?.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword?.Clear();
                    txtpassword?.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 4. Re-enable buttons no matter what happens
                btnlogin.Enabled = true;
                btnclear.Enabled = true;
            }
        }

        // Clean, normal method returning a simple true/false
        private bool Authenticate(string username, string password)
        {
            // Demo-only credentials
            return string.Equals(username, "system", StringComparison.OrdinalIgnoreCase) && password == "int123";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuserid?.Clear();
            txtpassword?.Clear();
            txtuserid?.Focus();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Ensure the entire application exits when the login form is closed
        }
    }
}