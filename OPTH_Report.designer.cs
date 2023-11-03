namespace eChandanCanteen
{
    partial class OPTH_Report
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgOpthSlip = new Telerik.WinControls.UI.RadGridView();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btngO = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnPdf = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgOpthSlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOpthSlip.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOpthSlip
            // 
            this.dgOpthSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgOpthSlip.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgOpthSlip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgOpthSlip.ForeColor = System.Drawing.Color.Black;
            this.dgOpthSlip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgOpthSlip.Location = new System.Drawing.Point(1, 39);
            // 
            // 
            // 
            this.dgOpthSlip.MasterTemplate.AllowAddNewRow = false;
            this.dgOpthSlip.MasterTemplate.AllowDeleteRow = false;
            this.dgOpthSlip.MasterTemplate.AllowEditRow = false;
            this.dgOpthSlip.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "IP_OP_NO";
            gridViewTextBoxColumn1.HeaderText = "OPD/IPD No.";
            gridViewTextBoxColumn1.Name = "IP_OP_NO";
            gridViewTextBoxColumn1.Width = 90;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "bill_no";
            gridViewTextBoxColumn2.HeaderText = "Reg.Number";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "bill_no";
            gridViewTextBoxColumn2.Width = 80;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pt_name";
            gridViewTextBoxColumn3.HeaderText = "Patient Name";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "pt_name";
            gridViewTextBoxColumn3.Width = 140;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Received";
            gridViewTextBoxColumn4.HeaderText = "Amt";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Name = "Received";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 40;
            gridViewDateTimeColumn1.FieldName = "c_rec_date";
            gridViewDateTimeColumn1.FormatString = "{0:dd-MM-yyyy hh:mm}";
            gridViewDateTimeColumn1.HeaderText = "HO Rec Date";
            gridViewDateTimeColumn1.Name = "c_rec_date";
            gridViewDateTimeColumn1.Width = 100;
            gridViewDateTimeColumn2.FieldName = "c_trf_date";
            gridViewDateTimeColumn2.FormatString = "{0:dd-MM-yyyy hh:mm}";
            gridViewDateTimeColumn2.HeaderText = "HO Trf Date";
            gridViewDateTimeColumn2.Name = "c_trf_date";
            gridViewDateTimeColumn2.Width = 100;
            gridViewDateTimeColumn3.FieldName = "rec_date";
            gridViewDateTimeColumn3.FormatString = "{0:dd-MM-yyyy hh:mm}";
            gridViewDateTimeColumn3.HeaderText = "Hosp Recieved";
            gridViewDateTimeColumn3.Name = "rec_date";
            gridViewDateTimeColumn3.Width = 100;
            gridViewDateTimeColumn4.FieldName = "del_date";
            gridViewDateTimeColumn4.FormatString = "{0:dd-MM-yyyy hh:mm}";
            gridViewDateTimeColumn4.HeaderText = "Patient.Delivered";
            gridViewDateTimeColumn4.Name = "del_date";
            gridViewDateTimeColumn4.Width = 100;
            gridViewDateTimeColumn5.EnableExpressionEditor = false;
            gridViewDateTimeColumn5.FieldName = "reg_date";
            gridViewDateTimeColumn5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn5.FormatString = "{0:dd-MM-yy}";
            gridViewDateTimeColumn5.HeaderText = "Date";
            gridViewDateTimeColumn5.Name = "reg_date";
            gridViewDateTimeColumn5.Width = 10;
            this.dgOpthSlip.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDateTimeColumn3,
            gridViewDateTimeColumn4,
            gridViewDateTimeColumn5});
            sortDescriptor1.PropertyName = "reg_date";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgOpthSlip.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.dgOpthSlip.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgOpthSlip.Name = "dgOpthSlip";
            this.dgOpthSlip.ReadOnly = true;
            this.dgOpthSlip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgOpthSlip.ShowGroupPanel = false;
            this.dgOpthSlip.Size = new System.Drawing.Size(809, 497);
            this.dgOpthSlip.TabIndex = 1;
            this.dgOpthSlip.Text = "radGridView1";
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(254, 12);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(95, 20);
            this.dtDate.TabIndex = 3;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FROM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btngO
            // 
            this.btngO.Location = new System.Drawing.Point(481, 12);
            this.btngO.Name = "btngO";
            this.btngO.Size = new System.Drawing.Size(34, 21);
            this.btngO.TabIndex = 5;
            this.btngO.Text = ">>";
            this.btngO.Click += new System.EventHandler(this.btngO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(380, 12);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(95, 20);
            this.dtTo.TabIndex = 6;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(711, 8);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(99, 24);
            this.btnPdf.TabIndex = 8;
            this.btnPdf.Text = "Export To Excel";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // OPTH_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 542);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.btngO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.dgOpthSlip);
            this.Name = "OPTH_Report";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription Slip for Opthalmic patients";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.PDF_Viwer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOpthSlip.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOpthSlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Telerik.WinControls.UI.RadGridView dgOpthSlip;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btngO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private Telerik.WinControls.UI.RadButton btnPdf;
    }
}
