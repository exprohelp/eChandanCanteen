namespace eChandanCanteen
{
    partial class WareHouseStock
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkZero = new System.Windows.Forms.CheckBox();
            this.btn_trfToxl = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last_Pur_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last_Pur_Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bestrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.lblItem);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.chkZero);
            this.GroupBox1.Controls.Add(this.btn_trfToxl);
            this.GroupBox1.Controls.Add(this.btnPrint);
            this.GroupBox1.Controls.Add(this.btnFill);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(7, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(780, 45);
            this.GroupBox1.TabIndex = 48;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = " ";
            // 
            // chkZero
            // 
            this.chkZero.AutoSize = true;
            this.chkZero.Checked = true;
            this.chkZero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZero.Location = new System.Drawing.Point(6, 18);
            this.chkZero.Name = "chkZero";
            this.chkZero.Size = new System.Drawing.Size(86, 17);
            this.chkZero.TabIndex = 57;
            this.chkZero.Text = "Include Zero";
            this.chkZero.UseVisualStyleBackColor = true;
            // 
            // btn_trfToxl
            // 
            this.btn_trfToxl.BackColor = System.Drawing.Color.LightCoral;
            this.btn_trfToxl.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trfToxl.Location = new System.Drawing.Point(654, 12);
            this.btn_trfToxl.Name = "btn_trfToxl";
            this.btn_trfToxl.Size = new System.Drawing.Size(120, 29);
            this.btn_trfToxl.TabIndex = 56;
            this.btn_trfToxl.Text = "Transfer To Excel";
            this.btn_trfToxl.UseVisualStyleBackColor = false;
            this.btn_trfToxl.Click += new System.EventHandler(this.btn_trfToxl_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::eChandanCanteen.Properties.Resources.print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(575, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 30);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
     
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFill.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(92, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(45, 28);
            this.btnFill.TabIndex = 20;
            this.btnFill.Text = ">>";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // item_name
            // 
            this.item_name.Text = "Product Name";
            this.item_name.Width = 371;
            // 
            // Last_Pur_Date
            // 
            this.Last_Pur_Date.Text = "Last_Pur_Date";
            this.Last_Pur_Date.Width = 100;
            // 
            // Last_Pur_Qty
            // 
            this.Last_Pur_Qty.Text = "Last_Pur_Qty";
            this.Last_Pur_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Last_Pur_Qty.Width = 80;
            // 
            // ExpDate
            // 
            this.ExpDate.Text = "Exp Date";
            this.ExpDate.Width = 82;
            // 
            // Bestrate
            // 
            this.Bestrate.Text = "Best Rate";
            this.Bestrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Bestrate.Width = 73;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 50;
            // 
            // lv_Detail
            // 
            this.lv_Detail.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_Detail.BackColor = System.Drawing.Color.White;
            this.lv_Detail.BackgroundImageTiled = true;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_name,
            this.Last_Pur_Date,
            this.Last_Pur_Qty,
            this.ExpDate,
            this.Bestrate,
            this.Qty});
            this.lv_Detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.ForeColor = System.Drawing.Color.Maroon;
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(7, 56);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(780, 480);
            this.lv_Detail.TabIndex = 47;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Product which are marked as best rate and having best rate greater than zero";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(144, 20);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(39, 13);
            this.lblItem.TabIndex = 59;
            this.lblItem.Text = "XXXX";
            // 
            // WareHouseStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(795, 541);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lv_Detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WareHouseStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{Stock At Unit & Warehouse}";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnFill;
        internal System.Windows.Forms.ColumnHeader item_name;
        internal System.Windows.Forms.ColumnHeader Last_Pur_Date;
        internal System.Windows.Forms.ColumnHeader Last_Pur_Qty;
        internal System.Windows.Forms.ColumnHeader ExpDate;
        internal System.Windows.Forms.ColumnHeader Bestrate;
        internal System.Windows.Forms.ColumnHeader Qty;
        internal System.Windows.Forms.ListView lv_Detail;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btn_trfToxl;
        private System.Windows.Forms.CheckBox chkZero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItem;
    }
}