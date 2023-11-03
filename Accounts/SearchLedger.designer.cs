namespace eIM
{
    partial class SearchLedger
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
            this.Search = new System.Windows.Forms.GroupBox();
            this.lv_ledger = new System.Windows.Forms.ListView();
            this.ld_Code = new System.Windows.Forms.ColumnHeader();
            this.ld_Name = new System.Windows.Forms.ColumnHeader();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.lv_ledger);
            this.Search.Controls.Add(this.txtSearch);
            this.Search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(9, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(356, 446);
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            this.Search.Text = "Select Ledger";
            // 
            // lv_ledger
            // 
            this.lv_ledger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lv_ledger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ld_Code,
            this.ld_Name});
            this.lv_ledger.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ledger.ForeColor = System.Drawing.Color.White;
            this.lv_ledger.FullRowSelect = true;
            this.lv_ledger.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ledger.Location = new System.Drawing.Point(11, 44);
            this.lv_ledger.Name = "lv_ledger";
            this.lv_ledger.Size = new System.Drawing.Size(339, 397);
            this.lv_ledger.TabIndex = 1;
            this.lv_ledger.UseCompatibleStateImageBehavior = false;
            this.lv_ledger.View = System.Windows.Forms.View.Details;
            // 
            // ld_Code
            // 
            this.ld_Code.Text = "ld_code";
            this.ld_Code.Width = 0;
            // 
            // ld_Name
            // 
            this.ld_Name.Text = "Ledger Name";
            this.ld_Name.Width = 315;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(339, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // SearchLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(377, 468);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SearchLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisplayLedger";
            this.Load += new System.EventHandler(this.frmSearchLedger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearchLedger_KeyDown);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lv_ledger;
        private System.Windows.Forms.ColumnHeader ld_Code;
        private System.Windows.Forms.ColumnHeader ld_Name;
    }
}