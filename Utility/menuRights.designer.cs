namespace eChandanCanteen.utility
{
    partial class menuRights
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor3 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor4 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuRights));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.rgv_employee = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_options = new System.Windows.Forms.ComboBox();
            this.btn_mark = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLookFor = new System.Windows.Forms.TextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(355, 39);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AllowSearchRow = true;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "element_name";
            gridViewTextBoxColumn9.HeaderText = "elementName";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "element_name";
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "cmt_text";
            gridViewTextBoxColumn10.HeaderText = "Tab";
            gridViewTextBoxColumn10.Name = "cmd_tab";
            gridViewTextBoxColumn10.Width = 165;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "grp_text";
            gridViewTextBoxColumn11.HeaderText = "Group";
            gridViewTextBoxColumn11.Name = "grp_text";
            gridViewTextBoxColumn11.Width = 126;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "element_text";
            gridViewTextBoxColumn12.HeaderText = "Menu Name";
            gridViewTextBoxColumn12.Name = "element_text";
            gridViewTextBoxColumn12.Width = 319;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "allow";
            gridViewTextBoxColumn13.HeaderText = "Flag";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "allow";
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.HeaderText = "Action";
            gridViewCommandColumn3.Name = "A";
            gridViewCommandColumn3.Width = 64;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "options";
            gridViewTextBoxColumn14.HeaderText = "options";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "options";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewCommandColumn3,
            gridViewTextBoxColumn14});
            sortDescriptor3.PropertyName = "cmd_tab";
            groupDescriptor3.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            sortDescriptor4.PropertyName = "grp_text";
            groupDescriptor4.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor3,
            groupDescriptor4});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(473, 459);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_info_RowFormatting);
            this.rgv_info.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_info_ViewCellFormatting);
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // rgv_employee
            // 
            this.rgv_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_employee.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_employee.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_employee.ForeColor = System.Drawing.Color.Black;
            this.rgv_employee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_employee.Location = new System.Drawing.Point(1, 34);
            // 
            // 
            // 
            this.rgv_employee.MasterTemplate.AllowAddNewRow = false;
            this.rgv_employee.MasterTemplate.AllowSearchRow = true;
            this.rgv_employee.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "emp_code";
            gridViewTextBoxColumn15.HeaderText = "emp_code";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "emp_code";
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "emp_name";
            gridViewTextBoxColumn16.HeaderText = "Name of Employee";
            gridViewTextBoxColumn16.Name = "emp_name";
            gridViewTextBoxColumn16.Width = 270;
            gridViewCommandColumn4.EnableExpressionEditor = false;
            gridViewCommandColumn4.HeaderText = "-";
            gridViewCommandColumn4.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn4.Image")));
            gridViewCommandColumn4.Name = "column1";
            gridViewCommandColumn4.Width = 25;
            this.rgv_employee.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewCommandColumn4});
            this.rgv_employee.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgv_employee.Name = "rgv_employee";
            this.rgv_employee.ReadOnly = true;
            this.rgv_employee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_employee.ShowGroupPanel = false;
            this.rgv_employee.Size = new System.Drawing.Size(349, 463);
            this.rgv_employee.TabIndex = 2;
            this.rgv_employee.Text = "radGridView1";
            this.rgv_employee.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Right Options";
            // 
            // cmb_options
            // 
            this.cmb_options.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_options.FormattingEnabled = true;
            this.cmb_options.Items.AddRange(new object[] {
            "Admin",
            "Operator"});
            this.cmb_options.Location = new System.Drawing.Point(616, 7);
            this.cmb_options.Name = "cmb_options";
            this.cmb_options.Size = new System.Drawing.Size(165, 28);
            this.cmb_options.TabIndex = 4;
            this.cmb_options.Text = "Admin";
            // 
            // btn_mark
            // 
            this.btn_mark.Image = global::eChandanCanteen.Properties.Resources.next;
            this.btn_mark.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mark.Location = new System.Drawing.Point(798, 6);
            this.btn_mark.Name = "btn_mark";
            this.btn_mark.Size = new System.Drawing.Size(30, 30);
            this.btn_mark.TabIndex = 5;
            this.btn_mark.Click += new System.EventHandler(this.btn_mark_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_mark.GetChildAt(0))).Image = global::eChandanCanteen.Properties.Resources.next;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_mark.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_mark.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_mark.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search :";
            // 
            // txtLookFor
            // 
            this.txtLookFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLookFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLookFor.Location = new System.Drawing.Point(65, 7);
            this.txtLookFor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLookFor.Name = "txtLookFor";
            this.txtLookFor.Size = new System.Drawing.Size(174, 22);
            this.txtLookFor.TabIndex = 18;
            this.txtLookFor.TextChanged += new System.EventHandler(this.txtLookFor_TextChanged);
            // 
            // radButton1
            // 
            this.radButton1.Image = global::eChandanCanteen.Properties.Resources.next;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(246, 6);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(25, 25);
            this.radButton1.TabIndex = 20;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::eChandanCanteen.Properties.Resources.next;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // menuRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 498);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLookFor);
            this.Controls.Add(this.btn_mark);
            this.Controls.Add(this.cmb_options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgv_employee);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "menuRights";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Assign Menu Rights To User";
            this.Load += new System.EventHandler(this.menuRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadGridView rgv_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_options;
        private Telerik.WinControls.UI.RadButton btn_mark;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLookFor;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
