using System;
using System.Windows.Forms;
using System.IO;

namespace Allowance_Tracker 
{ 
    public partial class SignUp : Form 
    { 
        public SignUp() { InitializeComponent(); }
        private void signUpButton_Click(object sender, EventArgs e) 
        {
            Variables local = new Variables();
            using (StreamReader sr = new StreamReader("AllowanceData.txt")) { if (sr.ReadLine() != null) { errorBox.Text = "Cannot sign up twice!"; return; } }
            if (string.IsNullOrWhiteSpace(passwordBox.Text) || string.IsNullOrWhiteSpace(userNameBox.Text)) { errorBox.Text = "Enter all fields!"; return; }
            errorBox.Text = "";
            local.SetVariables(passwordBox.Text, userNameBox.Text);
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }
        private void hidePassword_CheckedChanged(object sender, EventArgs e) 
        {
            if (passwordBox.UseSystemPasswordChar == true) { passwordBox.UseSystemPasswordChar = false; return; }
            else { passwordBox.UseSystemPasswordChar = true; }
        }
    }
}