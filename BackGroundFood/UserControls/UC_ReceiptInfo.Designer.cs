namespace QLKho.UserControls
{
    partial class UC_ReceiptInfo
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
            this.listViewGoods = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listViewReceipt = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewGoods
            // 
            this.listViewGoods.Location = new System.Drawing.Point(751, 16);
            this.listViewGoods.Name = "listViewGoods";
            this.listViewGoods.Size = new System.Drawing.Size(546, 539);
            this.listViewGoods.TabIndex = 0;
            this.listViewGoods.UseCompatibleStateImageBehavior = false;
            this.listViewGoods.View = System.Windows.Forms.View.Details;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PICK DATE";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(459, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 68);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // listViewReceipt
            // 
            this.listViewReceipt.Location = new System.Drawing.Point(40, 153);
            this.listViewReceipt.Name = "listViewReceipt";
            this.listViewReceipt.Size = new System.Drawing.Size(387, 385);
            this.listViewReceipt.TabIndex = 4;
            this.listViewReceipt.UseCompatibleStateImageBehavior = false;
            this.listViewReceipt.View = System.Windows.Forms.View.Details;
            this.listViewReceipt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewReceipt_MouseDoubleClick);
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.listViewReceipt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listViewGoods);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1353, 577);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGoods;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listViewReceipt;
    }
}
