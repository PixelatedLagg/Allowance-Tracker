using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Allowance_Tracker { public partial class Login : Form {
        public Login() { InitializeComponent(); }
        private void logInButton_Click(object sender, EventArgs e) {
            try { Variables.GetVariables(); }
            catch { errorText.Text = "Create an account!"; return; }
            if (passwordBox.Text != Variables.password || usernameBox.Text != Variables.username) {
                errorText.Text = "Username or password is incorrect!";
                return;
            }
            this.Hide();
            Variables.mainpage.ShowDialog();
            this.Close();
        }
        private void HidePassword_CheckedChanged(object sender, EventArgs e) {
            if (passwordBox.UseSystemPasswordChar == true) { passwordBox.UseSystemPasswordChar = false; return; }
            else { passwordBox.UseSystemPasswordChar = true; return; }
        }
        private void AllowanceTracker_Load(object sender, EventArgs e) { }
        private void SignUpButton_Click(object sender, EventArgs e) { 
            this.Hide();
            Variables.signup.ShowDialog();
            this.Close();
        }
    }
}
