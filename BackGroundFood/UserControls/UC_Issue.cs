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
    public partial class UC_Issue : UserControl
    {
        List<Goods> listGoods = new List<Goods>();
        public UC_Issue()
        {
            InitializeComponent();
        }

        private void UC_Issue_Load(object sender, EventArgs e)
        {
            LoadListViewGoods();
        }

        public void LoadListViewGoods()
        {
            listViewGood.Columns.Clear();
            listViewGood.Items.Clear();
            listViewGood.Columns.Add("ID").Width = 80;
            listViewGood.Columns.Add("Name").Width = 100;
            listViewGood.Columns.Add("Gia").Width = 100;
            listViewGood.Columns.Add("So luong").Width = 100;

            string query = string.Format("Select HANGHOA.MAHH, TENHH, DONGIA, SLCUOI from HANGHOA, TONKHO where HANGHOA.MAHH = TONKHO.MAHH");
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["DONGIA"].ToString().Trim());
                item.SubItems.Add(row["SLCUOI"].ToString().Trim());

                listViewGood.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            listViewGood.Columns.Clear();
            listViewGood.Items.Clear();

            listViewGood.Columns.Add("ID").Width = 80;
            listViewGood.Columns.Add("Name").Width = 100;
            listViewGood.Columns.Add("So luong nhap").Width = 150;

            string queryNhap = string.Format("Select NGAYNHAP, HANGHOA.MAHH, TENHH, SOLUONGNHAP" +
                "from HANGHOA, PHIEUNHAP, CTPHIEUNHAP" +
                "where HANGHOA.MAHH = CTPHIEUNHAP.MAHH " +
                "and CTPHIEUNHAP.SOPN = PHIEUNHAP.SOPN" +
                "and NGAYNHAP = {0}", date);
            DataTable result = SqlConnect.Instance.ExecuteQuery(queryNhap);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["SOLUONGNHAP"].ToString().Trim());

                listViewGood.Items.Add(item);
            }
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            listViewGood.Columns.Clear();
            listViewGood.Items.Clear();

            listViewGood.Columns.Add("ID").Width = 80;
            listViewGood.Columns.Add("Name").Width = 100;
            listViewGood.Columns.Add("So luong xuat").Width = 150;

            string queryXUAT = string.Format("Select NGAYXUAT, HANGHOA.MAHH, TENHH, SLXUAT" +
                "from HANGHOA, PHIEUXUAT, CTPHIEUXUAT" +
                "where HANGHOA.MAHH = CTPHIEUXUAT.MAHH " +
                "and CTPHIEUXUAT.SOPN = PHIEUXUAT.SOPN" +
                "and NGAYXUAT = {0}", date);
            DataTable result = SqlConnect.Instance.ExecuteQuery(queryXUAT);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["SLXUAT"].ToString().Trim());

                listViewGood.Items.Add(item);
            }
        }
    }
}
