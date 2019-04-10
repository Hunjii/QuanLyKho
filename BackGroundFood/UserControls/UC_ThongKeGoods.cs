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
    public partial class UC_ThongKeGoods : UserControl
    {
        public UC_ThongKeGoods()
        {
            InitializeComponent();
        }

        private void UC_ThongKeGoods_Load(object sender, EventArgs e)
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
            listViewGoods.Columns.Add("So luong").Width = 100;

            string query = string.Format("Select HANGHOA.MAHH, TENHH, DONGIA, SLCUOI from HANGHOA, TONKHO where HANGHOA.MAHH = TONKHO.MAHH");
            DataTable result = SqlConnect.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["MAHH"].ToString().Trim());
                item.SubItems.Add(row["TENHH"].ToString().Trim());
                item.SubItems.Add(row["DONGIA"].ToString().Trim());
                item.SubItems.Add(row["SLCUOI"].ToString().Trim());

                listViewGoods.Items.Add(item);
            }
        }
    }
}
