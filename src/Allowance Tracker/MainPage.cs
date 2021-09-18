using System;
using System.Globalization;
using System.Windows.Forms;
namespace Allowance_Tracker 
{ 
    public partial class Mainpage : Form 
    {
        public Mainpage() { InitializeComponent(); StartVariables(); }
        public void StartVariables() 
        {
            Variables local = new Variables();
            local.GetVariables();
            childNameOne.Text = local.Name1;
            childNameTwo.Text = local.Name2;
            childNameThree.Text = local.Name3;
            childNameFour.Text = local.Name4;
            childNameFive.Text = local.Name5;
            childAmountOne.Text = Convert.ToString(local.Money1);
            childAmountTwo.Text = Convert.ToString(local.Money2);
            childAmountThree.Text = Convert.ToString(local.Money3);
            childAmountFour.Text = Convert.ToString(local.Money4);
            childAmountFive.Text = Convert.ToString(local.Money5);
            Date1.Text = local.Date1;
            Date2.Text = local.Date2;
            Date3.Text = local.Date3;
            Comment1.Text = local.Comment1;
            Comment2.Text = local.Comment2;
            Comment3.Text = local.Comment3;
        }
        private void AddMoney_Click(object sender, EventArgs e) 
        {
            Variables local = new Variables();
            local.GetVariables();
            string child = addMoneyChild.Text;
            string money = addMoneyAmount.Text;
            string comment = addMoneyComment.Text;
            if (child == null || money == null) { addMoneyError.Text = "Enter all fields!"; return; }
            try { double test = Convert.ToDouble(money); } catch { addMoneyError.Text = "Enter a valid money amount!"; return; }
            double moneyamount = Convert.ToDouble(money);
            if (moneyamount <= 0) { addMoneyError.Text = "Enter a valid money amount!"; return; }
            if (comment != null) { SetComment(comment); }
            if (childNameOne.Text == child && childNameOne.Text != "Child")
            {
                local.Money1 += moneyamount;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameTwo.Text == child && childNameTwo.Text != "Child")
            {
                local.Money2 += moneyamount;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameThree.Text == child && childNameThree.Text != "Child")
            {
                local.Money3 += moneyamount;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameFour.Text == child && childNameFour.Text != "Child")
            {
                local.Money4 += moneyamount;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameFive.Text == child && childNameFive.Text != "Child")
            {
                local.Money5 += moneyamount;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            addMoneyError.Text = "Child does not exist!";
        }
        private void AddChild_Click(object sender, EventArgs e) 
        {
            Variables local = new Variables();
            local.GetVariables();
            string child = addChildName.Text;
            if (child == null) { childError.Text = "Enter all fields!"; return; }
            if (childNameOne.Text != "Child" && childNameTwo.Text != "Child" && childNameThree.Text != "Child" && childNameFour.Text != "Child" && childNameFive.Text != "Child") 
            {
                childError.Text = "All child slots are full!";
                return;
            }
            if (childNameOne.Text == "Child") 
            {
                local.Name1 = child;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameTwo.Text == "Child") 
            {
                local.Name2 = child;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameThree.Text == "Child") 
            {
                local.Name3 = child;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameFour.Text == "Child")
            {
                local.Name4 = child;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameFive.Text == "Child")
            {
                local.Name5 = child;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            childError.Text = "Child does not exist!";
        }

        private void DeleteChild_Click(object sender, EventArgs e)
        {
            Variables local = new Variables();
            local.GetVariables();
            string temp = deleteChildName.Text;
            if (temp == null) { return; }
            if (childNameOne.Text != "Child" && childNameOne.Text == temp)
            {
                local.Name1 = "Child";
                local.Money1 = 0;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameTwo.Text != "Child" && childNameTwo.Text == temp)
            {
                local.Name2 = "Child";
                local.Money2 = 0;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameThree.Text != "Child" && childNameThree.Text == temp)
            {
                local.Name3 = "Child";
                local.Money3 = 0;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameFour.Text != "Child" && childNameFour.Text == temp)
            {
                local.Name4 = "Child";
                local.Money4 = 0;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            if (childNameFive.Text != "Child" && childNameFive.Text == temp)
            {
                local.Name5 = "Child";
                local.Money5 = 0;
                local.ChangeVariables();
                StartVariables();
                return;
            }
            childError.Text = "Child does not exist!";
        }

        private void TakeMoney_Click(object sender, EventArgs e)
        {
            Variables local = new Variables();
            local.GetVariables();
            string child = takeMoneyChild.Text;
            string money = takeMoneyAmount.Text;
            string comment = takeMoneyComment.Text;
            if (child == null || money == null) { addMoneyError.Text = "Enter all fields!"; return; }
            try { double test = Convert.ToDouble(money); } catch { addMoneyError.Text = "Enter a valid money amount!"; return; }
            double moneyamount = Convert.ToDouble(money);
            if (moneyamount <= 0) { addMoneyError.Text = "Enter a valid money amount!"; return; }
            if (childNameOne.Text == child && childNameOne.Text != "Child")
            {
                local.Money1 -= moneyamount;
                local.ChangeVariables();
                StartVariables();
            }
            if (childNameTwo.Text == child && childNameTwo.Text != "Child")
            {
                local.Money2 -= moneyamount;
                local.ChangeVariables();
                StartVariables();
            }
            if (childNameThree.Text == child && childNameThree.Text != "Child")
            {
                local.Money3 -= moneyamount;
                local.ChangeVariables();
                StartVariables();
            }
            if (childNameFour.Text == child && childNameFour.Text != "Child")
            {
                local.Money4 -= moneyamount;
                local.ChangeVariables();
                StartVariables();
            }
            if (childNameFive.Text == child && childNameFive.Text != "Child")
            {
                local.Money5 -= moneyamount;
                local.ChangeVariables();
                StartVariables();
            }
        }
        public void SetComment(string comment)
        {
            Variables local = new Variables();
            local.GetVariables();
            //DateTime today = DateTime.ParseExact(DateTime.Now.ToString("MM:dd:yy"), "MM/dd/yy", CultureInfo.InvariantCulture);
            /**DateTime temp1 = DateTime.ParseExact(local.Date1, "MM/dd/yy", CultureInfo.InvariantCulture);
            DateTime temp2 = DateTime.ParseExact(local.Date2, "MM/dd/yy", CultureInfo.InvariantCulture);
            DateTime temp3 = DateTime.ParseExact(local.Date3, "MM/dd/yy", CultureInfo.InvariantCulture);
            if (temp1 < today)
            {
                local.Date3 = local.Date2;
                local.Comment3 = local.Comment2;
                local.Date2 = local.Date1;
                local.Comment2 = local.Comment1;
                local.Date1 = today.ToString();
                local.Comment1 = comment;
                Date3.Text = local.Date3;
                Comment3.Text = local.Comment3;
                Date2.Text = local.Date2;
                Comment2.Text = local.Comment2;
                Date1.Text = local.Date1;
                Comment1.Text = local.Comment1;
                local.ChangeVariables();
            }**/
            local.Date3 = local.Date2;
            local.Comment3 = local.Comment2;
            local.Date2 = local.Date1;
            local.Comment2 = local.Comment1;
            local.Date1 = String.Format("MM/dd/yy", DateTime.Now).ToString();
            local.Comment1 = comment;
            Date3.Text = local.Date3;
            Comment3.Text = local.Comment3;
            Date2.Text = local.Date2;
            Comment2.Text = local.Comment2;
            Date1.Text = local.Date1;
            Comment1.Text = local.Comment1;
            local.ChangeVariables();
        }
    }
}
