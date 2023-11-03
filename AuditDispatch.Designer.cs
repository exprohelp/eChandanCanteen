namespace eChandanCanteen
{
    partial class AuditDispatch
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
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.m_list = new eChandanCanteen.PrintableListView();
            this.Unit = new System.Windows.Forms.ColumnHeader();
            this.Dispatch = new System.Windows.Forms.ColumnHeader();
            this.InTrans = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxUnit);
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 225;
            this.label2.Text = "Select Branch";
            // 
            // cbxUnit
            // 
            this.cbxUnit.BackColor = System.Drawing.Color.White;
            this.cbxUnit.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.ItemHeight = 17;
            this.cbxUnit.Location = new System.Drawing.Point(8, 40);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(451, 25);
            this.cbxUnit.TabIndex = 224;
            this.cbxUnit.Text = "Select";
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Black;
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(477, 36);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(54, 35);
            this.btnFill.TabIndex = 56;
            this.btnFill.Text = ">>";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(455, 515);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 31);
            this.btnPrint.TabIndex = 67;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // m_list
            // 
            this.m_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Unit,
            this.Dispatch,
            this.InTrans});
            this.m_list.FitToPage = false;
            this.m_list.Font = new System.Drawing.Font("Calibri", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_list.FullRowSelect = true;
            this.m_list.GridLines = true;
            this.m_list.Location = new System.Drawing.Point(6, 80);
            this.m_list.Name = "m_list";
            this.m_list.Size = new System.Drawing.Size(557, 431);
            this.m_list.TabIndex = 66;
            this.m_list.Title = "";
            this.m_list.UseCompatibleStateImageBehavior = false;
            this.m_list.View = System.Windows.Forms.View.Details;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit Name";
            this.Unit.Width = 325;
            // 
            // Dispatch
            // 
            this.Dispatch.Text = "Dispatch(Qty)";
            this.Dispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Dispatch.Width = 100;
            // 
            // InTrans
            // 
            this.InTrans.Text = "Not Received(Qty)";
            this.InTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InTrans.Width = 109;
            // 
            // AuditDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 546);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.m_list);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AuditDispatch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatch During Audit";
            this.Load += new System.EventHandler(this.AuditDispatch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Button btnFill;
        private PrintableListView m_list;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Dispatch;
        private System.Windows.Forms.ColumnHeader InTrans;
        private System.Windows.Forms.Button btnPrint;
    }
}