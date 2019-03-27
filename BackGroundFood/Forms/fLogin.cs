using QLKho.Controller;
using QLKho.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKho.Forms
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            if (Login( userName, passWord))
            {
                Account Login = AccountData.Instance.GetAccount(userName);
                fMenu f = new fMenu(Login);
                this.Hide();
                f.ShowDialog();
            }
            else{
               MessageBox.Show("Sorry, we can't find an account.");
            }
            
        }

        bool Login(string userName, string passWord)
        {
            return AccountData.Instance.Login(userName, passWord);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
