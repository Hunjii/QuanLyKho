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
    public partial class UC_ReceiptInfo : UserControl
    {
        public UC_ReceiptInfo()
        {
            InitializeComponent();
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            LoadListViewReceipt();

            listViewGoods.Columns.Clear();
            listViewGoods.Items.Clear();
            listViewGoods.Columns.Add("ID").Width = 80;
            listViewGoods.Columns.Add("Name").Width = 100;
            listViewGoods.Columns.Add("Gia").Width = 100;
            listViewGoods.Columns.Add("So luong").Width = 100;
        }

        public void LoadListViewReceipt()
        {
            listViewReceipt.Columns.Clear();
            listViewReceipt.Items.Clear();

            listViewReceipt.Columns.Add("ID").Width = 80;
            listViewReceipt.Columns.Add("Ngay nhap").Width = 150;

            string query = string.Format("Select * from dbo.PHIEUNHAP ");
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["SOPN"].ToString().Trim());
                item.SubItems.Add(Convert.ToDateTime(row["NGAYNHAP"]).ToString("dd/MM/yyyy"));

                listViewReceipt.Items.Add(item);
            }

        }

        public void LoadListViewGoods(string maPN)
         {
            listViewGoods.Items.Clear();
            string query = string.Format("Select HANGHOA.MAHH, TENHH, SOLUONGNHAP, DONGIA from HANGHOA, CTPHIEUNHAP " +
                "where HANGHOA.MAHH = CTPHIEUNHAP.MAHH and CTPHIEUNHAP.SOPN = '{0}'", maPN);
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["DONGIA"].ToString().Trim());
                item.SubItems.Add(row["SOLUONGNHAP"].ToString().Trim());

                listViewGoods.Items.Add(item);
            }
        }

        private void listViewReceipt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewReceipt.SelectedItems.Count == 1)
            {
                ListViewItem item = listViewReceipt.SelectedItems[0];
                
                LoadListViewGoods(item.SubItems[0].Text);
            }
        }
    }
}
