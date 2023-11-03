namespace eChandanCanteen
{
    partial class OrderGeneration
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtPqty = new System.Windows.Forms.TextBox();
            this.txtPendOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPack = new System.Windows.Forms.ComboBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lv_Issued = new System.Windows.Forms.ListView();
            this.auto_id = new System.Windows.Forms.ColumnHeader();
            this.product = new System.Windows.Forms.ColumnHeader();
            this.Pack = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.itemhelpgrid = new System.Windows.Forms.ListView();
            this.Item_id = new System.Windows.Forms.ColumnHeader();
            this.Itemname = new System.Windows.Forms.ColumnHeader();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnShow = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "P. Qty";
            // 
            // txtPqty
            // 
            this.txtPqty.BackColor = System.Drawing.Color.LightGray;
            this.txtPqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPqty.Enabled = false;
            this.txtPqty.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPqty.Location = new System.Drawing.Point(419, 25);
            this.txtPqty.Name = "txtPqty";
            this.txtPqty.Size = new System.Drawing.Size(50, 26);
            this.txtPqty.TabIndex = 11;
            this.txtPqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtPqty, "Pack Quantity");
            // 
            // txtPendOrder
            // 
            this.txtPendOrder.BackColor = System.Drawing.Color.Silver;
            this.txtPendOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendOrder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendOrder.Location = new System.Drawing.Point(472, 25);
            this.txtPendOrder.Name = "txtPendOrder";
            this.txtPendOrder.ReadOnly = true;
            this.txtPendOrder.Size = new System.Drawing.Size(68, 26);
            this.txtPendOrder.TabIndex = 10;
            this.txtPendOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtPendOrder, "Pending Order");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pend.Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pack Size";
            // 
            // cbxPack
            // 
            this.cbxPack.BackColor = System.Drawing.Color.Silver;
            this.cbxPack.Enabled = false;
            this.cbxPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPack.ForeColor = System.Drawing.Color.Yellow;
            this.cbxPack.FormattingEnabled = true;
            this.cbxPack.Location = new System.Drawing.Point(312, 27);
            this.cbxPack.Name = "cbxPack";
            this.cbxPack.Size = new System.Drawing.Size(104, 24);
            this.cbxPack.TabIndex = 6;
            this.cbxPack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPack_KeyDown);
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(543, 25);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(51, 26);
            this.txtqty.TabIndex = 5;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtqty, "Quantity Should Be in Multiplication of Pack Size.");
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            this.txtqty.Enter += new System.EventHandler(this.txtqty_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(5, 25);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(305, 26);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            this.txtProduct.Enter += new System.EventHandler(this.txtProduct_Enter);
            // 
            // lv_Issued
            // 
            this.lv_Issued.BackColor = System.Drawing.Color.White;
            this.lv_Issued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Issued.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.auto_id,
            this.product,
            this.Pack,
            this.Qty});
            this.lv_Issued.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Issued.FullRowSelect = true;
            this.lv_Issued.GridLines = true;
            this.lv_Issued.Location = new System.Drawing.Point(5, 53);
            this.lv_Issued.Name = "lv_Issued";
            this.lv_Issued.Size = new System.Drawing.Size(601, 401);
            this.lv_Issued.TabIndex = 3;
            this.lv_Issued.UseCompatibleStateImageBehavior = false;
            this.lv_Issued.View = System.Windows.Forms.View.Details;
            this.lv_Issued.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Issued_KeyDown);
            // 
            // auto_id
            // 
            this.auto_id.Text = "auto_id";
            this.auto_id.Width = 0;
            // 
            // product
            // 
            this.product.Text = "Product Name";
            this.product.Width = 371;
            // 
            // Pack
            // 
            this.Pack.Text = "Pack Size/Qty";
            this.Pack.Width = 130;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 75;
            // 
            // itemhelpgrid
            // 
            this.itemhelpgrid.BackColor = System.Drawing.Color.White;
            this.itemhelpgrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item_id,
            this.Itemname});
            this.itemhelpgrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemhelpgrid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemhelpgrid.ForeColor = System.Drawing.Color.Black;
            this.itemhelpgrid.FullRowSelect = true;
            this.itemhelpgrid.GridLines = true;
            this.itemhelpgrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemhelpgrid.Location = new System.Drawing.Point(6, 54);
            this.itemhelpgrid.Name = "itemhelpgrid";
            this.itemhelpgrid.Size = new System.Drawing.Size(304, 296);
            this.itemhelpgrid.TabIndex = 179;
            this.itemhelpgrid.UseCompatibleStateImageBehavior = false;
            this.itemhelpgrid.View = System.Windows.Forms.View.Details;
            this.itemhelpgrid.Visible = false;
            this.itemhelpgrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemhelpgrid_KeyDown);
            // 
            // Item_id
            // 
            this.Item_id.Text = "Item_Id";
            this.Item_id.Width = 0;
            // 
            // Itemname
            // 
            this.Itemname.Text = "Name of Product";
            this.Itemname.Width = 280;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(504, 460);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 180;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShow.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(5, 460);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 29);
            this.btnShow.TabIndex = 181;
            this.btnShow.Text = "Refresh";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // OrderGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(610, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtPqty);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtPendOrder);
            this.Controls.Add(this.itemhelpgrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lv_Issued);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.cbxPack);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "OrderGeneration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Generation";
            this.Load += new System.EventHandler(this.OrderGeneration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ListView lv_Issued;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader Pack;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader auto_id;
        private System.Windows.Forms.ComboBox cbxPack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView itemhelpgrid;
        public System.Windows.Forms.ColumnHeader Item_id;
        public System.Windows.Forms.ColumnHeader Itemname;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txtPendOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPqty;
    }
}