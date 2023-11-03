namespace eChandanCanteen.Canteen
{
    partial class SaleReport
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReport));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem5 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem6 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem7 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem8 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.bill_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCanteen = new eChandanCanteen.dataset.dsCanteen();
            this.bill_masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_gstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnXL = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.rdp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rdp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rgv_report = new Telerik.WinControls.UI.RadGridView();
            this.dsCanteenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCanteenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.bill_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCanteen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_gstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_report.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCanteenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCanteenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_infoBindingSource
            // 
            this.bill_infoBindingSource.DataMember = "bill_info";
            this.bill_infoBindingSource.DataSource = this.dsCanteen;
            // 
            // dsCanteen
            // 
            this.dsCanteen.DataSetName = "dsCanteen";
            this.dsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bill_masterBindingSource
            // 
            this.bill_masterBindingSource.DataMember = "bill_master";
            this.bill_masterBindingSource.DataSource = this.dsCanteen;
            // 
            // bill_gstBindingSource
            // 
            this.bill_gstBindingSource.DataMember = "bill_gst";
            this.bill_gstBindingSource.DataSource = this.dsCanteen;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnPrint);
            this.radGroupBox1.Controls.Add(this.btnXL);
            this.radGroupBox1.Controls.Add(this.btnSubmit);
            this.radGroupBox1.Controls.Add(this.rdp_to);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.rdp_from);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 1);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1238, 41);
            this.radGroupBox1.TabIndex = 0;
            // 
            // btnXL
            // 
            this.btnXL.Image = global::eChandanCanteen.Properties.Resources.export_excel;
            this.btnXL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXL.Location = new System.Drawing.Point(618, 6);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(45, 30);
            this.btnXL.TabIndex = 5;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(502, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(55, 24);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdp_to
            // 
            this.rdp_to.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_to.Location = new System.Drawing.Point(399, 11);
            this.rdp_to.Name = "rdp_to";
            this.rdp_to.Size = new System.Drawing.Size(97, 23);
            this.rdp_to.TabIndex = 3;
            this.rdp_to.TabStop = false;
            this.rdp_to.Text = "08/10/2018";
            this.rdp_to.Value = new System.DateTime(2018, 10, 8, 16, 52, 29, 282);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // rdp_from
            // 
            this.rdp_from.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_from.Location = new System.Drawing.Point(266, 11);
            this.rdp_from.Name = "rdp_from";
            this.rdp_from.Size = new System.Drawing.Size(97, 23);
            this.rdp_from.TabIndex = 1;
            this.rdp_from.TabStop = false;
            this.rdp_from.Text = "08/10/2018";
            this.rdp_from.Value = new System.DateTime(2018, 10, 8, 16, 52, 29, 282);
            this.rdp_from.Leave += new System.EventHandler(this.rdp_from_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // rgv_report
            // 
            this.rgv_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_report.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_report.ForeColor = System.Drawing.Color.Black;
            this.rgv_report.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_report.Location = new System.Drawing.Point(0, 49);
            // 
            // 
            // 
            this.rgv_report.MasterTemplate.AllowAddNewRow = false;
            this.rgv_report.MasterTemplate.AutoExpandGroups = true;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "sale_date";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "Date";
            gridViewDateTimeColumn2.Name = "sale_date";
            gridViewDateTimeColumn2.Width = 90;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "sale_inv_no";
            gridViewTextBoxColumn4.HeaderText = "Bill No";
            gridViewTextBoxColumn4.Name = "sale_inv_no";
            gridViewTextBoxColumn4.Width = 129;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "cust_name";
            gridViewTextBoxColumn5.HeaderText = "Customer";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "cust_name";
            gridViewTextBoxColumn5.Width = 207;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "total";
            gridViewDecimalColumn5.HeaderText = "Total";
            gridViewDecimalColumn5.Name = "total";
            gridViewDecimalColumn5.Width = 65;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "discount";
            gridViewDecimalColumn6.HeaderText = "Discount";
            gridViewDecimalColumn6.Name = "discount";
            gridViewDecimalColumn6.Width = 69;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "net";
            gridViewDecimalColumn7.HeaderText = "Net";
            gridViewDecimalColumn7.Name = "net";
            gridViewDecimalColumn7.Width = 72;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "username";
            gridViewTextBoxColumn6.HeaderText = "Operator";
            gridViewTextBoxColumn6.Name = "username";
            gridViewTextBoxColumn6.Width = 109;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "received";
            gridViewDecimalColumn8.HeaderText = "Received";
            gridViewDecimalColumn8.Name = "received";
            gridViewDecimalColumn8.Width = 56;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column1";
            gridViewCommandColumn2.Width = 28;
            this.rgv_report.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn8,
            gridViewCommandColumn2});
            sortDescriptor2.PropertyName = "column2";
            this.rgv_report.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            gridViewSummaryItem5.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem5.FormatString = "{0:N2}";
            gridViewSummaryItem5.Name = "total";
            gridViewSummaryItem6.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem6.FormatString = "{0:N2}";
            gridViewSummaryItem6.Name = "discount";
            gridViewSummaryItem7.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem7.FormatString = "{0:N2}";
            gridViewSummaryItem7.Name = "net";
            gridViewSummaryItem8.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem8.FormatString = "{0:N2}";
            gridViewSummaryItem8.Name = "received";
            this.rgv_report.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem5,
                gridViewSummaryItem6,
                gridViewSummaryItem7,
                gridViewSummaryItem8}));
            this.rgv_report.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_report.Name = "rgv_report";
            this.rgv_report.ReadOnly = true;
            this.rgv_report.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_report.Size = new System.Drawing.Size(861, 508);
            this.rgv_report.TabIndex = 1;
            this.rgv_report.Text = "radGridView1";
            this.rgv_report.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_report_CommandCellClick);
            // 
            // dsCanteenBindingSource1
            // 
            this.dsCanteenBindingSource1.DataSource = this.dsCanteen;
            this.dsCanteenBindingSource1.Position = 0;
            // 
            // dsCanteenBindingSource
            // 
            this.dsCanteenBindingSource.DataSource = this.dsCanteen;
            this.dsCanteenBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(868, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(370, 508);
            this.reportViewer1.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Image = global::eChandanCanteen.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(868, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 27);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print with KOT";
            this.btnPrint.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 556);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.rgv_report);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SaleReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Sales Register";
            this.Load += new System.EventHandler(this.SaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCanteen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_gstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_report.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCanteenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCanteenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_to;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_from;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView rgv_report;
        private Telerik.WinControls.UI.RadButton btnXL;
        private System.Windows.Forms.BindingSource dsCanteenBindingSource;
        private dataset.dsCanteen dsCanteen;
        private System.Windows.Forms.BindingSource bill_infoBindingSource;
        private System.Windows.Forms.BindingSource bill_masterBindingSource;
        private System.Windows.Forms.BindingSource bill_gstBindingSource;
        private System.Windows.Forms.BindingSource dsCanteenBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Telerik.WinControls.UI.RadButton btnPrint;
    }
}