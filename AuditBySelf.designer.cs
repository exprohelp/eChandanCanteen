namespace eChandanCanteen
{
    partial class AuditBySelf 
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
        //private void InitializeComponent()
        //{
        //    this.btnRetrive = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //    // 
        //    // btnRetrive
        //    // 
        //    this.btnRetrive.Location = new System.Drawing.Point(277, 31);
        //    this.btnRetrive.Name = "btnRetrive";
        //    this.btnRetrive.Size = new System.Drawing.Size(75, 23);
        //    this.btnRetrive.TabIndex = 0;
        //    this.btnRetrive.Text = "Retrive";
        //    this.btnRetrive.UseVisualStyleBackColor = true;
        //    this.btnRetrive.Click += new System.EventHandler(this.btnRetrive_Click);
        //    // 
        //    // TestPrintListView
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(920, 266);
        //    this.Controls.Add(this.btnRetrive);
        //    this.Name = "TestPrintListView";
        //    this.Text = "TestPrintListView";
        //    this.Load += new System.EventHandler(this.TestPrintListView_Load);
        //    this.ResumeLayout(false);

        //}

        #endregion

        private System.Windows.Forms.Button btnRetrive;
        private PrintableListView m_list;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader ietm_name;
        private System.Windows.Forms.ColumnHeader ptype;
        private System.Windows.Forms.ColumnHeader pQty;
        private System.Windows.Forms.ColumnHeader op_stock;
        private System.Windows.Forms.ColumnHeader RetQty;
        private System.Windows.Forms.ColumnHeader PurchQty;
        private System.Windows.Forms.ColumnHeader dispqty;
        private System.Windows.Forms.ColumnHeader clQty;
        private System.Windows.Forms.ColumnHeader curStock;
    }
}