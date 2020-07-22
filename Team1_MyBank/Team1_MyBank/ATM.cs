using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MyBank
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        double amount;
        double checkingBalance = 0;//checking account balance
        double savingsBalance = 0;//savings acount balance 
        StreamWriter outputFile;

        //clears form textbox
        private void Clear()
        {
            amtDTextBox.Text = "";
            amtFTextBox.Text = "";
            amtWTextBox.Text = "";
            amtTTextBox.Text = "";
            balDisLabel.Text = "";
            statementListBox.Text = "";
        }

        //Submit button for Deposit
        private void SubmitDButton_Click(object sender, EventArgs e)
        {
            try
            {
                amount = double.Parse(amtDTextBox.Text);//gets amount from deposit

                if(amount > 0)//checks that amount is positive 
                {
                    if (cDepositRadioButton.Checked)//check if deposited to checking
                    {
                        checkingBalance += amount;//add amount to checking balance 
                        balCDLabel.Text = checkingBalance.ToString();//display new balance
                        outputFile = File.AppendText("checking.txt");//changes checking file
                        outputFile.WriteLine("Deposited: $" + amount + " New balance: $" + checkingBalance);//write deposited amount and new balance
                        outputFile.Close();
                        MessageBox.Show("Deposited $" + amount);//display the amount has been deposited 
                    }

                    else if (sDepositRadioButton.Checked)//check if deposited to savings
                    {
                        savingsBalance += amount;//add amount to savings balance
                        balSDLabel.Text = savingsBalance.ToString();//display new balance
                        outputFile = File.AppendText("savings.txt");//changes saving file
                        outputFile.WriteLine("Deposited: $" + amount + " New balance: $" + savingsBalance);//write deposited amount and new balance
                        outputFile.Close();
                        MessageBox.Show("Deposited $" + amount);//display the amount that has been deposited
                    }

                    else
                    {
                        Clear();
                        MessageBox.Show("Choose either checking or savings account");
                    }
                }

                else
                {
                    Clear();
                    MessageBox.Show("Enter a positive value");
                }
            }

            catch
            {
                Clear();
                MessageBox.Show("Enter an amount");
            }
        }

        //Submit button for Withdraw
        private void SubmitWButton_Click(object sender, EventArgs e)
        {
            try
            {
                amount = double.Parse(amtWTextBox.Text);//gets amount from amount withdraw textbox 

                if (amount > 0)//checks that amount is positive 
                {
                    if (cWRadioButton.Checked)//check if checking button was chosen
                    {
                        if(amount > checkingBalance)//check if there are sufficient funds
                        {
                            checkingBalance -= amount;//subtract amount from checking balance 
                            balCWLabel.Text = checkingBalance.ToString();//display the new balance
                            outputFile = File.AppendText("checking.txt");//changes checking file
                            outputFile.WriteLine("Withdrawm: $" + amount + " New balance: $" + checkingBalance);//writes withdrawn amount and new balance
                            outputFile.Close();
                            MessageBox.Show("Withdrawn $" + amount);//display withdrawn amount
                        }

                        else
                        {
                            Clear();
                            MessageBox.Show("You have insufficient funds in your Checking account.");
                        }
                    }

                    else if (sWRadioButton.Checked)//check if savings account was chose
                    {
                        if (amount > savingsBalance)//check for sufficient funds
                        {
                            savingsBalance -= amount;//subtract amount from savings balance 
                            balSWLabel.Text = savingsBalance.ToString();//display new balance
                            outputFile = File.AppendText("savings.txt");//change savings file
                            outputFile.WriteLine("Withdrawn: $" + amount + " New balance: $" + savingsBalance);//writes withdrawn amount and new balance
                            outputFile.Close();
                            MessageBox.Show("Withdrawn $" + amount);//display withdrawn amount
                        }

                        else
                        {
                            Clear();
                            MessageBox.Show("You have insufficient funds in your Savings account.");
                        }
                    }

                    else
                    {
                        Clear();
                        MessageBox.Show("Choose either checking or savings account");
                    }
                }

                else
                {
                    Clear();
                    MessageBox.Show("Enter a positive value");
                }
            }

            catch
            {
                Clear();
                MessageBox.Show("Enter an amount");
            }
        }

        //Submit button for Fast Cash
        private void SubmitFButton_Click(object sender, EventArgs e)
        {
            try
            {
                amount = double.Parse(amtFTextBox.Text);//gets amount from textbox

                if (amount > 0)//checks if it is a positive amount
                {
                    if (amount % 20 == 0)//checks that it is a multiple of 20
                    {
                        if (amount <= 200)//checks that amount is less than or equal to 200
                        { 
                            if (cFRadioButton.Checked)//check if checking account was chosen
                            {
                                if (amount > checkingBalance)//checks for sufficient funds
                                {
                                    checkingBalance -= amount;//subtracts amount from checking balance
                                    balCFLabel.Text = checkingBalance.ToString();//display new amount
                                    outputFile = File.AppendText("checking.txt");//changes checking file
                                    outputFile.WriteLine("Withdrawn: $" + amount + " New balance: $" + checkingBalance);//write withdrawn amount and new balance
                                    outputFile.Close();
                                    MessageBox.Show("Withdrawn: $" + amount);//display withdrawn amount
                                }
                                else
                                {
                                    Clear();
                                    MessageBox.Show("There are insufficient funds in your checking account.");
                                }
                            }

                            else if (sFRadioButton.Checked)//Check if savings account was chosen
                            {
                                if (amount > savingsBalance)//checks for sufficient funds
                                {
                                    savingsBalance -= amount;//subtract amount from savings balance 
                                    balSFLabel.Text = savingsBalance.ToString();//display the new balance
                                    outputFile = File.AppendText("savings.txt");//change savings file
                                    outputFile.WriteLine("Withdrawn: $" + amount + " New balance: $" + savingsBalance);//write withdrawn amount and new balance
                                    outputFile.Close();
                                    MessageBox.Show("Withdrawn: $" + amount);//display withdrawn amount
                                }
                                else
                                {
                                    Clear();
                                    MessageBox.Show("There are insufficient funds in your savings account");
                                }
                            }

                            else
                            {
                                Clear();
                                MessageBox.Show("Choose either checking or savings account");
                            }
                        }

                        else
                        {
                            Clear();
                            MessageBox.Show("Amount must be less than or equal to $200");
                        }
                    }

                    else
                    {
                        Clear();
                        MessageBox.Show("Amount must be a multiple of 20");
                    }
                }

                else
                {
                    Clear();
                    MessageBox.Show("Enter a positive value");
                }
            }

            catch
            {
                Clear();
                MessageBox.Show("Enter an amount");
            }
        }

        //Submit button for Transfer
        private void SubmitTButton_Click(object sender, EventArgs e)
        {
            try
            {
                amount = double.Parse(amtDTextBox.Text);//gets amount from textbox

                if (amount > 0)//checks that it is a positive amount
                {
                    if (frCRadioButton.Checked)//check if withdrawn from checking 
                    {
                        if (amount > checkingBalance)//check for sufficient funds
                        {
                            if (toSRadioButton.Checked)//check if depositing to savings
                            {
                                checkingBalance -= amount;//subtract amount from checking balance
                                balCWLabel.Text = checkingBalance.ToString();//display new balance
                                outputFile = File.AppendText("checking.txt");//change checking file
                                outputFile.WriteLine("Withdrawm: $" + amount + " New balance: $" + checkingBalance);//writes withdrawn amount and new balance
                                outputFile.Close();

                                savingsBalance += amount;//add amount to savings balance
                                balCWLabel.Text = savingsBalance.ToString();//dispaly new balance
                                outputFile = File.AppendText("savings.txt");//change savings file
                                outputFile.WriteLine("Deposited: $" + amount + " New balance: $" + savingsBalance);//write deposited amount and new balance 
                                outputFile.Close();
                            }
                            else if (toCRadioButton.Checked)//check if depositing to checking
                            {
                                Clear();
                                MessageBox.Show("Deposit to Savings account");
                            }
                            else
                            {
                                Clear();
                                MessageBox.Show("Choose an account to deposit to");
                            }
                        }

                        else
                        {
                            Clear();
                            MessageBox.Show("You have insufficient funds in your Checking account.");
                        }
                    }
                    else if (frSRadioButton.Checked)//check if amount is from savings account
                    {
                        if (amount > savingsBalance)//check for sufficient funds 
                        { 
                            if (toCRadioButton.Checked)//check if deposited to checking account
                            {
                                savingsBalance -= amount;//subtract amount from savings balance
                                balSWLabel.Text = savingsBalance.ToString();//display new balance
                                outputFile = File.AppendText("savings.txt");//change savings file
                                outputFile.WriteLine("Withdrawn: $" + amount + " New balance: $" + savingsBalance);//write withdrawn amount and new balance
                                outputFile.Close();

                                checkingBalance += amount;//add amount to checking balance 
                                balCWLabel.Text = checkingBalance.ToString();//display new balance
                                outputFile = File.AppendText("checking.txt");//change checking file
                                outputFile.WriteLine("Deposited: $" + amount + " New balance: $" + checkingBalance);//write deposited amount and new balance
                                outputFile.Close();
                            }
                            else if (toSRadioButton.Checked)//check if deposited to savings account
                            {
                                Clear();
                                MessageBox.Show("Deposit to Checking account");
                            }
                            else
                            {
                                Clear();
                                MessageBox.Show("Choose an account to deposit to");
                            }
                        }

                        else
                        {
                            Clear();
                            MessageBox.Show("You have insufficient funds in your Savings account.");
                        }
                    }
                    else
                    {
                        Clear();
                        MessageBox.Show("Choose either checking or savings account");
                    }
                }
                else
                {
                    Clear();
                    MessageBox.Show("Enter a positive value");
                }
            }
            catch
            {
                Clear();
                MessageBox.Show("Enter an amount");
            }
        }

        //Submit button for Balance Display 
        private void SubmitBButton_Click(object sender, EventArgs e)
        {
            if (cBRadioButton.Checked)//check if checking account was chosen
            {
                balDisLabel.Text = checkingBalance.ToString();//display checking balance
            }
            else if (sBRadioButton.Checked)//check if savings account was chosen
            {
                balDisLabel.Text = savingsBalance.ToString();//display savings balance
            }
            else
            {
                MessageBox.Show("Choose either Checking or Savings account");
            }
        }

        //Submit button for Mini Statement 
       private void SubmitMButton_Click(object sender, EventArgs e)
        {
            int totalLines = 0, count = 0;
            StreamReader reader;

           if (sMRadioButton.Checked)//check if savings account was chosen
            {
                reader = File.OpenText("savings.txt");//read savings file
                totalLines = File.ReadAllLines("savings.txt").Length;//gets total lines in file
                string[] savingsLines = new string[totalLines];

                for(int i = 0; i<totalLines; i++)
                {
                    savingsLines[i] = reader.ReadLine();
                }
                for(int i = totalLines-1; count <10 && i >=0; i--)
                {
                    statementListBox.Items.Add(savingsLines[i]);
                    count++;
                }
                reader.Close();
            }

            else if (cMRadioButton.Checked)//check if checking account was chosen
            {
                
                reader = File.OpenText("checking.txt");//read checking file
                totalLines = File.ReadAllLines("checking.txt").Length;//gets total lines in file
                string[] checkingLines = new string[totalLines];

                for (int i = 0; i < totalLines; i++)
                {
                    checkingLines[i] = reader.ReadLine();
                }
                for (int i = totalLines - 1; count < 10 && i >= 0; i--)
                {
                    statementListBox.Items.Add(checkingLines[i]);
                    count++;
                }
                reader.Close();
            }

        }

        //Clear Buttons
        private void ClearDButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ClearWButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ClearFButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ClearTButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ClearBButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ClearMButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Exit Buttons
        private void ExitDButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void ExitWButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void ExitFButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void ExitTButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void ExitBButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void ExitMButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
