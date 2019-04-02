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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewGood = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNhap = new System.Windows.Forms.Button();
            this.buttonXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewGood
            // 
            this.listViewGood.Location = new System.Drawing.Point(729, 103);
            this.listViewGood.Name = "listViewGood";
            this.listViewGood.Size = new System.Drawing.Size(719, 504);
            this.listViewGood.TabIndex = 1;
            this.listViewGood.UseCompatibleStateImageBehavior = false;
            this.listViewGood.View = System.Windows.Forms.View.Details;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(201, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn ngày";
            // 
            // buttonNhap
            // 
            this.buttonNhap.Location = new System.Drawing.Point(406, 198);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.Size = new System.Drawing.Size(130, 54);
            this.buttonNhap.TabIndex = 4;
            this.buttonNhap.Text = "Nhập";
            this.buttonNhap.UseVisualStyleBackColor = true;
            this.buttonNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonXuat
            // 
            this.buttonXuat.Location = new System.Drawing.Point(406, 304);
            this.buttonXuat.Name = "buttonXuat";
            this.buttonXuat.Size = new System.Drawing.Size(130, 54);
            this.buttonXuat.TabIndex = 5;
            this.buttonXuat.Text = "Xuất";
            this.buttonXuat.UseVisualStyleBackColor = true;
            this.buttonXuat.Click += new System.EventHandler(this.buttonXuat_Click);
            // 
            // UC_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.buttonXuat);
            this.Controls.Add(this.buttonNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listViewGood);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Issue";
            this.Size = new System.Drawing.Size(1600, 738);
            this.Load += new System.EventHandler(this.UC_Issue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewGood;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNhap;
        private System.Windows.Forms.Button buttonXuat;
    }
}
