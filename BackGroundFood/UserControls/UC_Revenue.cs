using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.Controller;
using QLKho.Forms;

namespace QLKho.UserControls
{
    public partial class UC_Revenue : UserControl
    {

        BindingSource accountList = new BindingSource();

        public UC_Revenue()
        {
            InitializeComponent();
            Loadingfor();
        }

        public void Loadingfor()
        {
            dtgvAccount.DataSource = accountList;
            LoadListAccount();
            BindingAccount();
        }

        void BindingAccount()
        {
            gbAccount.Enabled = false;
            txbUser.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            txbDisplay.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            txbPass.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "password", true, DataSourceUpdateMode.Never));
            numeudType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "type", true, DataSourceUpdateMode.Never));
        }

        public void LoadListAccount()
        {
            accountList.DataSource = AccountData.Instance.GetListAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountProfiles acc = new AccountProfiles();
            acc.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txbUser.Text;
            if (MessageBox.Show("Delete this account ?", "Quetion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccountData.Instance.DeleteAccount(username);
                LoadListAccount();
            }
            else 
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbAccount.Enabled = true;
            dtgvAccount.Enabled = false;
            txbUser.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gbAccount.Enabled = false;
            dtgvAccount.Enabled = true;
            string username = txbUser.Text;
            string displayname = txbDisplay.Text;
            string password = txbPass.Text;
            int type = (int)numeudType.Value;
            if (AccountData.Instance.UpdateAccount(username, displayname, password, type))
            {
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void UC_Revenue_Load(object sender, EventArgs e)
        {
        }
    }
}
