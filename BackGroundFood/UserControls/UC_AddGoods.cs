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

namespace QLKho.UserControls
{
    public partial class UC_AddGoods : UserControl
    {
        public UC_AddGoods()
        {
            InitializeComponent();
        }

        private void UC_AddGoods_Load(object sender, EventArgs e)
        {
            LoadListViewGoods();
        }

        public void LoadListViewGoods()
        {
            listViewGoods.Columns.Clear();
            listViewGoods.Items.Clear();
            listViewGoods.Columns.Add("ID").Width = 80;
            listViewGoods.Columns.Add("Name").Width = 100;
            listViewGoods.Columns.Add("Gia").Width = 100;

            string query = string.Format("Select * from HANGHOA");
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["DONGIA"].ToString().Trim());

                listViewGoods.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into HANGHOA(MAHH, TENHH, DONGIA) values ('{0}', '{1}', '{2}')", txtIDGoods.Text, txtGoodsName.Text, Convert.ToDouble(txtPrice.Text));
            int result1 = SqlConnect.Instance.ExcuseNonQuery(query);
            if (result1 == 1) MessageBox.Show("Them thanh cong");
            else
            {
                MessageBox.Show("Them khong thanh cong");
            }
            string add = string.Format("insert into TONKHO(MAHH, THANG, SLCUOI) values ('{0}', 1, 0)", txtIDGoods.Text);
            int result2 = SqlConnect.Instance.ExcuseNonQuery(add);
            LoadListViewGoods();
        }
    }
}
