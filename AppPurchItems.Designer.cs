namespace eChandanCanteen
{
    partial class AppPurchItems
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemhelpgrid = new System.Windows.Forms.ListView();
            this.itemid = new System.Windows.Forms.ColumnHeader();
            this.Itemname = new System.Windows.Forms.ColumnHeader();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lvappitem = new System.Windows.Forms.ListView();
            this.autoid = new System.Windows.Forms.ColumnHeader();
            this.appproduct = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Select Unit";
            // 
            // cbxUnit
            // 
            this.cbxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Location = new System.Drawing.Point(77, 14);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(242, 26);
            this.cbxUnit.TabIndex = 29;
            this.cbxUnit.SelectedIndexChanged += new System.EventHandler(this.cbxUnit_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(327, 13);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(45, 29);
            this.btnGo.TabIndex = 31;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.cbxUnit);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 48);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // itemhelpgrid
            // 
            this.itemhelpgrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemid,
            this.Itemname});
            this.itemhelpgrid.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemhelpgrid.FullRowSelect = true;
            this.itemhelpgrid.GridLines = true;
            this.itemhelpgrid.Location = new System.Drawing.Point(2, 86);
            this.itemhelpgrid.Name = "itemhelpgrid";
            this.itemhelpgrid.Size = new System.Drawing.Size(319, 363);
            this.itemhelpgrid.TabIndex = 33;
            this.itemhelpgrid.UseCompatibleStateImageBehavior = false;
            this.itemhelpgrid.View = System.Windows.Forms.View.Details;
            this.itemhelpgrid.SelectedIndexChanged += new System.EventHandler(this.itemhelpgrid_SelectedIndexChanged);
            // 
            // itemid
            // 
            this.itemid.Text = "iemid";
            this.itemid.Width = 1;
            // 
            // Itemname
            // 
            this.Itemname.Text = "Item Name";
            this.Itemname.Width = 293;
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(2, 56);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(319, 27);
            this.txtProduct.TabIndex = 34;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // lvappitem
            // 
            this.lvappitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.autoid,
            this.appproduct});
            this.lvappitem.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvappitem.FullRowSelect = true;
            this.lvappitem.GridLines = true;
            this.lvappitem.Location = new System.Drawing.Point(367, 86);
            this.lvappitem.Name = "lvappitem";
            this.lvappitem.Size = new System.Drawing.Size(319, 363);
            this.lvappitem.TabIndex = 35;
            this.lvappitem.UseCompatibleStateImageBehavior = false;
            this.lvappitem.View = System.Windows.Forms.View.Details;
            this.lvappitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvappitem_KeyDown);
            // 
            // autoid
            // 
            this.autoid.Text = "autoid";
            this.autoid.Width = 1;
            // 
            // appproduct
            // 
            this.appproduct.Text = "App Product";
            this.appproduct.Width = 293;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(324, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 54);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AppPurchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(686, 451);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvappitem);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.itemhelpgrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppPurchItems";
            this.Text = "AppPurchItems";
            this.Load += new System.EventHandler(this.AppPurchItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView itemhelpgrid;
        private System.Windows.Forms.ColumnHeader itemid;
        private System.Windows.Forms.ColumnHeader Itemname;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ListView lvappitem;
        private System.Windows.Forms.ColumnHeader autoid;
        private System.Windows.Forms.ColumnHeader appproduct;
        private System.Windows.Forms.Button btnAdd;
    }
}