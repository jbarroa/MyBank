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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Create instance of  MyBank Class
            //Only allow username and password
            Administrator admin = new Administrator();
            if (usernameTextBox.Text == "Group1" && passwordTextBox.Text == "FinalProject")
            {
                //Display form
                admin.ShowDialog();
            }
        }


    }
}
