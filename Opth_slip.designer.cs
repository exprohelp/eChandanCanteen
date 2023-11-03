namespace eChandanCanteen
{
    partial class Opth_slip
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.dgOpthSlip = new Telerik.WinControls.UI.RadGridView();
            this.radPdfViewer2 = new Telerik.WinControls.UI.RadPdfViewer();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btngO = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgOpthSlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOpthSlip.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOpthSlip
            // 
            this.dgOpthSlip.Location = new System.Drawing.Point(1, 39);
            // 
            // dgOpthSlip
            // 
            this.dgOpthSlip.MasterTemplate.AllowAddNewRow = false;
            this.dgOpthSlip.MasterTemplate.AllowDeleteRow = false;
            this.dgOpthSlip.MasterTemplate.AllowEditRow = false;
            this.dgOpthSlip.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.FieldName = "lab_reg_id";
            gridViewTextBoxColumn1.HeaderText = "Reg.Number";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "lab_reg_id";
            gridViewTextBoxColumn1.Width = 80;
            gridViewTextBoxColumn2.FieldName = "pt_name";
            gridViewTextBoxColumn2.HeaderText = "Patient Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "pt_name";
            gridViewTextBoxColumn2.Width = 140;
            gridViewTextBoxColumn3.FieldName = "Received";
            gridViewTextBoxColumn3.HeaderText = "Received";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Name = "Received";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 60;
            gridViewCommandColumn1.DefaultText = "Open";
            gridViewCommandColumn1.FieldName = "c_rec_flag";
            gridViewCommandColumn1.HeaderText = "cmd1";
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 80;
            gridViewCommandColumn2.DefaultText = "Confirm";
            gridViewCommandColumn2.FieldName = "c_trf_flag";
            gridViewCommandColumn2.HeaderText = "cmd2";
            gridViewCommandColumn2.Name = "column2";
            gridViewCommandColumn2.Width = 80;
            gridViewCommandColumn3.FieldName = "cmd_1";
            gridViewCommandColumn3.HeaderText = "View";
            gridViewCommandColumn3.Name = "open";
            gridViewTextBoxColumn4.FieldName = "Reg_date";
            gridViewTextBoxColumn4.HeaderText = "Reg Date";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "Reg_date";
            gridViewTextBoxColumn5.FieldName = "doc_path";
            gridViewTextBoxColumn5.HeaderText = "column3";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "doc_path";
            this.dgOpthSlip.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            sortDescriptor1.PropertyName = "reg_date";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgOpthSlip.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.dgOpthSlip.Name = "dgOpthSlip";
            this.dgOpthSlip.ShowGroupPanel = false;
            this.dgOpthSlip.Size = new System.Drawing.Size(554, 497);
            this.dgOpthSlip.TabIndex = 1;
            this.dgOpthSlip.Text = "radGridView1";
            this.dgOpthSlip.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgOpthSlip_CommandCellClick);
            // 
            // radPdfViewer2
            // 
            this.radPdfViewer2.Location = new System.Drawing.Point(559, 2);
            this.radPdfViewer2.Name = "radPdfViewer2";
            this.radPdfViewer2.Size = new System.Drawing.Size(603, 534);
            this.radPdfViewer2.TabIndex = 2;
            this.radPdfViewer2.Text = "radPdfViewer2";
            this.radPdfViewer2.ThumbnailsScaleFactor = 0.15F;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(186, 12);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(95, 20);
            this.dtDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FROM";
            // 
            // btngO
            // 
            this.btngO.Location = new System.Drawing.Point(416, 12);
            this.btngO.Name = "btngO";
            this.btngO.Size = new System.Drawing.Size(34, 21);
            this.btngO.TabIndex = 5;
            this.btngO.Text = ">>";
            this.btngO.Click += new System.EventHandler(this.btngO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TO";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(312, 12);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(95, 20);
            this.dtTo.TabIndex = 6;
            // 
            // Opth_slip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.btngO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.radPdfViewer2);
            this.Controls.Add(this.dgOpthSlip);
            this.Name = "Opth_slip";
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
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private Telerik.WinControls.UI.RadGridView dgOpthSlip;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer2;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btngO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
    }
}
