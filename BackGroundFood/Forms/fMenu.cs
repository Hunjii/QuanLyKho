using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QLKho.UserControls;
using QLKho.Forms;
using System.Threading;
using QLKho.Models;

namespace QLKho
{
    public partial class fMenu : Form
    {
        private Account login;

        public Account Login
        {
            get { return login; }
            set { login = value; GetType(login.Type); }
        }

        public fMenu(Account acc)
        {
            InitializeComponent();
            this.Login = acc;
        }
       
        void GetType(int type)
        {
            btnRevenue.Enabled = type == 0;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Receipt ucrec = new UC_Receipt();
            AddControlsToPanel(ucrec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_Goods ucg = new UC_Goods();
            AddControlsToPanel(ucg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Revenue ucrev = new UC_Revenue();
            AddControlsToPanel(ucrev);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            UC_Issue uci = new UC_Issue();
            AddControlsToPanel(uci);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin login = new fLogin();
            login.Show();
        }
        
    }
}
