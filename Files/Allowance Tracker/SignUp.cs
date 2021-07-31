using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Allowance_Tracker { public partial class SignUp : Form { 
        public SignUp() { InitializeComponent(); }
        private void signUpButton_Click(object sender, EventArgs e) {
            using (StreamReader sr = new StreamReader("AllowanceData.txt")) {
                if (sr.ReadLine() != null) {
                    errorBox.Text = "Cannot sign up twice!";
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(passwordBox.Text) || string.IsNullOrWhiteSpace(usernameBox.Text)) {
                errorBox.Text = "Enter all fields!";
                return;
            }
            errorBox.Text = "";
            Variables.SetVariables(passwordBox.Text, usernameBox.Text);
            this.Hide();
            Variables.login.ShowDialog();
            this.Close();
        }
        private void hidePassword_CheckedChanged(object sender, EventArgs e) {
            if (passwordBox.UseSystemPasswordChar == true) { passwordBox.UseSystemPasswordChar = false; return; }
            else { passwordBox.UseSystemPasswordChar = true; return; }
        }
    }
}