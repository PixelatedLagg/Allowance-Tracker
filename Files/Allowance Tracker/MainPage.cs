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
    public partial class Mainpage : Form
    {
        public Mainpage() { InitializeComponent(); StartVariables(); }
        public void StartVariables() {
            this.childNameOne.Text = Variables.name1;
            this.childNameTwo.Text = Variables.name2;
            this.childNameThree.Text = Variables.name3;
            this.childNameFour.Text = Variables.name4;
            this.childNameFive.Text = Variables.name5;
            this.childAmountOne.Text = Convert.ToString(Variables.money1);
            this.childAmountTwo.Text = Convert.ToString(Variables.money2);
            this.childAmountThree.Text = Convert.ToString(Variables.money3);
            this.childAmountFour.Text = Convert.ToString(Variables.money4);
            this.childAmountFive.Text = Convert.ToString(Variables.money5);
        }
        private void AddMoney_Click(object sender, EventArgs e) {
            string child = addMoneyChild.Text;
            string money = addMoneyAmount.Text;
            string comment = addMoneyComment.Text;
            if (child == null || money == null) { addMoneyError.Text = "Enter all fields!"; return; }
            if (Variables.name1 != child && Variables.name2 != child && Variables.name3 != child && Variables.name4 != child && Variables.name5 != child) {
                addMoneyError.Text = "Child does not exist!";
                return;
            }
            try { 
                double moneyAmount = Convert.ToDouble(money);
                if (moneyAmount <= 0) { addMoneyError.Text = "Enter a valid money amount!"; return; }
                if (child == Variables.name1) {
                    Variables.money1 += moneyAmount;
                    Variables.ChangeVariables();
                    StartVariables();
                }
                if (child == Variables.name2) {
                    Variables.money2 += moneyAmount;
                    Variables.ChangeVariables();
                    StartVariables();
                }
                if (child == Variables.name3) {
                    Variables.money3 += moneyAmount;
                    Variables.ChangeVariables();
                    StartVariables();
                }
                if (child == Variables.name4) {
                    Variables.money4 += moneyAmount;
                    Variables.ChangeVariables();
                    StartVariables();
                }
                if (child == Variables.name5) {
                    Variables.money5 += moneyAmount;
                    Variables.ChangeVariables();
                    StartVariables();
                }
            }
            catch { addMoneyError.Text = "Enter a valid money amount!"; return; }
        }
        private void AddChild_Click(object sender, EventArgs e) {
            string child = addChildName.Text;
            if (child == null) { childError.Text = "Enter all fields!"; return; }
            if (Variables.name1 == "child" && Variables.name2 == "child" && Variables.name3 == "child" && Variables.name4 == "child" && Variables.name5 == "child") {
                childError.Text = "All child slots are full!";
                return;
            }
            if (Variables.name1 == "child") {
                Variables.name1 = child;
                Variables.ChangeVariables();
                StartVariables();
            }
            if (Variables.name2 == "child") {
                Variables.name2 = child;
                Variables.ChangeVariables();
                StartVariables();
            }
            if (Variables.name3 == "child") {
                Variables.name3 = child;
                Variables.ChangeVariables();
                StartVariables();
            }
            if (Variables.name4 == "child") {
                Variables.name4 = child;
                Variables.ChangeVariables();
                StartVariables();
            }
            if (Variables.name5 == "child") {
                Variables.name5 = child;
                Variables.ChangeVariables();
                StartVariables();
            }
        }
    }
}
