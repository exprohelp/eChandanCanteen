namespace eChandanCanteen.Canteen
{
    partial class PaymentReceiving
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor1 = new Telerik.WinControls.Data.FilterDescriptor();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentReceiving));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lbl_empname = new System.Windows.Forms.Label();
            this.txtPayRemark = new Telerik.WinControls.UI.RadTextBox();
            this.txttranId = new System.Windows.Forms.TextBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbSwapCard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgpayList = new Telerik.WinControls.UI.RadGridView();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.rdp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rdp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImport = new Telerik.WinControls.UI.RadButton();
            this.dgDOCTOR = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpayList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpayList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_empname
            // 
            this.lbl_empname.AutoSize = true;
            this.lbl_empname.Location = new System.Drawing.Point(528, 12);
            this.lbl_empname.Name = "lbl_empname";
            this.lbl_empname.Size = new System.Drawing.Size(138, 13);
            this.lbl_empname.TabIndex = 1;
            this.lbl_empname.Text = "Employee /Doctor Name ";
            // 
            // txtPayRemark
            // 
            this.txtPayRemark.AutoSize = false;
            this.txtPayRemark.Location = new System.Drawing.Point(531, 97);
            this.txtPayRemark.Multiline = true;
            this.txtPayRemark.Name = "txtPayRemark";
            this.txtPayRemark.Size = new System.Drawing.Size(419, 42);
            this.txtPayRemark.TabIndex = 3;
            // 
            // txttranId
            // 
            this.txttranId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttranId.Location = new System.Drawing.Point(531, 67);
            this.txttranId.MaxLength = 20;
            this.txttranId.Name = "txttranId";
            this.txttranId.Size = new System.Drawing.Size(209, 25);
            this.txttranId.TabIndex = 313;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(610, 41);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(50, 17);
            this.rbCash.TabIndex = 316;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbSwapCard
            // 
            this.rbSwapCard.AutoSize = true;
            this.rbSwapCard.Location = new System.Drawing.Point(667, 41);
            this.rbSwapCard.Name = "rbSwapCard";
            this.rbSwapCard.Size = new System.Drawing.Size(83, 17);
            this.rbSwapCard.TabIndex = 317;
            this.rbSwapCard.Text = "Swipe Card";
            this.rbSwapCard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 318;
            this.label2.Text = "Payment Remark";
            // 
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmt.Location = new System.Drawing.Point(531, 36);
            this.txtAmt.MaxLength = 20;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(69, 25);
            this.txtAmt.TabIndex = 319;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 320;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 321;
            this.label4.Tag = "0";
            this.label4.Text = "Transaction Id";
            // 
            // dgpayList
            // 
            this.dgpayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgpayList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgpayList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgpayList.ForeColor = System.Drawing.Color.Black;
            this.dgpayList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgpayList.Location = new System.Drawing.Point(388, 174);
            // 
            // 
            // 
            this.dgpayList.MasterTemplate.AllowAddNewRow = false;
            this.dgpayList.MasterTemplate.AllowEditRow = false;
            this.dgpayList.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "partyName";
            gridViewTextBoxColumn1.HeaderText = "Party Name";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "partyName";
            gridViewTextBoxColumn1.Width = 186;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "paymode";
            gridViewTextBoxColumn2.HeaderText = "Paymode";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "paymode";
            gridViewTextBoxColumn2.Width = 65;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Remark";
            gridViewTextBoxColumn3.HeaderText = "Remark";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "Remark";
            gridViewTextBoxColumn3.Width = 175;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "cr_date";
            gridViewTextBoxColumn4.HeaderText = "Date";
            gridViewTextBoxColumn4.Name = "cr_date";
            gridViewTextBoxColumn4.Width = 83;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "amount";
            gridViewDecimalColumn1.HeaderText = "Amount";
            gridViewDecimalColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Name = "amount";
            gridViewDecimalColumn1.Width = 77;
            this.dgpayList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1});
            this.dgpayList.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor1});
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "amount";
            this.dgpayList.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.dgpayList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgpayList.Name = "dgpayList";
            this.dgpayList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgpayList.Size = new System.Drawing.Size(622, 403);
            this.dgpayList.TabIndex = 322;
            this.dgpayList.Text = "radGridView1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(531, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 24);
            this.btnSave.TabIndex = 323;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(895, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(55, 24);
            this.btnSubmit.TabIndex = 328;
            this.btnSubmit.Text = "View";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdp_to
            // 
            this.rdp_to.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_to.Location = new System.Drawing.Point(792, 145);
            this.rdp_to.Name = "rdp_to";
            this.rdp_to.Size = new System.Drawing.Size(97, 23);
            this.rdp_to.TabIndex = 327;
            this.rdp_to.TabStop = false;
            this.rdp_to.Text = "08/10/2018";
            this.rdp_to.Value = new System.DateTime(2018, 10, 8, 16, 52, 29, 282);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 326;
            this.label5.Text = "To";
            // 
            // rdp_from
            // 
            this.rdp_from.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_from.Location = new System.Drawing.Point(660, 145);
            this.rdp_from.Name = "rdp_from";
            this.rdp_from.Size = new System.Drawing.Size(97, 23);
            this.rdp_from.TabIndex = 325;
            this.rdp_from.TabStop = false;
            this.rdp_from.Text = "08/10/2018";
            this.rdp_from.Value = new System.DateTime(2018, 10, 8, 16, 52, 29, 282);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 324;
            this.label6.Text = "From";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(249, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(134, 24);
            this.btnImport.TabIndex = 329;
            this.btnImport.Text = "Import  Ledger";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgDOCTOR
            // 
            this.dgDOCTOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgDOCTOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgDOCTOR.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgDOCTOR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgDOCTOR.ForeColor = System.Drawing.Color.Black;
            this.dgDOCTOR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgDOCTOR.Location = new System.Drawing.Point(1, 30);
            // 
            // 
            // 
            this.dgDOCTOR.MasterTemplate.AllowAddNewRow = false;
            this.dgDOCTOR.MasterTemplate.AllowDeleteRow = false;
            this.dgDOCTOR.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "emp_code";
            gridViewTextBoxColumn5.HeaderText = "Code";
            gridViewTextBoxColumn5.Name = "emp_code";
            gridViewTextBoxColumn5.Width = 65;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "emp_name";
            gridViewTextBoxColumn6.HeaderText = "Name";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "emp_name";
            gridViewTextBoxColumn6.Width = 248;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 28;
            this.dgDOCTOR.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1});
            this.dgDOCTOR.MasterTemplate.EnableFiltering = true;
            this.dgDOCTOR.MasterTemplate.EnableGrouping = false;
            this.dgDOCTOR.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgDOCTOR.Name = "dgDOCTOR";
            this.dgDOCTOR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgDOCTOR.Size = new System.Drawing.Size(382, 547);
            this.dgDOCTOR.TabIndex = 330;
            this.dgDOCTOR.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgDOCTOR_CommandCellClick);
            // 
            // PaymentReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 582);
            this.Controls.Add(this.dgDOCTOR);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdp_to);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdp_from);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgpayList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSwapCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.txttranId);
            this.Controls.Add(this.txtPayRemark);
            this.Controls.Add(this.lbl_empname);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.MinimizeBox = false;
            this.Name = "PaymentReceiving";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Receiving";
            this.Load += new System.EventHandler(this.PaymentReceiving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPayRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpayList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgpayList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_empname;
        private Telerik.WinControls.UI.RadTextBox txtPayRemark;
        private System.Windows.Forms.TextBox txttranId;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbSwapCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadGridView dgpayList;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_to;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_from;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadButton btnImport;
        private Telerik.WinControls.UI.RadGridView dgDOCTOR;
    }
}
