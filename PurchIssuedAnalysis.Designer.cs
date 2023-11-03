namespace eChandanCanteen
{
    partial class PurchIssuedAnalysis
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModSelectProd = new System.Windows.Forms.ComboBox();
            this.pbPurchageFillInfo = new System.Windows.Forms.ProgressBar();
            this.btnFill = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.m_list = new eChandanCanteen.PrintableListView();
            this.Unit = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Issued = new System.Windows.Forms.ColumnHeader();
            this.Running = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbModSelectProd);
            this.groupBox1.Controls.Add(this.pbPurchageFillInfo);
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 225;
            this.label2.Text = "Select Product";
            // 
            // cmbModSelectProd
            // 
            this.cmbModSelectProd.BackColor = System.Drawing.Color.White;
            this.cmbModSelectProd.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModSelectProd.FormattingEnabled = true;
            this.cmbModSelectProd.ItemHeight = 17;
            this.cmbModSelectProd.Location = new System.Drawing.Point(8, 42);
            this.cmbModSelectProd.Name = "cmbModSelectProd";
            this.cmbModSelectProd.Size = new System.Drawing.Size(434, 25);
            this.cmbModSelectProd.TabIndex = 224;
            this.cmbModSelectProd.Text = "Select";
            this.cmbModSelectProd.SelectedIndexChanged += new System.EventHandler(this.cmbModSelectProd_SelectedIndexChanged);
            // 
            // pbPurchageFillInfo
            // 
            this.pbPurchageFillInfo.Enabled = false;
            this.pbPurchageFillInfo.Location = new System.Drawing.Point(503, 40);
            this.pbPurchageFillInfo.MarqueeAnimationSpeed = 35;
            this.pbPurchageFillInfo.Maximum = 50;
            this.pbPurchageFillInfo.Name = "pbPurchageFillInfo";
            this.pbPurchageFillInfo.Size = new System.Drawing.Size(48, 28);
            this.pbPurchageFillInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbPurchageFillInfo.TabIndex = 57;
            this.pbPurchageFillInfo.Visible = false;
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Black;
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(447, 39);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(54, 32);
            this.btnFill.TabIndex = 56;
            this.btnFill.Text = ">>";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // m_list
            // 
            this.m_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Unit,
            this.Quantity,
            this.Issued,
            this.Running});
            this.m_list.FitToPage = false;
            this.m_list.Font = new System.Drawing.Font("Calibri", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_list.FullRowSelect = true;
            this.m_list.GridLines = true;
            this.m_list.Location = new System.Drawing.Point(2, 79);
            this.m_list.Name = "m_list";
            this.m_list.Size = new System.Drawing.Size(557, 443);
            this.m_list.TabIndex = 64;
            this.m_list.Title = "";
            this.m_list.UseCompatibleStateImageBehavior = false;
            this.m_list.View = System.Windows.Forms.View.Details;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit Name";
            this.Unit.Width = 231;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Purchase(Qty)";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.Width = 105;
            // 
            // Issued
            // 
            this.Issued.Text = "Dispatch(Qty)";
            this.Issued.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Issued.Width = 100;
            // 
            // Running
            // 
            this.Running.Text = "Balance";
            this.Running.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Running.Width = 96;
            // 
            // PurchIssuedAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(561, 525);
            this.Controls.Add(this.m_list);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "PurchIssuedAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase And Dispatch Analysis";
            this.Load += new System.EventHandler(this.PurchIssuedAnalysis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbModSelectProd;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ProgressBar pbPurchageFillInfo;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PrintableListView m_list;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Issued;
        private System.Windows.Forms.ColumnHeader Running;
    }
}