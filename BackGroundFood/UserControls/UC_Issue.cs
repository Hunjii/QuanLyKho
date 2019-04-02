using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.Models;
using QLKho.Controller;

namespace QLKho.UserControls
{
    public partial class UC_Issue : UserControl
    {
        List<CT_PhieuXuat> lstCT_PhieuXuat = new List<CT_PhieuXuat>();
        bool st = false;

        public UC_Issue()
        {
            InitializeComponent();
        }

        private void UC_Issue_Load(object sender, EventArgs e)
        {
            dgvPhieuXuat.DataSource = Issue.LoadPhieuXuat();
            dgvPhieuXuat.Columns[0].HeaderText = "Số PX";
            dgvPhieuXuat.Columns[0].Width = 70;
            dgvPhieuXuat.Columns[1].HeaderText = "Ngày Xuất";
            dgvPhieuXuat.Columns[1].Width = 100;
            dgvPhieuXuat.Columns[2].HeaderText = "Tên Khách Hàng";
            dgvPhieuXuat.Columns[2].Width = 150;
            cbMaHH.DataSource = Issue.LoadHangHoaCBX();
            cbMaHH.ValueMember = "MaHH";
            cbMaHH.DisplayMember = "TenHH";
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            //Them phieu xuat
            PhieuXuat px = new PhieuXuat();
            px.SoPX = txtSoPX.Text;
            px.TenKH = txtTenKH.Text;
            //List<CT_PhieuXuat> lstCT_PhieuXuat = new List<CT_PhieuXuat>();
            bool b = Issue.ThemPhieuXuat(px, lstCT_PhieuXuat);
            if (b) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công", "Thông báo");
            dgvPhieuXuat.DataSource = Issue.LoadPhieuXuat();
            //gán lại trạng thái cho biến st
            st = false;
        }
        private void btnThemChiTietPX_Click(object sender, EventArgs e)
        {
            try
            {
                //load lai listview 
                if (!st)
                {
                    lvCTPhieuXuat.Items.Clear();
                    st = true;
                }
                    CT_PhieuXuat ctpx = new CT_PhieuXuat();
                ctpx.MaHH = cbMaHH.SelectedValue.ToString();
                ctpx.SLXuat = Convert.ToInt32(txtSoLuongXuat.Text);
                ctpx.DonGiaXuat = Convert.ToDecimal(txtDonGiaXuat.Text);
                lstCT_PhieuXuat.Add(ctpx);
               //Them vao listview
                ListViewItem item = new ListViewItem();
                item.Text = ctpx.MaHH;
                //lay thuoc tinh ten hang hoa tu csdl
                DataTable data = Issue.LayThongTinHangHoa(ctpx.MaHH);
                item.SubItems.Add(data.Rows[0]["TENHH"].ToString());
                item.SubItems.Add(ctpx.SLXuat.ToString());
                item.SubItems.Add(ctpx.DonGiaXuat.ToString());
                lvCTPhieuXuat.Items.Add(item);
            }
            catch (Exception ex){}
        }

        private void dgvPhieuXuat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lvCTPhieuXuat.Items.Clear();
            int numrow;
            numrow = e.RowIndex;
            txtSoPX.Text = dgvPhieuXuat.Rows[numrow].Cells[0].Value.ToString();
            txtTenKH.Text = dgvPhieuXuat.Rows[numrow].Cells[2].Value.ToString();
            DataTable data= Issue.LayChiTietPhieuXuat(dgvPhieuXuat.Rows[numrow].Cells[0].Value.ToString());
            int i = 0;
            foreach (DataRow dr in data.Rows)
            {
                lvCTPhieuXuat.Items.Add(dr["MAHH"].ToString());
                lvCTPhieuXuat.Items[i].SubItems.Add(dr["TENHH"].ToString());
                lvCTPhieuXuat.Items[i].SubItems.Add(dr["SLXUAT"].ToString());
                lvCTPhieuXuat.Items[i].SubItems.Add(dr["DONGIAXUAT"].ToString());
                i++;
            }
        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
                PhieuXuat px = new PhieuXuat();
                px.SoPX = txtSoPX.Text;
                px.TenKH = txtTenKH.Text;
                
            CT_PhieuXuat ctpx = new CT_PhieuXuat();
            ctpx.MaHH = cbMaHH.SelectedValue.ToString();
            ctpx.SLXuat = Convert.ToInt32(txtSoLuongXuat.Text);
            ctpx.DonGiaXuat = Convert.ToDecimal(txtDonGiaXuat.Text);
            bool b = Issue.CapNhatPhieuXuat(px,ctpx);
            if (b) MessageBox.Show("Cập nhật thành công!");
            dgvPhieuXuat.DataSource = Issue.LoadPhieuXuat();
        }

        private void lvCTPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTPhieuXuat.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCTPhieuXuat.SelectedItems[0];
                //cbMaHH.Text = item.Text;
                int index=cbMaHH.FindString(item.SubItems[1].Text);
                cbMaHH.SelectedIndex = index;
                txtSoLuongXuat.Text = item.SubItems[2].Text;
                txtDonGiaXuat.Text = item.SubItems[3].Text;
            }
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            bool b = Issue.XoaPhieuXuat(txtSoPX.Text);
            if (b) MessageBox.Show("Xóa thành công!", "Thông báo");
            else MessageBox.Show("Xóa không thành công", "Thông báo");
            dgvPhieuXuat.DataSource = Issue.LoadPhieuXuat();
        }
    }
}
