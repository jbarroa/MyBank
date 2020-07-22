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
    struct Customer
    {
        public int customerID;
        public string firstName;
        public string lastName;
        public int accountID;
    }

    struct Account
    {
        public int accountID;
        public int accountNumber;
        public int type;
        public double amount;
    }

    struct Loan
    {
        public int customerID;
        public int loanID;
        public int loanType;
        public int years;
        public double interestRate;
        public double amount;
    }

    public partial class Administrator : Form
    {
        //Field to hold a list of each object
        private List<Customer> customerList = new List<Customer>();
        private List<Account> accountList = new List<Account>();
        private List<Loan> loanList = new List<Loan>();

        public Administrator()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (customersCheckBox.Checked)
            {
                StreamReader inputFile;               //read file
                string line;

                //Create instance of structure
                Customer entry = new Customer();

                //Create a delimeter array
                char[] delim = { ',' };

                //Read file
                inputFile = File.OpenText("customers.txt");

                //Read lines from the file
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file
                    line = inputFile.ReadLine();

                    //Tokenize the line
                    string[] tokens = line.Split(delim);

                    //add entry object to list
                    customerList.Add(entry);
                }

                customersListBox.Items.Add(entry);
            }
            if (accountsCheckBox.Checked)
            {
                StreamReader inputFile;               
                //read file
                string line;

                //Create instance of structure
                Account entry = new Account();

                //Create a delimeter array
                char[] delim = { ',' };

                //Read file
                inputFile = File.OpenText("accounts.txt");

                //Read lines from the file
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file
                    line = inputFile.ReadLine();

                    //Tokenize the line
                    string[] tokens = line.Split(delim);

                    //add entry object to list
                    accountList.Add(entry);
                }

                accountsListBox.Items.Add(entry);
            }
            if (loansCheckBox.Checked)
            {
                StreamReader inputFile;               
                //read file
                string line;

                //Create instance of structure
                Loan entry = new Loan();

                //Create a delimeter array
                char[] delim = { ',' };

                //Read file
                inputFile = File.OpenText("loans.txt");

                //Read lines from the file
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file
                    line = inputFile.ReadLine();

                    //Tokenize the line
                    string[] tokens = line.Split(delim);

                    //add entry object to list
                    loanList.Add(entry);
                }
                loansListBox.Items.Add(entry);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear form
            customersListBox.Items.Clear();
            loansListBox.Items.Clear();
            accountsListBox.Items.Clear();
            accountsCheckBox.Checked = false;
            customersCheckBox.Checked = false;
            loansCheckBox.Checked = false;
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            if (customersCheckBox.Checked)
            {
                foreach (Customer entry in customerList)
                {
                    customersListBox.Items.Add(customersTextBox.Text);
                }
            }
            if (accountsCheckBox.Checked)
            {
                foreach (Account entry in accountList)
                {
                    accountsListBox.Items.Add(accountsTextBox.Text);
                }
            }
            if (loansCheckBox.Checked)
            {
                foreach (Loan entry in loanList)
                {
                    loansListBox.Items.Add(loansTextBox.Text);
                }
            }
        }
    }

}
