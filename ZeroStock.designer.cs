namespace eChandanCanteen
{
    partial class ZeroStock
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
            this.btnView = new System.Windows.Forms.Button();
            this.m_list = new eChandanCanteen.PrintableListView();
            this.item_id = new System.Windows.Forms.ColumnHeader();
            this.UnitName = new System.Windows.Forms.ColumnHeader();
            this.packsize = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightCoral;
            this.btnView.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(131, 31);
            this.btnView.TabIndex = 68;
            this.btnView.Text = "View Zero Product";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // m_list
            // 
            this.m_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.UnitName,
            this.packsize,
            this.Quantity});
            this.m_list.FitToPage = false;
            this.m_list.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_list.FullRowSelect = true;
            this.m_list.GridLines = true;
            this.m_list.Location = new System.Drawing.Point(3, 37);
            this.m_list.Name = "m_list";
            this.m_list.Size = new System.Drawing.Size(587, 450);
            this.m_list.TabIndex = 67;
            this.m_list.Title = "";
            this.m_list.UseCompatibleStateImageBehavior = false;
            this.m_list.View = System.Windows.Forms.View.Details;
            // 
            // item_id
            // 
            this.item_id.Text = "Item_id";
            this.item_id.Width = 1;
            // 
            // UnitName
            // 
            this.UnitName.Text = "Unit Name";
            this.UnitName.Width = 388;
            // 
            // packsize
            // 
            this.packsize.Text = "Pack Size";
            this.packsize.Width = 98;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.Width = 74;
            // 
            // ZeroStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(593, 531);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.m_list);
            this.Name = "ZeroStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero Product At WareHouse";
            this.Load += new System.EventHandler(this.ZeroStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PrintableListView m_list;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader packsize;
        private System.Windows.Forms.ColumnHeader UnitName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button btnView;
    }
}