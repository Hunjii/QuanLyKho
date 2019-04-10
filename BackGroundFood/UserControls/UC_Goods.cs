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
using QLKho.UserControls;

namespace QLKho
{
    public partial class UC_Goods : UserControl
    {
        BindingSource FoodList = new BindingSource();
        public UC_Goods()
        {
            InitializeComponent();
 
        }

        private void UC_Goods_Load(object sender, EventArgs e)
        {
           
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(c);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UC_AddGoods uc = new UC_AddGoods();
            AddControlsToPanel(uc);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UC_ReceiptInfo uc = new UC_ReceiptInfo();
            AddControlsToPanel(uc);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            UC_ThongKeGoods uc = new UC_ThongKeGoods();
            AddControlsToPanel(uc);
        }
    }
}
