namespace eChandanCanteen
{
    partial class ProductHistory
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
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.mFD = new System.Windows.Forms.ColumnHeader();
            this.invoicedate = new System.Windows.Forms.ColumnHeader();
            this.inv_date = new System.Windows.Forms.ColumnHeader();
            this.qty = new System.Windows.Forms.ColumnHeader();
            this.RATE = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModSelectProd = new System.Windows.Forms.ComboBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.pbPurchageFillInfo = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Packsize = new System.Windows.Forms.ColumnHeader();
            this.PackQty = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Detail
            // 
            this.lv_Detail.BackColor = System.Drawing.Color.LightBlue;
            this.lv_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mFD,
            this.invoicedate,
            this.inv_date,
            this.Packsize,
            this.PackQty,
            this.qty,
            this.RATE});
            this.lv_Detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(5, 58);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(808, 514);
            this.lv_Detail.TabIndex = 3;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            // 
            // mFD
            // 
            this.mFD.Text = "Manufacturer";
            this.mFD.Width = 194;
            // 
            // invoicedate
            // 
            this.invoicedate.Text = "Invoce No";
            this.invoicedate.Width = 123;
            // 
            // inv_date
            // 
            this.inv_date.Text = "Invoice Date";
            this.inv_date.Width = 104;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qty.Width = 87;
            // 
            // RATE
            // 
            this.RATE.Text = "Rate(NPR)";
            this.RATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RATE.Width = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbModSelectProd);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Controls.Add(this.pbPurchageFillInfo);
            this.groupBox1.Location = new System.Drawing.Point(5, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(360, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 225;
            this.label2.Text = "From";
            // 
            // cmbModSelectProd
            // 
            this.cmbModSelectProd.BackColor = System.Drawing.Color.White;
            this.cmbModSelectProd.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModSelectProd.FormattingEnabled = true;
            this.cmbModSelectProd.ItemHeight = 17;
            this.cmbModSelectProd.Location = new System.Drawing.Point(87, 19);
            this.cmbModSelectProd.Name = "cmbModSelectProd";
            this.cmbModSelectProd.Size = new System.Drawing.Size(269, 25);
            this.cmbModSelectProd.TabIndex = 224;
            this.cmbModSelectProd.Text = "Select";
            this.cmbModSelectProd.SelectedIndexChanged += new System.EventHandler(this.cmbModSelectProd_SelectedIndexChanged);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(533, 21);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(99, 20);
            this.dtTo.TabIndex = 61;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(397, 22);
            this.dtFrom.MinDate = new System.DateTime(1753, 2, 4, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(106, 20);
            this.dtFrom.TabIndex = 60;
            this.dtFrom.Value = new System.DateTime(2009, 5, 15, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(505, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Select Unit";
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Black;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(639, 19);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(52, 26);
            this.btnFill.TabIndex = 56;
            this.btnFill.Text = ">>";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // pbPurchageFillInfo
            // 
            this.pbPurchageFillInfo.Enabled = false;
            this.pbPurchageFillInfo.Location = new System.Drawing.Point(713, 20);
            this.pbPurchageFillInfo.MarqueeAnimationSpeed = 35;
            this.pbPurchageFillInfo.Maximum = 50;
            this.pbPurchageFillInfo.Name = "pbPurchageFillInfo";
            this.pbPurchageFillInfo.Size = new System.Drawing.Size(85, 23);
            this.pbPurchageFillInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbPurchageFillInfo.TabIndex = 57;
            this.pbPurchageFillInfo.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Packsize
            // 
            this.Packsize.Text = "Pack Size";
            this.Packsize.Width = 92;
            // 
            // PackQty
            // 
            this.PackQty.Text = "Pack Qty";
            this.PackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PackQty.Width = 86;
            // 
            // ProductHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(818, 584);
            this.Controls.Add(this.lv_Detail);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product History";
            this.Load += new System.EventHandler(this.ProductHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Detail;
        private System.Windows.Forms.ColumnHeader invoicedate;
        private System.Windows.Forms.ColumnHeader inv_date;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader RATE;
        private System.Windows.Forms.ColumnHeader mFD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ProgressBar pbPurchageFillInfo;
        private System.Windows.Forms.ComboBox cmbModSelectProd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Packsize;
        private System.Windows.Forms.ColumnHeader PackQty;
    }
}