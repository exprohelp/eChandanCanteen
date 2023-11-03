namespace eChandanCanteen
{
    partial class ItemWiseVendor
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
            this.lv_Product = new System.Windows.Forms.ListView();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lv_Vendor = new System.Windows.Forms.ListView();
            this.Vendor = new System.Windows.Forms.ColumnHeader();
            this.company = new System.Windows.Forms.ColumnHeader();
            this.Purchaseid = new System.Windows.Forms.ColumnHeader();
            this.invno = new System.Windows.Forms.ColumnHeader();
            this.inv_date = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lv_Product
            // 
            this.lv_Product.BackColor = System.Drawing.SystemColors.Info;
            this.lv_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19});
            this.lv_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Product.FullRowSelect = true;
            this.lv_Product.GridLines = true;
            this.lv_Product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_Product.Location = new System.Drawing.Point(0, 44);
            this.lv_Product.Name = "lv_Product";
            this.lv_Product.Size = new System.Drawing.Size(325, 471);
            this.lv_Product.TabIndex = 176;
            this.lv_Product.TabStop = false;
            this.lv_Product.UseCompatibleStateImageBehavior = false;
            this.lv_Product.View = System.Windows.Forms.View.Details;
            this.lv_Product.SelectedIndexChanged += new System.EventHandler(this.lv_Product_SelectedIndexChanged);
            this.lv_Product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Product_KeyDown);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Item Id";
            this.columnHeader18.Width = 0;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "";
            this.columnHeader19.Width = 298;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 175;
            this.label7.Text = "Product Name";
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.Blue;
            this.txtProdName.Location = new System.Drawing.Point(0, 23);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(325, 24);
            this.txtProdName.TabIndex = 177;
            this.txtProdName.TabStop = false;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdName_KeyDown);
            // 
            // lv_Vendor
            // 
            this.lv_Vendor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Vendor,
            this.company,
            this.Purchaseid,
            this.invno,
            this.inv_date});
            this.lv_Vendor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Vendor.FullRowSelect = true;
            this.lv_Vendor.GridLines = true;
            this.lv_Vendor.Location = new System.Drawing.Point(324, 23);
            this.lv_Vendor.Name = "lv_Vendor";
            this.lv_Vendor.Size = new System.Drawing.Size(756, 228);
            this.lv_Vendor.TabIndex = 178;
            this.lv_Vendor.UseCompatibleStateImageBehavior = false;
            this.lv_Vendor.View = System.Windows.Forms.View.Details;
            this.lv_Vendor.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Vendor_ItemSelectionChanged);
            this.lv_Vendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Vendor_KeyDown);
            // 
            // Vendor
            // 
            this.Vendor.Text = "Vendor Name";
            this.Vendor.Width = 229;
            // 
            // company
            // 
            this.company.Text = "Company Code";
            this.company.Width = 93;
            // 
            // Purchaseid
            // 
            this.Purchaseid.Text = "Purchase Id";
            this.Purchaseid.Width = 109;
            // 
            // invno
            // 
            this.invno.Text = "Invoice No.";
            this.invno.Width = 79;
            // 
            // inv_date
            // 
            this.inv_date.Text = "Invoice Date";
            this.inv_date.Width = 109;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(324, 250);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 264);
            this.listView1.TabIndex = 179;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 229;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Manufacturer";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Batch";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Expiry";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pack Size";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pack Qty";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MRP";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 52;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NPR";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 49;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Qty";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ItemWiseVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1083, 515);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lv_Vendor);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lv_Product);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemWiseVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ItemWiseVendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView lv_Product;
        internal System.Windows.Forms.ColumnHeader columnHeader18;
        internal System.Windows.Forms.ColumnHeader columnHeader19;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.ListView lv_Vendor;
        private System.Windows.Forms.ColumnHeader Vendor;
        private System.Windows.Forms.ColumnHeader company;
        private System.Windows.Forms.ColumnHeader invno;
        private System.Windows.Forms.ColumnHeader inv_date;
        private System.Windows.Forms.ColumnHeader Purchaseid;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}