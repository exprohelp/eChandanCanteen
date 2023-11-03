namespace eChandanCanteen
{
    partial class PH_byItem
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
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.mFD = new System.Windows.Forms.ColumnHeader();
            this.invoicedate = new System.Windows.Forms.ColumnHeader();
            this.inv_date = new System.Windows.Forms.ColumnHeader();
            this.qty = new System.Windows.Forms.ColumnHeader();
            this.RATE = new System.Windows.Forms.ColumnHeader();
            this.pbPurchageFillInfo = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lv_Detail
            // 
            this.lv_Detail.BackColor = System.Drawing.Color.LightBlue;
            this.lv_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.mFD,
            this.invoicedate,
            this.inv_date,
            this.qty,
            this.RATE});
            this.lv_Detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(8, 36);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(808, 550);
            this.lv_Detail.TabIndex = 4;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 165;
            // 
            // mFD
            // 
            this.mFD.Text = "Manufacturer";
            this.mFD.Width = 196;
            // 
            // invoicedate
            // 
            this.invoicedate.Text = "Invoce No";
            this.invoicedate.Width = 149;
            // 
            // inv_date
            // 
            this.inv_date.Text = "Invoice Date";
            this.inv_date.Width = 98;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qty.Width = 81;
            // 
            // RATE
            // 
            this.RATE.Text = "Rate(MRP)";
            this.RATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RATE.Width = 97;
            // 
            // pbPurchageFillInfo
            // 
            this.pbPurchageFillInfo.Enabled = false;
            this.pbPurchageFillInfo.Location = new System.Drawing.Point(660, 7);
            this.pbPurchageFillInfo.MarqueeAnimationSpeed = 35;
            this.pbPurchageFillInfo.Maximum = 50;
            this.pbPurchageFillInfo.Name = "pbPurchageFillInfo";
            this.pbPurchageFillInfo.Size = new System.Drawing.Size(156, 23);
            this.pbPurchageFillInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbPurchageFillInfo.TabIndex = 58;
            this.pbPurchageFillInfo.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // PH_byItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(824, 589);
            this.Controls.Add(this.pbPurchageFillInfo);
            this.Controls.Add(this.lv_Detail);
            this.Name = "PH_byItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PH_byItem";
            this.Load += new System.EventHandler(this.PH_byItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Detail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader mFD;
        private System.Windows.Forms.ColumnHeader invoicedate;
        private System.Windows.Forms.ColumnHeader inv_date;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader RATE;
        private System.Windows.Forms.ProgressBar pbPurchageFillInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}