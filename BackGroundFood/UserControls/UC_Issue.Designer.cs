using QLKho.Models;
namespace QLKho.UserControls
{
    partial class UC_Issue
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaPX = new System.Windows.Forms.Button();
            this.btnSuaPX = new System.Windows.Forms.Button();
            this.btnThemPX = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaCTPX = new System.Windows.Forms.Button();
            this.cbMaHH = new System.Windows.Forms.ComboBox();
            this.btnSuaCTPX = new System.Windows.Forms.Button();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.btnThemCTPX = new System.Windows.Forms.Button();
            this.txtSoLuongXuat = new System.Windows.Forms.TextBox();
            this.lblDonGiaXuat = new System.Windows.Forms.Label();
            this.txtDonGiaXuat = new System.Windows.Forms.TextBox();
            this.lblSoLuongXuat = new System.Windows.Forms.Label();
            this.lblSoPX = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoPX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCTPhieuXuat = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpNgayXuatTo = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayXuatFrom = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiemSoPX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimKiemNgayXuat = new System.Windows.Forms.Label();
            this.btnTimKiemPX = new System.Windows.Forms.Button();
            this.lblTimKiemSoPX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuXuat)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaPX);
            this.groupBox1.Controls.Add(this.btnSuaPX);
            this.groupBox1.Controls.Add(this.btnThemPX);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblSoPX);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtSoPX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 380);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xuất hàng";
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Location = new System.Drawing.Point(246, 118);
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPX.TabIndex = 5;
            this.btnXoaPX.Text = "Xóa";
            this.btnXoaPX.UseVisualStyleBackColor = true;
            this.btnXoaPX.Click += new System.EventHandler(this.btnXoaPX_Click);
            // 
            // btnSuaPX
            // 
            this.btnSuaPX.Location = new System.Drawing.Point(137, 118);
            this.btnSuaPX.Name = "btnSuaPX";
            this.btnSuaPX.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPX.TabIndex = 5;
            this.btnSuaPX.Text = "Sửa";
            this.btnSuaPX.UseVisualStyleBackColor = true;
            this.btnSuaPX.Click += new System.EventHandler(this.btnSuaPX_Click);
            // 
            // btnThemPX
            // 
            this.btnThemPX.Location = new System.Drawing.Point(40, 118);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(75, 23);
            this.btnThemPX.TabIndex = 5;
            this.btnThemPX.Text = "Thêm";
            this.btnThemPX.UseVisualStyleBackColor = true;
            this.btnThemPX.Click += new System.EventHandler(this.btnThemPX_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaCTPX);
            this.groupBox3.Controls.Add(this.cbMaHH);
            this.groupBox3.Controls.Add(this.btnSuaCTPX);
            this.groupBox3.Controls.Add(this.lblMaHH);
            this.groupBox3.Controls.Add(this.btnThemCTPX);
            this.groupBox3.Controls.Add(this.txtSoLuongXuat);
            this.groupBox3.Controls.Add(this.lblDonGiaXuat);
            this.groupBox3.Controls.Add(this.txtDonGiaXuat);
            this.groupBox3.Controls.Add(this.lblSoLuongXuat);
            this.groupBox3.Location = new System.Drawing.Point(5, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 216);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu xuất";
            // 
            // btnXoaCTPX
            // 
            this.btnXoaCTPX.Location = new System.Drawing.Point(241, 168);
            this.btnXoaCTPX.Name = "btnXoaCTPX";
            this.btnXoaCTPX.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCTPX.TabIndex = 5;
            this.btnXoaCTPX.Text = "Xóa";
            this.btnXoaCTPX.UseVisualStyleBackColor = true;
            this.btnXoaCTPX.Click += new System.EventHandler(this.btnXoaCTPX_Click);
            // 
            // cbMaHH
            // 
            this.cbMaHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHH.FormattingEnabled = true;
            this.cbMaHH.Location = new System.Drawing.Point(184, 27);
            this.cbMaHH.Name = "cbMaHH";
            this.cbMaHH.Size = new System.Drawing.Size(159, 24);
            this.cbMaHH.TabIndex = 3;
            // 
            // btnSuaCTPX
            // 
            this.btnSuaCTPX.Location = new System.Drawing.Point(132, 168);
            this.btnSuaCTPX.Name = "btnSuaCTPX";
            this.btnSuaCTPX.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCTPX.TabIndex = 5;
            this.btnSuaCTPX.Text = "Sửa";
            this.btnSuaCTPX.UseVisualStyleBackColor = true;
            this.btnSuaCTPX.Click += new System.EventHandler(this.btnSuaCTPX_Click);
            // 
            // lblMaHH
            // 
            this.lblMaHH.AutoSize = true;
            this.lblMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaHH.Location = new System.Drawing.Point(39, 30);
            this.lblMaHH.Name = "lblMaHH";
            this.lblMaHH.Size = new System.Drawing.Size(99, 15);
            this.lblMaHH.TabIndex = 0;
            this.lblMaHH.Text = "Mã Hàng Hóa:";
            // 
            // btnThemCTPX
            // 
            this.btnThemCTPX.Location = new System.Drawing.Point(35, 168);
            this.btnThemCTPX.Name = "btnThemCTPX";
            this.btnThemCTPX.Size = new System.Drawing.Size(75, 23);
            this.btnThemCTPX.TabIndex = 5;
            this.btnThemCTPX.Text = "Thêm";
            this.btnThemCTPX.UseVisualStyleBackColor = true;
            this.btnThemCTPX.Click += new System.EventHandler(this.btnThemCTPX_Click);
            // 
            // txtSoLuongXuat
            // 
            this.txtSoLuongXuat.Location = new System.Drawing.Point(184, 71);
            this.txtSoLuongXuat.Name = "txtSoLuongXuat";
            this.txtSoLuongXuat.Size = new System.Drawing.Size(159, 22);
            this.txtSoLuongXuat.TabIndex = 2;
            // 
            // lblDonGiaXuat
            // 
            this.lblDonGiaXuat.AutoSize = true;
            this.lblDonGiaXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonGiaXuat.Location = new System.Drawing.Point(39, 118);
            this.lblDonGiaXuat.Name = "lblDonGiaXuat";
            this.lblDonGiaXuat.Size = new System.Drawing.Size(96, 15);
            this.lblDonGiaXuat.TabIndex = 0;
            this.lblDonGiaXuat.Text = "Đơn Giá Xuất:";
            // 
            // txtDonGiaXuat
            // 
            this.txtDonGiaXuat.Location = new System.Drawing.Point(184, 118);
            this.txtDonGiaXuat.Name = "txtDonGiaXuat";
            this.txtDonGiaXuat.Size = new System.Drawing.Size(159, 22);
            this.txtDonGiaXuat.TabIndex = 2;
            // 
            // lblSoLuongXuat
            // 
            this.lblSoLuongXuat.AutoSize = true;
            this.lblSoLuongXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoLuongXuat.Location = new System.Drawing.Point(39, 74);
            this.lblSoLuongXuat.Name = "lblSoLuongXuat";
            this.lblSoLuongXuat.Size = new System.Drawing.Size(105, 15);
            this.lblSoLuongXuat.TabIndex = 0;
            this.lblSoLuongXuat.Text = "Số Lượng Xuất:";
            // 
            // lblSoPX
            // 
            this.lblSoPX.AutoSize = true;
            this.lblSoPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoPX.Location = new System.Drawing.Point(39, 32);
            this.lblSoPX.Name = "lblSoPX";
            this.lblSoPX.Size = new System.Drawing.Size(102, 15);
            this.lblSoPX.TabIndex = 0;
            this.lblSoPX.Text = "Số Phiếu Xuất:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenKH.Location = new System.Drawing.Point(39, 84);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 15);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên Khách Hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(189, 84);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(159, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSoPX
            // 
            this.txtSoPX.Location = new System.Drawing.Point(189, 29);
            this.txtSoPX.Name = "txtSoPX";
            this.txtSoPX.Size = new System.Drawing.Size(159, 22);
            this.txtSoPX.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuXuat);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(465, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 509);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu xuất";
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.AllowUserToAddRows = false;
            this.dgvPhieuXuat.AllowUserToResizeRows = false;
            this.dgvPhieuXuat.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(3, 16);
            this.dgvPhieuXuat.MultiSelect = false;
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.ReadOnly = true;
            this.dgvPhieuXuat.RowHeadersVisible = false;
            this.dgvPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(370, 490);
            this.dgvPhieuXuat.TabIndex = 0;
            this.dgvPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuat_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCTPhieuXuat);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(844, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 509);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết phiếu xuất";
            // 
            // dgvCTPhieuXuat
            // 
            this.dgvCTPhieuXuat.AllowUserToAddRows = false;
            this.dgvCTPhieuXuat.AllowUserToDeleteRows = false;
            this.dgvCTPhieuXuat.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCTPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPhieuXuat.Location = new System.Drawing.Point(3, 16);
            this.dgvCTPhieuXuat.MultiSelect = false;
            this.dgvCTPhieuXuat.Name = "dgvCTPhieuXuat";
            this.dgvCTPhieuXuat.ReadOnly = true;
            this.dgvCTPhieuXuat.RowHeadersVisible = false;
            this.dgvCTPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPhieuXuat.Size = new System.Drawing.Size(333, 490);
            this.dgvCTPhieuXuat.TabIndex = 0;
            this.dgvCTPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuXuat_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpNgayXuatTo);
            this.groupBox5.Controls.Add(this.dtpNgayXuatFrom);
            this.groupBox5.Controls.Add(this.txtTimKiemSoPX);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lblTimKiemNgayXuat);
            this.groupBox5.Controls.Add(this.btnTimKiemPX);
            this.groupBox5.Controls.Add(this.lblTimKiemSoPX);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(16, 461);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 123);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // dtpNgayXuatTo
            // 
            this.dtpNgayXuatTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuatTo.Location = new System.Drawing.Point(100, 78);
            this.dtpNgayXuatTo.Name = "dtpNgayXuatTo";
            this.dtpNgayXuatTo.Size = new System.Drawing.Size(175, 20);
            this.dtpNgayXuatTo.TabIndex = 12;
            // 
            // dtpNgayXuatFrom
            // 
            this.dtpNgayXuatFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuatFrom.Location = new System.Drawing.Point(100, 50);
            this.dtpNgayXuatFrom.Name = "dtpNgayXuatFrom";
            this.dtpNgayXuatFrom.Size = new System.Drawing.Size(175, 20);
            this.dtpNgayXuatFrom.TabIndex = 11;
            // 
            // txtTimKiemSoPX
            // 
            this.txtTimKiemSoPX.Location = new System.Drawing.Point(100, 22);
            this.txtTimKiemSoPX.Name = "txtTimKiemSoPX";
            this.txtTimKiemSoPX.Size = new System.Drawing.Size(175, 20);
            this.txtTimKiemSoPX.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "đến:";
            // 
            // lblTimKiemNgayXuat
            // 
            this.lblTimKiemNgayXuat.AutoSize = true;
            this.lblTimKiemNgayXuat.Location = new System.Drawing.Point(17, 52);
            this.lblTimKiemNgayXuat.Name = "lblTimKiemNgayXuat";
            this.lblTimKiemNgayXuat.Size = new System.Drawing.Size(70, 13);
            this.lblTimKiemNgayXuat.TabIndex = 1;
            this.lblTimKiemNgayXuat.Text = "Ngày xuất từ:";
            // 
            // btnTimKiemPX
            // 
            this.btnTimKiemPX.Location = new System.Drawing.Point(299, 50);
            this.btnTimKiemPX.Name = "btnTimKiemPX";
            this.btnTimKiemPX.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemPX.TabIndex = 0;
            this.btnTimKiemPX.Text = "Tìm kiếm";
            this.btnTimKiemPX.UseVisualStyleBackColor = true;
            this.btnTimKiemPX.Click += new System.EventHandler(this.btnTimKiemPX_Click);
            // 
            // lblTimKiemSoPX
            // 
            this.lblTimKiemSoPX.AutoSize = true;
            this.lblTimKiemSoPX.Location = new System.Drawing.Point(17, 22);
            this.lblTimKiemSoPX.Name = "lblTimKiemSoPX";
            this.lblTimKiemSoPX.Size = new System.Drawing.Size(75, 13);
            this.lblTimKiemSoPX.TabIndex = 1;
            this.lblTimKiemSoPX.Text = "Số phiếu xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "QUẢN LÝ PHIẾU XUẤT";
            // 
            // UC_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Issue";
            this.Size = new System.Drawing.Size(1200, 643);
            this.Load += new System.EventHandler(this.UC_Issue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuXuat)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaHH;
        private System.Windows.Forms.Label lblSoPX;
        private System.Windows.Forms.Label lblMaHH;
        private System.Windows.Forms.TextBox txtSoPX;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblDonGiaXuat;
        private System.Windows.Forms.Label lblSoLuongXuat;
        private System.Windows.Forms.TextBox txtDonGiaXuat;
        private System.Windows.Forms.TextBox txtSoLuongXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimKiemSoPX;
        private System.Windows.Forms.Label lblTimKiemSoPX;
        private System.Windows.Forms.Button btnTimKiemPX;
        private System.Windows.Forms.DateTimePicker dtpNgayXuatTo;
        private System.Windows.Forms.DateTimePicker dtpNgayXuatFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimKiemNgayXuat;
        private System.Windows.Forms.DataGridView dgvCTPhieuXuat;
        private System.Windows.Forms.Button btnXoaPX;
        private System.Windows.Forms.Button btnSuaPX;
        private System.Windows.Forms.Button btnThemPX;
        private System.Windows.Forms.Button btnXoaCTPX;
        private System.Windows.Forms.Button btnSuaCTPX;
        private System.Windows.Forms.Button btnThemCTPX;
        private System.Windows.Forms.Label label2;
    }
}
