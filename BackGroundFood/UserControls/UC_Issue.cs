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
            dgvPhieuXuat.Columns[1].Width = 110;
            dgvPhieuXuat.Columns[2].HeaderText = "Tên Khách Hàng";
            dgvPhieuXuat.Columns[2].Width = 180;
            cbMaHH.DataSource = Issue.LoadHangHoaCBX();
            cbMaHH.ValueMember = "MaHH";
            cbMaHH.DisplayMember = "TenHH";
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow < 0) return;
            //đưa dữ liệu vào textbox
            txtSoPX.Text = dgvPhieuXuat.Rows[numrow].Cells[0].Value.ToString();
            txtTenKH.Text = dgvPhieuXuat.Rows[numrow].Cells[2].Value.ToString();
            //đưa dữ liệu vào chi tiết PX
            dgvCTPhieuXuat.DataSource = Issue.LayChiTietPhieuXuat(dgvPhieuXuat.Rows[numrow].Cells[0].Value.ToString());
            dgvCTPhieuXuat.Columns[0].Visible = false;
            dgvCTPhieuXuat.Columns[1].HeaderText = "Mã hàng hóa";
            dgvCTPhieuXuat.Columns[2].HeaderText = "Số lượng xuất";
            dgvCTPhieuXuat.Columns[3].HeaderText = "Đơn giá xuất";

        }

        private void btnTimKiemPX_Click(object sender, EventArgs e)
        {
            dgvPhieuXuat.DataSource = Issue.TimKiemPX(txtTimKiemSoPX.Text, dtpNgayXuatFrom.Value, dtpNgayXuatTo.Value);
        }

        private void dgvCTPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow < 0) return;
            cbMaHH.SelectedValue = dgvCTPhieuXuat.Rows[numrow].Cells[1].Value.ToString();
            txtSoLuongXuat.Text = dgvCTPhieuXuat.Rows[numrow].Cells[2].Value.ToString();
            txtDonGiaXuat.Text = dgvCTPhieuXuat.Rows[numrow].Cells[3].Value.ToString();
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            //Them phieu xuat
            PhieuXuat px = new PhieuXuat();
            px.SoPX = txtSoPX.Text;
            px.TenKH = txtTenKH.Text;
            //List<CT_PhieuXuat> lstCT_PhieuXuat = new List<CT_PhieuXuat>();
            bool b = Issue.ThemPhieuXuat(px);
            if (b) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công", "Thông báo");
            dgvPhieuXuat.DataSource = Issue.LoadPhieuXuat();
        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
            PhieuXuat px = new PhieuXuat();
            px.SoPX = txtSoPX.Text;
            px.TenKH = txtTenKH.Text;
            bool b = Issue.CapNhatPhieuXuat(px);
            if (b) MessageBox.Show("Cập nhật thành công!");
            dgvPhieuXuat.DataSource = Issue.LoadPhieuXuat();
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            bool b = Issue.XoaPhieuXuat(txtSoPX.Text);
            if (b) MessageBox.Show("Xóa thành công!", "Thông báo");
            else MessageBox.Show("Xóa không thành công", "Thông báo");
            dgvPhieuXuat.DataSource = Issue.LoadPhieuXuat();
        }

        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            CT_PhieuXuat ctpx = new CT_PhieuXuat();
            ctpx.MaHH = cbMaHH.SelectedValue.ToString();
            ctpx.SLXuat = Convert.ToInt32(txtSoLuongXuat.Text);
            ctpx.DonGiaXuat = Convert.ToInt32(txtDonGiaXuat.Text);
            
            bool b = Issue.ThemCTPhieuXuat(txtSoPX.Text,ctpx);
            if (b) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm không thành công", "Thông báo");
            dgvCTPhieuXuat.DataSource = Issue.LayChiTietPhieuXuat(txtSoPX.Text);
        }

        private void btnSuaCTPX_Click(object sender, EventArgs e)
        {
            CT_PhieuXuat ctpx = new CT_PhieuXuat();
            ctpx.MaHH = cbMaHH.SelectedValue.ToString();
            ctpx.SLXuat = Convert.ToInt32(txtSoLuongXuat.Text);
            ctpx.DonGiaXuat = Convert.ToInt32(txtDonGiaXuat.Text);
            bool b = Issue.SuaCTPhieuXuat(txtSoPX.Text, ctpx);
            if (b) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa không thành công", "Thông báo");
            dgvCTPhieuXuat.DataSource = Issue.LayChiTietPhieuXuat(txtSoPX.Text);
        }

        private void btnXoaCTPX_Click(object sender, EventArgs e)
        {
            
            bool b = Issue.XoaCTPhieuXuat(txtSoPX.Text,cbMaHH.SelectedValue.ToString());
            if (b) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa không thành công", "Thông báo");
            dgvCTPhieuXuat.DataSource = Issue.LayChiTietPhieuXuat(txtSoPX.Text);
        }
    }
}
