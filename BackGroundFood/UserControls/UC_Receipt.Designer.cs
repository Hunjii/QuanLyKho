namespace QLKho
{
    partial class UC_Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Receipt));
            this.palUCMenu1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbNhapHang = new System.Windows.Forms.GroupBox();
            this.listViewReceipeGood = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNCC = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxGoodsName = new System.Windows.Forms.ComboBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewGood = new System.Windows.Forms.ListView();
            this.textBoxSDH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.palUCMenu1.SuspendLayout();
            this.grbNhapHang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // palUCMenu1
            // 
            this.palUCMenu1.Controls.Add(this.btnEdit);
            this.palUCMenu1.Controls.Add(this.btnDelete);
            this.palUCMenu1.Controls.Add(this.btnAdd);
            this.palUCMenu1.Location = new System.Drawing.Point(21, 4);
            this.palUCMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.palUCMenu1.Name = "palUCMenu1";
            this.palUCMenu1.Size = new System.Drawing.Size(541, 69);
            this.palUCMenu1.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(360, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 69);
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
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(183, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 69);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Thong ke";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(7, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 69);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "New receipt";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbNhapHang
            // 
            this.grbNhapHang.Controls.Add(this.label3);
            this.grbNhapHang.Controls.Add(this.textBoxSDH);
            this.grbNhapHang.Controls.Add(this.listViewReceipeGood);
            this.grbNhapHang.Controls.Add(this.button1);
            this.grbNhapHang.Controls.Add(this.label2);
            this.grbNhapHang.Controls.Add(this.textBoxNCC);
            this.grbNhapHang.Controls.Add(this.textBoxID);
            this.grbNhapHang.Controls.Add(this.label1);
            this.grbNhapHang.Controls.Add(this.groupBox3);
            this.grbNhapHang.Location = new System.Drawing.Point(28, 80);
            this.grbNhapHang.Name = "grbNhapHang";
            this.grbNhapHang.Size = new System.Drawing.Size(859, 535);
            this.grbNhapHang.TabIndex = 3;
            this.grbNhapHang.TabStop = false;
            // 
            // listViewReceipeGood
            // 
            this.listViewReceipeGood.Location = new System.Drawing.Point(6, 169);
            this.listViewReceipeGood.Name = "listViewReceipeGood";
            this.listViewReceipeGood.Size = new System.Drawing.Size(408, 281);
            this.listViewReceipeGood.TabIndex = 12;
            this.listViewReceipeGood.UseCompatibleStateImageBehavior = false;
            this.listViewReceipeGood.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Done";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ma nha cung cap:";
            // 
            // textBoxNCC
            // 
            this.textBoxNCC.Location = new System.Drawing.Point(154, 79);
            this.textBoxNCC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNCC.Name = "textBoxNCC";
            this.textBoxNCC.Size = new System.Drawing.Size(211, 22);
            this.textBoxNCC.TabIndex = 9;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(154, 37);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(211, 22);
            this.textBoxID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Receipt ID   :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxGoodsName);
            this.groupBox3.Controls.Add(this.textBoxAmount);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(421, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(416, 460);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information Goods";
            // 
            // comboBoxGoodsName
            // 
            this.comboBoxGoodsName.FormattingEnabled = true;
            this.comboBoxGoodsName.Location = new System.Drawing.Point(156, 40);
            this.comboBoxGoodsName.Name = "comboBoxGoodsName";
            this.comboBoxGoodsName.Size = new System.Drawing.Size(205, 28);
            this.comboBoxGoodsName.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(156, 203);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(211, 26);
            this.textBoxAmount.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(156, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Goods name      :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(28, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Amount    :";
            // 
            // listViewGood
            // 
            this.listViewGood.Location = new System.Drawing.Point(893, 80);
            this.listViewGood.Name = "listViewGood";
            this.listViewGood.Size = new System.Drawing.Size(421, 532);
            this.listViewGood.TabIndex = 4;
            this.listViewGood.UseCompatibleStateImageBehavior = false;
            this.listViewGood.View = System.Windows.Forms.View.Details;
            // 
            // textBoxSDH
            // 
            this.textBoxSDH.Location = new System.Drawing.Point(154, 125);
            this.textBoxSDH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSDH.Name = "textBoxSDH";
            this.textBoxSDH.Size = new System.Drawing.Size(211, 22);
            this.textBoxSDH.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "So don hang:";
            // 
            // UC_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.listViewGood);
            this.Controls.Add(this.grbNhapHang);
            this.Controls.Add(this.palUCMenu1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Receipt";
            this.Size = new System.Drawing.Size(1333, 615);
            this.Load += new System.EventHandler(this.UC_Receipt_Load);
            this.palUCMenu1.ResumeLayout(false);
            this.grbNhapHang.ResumeLayout(false);
            this.grbNhapHang.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palUCMenu1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbNhapHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNCC;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewReceipeGood;
        private System.Windows.Forms.ListView listViewGood;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxGoodsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSDH;
    }
}
