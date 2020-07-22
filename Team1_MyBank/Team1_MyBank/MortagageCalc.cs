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
    public partial class MortagageCalc : Form
    {
        public MortagageCalc()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the Form.
            this.Close();
        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Declare local variables.
                double interest = 0.0;
                decimal amountOfLoan = 0.0M;
                decimal monthlyPaymentLabel = 0.0M;
                double numberOfYears = 0.0;
                double R = 0.0;
                double F = 0.0;

                // Retrieve the necessary information from the TextBoxes.
                interest = double.Parse(annualRateOfInterestTextBox.Text);
                amountOfLoan = decimal.Parse(amountOfLoanTextBox.Text);
                numberOfYears = 12 * double.Parse(numberOfYearsTextBox.Text);

                // Calculate the interest rate.
                R = interest / 1200;
                F = Math.Pow(1 + R, numberOfYears);
                monthlyPaymentLabel = amountOfLoan * (decimal)((R * F / (-1 + F)));
                monthlyPaymentResult.Text = monthlyPaymentLabel.ToString("n1");
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            // Clear the Text Boxes.
            amountOfLoanTextBox.Text = "";
            annualRateOfInterestTextBox.Text = "";
            numberOfYearsTextBox.Text = "";
            monthlyPaymentResult.Text = "";

            // Reset the focus.
            amountOfLoanTextBox.Focus();
        }
    }
}