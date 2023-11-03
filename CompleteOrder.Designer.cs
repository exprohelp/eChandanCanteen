namespace eChandanCanteen
{
    partial class CompleteOrder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.lv_PurchBillInfo = new System.Windows.Forms.ListView();
            this.auto_id = new System.Windows.Forms.ColumnHeader();
            this.RecId = new System.Windows.Forms.ColumnHeader();
            this.ProductName = new System.Windows.Forms.ColumnHeader();
            this.BatchNo = new System.Windows.Forms.ColumnHeader();
            this.Pack_Size = new System.Windows.Forms.ColumnHeader();
            this.PACKqTY = new System.Windows.Forms.ColumnHeader();
            this.ExpDate = new System.Windows.Forms.ColumnHeader();
            this.UPR = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(872, 267);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lv_PurchBillInfo
            // 
            this.lv_PurchBillInfo.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_PurchBillInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lv_PurchBillInfo.BackgroundImageTiled = true;
            this.lv_PurchBillInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_PurchBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.auto_id,
            this.RecId,
            this.ProductName,
            this.BatchNo,
            this.Pack_Size,
            this.PACKqTY,
            this.ExpDate,
            this.UPR,
            this.Qty,
            this.Amount});
            this.lv_PurchBillInfo.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_PurchBillInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lv_PurchBillInfo.FullRowSelect = true;
            this.lv_PurchBillInfo.GridLines = true;
            this.lv_PurchBillInfo.Location = new System.Drawing.Point(6, 313);
            this.lv_PurchBillInfo.Name = "lv_PurchBillInfo";
            this.lv_PurchBillInfo.Size = new System.Drawing.Size(872, 241);
            this.lv_PurchBillInfo.TabIndex = 168;
            this.lv_PurchBillInfo.UseCompatibleStateImageBehavior = false;
            this.lv_PurchBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // auto_id
            // 
            this.auto_id.Width = 0;
            // 
            // RecId
            // 
            this.RecId.Text = "RecId";
            this.RecId.Width = 0;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 325;
            // 
            // BatchNo
            // 
            this.BatchNo.Text = "Batch";
            this.BatchNo.Width = 102;
            // 
            // Pack_Size
            // 
            this.Pack_Size.Text = "Pack Size";
            this.Pack_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pack_Size.Width = 88;
            // 
            // PACKqTY
            // 
            this.PACKqTY.Text = "Pack Qty";
            this.PACKqTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PACKqTY.Width = 69;
            // 
            // ExpDate
            // 
            this.ExpDate.Text = "Exp Date";
            this.ExpDate.Width = 77;
            // 
            // UPR
            // 
            this.UPR.Text = "UPR";
            this.UPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UPR.Width = 58;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 58;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 72;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 26);
            this.comboBox1.TabIndex = 169;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(696, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 27);
            this.textBox1.TabIndex = 170;
            // 
            // CompleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lv_PurchBillInfo);
            this.Controls.Add(this.listView1);
            this.Name = "CompleteOrder";
            this.Text = "CompleteOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ListView lv_PurchBillInfo;
        private System.Windows.Forms.ColumnHeader auto_id;
        private System.Windows.Forms.ColumnHeader RecId;
        internal System.Windows.Forms.ColumnHeader ProductName;
        internal System.Windows.Forms.ColumnHeader BatchNo;
        internal System.Windows.Forms.ColumnHeader Pack_Size;
        internal System.Windows.Forms.ColumnHeader PACKqTY;
        internal System.Windows.Forms.ColumnHeader ExpDate;
        internal System.Windows.Forms.ColumnHeader UPR;
        internal System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}