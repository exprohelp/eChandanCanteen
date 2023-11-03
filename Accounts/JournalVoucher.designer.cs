namespace eIM
{
    partial class JournalVoucher
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
            this.lv_ledger = new System.Windows.Forms.ListView();
            this.Ledger = new System.Windows.Forms.ColumnHeader();
            this.lv_Ld_detail = new System.Windows.Forms.ListView();
            this.MastId = new System.Windows.Forms.ColumnHeader();
            this.VoucherNo = new System.Windows.Forms.ColumnHeader();
            this.vchdate = new System.Windows.Forms.ColumnHeader();
            this.debitaccopay = new System.Windows.Forms.ColumnHeader();
            this.cracctopay = new System.Windows.Forms.ColumnHeader();
            this.amt = new System.Windows.Forms.ColumnHeader();
            this.Narration = new System.Windows.Forms.ColumnHeader();
            this.txtCredit_amt = new System.Windows.Forms.TextBox();
            this.txtdebit_amt = new System.Windows.Forms.TextBox();
            this.txtCreditAC = new System.Windows.Forms.TextBox();
            this.txtdebitAC = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldebit = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.lv_ledger);
            this.groupBox1.Controls.Add(this.lv_Ld_detail);
            this.groupBox1.Controls.Add(this.txtCredit_amt);
            this.groupBox1.Controls.Add(this.txtdebit_amt);
            this.groupBox1.Controls.Add(this.txtCreditAC);
            this.groupBox1.Controls.Add(this.txtdebitAC);
            this.groupBox1.Controls.Add(this.txtNarration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbldebit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lv_ledger
            // 
            this.lv_ledger.BackColor = System.Drawing.Color.LightBlue;
            this.lv_ledger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ledger});
            this.lv_ledger.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ledger.FullRowSelect = true;
            this.lv_ledger.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ledger.Location = new System.Drawing.Point(582, 10);
            this.lv_ledger.MultiSelect = false;
            this.lv_ledger.Name = "lv_ledger";
            this.lv_ledger.Size = new System.Drawing.Size(294, 339);
            this.lv_ledger.TabIndex = 0;
            this.lv_ledger.UseCompatibleStateImageBehavior = false;
            this.lv_ledger.View = System.Windows.Forms.View.Details;
            this.lv_ledger.Visible = false;
            this.lv_ledger.Leave += new System.EventHandler(this.lv_ledger_Leave);
            this.lv_ledger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_ledger_KeyDown);
            // 
            // Ledger
            // 
            this.Ledger.Text = "Ledger Name";
            this.Ledger.Width = 270;
            // 
            // lv_Ld_detail
            // 
            this.lv_Ld_detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MastId,
            this.VoucherNo,
            this.vchdate,
            this.debitaccopay,
            this.cracctopay,
            this.amt,
            this.Narration});
            this.lv_Ld_detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Ld_detail.FullRowSelect = true;
            this.lv_Ld_detail.GridLines = true;
            this.lv_Ld_detail.Location = new System.Drawing.Point(5, 140);
            this.lv_Ld_detail.Name = "lv_Ld_detail";
            this.lv_Ld_detail.Size = new System.Drawing.Size(871, 209);
            this.lv_Ld_detail.TabIndex = 1;
            this.lv_Ld_detail.UseCompatibleStateImageBehavior = false;
            this.lv_Ld_detail.View = System.Windows.Forms.View.Details;
            this.lv_Ld_detail.Enter += new System.EventHandler(this.lv_Ld_detail_Enter);
            this.lv_Ld_detail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Ld_detail_KeyDown);
            // 
            // MastId
            // 
            this.MastId.Text = "Mast_Id";
            this.MastId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MastId.Width = 0;
            // 
            // VoucherNo
            // 
            this.VoucherNo.Text = "VoucherNo";
            this.VoucherNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VoucherNo.Width = 0;
            // 
            // vchdate
            // 
            this.vchdate.Text = "Voucher Date";
            this.vchdate.Width = 100;
            // 
            // debitaccopay
            // 
            this.debitaccopay.Text = "Debit A/C  or Pay To";
            this.debitaccopay.Width = 163;
            // 
            // cracctopay
            // 
            this.cracctopay.Text = "Credit A/C  or Pay To";
            this.cracctopay.Width = 157;
            // 
            // amt
            // 
            this.amt.Text = "Amount";
            this.amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Narration
            // 
            this.Narration.Text = "Narration";
            this.Narration.Width = 340;
            // 
            // txtCredit_amt
            // 
            this.txtCredit_amt.Location = new System.Drawing.Point(461, 43);
            this.txtCredit_amt.Name = "txtCredit_amt";
            this.txtCredit_amt.ReadOnly = true;
            this.txtCredit_amt.Size = new System.Drawing.Size(75, 20);
            this.txtCredit_amt.TabIndex = 10;
            this.txtCredit_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdebit_amt
            // 
            this.txtdebit_amt.Location = new System.Drawing.Point(461, 19);
            this.txtdebit_amt.Name = "txtdebit_amt";
            this.txtdebit_amt.Size = new System.Drawing.Size(74, 20);
            this.txtdebit_amt.TabIndex = 9;
            this.txtdebit_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdebit_amt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdebit_amt_KeyDown);
            // 
            // txtCreditAC
            // 
            this.txtCreditAC.Location = new System.Drawing.Point(80, 41);
            this.txtCreditAC.Name = "txtCreditAC";
            this.txtCreditAC.Size = new System.Drawing.Size(318, 20);
            this.txtCreditAC.TabIndex = 8;
            this.txtCreditAC.TextChanged += new System.EventHandler(this.txtCreditAC_TextChanged);
            this.txtCreditAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditAC_KeyDown);
            this.txtCreditAC.Enter += new System.EventHandler(this.txtCreditAC_Enter);
            // 
            // txtdebitAC
            // 
            this.txtdebitAC.AccessibleDescription = "xt";
            this.txtdebitAC.Location = new System.Drawing.Point(80, 19);
            this.txtdebitAC.Name = "txtdebitAC";
            this.txtdebitAC.Size = new System.Drawing.Size(318, 20);
            this.txtdebitAC.TabIndex = 0;
            this.txtdebitAC.TextChanged += new System.EventHandler(this.txtdebitAC_TextChanged);
            this.txtdebitAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdebitAC_KeyDown);
            this.txtdebitAC.Enter += new System.EventHandler(this.txtdebitAC_Enter);
            // 
            // txtNarration
            // 
            this.txtNarration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNarration.Location = new System.Drawing.Point(81, 63);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(317, 71);
            this.txtNarration.TabIndex = 6;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Narration";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " Debit  A/C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credit A/C";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cr. Amt";
            // 
            // lbldebit
            // 
            this.lbldebit.AutoSize = true;
            this.lbldebit.Location = new System.Drawing.Point(400, 26);
            this.lbldebit.Name = "lbldebit";
            this.lbldebit.Size = new System.Drawing.Size(49, 13);
            this.lbldebit.TabIndex = 1;
            this.lbldebit.Text = "Dr. Amt";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(791, 12);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(91, 21);
            this.txtDate.TabIndex = 12;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(755, 15);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(34, 13);
            this.lblDay.TabIndex = 11;
            this.lblDay.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Journal Voucher";
            // 
            // JournalVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(894, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "JournalVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{Journal Voucher}";
            this.Load += new System.EventHandler(this.VoucherFeeding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_ledger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldebit;
        private System.Windows.Forms.ListView lv_Ld_detail;
        private System.Windows.Forms.TextBox txtCredit_amt;
        private System.Windows.Forms.TextBox txtdebit_amt;
        private System.Windows.Forms.TextBox txtCreditAC;
        private System.Windows.Forms.TextBox txtdebitAC;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.ColumnHeader vchdate;
        private System.Windows.Forms.ColumnHeader debitaccopay;
        private System.Windows.Forms.ColumnHeader cracctopay;
        private System.Windows.Forms.ColumnHeader amt;
        private System.Windows.Forms.ColumnHeader Narration;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ColumnHeader Ledger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader VoucherNo;
        private System.Windows.Forms.ColumnHeader MastId;
    }
}