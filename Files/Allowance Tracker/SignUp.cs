using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allowance_Tracker
{
    public partial class SignUp : Form
    {
        public SignUp() { InitializeComponent(); }
        private void button2_Click(object sender, EventArgs e)
        {
            string usernameInput = usernameBox.Text;
            string passwordInput = passwordBox.Text;
            Variables.SetVariables(passwordInput, usernameInput);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar == true) { passwordBox.UseSystemPasswordChar = false; return; }
            else { passwordBox.UseSystemPasswordChar = true; return; }
        }
    }
}