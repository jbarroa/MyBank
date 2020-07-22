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
    public partial class Req : Form
    {
        public Req()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (userTxt.Text.Length <3||passTxt.Text.Length < 5)
            {
                MessageBox.Show("Username or passsword is invalid or too short");
            }
            else
            {
                string dir = userTxt.Text; 
                Directory.CreateDirectory("data\\" + dir);

                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encuser = AesCryp.Encrypt(userTxt.Text);
                string encpass= AesCryp.Encrypt(passTxt.Text);

                sw.WriteLine(encuser);
                sw.WriteLine(encpass);
                sw.Close();

                MessageBox.Show("Welcome to Bank 1", userTxt.Text);
                this.Close();
            }
        }
    }
}
