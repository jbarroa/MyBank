using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AesEncDec;
using System.IO;

namespace MyBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Req rf = new Req();
            rf.Show();
        }

        private void UserTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (userTxt.Text.Length < 3 || passTxt.Text.Length < 5)
            {
                MessageBox.Show("Username or passsword is invalid or too short");
            }
            else
            {
                string dir = userTxt.Text;
                if (!Directory.Exists("data\\" + dir))
                    MessageBox.Show("User was not found!", dir);
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encuser = sr.ReadLine();
                    string encpass = sr.ReadLine();
                    sr.Close();

                    string decuser = AesCryp.Decrypt(encuser);
                    string decpass = AesCryp.Decrypt(encpass);

                    if(decuser == userTxt.Text && decpass== passTxt.Text)
                    {
                        MessageBox.Show("Welcome to bank 1", decuser);
                        this.Close();
                        ATM newATM = new ATM();
                        newATM.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error with username or password is incorrect");// if its a hacker it wouldn't know whether user name exist so using"or"
                    }

                }
            }
        }
        
    }
}
