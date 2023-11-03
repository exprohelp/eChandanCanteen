namespace eChandanCanteen.Canteen
{
    partial class HIS_Doctor
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgDOCTOR = new Telerik.WinControls.UI.RadGridView();
            this.rbempmaster = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHIS = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDOCTOR
            // 
            this.dgDOCTOR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDOCTOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgDOCTOR.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgDOCTOR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgDOCTOR.ForeColor = System.Drawing.Color.Black;
            this.dgDOCTOR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgDOCTOR.Location = new System.Drawing.Point(2, 44);
            // 
            // 
            // 
            this.dgDOCTOR.MasterTemplate.AllowAddNewRow = false;
            this.dgDOCTOR.MasterTemplate.AllowDeleteRow = false;
            this.dgDOCTOR.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Doctor_Id";
            gridViewTextBoxColumn1.HeaderText = "Code";
            gridViewTextBoxColumn1.Name = "Doctor_Id";
            gridViewTextBoxColumn1.Width = 65;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "DoctorName";
            gridViewTextBoxColumn2.HeaderText = "Doctor";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "DoctorName";
            gridViewTextBoxColumn2.Width = 354;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "free_tea";
            gridViewTextBoxColumn3.HeaderText = "free_tea";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "free_tea";
            this.dgDOCTOR.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgDOCTOR.MasterTemplate.EnableFiltering = true;
            this.dgDOCTOR.MasterTemplate.EnableGrouping = false;
            this.dgDOCTOR.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgDOCTOR.Name = "dgDOCTOR";
            this.dgDOCTOR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgDOCTOR.Size = new System.Drawing.Size(458, 402);
            this.dgDOCTOR.TabIndex = 3;
            this.dgDOCTOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgDOCTOR_KeyDown);
            // 
            // rbempmaster
            // 
            this.rbempmaster.AutoSize = true;
            this.rbempmaster.Checked = true;
            this.rbempmaster.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbempmaster.Location = new System.Drawing.Point(6, 14);
            this.rbempmaster.Name = "rbempmaster";
            this.rbempmaster.Size = new System.Drawing.Size(145, 17);
            this.rbempmaster.TabIndex = 6;
            this.rbempmaster.TabStop = true;
            this.rbempmaster.Text = "From Employee Master";
            this.rbempmaster.UseVisualStyleBackColor = true;
            this.rbempmaster.CheckedChanged += new System.EventHandler(this.rbempmaster_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHIS);
            this.groupBox1.Controls.Add(this.rbempmaster);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 36);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbHIS
            // 
            this.rbHIS.AutoSize = true;
            this.rbHIS.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHIS.Location = new System.Drawing.Point(344, 13);
            this.rbHIS.Name = "rbHIS";
            this.rbHIS.Size = new System.Drawing.Size(72, 17);
            this.rbHIS.TabIndex = 7;
            this.rbHIS.Text = "From HIS";
            this.rbHIS.UseVisualStyleBackColor = true;
            this.rbHIS.CheckedChanged += new System.EventHandler(this.rbHIS_CheckedChanged);
            // 
            // HIS_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgDOCTOR);
            this.Name = "HIS_Doctor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.HIS_Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDOCTOR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgDOCTOR;
        private System.Windows.Forms.RadioButton rbempmaster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHIS;
    }
}
