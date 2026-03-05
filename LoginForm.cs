using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            var username = txtuserid?.Text?.Trim();
            var password = txtpassword?.Text; // For production consider a more secure handling

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

            btnlogin.Enabled = false;
            btnclear.Enabled = false;
            try
            {
                bool isAuthenticated = await AuthenticateAsync(username, password).ConfigureAwait(false);

                // Switch back to UI thread to update UI
                if (InvokeRequired)
                {
                    Invoke(new Action(() => PostAuthentication(isAuthenticated)));
                }
                else
                {
                    PostAuthentication(isAuthenticated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        btnlogin.Enabled = true;
                        btnclear.Enabled = true;
                    }));
                }
                else
                {
                    btnlogin.Enabled = true;
                    btnclear.Enabled = true;
                }
            }
        }

        private void PostAuthentication(bool ok)
        {
            if (ok)
            {
                var menu = new Menuform(); // ensure class name matches your project
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid user name or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }

        private Task<bool> AuthenticateAsync(string username, string password)
        {
            // Replace with your real authentication (DB, API, etc.)
            return Task.Run(async () =>
            {
                await Task.Delay(300).ConfigureAwait(false);
                // Demo-only credentials -- DO NOT use in production
                return string.Equals(username, "system", StringComparison.OrdinalIgnoreCase)
                       && password == "int123";
            });
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuserid.Clear();
            txtpassword.Clear();
            txtuserid.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // If not needed remove the event subscription in the designer to avoid empty handler.
        }
    }
}