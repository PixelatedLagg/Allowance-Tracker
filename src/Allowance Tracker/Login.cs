using System;
using System.Windows.Forms;
namespace Allowance_Tracker 
{ 
    public partial class Login : Form 
    {
        public Login() { InitializeComponent(); }
        private void logInButton_Click(object sender, EventArgs e) 
        {
            Variables local = new Variables();
            try { local.GetVariables(); } 
            catch { errorText.Text = "Create an account!"; return; }
            if (passwordBox.Text != local.Password || userNameBox.Text != local.UserName) { errorText.Text = "Username or password is incorrect!"; return; }
            this.Hide();
            new Mainpage().ShowDialog();
            this.Close();
        }
        private void HidePassword_CheckedChanged(object sender, EventArgs e) 
        {
            if (passwordBox.UseSystemPasswordChar == true) { passwordBox.UseSystemPasswordChar = false; return; }
            else { passwordBox.UseSystemPasswordChar = true; }
        }
        private void AllowanceTracker_Load(object sender, EventArgs e) { }
        private void SignUpButton_Click(object sender, EventArgs e) { this.Hide(); new SignUp().ShowDialog(); this.Close(); }
    }
}
