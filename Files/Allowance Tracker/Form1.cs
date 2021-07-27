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
    public partial class AllowanceTracker : Form
    {
        public AllowanceTracker() { InitializeComponent(); }
        private void button2_Click(object sender, EventArgs e)
        {
            string email = File.ReadLines(@"AllowanceData.txt").Take(1).First();
            //string password = File.ReadLines(@"AllowanceData.txt").Skip(1).Take(2)
            string passwordEntry = passwordBox.Text;
            string emailEntry = emailBox.Text;
            //if ((email != emailEntry) || (password != passwordEntry)) { textBox7.Text = password; return; }
            if ((emailEntry != "") && (emailEntry.Contains("@") == false)) { emailError(); return; }
            if (passwordEntry.Length == 0) { blankError(); return; }
            if (emailEntry.Length == 0) { blankError(); return; }
            if ((emailEntry.Length != 0) && (passwordEntry.Length != 0) && (emailEntry.Contains("@")))
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
        }
        public void blankError() { textBox7.Text = "Enter all fields!"; }
        public void emailError() { textBox7.Text = "Enter a valid email!"; }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar == true) { passwordBox.UseSystemPasswordChar = false; return; }
            else { passwordBox.UseSystemPasswordChar = true; return; }
        }
        private void AllowanceTracker_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
            this.Close();
        }
        private void emailBox_TextChanged(object sender, EventArgs e) { }

        private void passwordBox_TextChanged(object sender, EventArgs e) { }

        private void textBox7_TextChanged(object sender, EventArgs e) { }
    }
}
