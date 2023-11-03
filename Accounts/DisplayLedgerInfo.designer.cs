namespace eIM
{
    partial class DisplayLedgerInfo
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
            this.lv_ledger = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.U_Name = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.particular = new System.Windows.Forms.ColumnHeader();
            this.vch_type = new System.Windows.Forms.ColumnHeader();
            this.vch_no = new System.Windows.Forms.ColumnHeader();
            this.debit = new System.Windows.Forms.ColumnHeader();
            this.credit = new System.Windows.Forms.ColumnHeader();
            this.naration = new System.Windows.Forms.ColumnHeader();
            this.unit_code = new System.Windows.Forms.ColumnHeader();
            this.lblOpDebit = new System.Windows.Forms.Label();
            this.lblOpCredit = new System.Windows.Forms.Label();
            this.lblCuDebit = new System.Windows.Forms.Label();
            this.lblClCredit = new System.Windows.Forms.Label();
            this.lblClDebit = new System.Windows.Forms.Label();
            this.lblCuCredit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLedgerName = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrntPreview = new System.Windows.Forms.Button();
            this.bynPrntDmp = new System.Windows.Forms.Button();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_ledger
            // 
            this.lv_ledger.BackColor = System.Drawing.Color.LemonChiffon;
            this.lv_ledger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.U_Name,
            this.date,
            this.particular,
            this.vch_type,
            this.vch_no,
            this.debit,
            this.credit,
            this.naration,
            this.unit_code});
            this.lv_ledger.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ledger.FullRowSelect = true;
            this.lv_ledger.GridLines = true;
            this.lv_ledger.Location = new System.Drawing.Point(7, 42);
            this.lv_ledger.Name = "lv_ledger";
            this.lv_ledger.Size = new System.Drawing.Size(976, 414);
            this.lv_ledger.TabIndex = 1;
            this.lv_ledger.UseCompatibleStateImageBehavior = false;
            this.lv_ledger.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // U_Name
            // 
            this.U_Name.Text = "UNIT NAME";
            this.U_Name.Width = 0;
            // 
            // date
            // 
            this.date.Text = "DATE";
            this.date.Width = 80;
            // 
            // particular
            // 
            this.particular.Text = "PARTICULAR";
            this.particular.Width = 250;
            // 
            // vch_type
            // 
            this.vch_type.Text = "VCH.TYPE";
            this.vch_type.Width = 80;
            // 
            // vch_no
            // 
            this.vch_no.Text = "VCH.NO";
            this.vch_no.Width = 130;
            // 
            // debit
            // 
            this.debit.Text = "DEBIT(RS)";
            this.debit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debit.Width = 74;
            // 
            // credit
            // 
            this.credit.Text = "CREDIT(RS)";
            this.credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.credit.Width = 82;
            // 
            // naration
            // 
            this.naration.Text = "NARRATION";
            this.naration.Width = 250;
            // 
            // unit_code
            // 
            this.unit_code.Text = "UnitCOde";
            this.unit_code.Width = 0;
            // 
            // lblOpDebit
            // 
            this.lblOpDebit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpDebit.ForeColor = System.Drawing.Color.White;
            this.lblOpDebit.Location = new System.Drawing.Point(825, 460);
            this.lblOpDebit.Name = "lblOpDebit";
            this.lblOpDebit.Size = new System.Drawing.Size(80, 15);
            this.lblOpDebit.TabIndex = 4;
            this.lblOpDebit.Text = "lblOpDebit";
            this.lblOpDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOpCredit
            // 
            this.lblOpCredit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpCredit.ForeColor = System.Drawing.Color.White;
            this.lblOpCredit.Location = new System.Drawing.Point(708, 461);
            this.lblOpCredit.Name = "lblOpCredit";
            this.lblOpCredit.Size = new System.Drawing.Size(80, 12);
            this.lblOpCredit.TabIndex = 5;
            this.lblOpCredit.Text = "lblOpCredit";
            this.lblOpCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCuDebit
            // 
            this.lblCuDebit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuDebit.ForeColor = System.Drawing.Color.White;
            this.lblCuDebit.Location = new System.Drawing.Point(708, 479);
            this.lblCuDebit.Name = "lblCuDebit";
            this.lblCuDebit.Size = new System.Drawing.Size(80, 12);
            this.lblCuDebit.TabIndex = 6;
            this.lblCuDebit.Text = "lblCuDebit";
            this.lblCuDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClCredit
            // 
            this.lblClCredit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClCredit.ForeColor = System.Drawing.Color.White;
            this.lblClCredit.Location = new System.Drawing.Point(708, 496);
            this.lblClCredit.Name = "lblClCredit";
            this.lblClCredit.Size = new System.Drawing.Size(80, 12);
            this.lblClCredit.TabIndex = 7;
            this.lblClCredit.Text = "lblClCredit";
            this.lblClCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClDebit
            // 
            this.lblClDebit.AutoSize = true;
            this.lblClDebit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClDebit.ForeColor = System.Drawing.Color.White;
            this.lblClDebit.Location = new System.Drawing.Point(845, 495);
            this.lblClDebit.Name = "lblClDebit";
            this.lblClDebit.Size = new System.Drawing.Size(60, 15);
            this.lblClDebit.TabIndex = 8;
            this.lblClDebit.Text = "lblClDebit";
            this.lblClDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCuCredit
            // 
            this.lblCuCredit.AutoSize = true;
            this.lblCuCredit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuCredit.ForeColor = System.Drawing.Color.White;
            this.lblCuCredit.Location = new System.Drawing.Point(837, 478);
            this.lblCuCredit.Name = "lblCuCredit";
            this.lblCuCredit.Size = new System.Drawing.Size(68, 15);
            this.lblCuCredit.TabIndex = 9;
            this.lblCuCredit.Text = "lblCuCredit";
            this.lblCuCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.lblLedgerName);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 37);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblLedgerName
            // 
            this.lblLedgerName.AutoSize = true;
            this.lblLedgerName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLedgerName.Location = new System.Drawing.Point(69, 16);
            this.lblLedgerName.Name = "lblLedgerName";
            this.lblLedgerName.Size = new System.Drawing.Size(13, 18);
            this.lblLedgerName.TabIndex = 24;
            this.lblLedgerName.Text = "-";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(775, 16);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(46, 18);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(740, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "To :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "From :";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(646, 16);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 18);
            this.lblFrom.TabIndex = 20;
            this.lblFrom.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ledger :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(590, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Opening Balance Rs :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(590, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Current Total Rs  :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(590, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Closing Balance Rs  :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrntPreview
            // 
            this.btnPrntPreview.BackColor = System.Drawing.Color.Wheat;
            this.btnPrntPreview.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPrntPreview.FlatAppearance.BorderSize = 2;
            this.btnPrntPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrntPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrntPreview.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrntPreview.ForeColor = System.Drawing.Color.Green;
            this.btnPrntPreview.Location = new System.Drawing.Point(7, 462);
            this.btnPrntPreview.Name = "btnPrntPreview";
            this.btnPrntPreview.Size = new System.Drawing.Size(111, 29);
            this.btnPrntPreview.TabIndex = 18;
            this.btnPrntPreview.Text = "Preview/Print";
            this.btnPrntPreview.UseVisualStyleBackColor = false;
            this.btnPrntPreview.Click += new System.EventHandler(this.btnPrntPreview_Click);
            // 
            // bynPrntDmp
            // 
            this.bynPrntDmp.BackColor = System.Drawing.Color.Wheat;
            this.bynPrntDmp.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bynPrntDmp.FlatAppearance.BorderSize = 2;
            this.bynPrntDmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bynPrntDmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bynPrntDmp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynPrntDmp.ForeColor = System.Drawing.Color.Green;
            this.bynPrntDmp.Location = new System.Drawing.Point(124, 462);
            this.bynPrntDmp.Name = "bynPrntDmp";
            this.bynPrntDmp.Size = new System.Drawing.Size(94, 29);
            this.bynPrntDmp.TabIndex = 19;
            this.bynPrntDmp.Text = "Print(DMP)";
            this.bynPrntDmp.UseVisualStyleBackColor = false;
            // 
            // grpDate
            // 
            this.grpDate.BackColor = System.Drawing.Color.LemonChiffon;
            this.grpDate.Controls.Add(this.btnSubmit);
            this.grpDate.Controls.Add(this.txtTo);
            this.grpDate.Controls.Add(this.txtFrom);
            this.grpDate.Controls.Add(this.label2);
            this.grpDate.Controls.Add(this.label6);
            this.grpDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDate.ForeColor = System.Drawing.Color.Green;
            this.grpDate.Location = new System.Drawing.Point(476, 170);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(173, 111);
            this.grpDate.TabIndex = 22;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "Date";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Olive;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubmit.Location = new System.Drawing.Point(59, 73);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSubmit_KeyDown);
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(54, 44);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(92, 23);
            this.txtTo.TabIndex = 8;
            this.txtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTo_KeyDown);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(55, 15);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(91, 23);
            this.txtFrom.TabIndex = 7;
            this.txtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "From :";
            // 
            // DisplayLedgerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(992, 512);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.bynPrntDmp);
            this.Controls.Add(this.btnPrntPreview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCuCredit);
            this.Controls.Add(this.lblClDebit);
            this.Controls.Add(this.lblClCredit);
            this.Controls.Add(this.lblCuDebit);
            this.Controls.Add(this.lblOpCredit);
            this.Controls.Add(this.lblOpDebit);
            this.Controls.Add(this.lv_ledger);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DisplayLedgerInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Information";
            this.Load += new System.EventHandler(this.frmDisplayLedger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDisplayLedger_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_ledger;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader U_Name;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader particular;
        private System.Windows.Forms.ColumnHeader vch_type;
        private System.Windows.Forms.ColumnHeader unit_code;
        private System.Windows.Forms.ColumnHeader vch_no;
        private System.Windows.Forms.ColumnHeader debit;
        private System.Windows.Forms.ColumnHeader credit;
        private System.Windows.Forms.ColumnHeader naration;
        private System.Windows.Forms.Label lblOpDebit;
        private System.Windows.Forms.Label lblOpCredit;
        private System.Windows.Forms.Label lblCuDebit;
        private System.Windows.Forms.Label lblClCredit;
        private System.Windows.Forms.Label lblClDebit;
        private System.Windows.Forms.Label lblCuCredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLedgerName;
        private System.Windows.Forms.Button btnPrntPreview;
        private System.Windows.Forms.Button bynPrntDmp;
        public System.Windows.Forms.Label lblTo;
        public System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}