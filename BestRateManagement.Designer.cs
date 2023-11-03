namespace eChandanCanteen
{
    partial class BestRateManagement
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
            System.Windows.Forms.Button btnView;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnViewExisting = new System.Windows.Forms.Button();
            this.cbxMfd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvbestrateinfo = new System.Windows.Forms.ListView();
            this.Mfd = new System.Windows.Forms.ColumnHeader();
            this.Product = new System.Windows.Forms.ColumnHeader();
            this.pack = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.auto_id = new System.Windows.Forms.ColumnHeader();
            this.txtsearchKey = new System.Windows.Forms.TextBox();
            this.cbxPackSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxVendor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvReport = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            btnView = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            btnView.BackColor = System.Drawing.Color.LightBlue;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnView.Location = new System.Drawing.Point(4, 7);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(103, 28);
            btnView.TabIndex = 17;
            btnView.Text = "Show All";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnViewExisting);
            this.tabPage1.Controls.Add(this.cbxMfd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lvbestrateinfo);
            this.tabPage1.Controls.Add(this.txtsearchKey);
            this.tabPage1.Controls.Add(this.cbxPackSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtBestRate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.cbxItem);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbxVendor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Feed New";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 79);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Help";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(430, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "2: You can delete selected bestrate information by using \'Delete\' key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(554, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "1: You can view existing best rate of particular product by clicking \'View Existi" +
                "ng\' button";
            // 
            // btnViewExisting
            // 
            this.btnViewExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewExisting.Font = new System.Drawing.Font("Arial Narrow", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExisting.Location = new System.Drawing.Point(704, 69);
            this.btnViewExisting.Name = "btnViewExisting";
            this.btnViewExisting.Size = new System.Drawing.Size(84, 28);
            this.btnViewExisting.TabIndex = 16;
            this.btnViewExisting.Text = "View Existing";
            this.btnViewExisting.UseVisualStyleBackColor = true;
            this.btnViewExisting.Click += new System.EventHandler(this.btnViewExisting_Click);
            // 
            // cbxMfd
            // 
            this.cbxMfd.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMfd.FormattingEnabled = true;
            this.cbxMfd.Location = new System.Drawing.Point(368, 103);
            this.cbxMfd.Name = "cbxMfd";
            this.cbxMfd.Size = new System.Drawing.Size(155, 25);
            this.cbxMfd.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Manufacturer";
            // 
            // lvbestrateinfo
            // 
            this.lvbestrateinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvbestrateinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mfd,
            this.Product,
            this.pack,
            this.Amount,
            this.auto_id});
            this.lvbestrateinfo.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbestrateinfo.FullRowSelect = true;
            this.lvbestrateinfo.GridLines = true;
            this.lvbestrateinfo.Location = new System.Drawing.Point(11, 141);
            this.lvbestrateinfo.Name = "lvbestrateinfo";
            this.lvbestrateinfo.Size = new System.Drawing.Size(778, 261);
            this.lvbestrateinfo.TabIndex = 13;
            this.lvbestrateinfo.UseCompatibleStateImageBehavior = false;
            this.lvbestrateinfo.View = System.Windows.Forms.View.Details;
            this.lvbestrateinfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvbestrateinfo_KeyDown);
            // 
            // Mfd
            // 
            this.Mfd.Text = "Manufacturer";
            this.Mfd.Width = 173;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 422;
            // 
            // pack
            // 
            this.pack.Text = "Pack SIze";
            this.pack.Width = 89;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 69;
            // 
            // auto_id
            // 
            this.auto_id.Text = "";
            this.auto_id.Width = 0;
            // 
            // txtsearchKey
            // 
            this.txtsearchKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearchKey.Location = new System.Drawing.Point(116, 69);
            this.txtsearchKey.Name = "txtsearchKey";
            this.txtsearchKey.Size = new System.Drawing.Size(154, 25);
            this.txtsearchKey.TabIndex = 12;
            // 
            // cbxPackSize
            // 
            this.cbxPackSize.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPackSize.FormattingEnabled = true;
            this.cbxPackSize.Location = new System.Drawing.Point(116, 103);
            this.cbxPackSize.Name = "cbxPackSize";
            this.cbxPackSize.Size = new System.Drawing.Size(155, 25);
            this.cbxPackSize.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Packs";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(704, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBestRate
            // 
            this.txtBestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBestRate.Location = new System.Drawing.Point(608, 105);
            this.txtBestRate.Name = "txtBestRate";
            this.txtBestRate.Size = new System.Drawing.Size(89, 25);
            this.txtBestRate.TabIndex = 8;
            this.txtBestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Best Rate";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(276, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxItem
            // 
            this.cbxItem.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(347, 69);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(351, 25);
            this.cbxItem.TabIndex = 4;
            this.cbxItem.SelectedIndexChanged += new System.EventHandler(this.cbxItem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Product";
            // 
            // cbxVendor
            // 
            this.cbxVendor.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVendor.FormattingEnabled = true;
            this.cbxVendor.Location = new System.Drawing.Point(116, 34);
            this.cbxVendor.Name = "cbxVendor";
            this.cbxVendor.Size = new System.Drawing.Size(673, 25);
            this.cbxVendor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Vendor";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage3.Controls.Add(btnView);
            this.tabPage3.Controls.Add(this.lvReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(797, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Report";
            // 
            // lvReport
            // 
            this.lvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvReport.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReport.FullRowSelect = true;
            this.lvReport.GridLines = true;
            this.lvReport.Location = new System.Drawing.Point(3, 39);
            this.lvReport.Name = "lvReport";
            this.lvReport.Size = new System.Drawing.Size(790, 454);
            this.lvReport.TabIndex = 14;
            this.lvReport.UseCompatibleStateImageBehavior = false;
            this.lvReport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Manufacturer";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product";
            this.columnHeader3.Width = 395;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pack SIze";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 2;
            // 
            // BestRateManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "BestRateManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Rate Management";
            this.Load += new System.EventHandler(this.BestRateManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPackSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearchKey;
        private System.Windows.Forms.ListView lvbestrateinfo;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader pack;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ComboBox cbxMfd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Mfd;
        private System.Windows.Forms.Button btnViewExisting;
        private System.Windows.Forms.ColumnHeader auto_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvReport;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}