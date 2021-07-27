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

namespace Allowance_Tracker
{
    public partial class Login : Form
    {
        public Login() { InitializeComponent(); }
        private void button2_Click(object sender, EventArgs e)
        {
            Variables.GetVariables();
        }
        public void BlankError() { errorText.Text = "Enter all fields!"; return; }
        public void EmailError() { errorText.Text = "Enter a valid email!"; return; }
        private void HidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar == true) { passwordBox.UseSystemPasswordChar = false; return; }
            else { passwordBox.UseSystemPasswordChar = true; return; }
        }
        private void AllowanceTracker_Load(object sender, EventArgs e) { }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Variables.signup.ShowDialog();
            this.Close();
        }
    }
}
