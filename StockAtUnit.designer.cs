namespace eChandanCanteen
{
    partial class StockAtUnit
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_trfToxl = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pbZeroStockUpdate = new System.Windows.Forms.ProgressBar();
            this.btnFill = new System.Windows.Forms.Button();
            this.cmbUnitName = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BatchNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.chkZero = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.GroupBox1.Controls.Add(this.chkZero);
            this.GroupBox1.Controls.Add(this.btn_trfToxl);
            this.GroupBox1.Controls.Add(this.btnPrint);
            this.GroupBox1.Controls.Add(this.pbZeroStockUpdate);
            this.GroupBox1.Controls.Add(this.btnFill);
            this.GroupBox1.Controls.Add(this.cmbUnitName);
            this.GroupBox1.Controls.Add(this.label20);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(7, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(780, 45);
            this.GroupBox1.TabIndex = 48;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = " ";
            // 
            // btn_trfToxl
            // 
            this.btn_trfToxl.BackColor = System.Drawing.Color.LightCoral;
            this.btn_trfToxl.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trfToxl.Location = new System.Drawing.Point(638, 13);
            this.btn_trfToxl.Name = "btn_trfToxl";
            this.btn_trfToxl.Size = new System.Drawing.Size(136, 29);
            this.btn_trfToxl.TabIndex = 56;
            this.btn_trfToxl.Text = "Transfer To Excel";
            this.btn_trfToxl.UseVisualStyleBackColor = false;
            this.btn_trfToxl.Click += new System.EventHandler(this.btn_trfToxl_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::eChandanCanteen.Properties.Resources.print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(565, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 30);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
   
            // 
            // pbZeroStockUpdate
            // 
            this.pbZeroStockUpdate.Enabled = false;
            this.pbZeroStockUpdate.Location = new System.Drawing.Point(512, 15);
            this.pbZeroStockUpdate.MarqueeAnimationSpeed = 35;
            this.pbZeroStockUpdate.Maximum = 50;
            this.pbZeroStockUpdate.Name = "pbZeroStockUpdate";
            this.pbZeroStockUpdate.Size = new System.Drawing.Size(50, 23);
            this.pbZeroStockUpdate.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbZeroStockUpdate.TabIndex = 51;
            this.pbZeroStockUpdate.Visible = false;
            this.pbZeroStockUpdate.Click += new System.EventHandler(this.pbZeroStockUpdate_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFill.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(461, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(45, 28);
            this.btnFill.TabIndex = 20;
            this.btnFill.Text = ">>";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // cmbUnitName
            // 
            this.cmbUnitName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitName.FormattingEnabled = true;
            this.cmbUnitName.Location = new System.Drawing.Point(164, 13);
            this.cmbUnitName.Name = "cmbUnitName";
            this.cmbUnitName.Size = new System.Drawing.Size(287, 24);
            this.cmbUnitName.TabIndex = 19;
            this.cmbUnitName.SelectedIndexChanged += new System.EventHandler(this.cmbUnitName_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(94, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Unit Name";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // BatchNo
            // 
            this.BatchNo.Text = "Batch";
            this.BatchNo.Width = 120;
            // 
            // Pack_Type
            // 
            this.Pack_Type.Text = "Pack Type";
            this.Pack_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pack_Type.Width = 100;
            // 
            // PackQty
            // 
            this.PackQty.Text = "Pack Qty";
            this.PackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PackQty.Width = 80;
            // 
            // ExpDate
            // 
            this.ExpDate.Text = "Exp Date";
            this.ExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExpDate.Width = 130;
            // 
            // NPR
            // 
            this.NPR.Text = "NPR";
            this.NPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NPR.Width = 80;
            // 
            // UPR
            // 
            this.UPR.Text = "UPR";
            this.UPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UPR.Width = 80;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 80;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 86;
            // 
            // lv_Detail
            // 
            this.lv_Detail.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_Detail.BackColor = System.Drawing.Color.White;
            this.lv_Detail.BackgroundImageTiled = true;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BatchNo,
            this.Pack_Type,
            this.PackQty,
            this.ExpDate,
            this.NPR,
            this.UPR,
            this.Qty,
            this.Amount});
            this.lv_Detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.ForeColor = System.Drawing.Color.Maroon;
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(7, 55);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(780, 461);
            this.lv_Detail.TabIndex = 47;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            // 
            // chkZero
            // 
            this.chkZero.AutoSize = true;
            this.chkZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZero.Location = new System.Drawing.Point(6, 18);
            this.chkZero.Name = "chkZero";
            this.chkZero.Size = new System.Drawing.Size(86, 17);
            this.chkZero.TabIndex = 57;
            this.chkZero.Text = "Include Zero";
            this.chkZero.UseVisualStyleBackColor = true;
            // 
            // StockAtUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(795, 521);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lv_Detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StockAtUnit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "{Stock At Unit & Warehouse}";
            this.Load += new System.EventHandler(this.StockAtUnit_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cmbUnitName;
        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ProgressBar pbZeroStockUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.ColumnHeader BatchNo;
        internal System.Windows.Forms.ColumnHeader Pack_Type;
        internal System.Windows.Forms.ColumnHeader PackQty;
        internal System.Windows.Forms.ColumnHeader ExpDate;
        internal System.Windows.Forms.ColumnHeader NPR;
        internal System.Windows.Forms.ColumnHeader UPR;
        internal System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Amount;
        internal System.Windows.Forms.ListView lv_Detail;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btn_trfToxl;
        private System.Windows.Forms.CheckBox chkZero;
    }
}