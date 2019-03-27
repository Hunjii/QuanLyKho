using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.Controller;
using QLKho.UserControls;

namespace QLKho.Forms
{
    public partial class AccountProfiles : Form
    {
        public AccountProfiles()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = txbuser_add.Text;
            string displayname = txbdisname_add.Text;
            string password = txbpass_add.Text;
            int type = (int)numeudtype.Value;
            if (txbuser_add.Text!="")
            {
                AccountData.Instance.InsertAccount(username, displayname, password, type);
                this.Hide();
                //UC_Revenue ac = new UC_Revenue();
                //ac.Refresh();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }
    }
}
