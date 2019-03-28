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
using System.Data.SqlClient;

namespace QLKho
{
    public partial class UC_Receipt : UserControl
    {

        List<Goods> listGoods = new List<Goods>();
        public UC_Receipt()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_Receipt_Load(object sender, EventArgs e)
        {
            LoadListViewReceipt();
            grbNhapHang.Hide();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadListViewReceipt();
            grbNhapHang.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = string.Format("Select * from dbo.HANGHOA where TENHH = '{0}'", comboBoxGoodsName.Text);
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(textBoxAmount.Text);

                Goods goods = new Goods(row["MAHH"].ToString().Trim(), Convert.ToInt16(textBoxAmount.Text));
                listGoods.Add(goods);

                listViewReceipeGood.Items.Add(item);
            }

            comboBoxGoodsName.ResetText();
            textBoxAmount.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadListViewGoods();

            listViewReceipeGood.Columns.Clear();
            listViewReceipeGood.Items.Clear();
            listViewReceipeGood.Columns.Add("ID").Width = 80;
            listViewReceipeGood.Columns.Add("Name").Width = 150;
            listViewReceipeGood.Columns.Add("So luong").Width = 100;
            grbNhapHang.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string queryReceipt = string.Format("INSERT INTO PHIEUNHAP(SOPN, NGAYNHAP, SODH) values ('{0}', '{1}', '{2}') ", 
                textBoxID.Text, Convert.ToString(DateTime.Now), textBoxSDH.Text);
            SqlConnect.Instance.ExecuteNonQuery(queryReceipt);
            string queryDH = string.Format("INSERT INTO DONDH(SODH, NGAYDH, MANCC) values ('{0}', '{1}', '{2}') ",
                textBoxSDH.Text, Convert.ToString(DateTime.Now), textBoxNCC.Text);
            SqlConnect.Instance.ExecuteNonQuery(queryDH);*/
            foreach (Goods item in listGoods)
            {
                string query = string.Format("UPDATE TONKHO SET SLCUOI = SLCUOI + '{0}' where MAHH = '{1}'", item.SoLuongNhap, item.MaHH);
                SqlConnect.Instance.ExcuseNonQuery(query);
            }
            LoadListViewGoods();
            listViewReceipeGood.Items.Clear();
        }

        public void LoadListViewReceipt()
        {
            listViewGood.Location = new Point(50, 65);
            listViewGood.Columns.Clear();
            listViewGood.Items.Clear();
            listViewGood.Columns.Add("ID").Width = 80;
            listViewGood.Columns.Add("Ngay nhap").Width = 150;

            string query = string.Format("Select * from dbo.PHIEUNHAP ");
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["SOPN"].ToString().Trim());
                item.SubItems.Add(row["NGAYNHAP"].ToString().Trim());

                listViewGood.Items.Add(item);
            }

        }

        public void LoadListViewGoods()
        {
            listViewGood.Location = new Point(800, 65);
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
                comboBoxGoodsName.Items.Clear();
                comboBoxGoodsName.Items.Add(row["TENHH"].ToString().Trim());
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["DONGIA"].ToString().Trim());
                item.SubItems.Add(row["SLCUOI"].ToString().Trim());

                listViewGood.Items.Add(item);
            }
        }
    }
}
