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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Issue));
            this.palUCMenu1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMaHH = new System.Windows.Forms.ComboBox();
            this.lblMaHH = new System.Windows.Forms.Label();
            this.btnThemChiTietPX = new System.Windows.Forms.Button();
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
            this.btnThemPX = new System.Windows.Forms.Button();
            this.btnSuaPX = new System.Windows.Forms.Button();
            this.btnXoaPX = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvCTPhieuXuat = new System.Windows.Forms.ListView();
            this.clmMaHH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTenHH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoLuongXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDonGiaXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.palUCMenu1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // palUCMenu1
            // 
            this.palUCMenu1.Controls.Add(this.btnEdit);
            this.palUCMenu1.Controls.Add(this.btnDelete);
            this.palUCMenu1.Controls.Add(this.btnAdd);
            this.palUCMenu1.Location = new System.Drawing.Point(16, 3);
            this.palUCMenu1.Name = "palUCMenu1";
            this.palUCMenu1.Size = new System.Drawing.Size(406, 56);
            this.palUCMenu1.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(270, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 56);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(137, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 56);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(5, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "AddNew";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblSoPX);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtSoPX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 380);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xuất hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMaHH);
            this.groupBox3.Controls.Add(this.lblMaHH);
            this.groupBox3.Controls.Add(this.btnThemChiTietPX);
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
            // cbMaHH
            // 
            this.cbMaHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHH.FormattingEnabled = true;
            this.cbMaHH.Location = new System.Drawing.Point(184, 27);
            this.cbMaHH.Name = "cbMaHH";
            this.cbMaHH.Size = new System.Drawing.Size(159, 24);
            this.cbMaHH.TabIndex = 3;
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
            // btnThemChiTietPX
            // 
            this.btnThemChiTietPX.ForeColor = System.Drawing.Color.Black;
            this.btnThemChiTietPX.Location = new System.Drawing.Point(110, 174);
            this.btnThemChiTietPX.Name = "btnThemChiTietPX";
            this.btnThemChiTietPX.Size = new System.Drawing.Size(147, 23);
            this.btnThemChiTietPX.TabIndex = 7;
            this.btnThemChiTietPX.Text = "Thêm vào phiếu xuất";
            this.btnThemChiTietPX.UseVisualStyleBackColor = true;
            this.btnThemChiTietPX.Click += new System.EventHandler(this.btnThemChiTietPX_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(465, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 386);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu xuất";
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(3, 16);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.Size = new System.Drawing.Size(351, 367);
            this.dgvPhieuXuat.TabIndex = 0;
            this.dgvPhieuXuat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhieuXuat_RowHeaderMouseClick);
            // 
            // btnThemPX
            // 
            this.btnThemPX.Location = new System.Drawing.Point(32, 490);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(99, 23);
            this.btnThemPX.TabIndex = 7;
            this.btnThemPX.Text = "Thêm";
            this.btnThemPX.UseVisualStyleBackColor = true;
            this.btnThemPX.Click += new System.EventHandler(this.btnThemPX_Click);
            // 
            // btnSuaPX
            // 
            this.btnSuaPX.Location = new System.Drawing.Point(153, 490);
            this.btnSuaPX.Name = "btnSuaPX";
            this.btnSuaPX.Size = new System.Drawing.Size(99, 23);
            this.btnSuaPX.TabIndex = 7;
            this.btnSuaPX.Text = "Cập nhật";
            this.btnSuaPX.UseVisualStyleBackColor = true;
            this.btnSuaPX.Click += new System.EventHandler(this.btnSuaPX_Click);
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Location = new System.Drawing.Point(286, 490);
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.Size = new System.Drawing.Size(99, 23);
            this.btnXoaPX.TabIndex = 7;
            this.btnXoaPX.Text = "Xóa";
            this.btnXoaPX.UseVisualStyleBackColor = true;
            this.btnXoaPX.Click += new System.EventHandler(this.btnXoaPX_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvCTPhieuXuat);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(828, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 383);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết phiếu xuất";
            // 
            // lvCTPhieuXuat
            // 
            this.lvCTPhieuXuat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMaHH,
            this.clmTenHH,
            this.clmSoLuongXuat,
            this.clmDonGiaXuat});
            this.lvCTPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCTPhieuXuat.FullRowSelect = true;
            this.lvCTPhieuXuat.GridLines = true;
            this.lvCTPhieuXuat.Location = new System.Drawing.Point(3, 16);
            this.lvCTPhieuXuat.MultiSelect = false;
            this.lvCTPhieuXuat.Name = "lvCTPhieuXuat";
            this.lvCTPhieuXuat.Size = new System.Drawing.Size(349, 364);
            this.lvCTPhieuXuat.TabIndex = 0;
            this.lvCTPhieuXuat.UseCompatibleStateImageBehavior = false;
            this.lvCTPhieuXuat.View = System.Windows.Forms.View.Details;
            this.lvCTPhieuXuat.SelectedIndexChanged += new System.EventHandler(this.lvCTPhieuXuat_SelectedIndexChanged);
            // 
            // clmMaHH
            // 
            this.clmMaHH.Text = "Mã hàng hóa";
            this.clmMaHH.Width = 75;
            // 
            // clmTenHH
            // 
            this.clmTenHH.Text = "Tên hàng hóa";
            this.clmTenHH.Width = 110;
            // 
            // clmSoLuongXuat
            // 
            this.clmSoLuongXuat.Text = "Số lượng xuất";
            this.clmSoLuongXuat.Width = 72;
            // 
            // clmDonGiaXuat
            // 
            this.clmDonGiaXuat.Text = "Đơn giá xuất";
            this.clmDonGiaXuat.Width = 88;
            // 
            // UC_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnXoaPX);
            this.Controls.Add(this.btnSuaPX);
            this.Controls.Add(this.btnThemPX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.palUCMenu1);
            this.Name = "UC_Issue";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.UC_Issue_Load);
            this.palUCMenu1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palUCMenu1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
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
        private System.Windows.Forms.Button btnThemPX;
        private System.Windows.Forms.Button btnSuaPX;
        private System.Windows.Forms.Button btnXoaPX;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemChiTietPX;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvCTPhieuXuat;
        private System.Windows.Forms.ColumnHeader clmMaHH;
        private System.Windows.Forms.ColumnHeader clmTenHH;
        private System.Windows.Forms.ColumnHeader clmSoLuongXuat;
        private System.Windows.Forms.ColumnHeader clmDonGiaXuat;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
