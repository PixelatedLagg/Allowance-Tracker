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
    public partial class Form2 : Form
    {
        public Form2() { InitializeComponent(); }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }

        private void textBox13_TextChanged(object sender, EventArgs e) { }

        private void textBox18_TextChanged(object sender, EventArgs e) { if (textBox18.Text.Length > 50) { textBox18.Text = "Too long!"; } }

        private void textBox17_TextChanged(object sender, EventArgs e) { }

        private void textBox16_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string moneyInput = textBox17.Text;
            moneyInput = moneyInput.Replace("$", "");
            string childName = textBox16.Text;
            string commentInput = textBox18.Text;
            if (childName == "") { blankError(); return; }
            if (moneyInput == "") { blankError(); return; }
            if (moneyInput.Length > 10) { moneyError(); return; }
            if (moneyInput != "") { textBox7.Text = ($"${moneyInput}"); }
        }
        public void blankError() { textBox19.Text = "Enter child name and amount of money!"; return; }
        public void moneyError() { textBox19.Text = "We both know you don't have that kind of money..."; return; }
        private void textBox19_TextChanged(object sender, EventArgs e) { }
    }
}
