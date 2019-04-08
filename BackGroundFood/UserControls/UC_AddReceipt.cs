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
    public partial class UC_AddReceipt : UserControl
    {
        List<Goods> listGoods = new List<Goods>();
        public UC_AddReceipt()
        {
            InitializeComponent();
        }

        //private void UC_AddReceipt_Load(object sender, EventArgs e)
        //{
        //    grbNhapHang.Show();
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    LoadListViewReceipt();
        //    grbNhapHang.Hide();
        //}

        public void LoadListViewReceiptGoods()
        {
            listViewReceipeGood.Columns.Clear();
            listViewReceipeGood.Items.Clear();
            listViewReceipeGood.Columns.Add("ID").Width = 80;
            listViewReceipeGood.Columns.Add("TenHH").Width = 150;
            listViewReceipeGood.Columns.Add("So luong").Width = 150;
            
            foreach (Goods row in listGoods)
            {
                ListViewItem item = new ListViewItem(row.MaHH);
                item.SubItems.Add(row.TenHH);
                item.SubItems.Add(row.SoLuongNhap.ToString());

                listViewReceipeGood.Items.Add(item);
            }

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
            comboBoxGoodsName.Items.Clear();
            foreach (DataRow row in result.Rows)
            {
                comboBoxGoodsName.Items.Add(row["TENHH"].ToString().Trim());
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["DONGIA"].ToString().Trim());
                item.SubItems.Add(row["SLCUOI"].ToString().Trim());

                listViewGood.Items.Add(item);
            }
        }

        private void UC_AddReceipt_Load(object sender, EventArgs e)
        {
            grbNhapHang.Show();
            LoadListViewGoods();
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

                Goods goods = new Goods(row["MAHH"].ToString().Trim(), row["TENHH"].ToString().Trim(), Convert.ToInt16(textBoxAmount.Text));
                listGoods.Add(goods);
                
            }
            LoadListViewReceiptGoods();
            comboBoxGoodsName.ResetText();
            textBoxAmount.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryDH = string.Format("INSERT INTO DONDH(SODH, NGAYDH, MANCC) values ('{0}', '{1}', '{2}') ",
                textBoxSDH.Text, Convert.ToString(DateTime.Now), textBoxNCC.Text);
            SqlConnect.Instance.ExcuseNonQuery(queryDH);
            string queryReceipt = string.Format("INSERT INTO PHIEUNHAP(SOPN, NGAYNHAP, SODH) values ('{0}', '{1}', '{2}') ", 
                textBoxID.Text, Convert.ToString(DateTime.Now), textBoxSDH.Text);
            SqlConnect.Instance.ExcuseNonQuery(queryReceipt);
            foreach (Goods item in listGoods)
            {
                string query = string.Format("UPDATE TONKHO SET SLCUOI = SLCUOI + '{0}' where MAHH = '{1}'", item.SoLuongNhap, item.MaHH);
                SqlConnect.Instance.ExcuseNonQuery(query);
                string update = string.Format("Insert into CTPHIEUNHAP(SOPN, MAHH, SOLUONGNHAP) values ('{0}', '{1}', '{2}')", textBoxID.Text, item.MaHH, item.SoLuongNhap);
                SqlConnect.Instance.ExcuseNonQuery(update);
            }
            LoadListViewGoods();
            listViewReceipeGood.Items.Clear();
        }
    }
}
