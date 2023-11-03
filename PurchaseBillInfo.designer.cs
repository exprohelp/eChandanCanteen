namespace eChandanCanteen
{
    partial class PurchaseBillInfo
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkVerify = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ddlDocuments = new System.Windows.Forms.ComboBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.pbPurchageFillInfo = new System.Windows.Forms.ProgressBar();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.MasterKeyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.feeding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvDisc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NetAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoundOff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.veri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ImgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.GroupBox1.Controls.Add(this.btnDelete);
            this.GroupBox1.Controls.Add(this.chkVerify);
            this.GroupBox1.Controls.Add(this.btnOpen);
            this.GroupBox1.Controls.Add(this.ddlDocuments);
            this.GroupBox1.Controls.Add(this.dtFrom);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.dtTo);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.btnFill);
            this.GroupBox1.Controls.Add(this.pbPurchageFillInfo);
            this.GroupBox1.Controls.Add(this.btnPrint);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(2, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1023, 49);
            this.GroupBox1.TabIndex = 52;
            this.GroupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(948, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 255;
            this.btnDelete.Text = "Delete Bill";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkVerify
            // 
            this.chkVerify.AutoSize = true;
            this.chkVerify.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerify.Location = new System.Drawing.Point(7, 21);
            this.chkVerify.Name = "chkVerify";
            this.chkVerify.Size = new System.Drawing.Size(124, 17);
            this.chkVerify.TabIndex = 58;
            this.chkVerify.Text = "Verified Purchase";
            this.chkVerify.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(838, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(43, 28);
            this.btnOpen.TabIndex = 254;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ddlDocuments
            // 
            this.ddlDocuments.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlDocuments.FormattingEnabled = true;
            this.ddlDocuments.Location = new System.Drawing.Point(637, 13);
            this.ddlDocuments.Name = "ddlDocuments";
            this.ddlDocuments.Size = new System.Drawing.Size(195, 28);
            this.ddlDocuments.TabIndex = 253;
            this.ddlDocuments.SelectedIndexChanged += new System.EventHandler(this.ddlDocuments_SelectedIndexChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(167, 17);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(111, 22);
            this.dtFrom.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(597, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 252;
            this.label2.Text = "BILL ";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(303, 17);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(119, 22);
            this.dtTo.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(279, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "From";
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(426, 15);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(45, 26);
            this.btnFill.TabIndex = 20;
            this.btnFill.Text = ">>";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // pbPurchageFillInfo
            // 
            this.pbPurchageFillInfo.Enabled = false;
            this.pbPurchageFillInfo.Location = new System.Drawing.Point(477, 16);
            this.pbPurchageFillInfo.MarqueeAnimationSpeed = 35;
            this.pbPurchageFillInfo.Maximum = 50;
            this.pbPurchageFillInfo.Name = "pbPurchageFillInfo";
            this.pbPurchageFillInfo.Size = new System.Drawing.Size(46, 25);
            this.pbPurchageFillInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbPurchageFillInfo.TabIndex = 51;
            this.pbPurchageFillInfo.Visible = false;
            this.pbPurchageFillInfo.Click += new System.EventHandler(this.pbPurchageFillInfo_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::eChandanCanteen.Properties.Resources.printer16;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(529, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 27);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lv_Detail
            // 
            this.lv_Detail.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_Detail.BackColor = System.Drawing.Color.White;
            this.lv_Detail.BackgroundImageTiled = true;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MasterKeyId,
            this.InvNo,
            this.InvDate,
            this.feeding,
            this.InvTotal,
            this.InvTax,
            this.InvDisc,
            this.NetAmt,
            this.RoundOff,
            this.veri});
            this.lv_Detail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.ForeColor = System.Drawing.Color.Maroon;
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(4, 57);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(745, 426);
            this.lv_Detail.TabIndex = 51;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            this.lv_Detail.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_Detail_ItemChecked);
            this.lv_Detail.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Detail_ItemSelectionChanged);
            this.lv_Detail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Detail_KeyDown);
            // 
            // MasterKeyId
            // 
            this.MasterKeyId.Text = "Purchage Id";
            this.MasterKeyId.Width = 111;
            // 
            // InvNo
            // 
            this.InvNo.Text = "Inv No";
            this.InvNo.Width = 72;
            // 
            // InvDate
            // 
            this.InvDate.Text = "Inv Date";
            this.InvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InvDate.Width = 80;
            // 
            // feeding
            // 
            this.feeding.Text = "Feeding";
            this.feeding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.feeding.Width = 89;
            // 
            // InvTotal
            // 
            this.InvTotal.Text = "Inv Total";
            this.InvTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvTotal.Width = 73;
            // 
            // InvTax
            // 
            this.InvTax.Text = "Inv Tax";
            this.InvTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvTax.Width = 66;
            // 
            // InvDisc
            // 
            this.InvDisc.Text = "Inv Disc";
            this.InvDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NetAmt
            // 
            this.NetAmt.Text = "Net Amt";
            this.NetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NetAmt.Width = 70;
            // 
            // RoundOff
            // 
            this.RoundOff.Text = "Round Off";
            this.RoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RoundOff.Width = 62;
            // 
            // veri
            // 
            this.veri.Text = "verify";
            this.veri.Width = 41;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 53;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(601, 17);
            this.toolStripStatusLabel1.Text = "Press \'P\' to print bill on selected purchase,press \'Enter\' to view only purchase " +
    "detail,Press \'B\' to view Scaned Bill";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(4, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 63);
            this.panel1.TabIndex = 251;
            this.panel1.Visible = false;
            // 
            // ImgPanel
            // 
            this.ImgPanel.AutoScroll = true;
            this.ImgPanel.Controls.Add(this.button1);
            this.ImgPanel.Controls.Add(this.pictureBox1);
            this.ImgPanel.Location = new System.Drawing.Point(754, 57);
            this.ImgPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ImgPanel.Name = "ImgPanel";
            this.ImgPanel.Size = new System.Drawing.Size(271, 494);
            this.ImgPanel.TabIndex = 255;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::eChandanCanteen.Properties.Resources.print;
            this.button1.Location = new System.Drawing.Point(116, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 43);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 489);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PurchaseBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1028, 575);
            this.Controls.Add(this.ImgPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lv_Detail);
            this.Name = "PurchaseBillInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{Purchase Bill Info}";
            this.Load += new System.EventHandler(this.PurchaseBillInfo_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ImgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ProgressBar pbPurchageFillInfo;
        private System.Windows.Forms.Button btnFill;
        internal System.Windows.Forms.ListView lv_Detail;
        internal System.Windows.Forms.ColumnHeader MasterKeyId;
        internal System.Windows.Forms.ColumnHeader InvNo;
        internal System.Windows.Forms.ColumnHeader InvDate;
        internal System.Windows.Forms.ColumnHeader InvTotal;
        internal System.Windows.Forms.ColumnHeader InvTax;
        internal System.Windows.Forms.ColumnHeader InvDisc;
        internal System.Windows.Forms.ColumnHeader NetAmt;
        private System.Windows.Forms.ColumnHeader RoundOff;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColumnHeader feeding;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkVerify;
        private System.Windows.Forms.ColumnHeader veri;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox ddlDocuments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ImgPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDelete;
    }
}