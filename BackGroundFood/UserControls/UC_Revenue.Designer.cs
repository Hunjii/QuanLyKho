namespace QLKho.UserControls
{
    partial class UC_Revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Revenue));
            this.palUCMenu1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.numeudType = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbDisplay = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.palUCMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.gbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeudType)).BeginInit();
            this.SuspendLayout();
            // 
            // palUCMenu1
            // 
            this.palUCMenu1.Controls.Add(this.btnEdit);
            this.palUCMenu1.Controls.Add(this.btnDelete);
            this.palUCMenu1.Controls.Add(this.btnAdd);
            this.palUCMenu1.Location = new System.Drawing.Point(39, 3);
            this.palUCMenu1.Name = "palUCMenu1";
            this.palUCMenu1.Size = new System.Drawing.Size(551, 56);
            this.palUCMenu1.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(390, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 56);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(196, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 56);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(5, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "AddNew";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.displayname,
            this.password,
            this.type});
            this.dtgvAccount.Location = new System.Drawing.Point(39, 83);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccount.Size = new System.Drawing.Size(551, 488);
            this.dtgvAccount.TabIndex = 4;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Tên Tài Khoản";
            this.username.Name = "username";
            this.username.Width = 130;
            // 
            // displayname
            // 
            this.displayname.DataPropertyName = "displayname";
            this.displayname.HeaderText = "Tên Hiển Thi";
            this.displayname.Name = "displayname";
            this.displayname.Width = 150;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Mật Khẩu";
            this.password.Name = "password";
            this.password.Width = 120;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Loại Tài Khoản";
            this.type.Name = "type";
            this.type.Width = 110;
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.numeudType);
            this.gbAccount.Controls.Add(this.btnSave);
            this.gbAccount.Controls.Add(this.txbPass);
            this.gbAccount.Controls.Add(this.txbDisplay);
            this.gbAccount.Controls.Add(this.txbUser);
            this.gbAccount.Controls.Add(this.labelType);
            this.gbAccount.Controls.Add(this.label3);
            this.gbAccount.Controls.Add(this.label2);
            this.gbAccount.Controls.Add(this.label1);
            this.gbAccount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbAccount.Location = new System.Drawing.Point(644, 68);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(476, 503);
            this.gbAccount.TabIndex = 5;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "ACCOUNT";
            // 
            // numeudType
            // 
            this.numeudType.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeudType.Location = new System.Drawing.Point(187, 242);
            this.numeudType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeudType.Name = "numeudType";
            this.numeudType.Size = new System.Drawing.Size(136, 28);
            this.numeudType.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(333, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbPass
            // 
            this.txbPass.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Location = new System.Drawing.Point(187, 176);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(266, 28);
            this.txbPass.TabIndex = 1;
            // 
            // txbDisplay
            // 
            this.txbDisplay.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplay.Location = new System.Drawing.Point(187, 116);
            this.txbDisplay.Name = "txbDisplay";
            this.txbDisplay.Size = new System.Drawing.Size(266, 28);
            this.txbDisplay.TabIndex = 1;
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(187, 56);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(266, 28);
            this.txbUser.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(27, 242);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(49, 22);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Display Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // UC_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.gbAccount);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.palUCMenu1);
            this.Name = "UC_Revenue";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.UC_Revenue_Load);
            this.palUCMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeudType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palUCMenu1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayname;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbDisplay;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numeudType;
    }
}
