using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyBank
{
    public partial class LoanApp : Form
    {
        public LoanApp()
        {
            InitializeComponent();
        }
        private bool IsSSNValidFormat(string str)
        {
            const int VALID_SSN= 11;
            bool valid;
            if (str.Length == VALID_SSN && str[3] == '-' && str[6] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }
        private void Unformat(ref string str)
        {
            str = str.Remove(3, 1);
            str = str.Remove(5, 1);
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            string ssninput = SSNTextBox.Text.Trim();
            const int VALID_First = 20;
            const int VALID_Last = 30;
            const int VALID_MI = 3;
            const int VALID_Street = 20;
            const int VALID_City = 20;
            const int VALID_Employ = 40;
            if (LastNameTextBox.Text.All(char.IsLetter))
            {
                if (LastNameTextBox.TextLength < VALID_Last)
                {
                    if (FirstNameTextBox.Text.All(char.IsLetter))
                    {
                        if (FirstNameTextBox.TextLength < VALID_First)
                        {
                            if (MITextBox.TextLength < VALID_MI)
                            {
                                if(IsSSNValidFormat(ssninput))
                                {
                                    Unformat(ref ssninput);
                                    if (NumberTextBox.Text.All(char.IsDigit))
                                    {
                                        if (StreetTextBox.Text.All(char.IsLetter))
                                        {
                                            if (StreetTextBox.TextLength < VALID_Street)
                                            {
                                                if (CityTextBox.Text.All(char.IsLetter))
                                                {
                                                    if (CityTextBox.TextLength < VALID_City)
                                                    {
                                                        if (EmployerTextBox.Text.All(char.IsLetter))
                                                        {
                                                            if (EmployerTextBox.TextLength < VALID_Employ)
                                                            {
                                                                try
                                                                {
                                                                    string martialstatus = "";
                                                                    string gender = "";
                                                                    string loantype = "";
                                                                    if (MarriedRadioButton.Checked == true)
                                                                    {
                                                                        martialstatus = "Married";
                                                                    }
                                                                    else if (DivorcedRadioButton.Checked == true)
                                                                    {
                                                                        martialstatus = "Divorced";
                                                                    }
                                                                    else if (SingleRadioButton.Checked == true)
                                                                    {
                                                                        martialstatus = "Single";
                                                                    }
                                                                    else if (WidowedRadioButton.Checked == true)
                                                                    {
                                                                        martialstatus = "Widowed";
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Choose a martial status");
                                                                    }
                                                                    if (MaleRadioButton.Checked == true)
                                                                    {
                                                                        gender = "Male";
                                                                    }
                                                                    else if (FemaleRadioButton.Checked == true)
                                                                    {
                                                                        gender = "Female";
                                                                    }
                                                                    else if (OtherRadioButton.Checked == true)
                                                                    {
                                                                        gender = "Other";
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Choose a gender");
                                                                    }
                                                                    if (CarRadioButton.Checked == true)
                                                                    {
                                                                        loantype = "Car";
                                                                    }
                                                                    else if (HomeRadioButton.Checked == true)
                                                                    {
                                                                        loantype = "Home";
                                                                    }
                                                                    else if (CollegeRadioButton.Checked == true)
                                                                    {
                                                                        loantype = "College";
                                                                    }
                                                                    else if (BPRadioButton.Checked == true)
                                                                    {
                                                                        loantype = "Business/Personal";
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Choose a loan type");
                                                                    }
                                                                    StreamWriter outputFile;
                                                                    outputFile = File.AppendText("loans_applications.txt");
                                                                    outputFile.WriteLine("Personal Information:  Last Name: " + LastNameTextBox.Text + ", First Name: " + FirstNameTextBox.Text
                                                                     + ", MI: " + MITextBox.Text + ", Age: " + AgeComboBox.Text
                                                                    + ", SSN: " + ssninput + ", Martial Status: " + martialstatus + ", Gender: " + gender + ", Address: " +
                                                                    NumberTextBox.Text + " " + StreetTextBox.Text + " " +
                                                                    CityTextBox.Text + "," + StateListBox.Text + ", Employment: " +
                                                                    EmployerTextBox.Text + ", Job Position: " + JobcheckedListBox.Text + ", Years Worked: " +
                                                                    YearsWorkedTextBox.Text + ", Salary: " + SalaryTextBox.Text + "," + " Type of Loan: " + loantype);
                                                                    outputFile.Close();
                                                                    int yearsWorked;
                                                                    double Salary;
                                                                    yearsWorked = int.Parse(YearsWorkedTextBox.Text);
                                                                    Salary = double.Parse(SalaryTextBox.Text);
                                                                    if (Salary >= 45000)
                                                                    {
                                                                        if (yearsWorked >= 2)
                                                                        {
                                                                            MessageBox.Show("Qualified!");
                                                                        }
                                                                    }
                                                                    else if (yearsWorked >= 5)
                                                                    {

                                                                        MessageBox.Show("Qualified!");
                                                                    }

                                                                    else
                                                                    {
                                                                        MessageBox.Show("Not Qualified");
                                                                    }

                                                                }
                                                                catch (Exception ex)
                                                                {
                                                                    MessageBox.Show(ex.Message);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Employer contains to many characters");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Employer be contain characters only");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("City contains to many characters only");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("City must be characters only");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Street contains to many characters");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Street must be characters only");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Address Number must be numbers only");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please format SSN as: XXX-XX-XXXX");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Middle initial contains to many characters");
                            }
                        }
                        else
                        {
                            MessageBox.Show("First name contains to many characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("First name must be characters only");
                    }
                }
                else
                {
                    MessageBox.Show("Last name contains to many characters");
                }
            }
            else
            {
                MessageBox.Show("Last name must be characters only");
            }

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Focus();
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            MITextBox.Text = "";
            SSNTextBox.Text = "";
            NumberTextBox.Text = "";
            StreetTextBox.Text = "";
            CityTextBox.Text = "";
            EmployerTextBox.Text = "";
            YearsWorkedTextBox.Text = "";
            SalaryTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
