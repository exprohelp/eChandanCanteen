namespace eChandanCanteen
{
    partial class BillingAnalysis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.pbPurchageFillInfo = new System.Windows.Forms.ProgressBar();
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.purchaseid = new System.Windows.Forms.ColumnHeader();
            this.inv_date = new System.Windows.Forms.ColumnHeader();
            this.feed_date = new System.Windows.Forms.ColumnHeader();
            this.days = new System.Windows.Forms.ColumnHeader();
            this.total = new System.Windows.Forms.ColumnHeader();
            this.emp = new System.Windows.Forms.ColumnHeader();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Controls.Add(this.pbPurchageFillInfo);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Arial Narrow", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(214, 19);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(119, 27);
            this.dtTo.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(182, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "From";
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(343, 17);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(54, 31);
            this.btnFill.TabIndex = 56;
            this.btnFill.Text = ">>";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // pbPurchageFillInfo
            // 
            this.pbPurchageFillInfo.Enabled = false;
            this.pbPurchageFillInfo.Location = new System.Drawing.Point(686, 19);
            this.pbPurchageFillInfo.MarqueeAnimationSpeed = 35;
            this.pbPurchageFillInfo.Maximum = 50;
            this.pbPurchageFillInfo.Name = "pbPurchageFillInfo";
            this.pbPurchageFillInfo.Size = new System.Drawing.Size(113, 28);
            this.pbPurchageFillInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbPurchageFillInfo.TabIndex = 57;
            this.pbPurchageFillInfo.Visible = false;
            // 
            // lv_Detail
            // 
            this.lv_Detail.BackColor = System.Drawing.Color.LightBlue;
            this.lv_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchaseid,
            this.inv_date,
            this.feed_date,
            this.days,
            this.total,
            this.emp});
            this.lv_Detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(3, 67);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(808, 496);
            this.lv_Detail.TabIndex = 1;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            // 
            // purchaseid
            // 
            this.purchaseid.Text = "Purchase Id";
            this.purchaseid.Width = 149;
            // 
            // inv_date
            // 
            this.inv_date.Text = "Invoice Date";
            this.inv_date.Width = 113;
            // 
            // feed_date
            // 
            this.feed_date.Text = "Feeding Date";
            this.feed_date.Width = 122;
            // 
            // days
            // 
            this.days.Text = "Days";
            this.days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.days.Width = 51;
            // 
            // total
            // 
            this.total.Text = "Total Amount";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total.Width = 97;
            // 
            // emp
            // 
            this.emp.Text = "Feeded By";
            this.emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emp.Width = 253;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(615, 576);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 23);
            this.lblTotal.TabIndex = 2;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Arial Narrow", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(60, 20);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(119, 27);
            this.dtFrom.TabIndex = 62;
            // 
            // BillingAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(816, 604);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lv_Detail);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillingAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingAnalysis";
            this.Load += new System.EventHandler(this.BillingAnalysis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ProgressBar pbPurchageFillInfo;
        private System.Windows.Forms.ListView lv_Detail;
        private System.Windows.Forms.ColumnHeader inv_date;
        private System.Windows.Forms.ColumnHeader feed_date;
        private System.Windows.Forms.ColumnHeader days;
        private System.Windows.Forms.ColumnHeader total;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader emp;
        private System.Windows.Forms.ColumnHeader purchaseid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtFrom;
    }
}