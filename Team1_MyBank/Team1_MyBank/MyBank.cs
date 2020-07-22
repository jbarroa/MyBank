using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBank
{
    public partial class MyBank : Form
    {
        public MyBank()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminForm = new AdminLogin();
            adminForm.ShowDialog();
        }

        private void ATMButton_Click(object sender, EventArgs e)
        {
            Login atmForm = new Login();
            atmForm.ShowDialog();
        }

        private void LoanAppButton_Click(object sender, EventArgs e)
        {
            LoanApp loanForm = new LoanApp();
            loanForm.ShowDialog();
        }

        private void MortgageCalcButton_Click(object sender, EventArgs e)
        {
            MortagageCalc mortgageForm = new MortagageCalc();
            mortgageForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
