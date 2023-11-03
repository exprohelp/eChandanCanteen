namespace eChandanCanteen
{
    partial class Audit_ReconcileStock
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
            this.lvSearchItem = new System.Windows.Forms.ListView();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.lv_tracking = new System.Windows.Forms.ListView();
            this.mkey = new System.Windows.Forms.ColumnHeader();
            this.Unit_name = new System.Windows.Forms.ColumnHeader();
            this.dt = new System.Windows.Forms.ColumnHeader();
            this.mkeytrf = new System.Windows.Forms.ColumnHeader();
            this.packtype = new System.Windows.Forms.ColumnHeader();
            this.prqty = new System.Windows.Forms.ColumnHeader();
            this.trfqty = new System.Windows.Forms.ColumnHeader();
            this.retqty = new System.Windows.Forms.ColumnHeader();
            this.bal = new System.Windows.Forms.ColumnHeader();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblMkey = new System.Windows.Forms.Label();
            this.txtFStkQty = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cmbSelectUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSearchItem
            // 
            this.lvSearchItem.BackColor = System.Drawing.Color.Silver;
            this.lvSearchItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19});
            this.lvSearchItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSearchItem.ForeColor = System.Drawing.Color.Black;
            this.lvSearchItem.FullRowSelect = true;
            this.lvSearchItem.GridLines = true;
            this.lvSearchItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSearchItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvSearchItem.Location = new System.Drawing.Point(5, 121);
            this.lvSearchItem.Name = "lvSearchItem";
            this.lvSearchItem.Size = new System.Drawing.Size(237, 404);
            this.lvSearchItem.TabIndex = 180;
            this.lvSearchItem.TabStop = false;
            this.toolTip1.SetToolTip(this.lvSearchItem, "Click Enter Key To Fill The Information");
            this.lvSearchItem.UseCompatibleStateImageBehavior = false;
            this.lvSearchItem.View = System.Windows.Forms.View.Details;
            this.lvSearchItem.SelectedIndexChanged += new System.EventHandler(this.lvSearchItem_SelectedIndexChanged);
            this.lvSearchItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvSearchItem_KeyDown);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Item Id";
            this.columnHeader18.Width = 0;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "";
            this.columnHeader19.Width = 214;
            // 
            // lv_tracking
            // 
            this.lv_tracking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_tracking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_tracking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mkey,
            this.Unit_name,
            this.dt,
            this.mkeytrf,
            this.packtype,
            this.prqty,
            this.trfqty,
            this.retqty,
            this.bal});
            this.lv_tracking.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_tracking.ForeColor = System.Drawing.Color.Black;
            this.lv_tracking.FullRowSelect = true;
            this.lv_tracking.GridLines = true;
            this.lv_tracking.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_tracking.Location = new System.Drawing.Point(6, 28);
            this.lv_tracking.Name = "lv_tracking";
            this.lv_tracking.Size = new System.Drawing.Size(665, 431);
            this.lv_tracking.TabIndex = 183;
            this.toolTip1.SetToolTip(this.lv_tracking, "Click On Product To Fill This Grid");
            this.lv_tracking.UseCompatibleStateImageBehavior = false;
            this.lv_tracking.View = System.Windows.Forms.View.Details;
            this.lv_tracking.SelectedIndexChanged += new System.EventHandler(this.lv_tracking_SelectedIndexChanged);
            this.lv_tracking.Enter += new System.EventHandler(this.lv_tracking_Enter);
            this.lv_tracking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_tracking_KeyDown);
            // 
            // mkey
            // 
            this.mkey.Text = "Master_Key_Id";
            this.mkey.Width = 0;
            // 
            // Unit_name
            // 
            this.Unit_name.Text = "Unit Name";
            this.Unit_name.Width = 200;
            // 
            // dt
            // 
            this.dt.Text = "Date";
            this.dt.Width = 80;
            // 
            // mkeytrf
            // 
            this.mkeytrf.Text = "Trfid/Mkey";
            this.mkeytrf.Width = 104;
            // 
            // packtype
            // 
            this.packtype.Text = "P.Type";
            this.packtype.Width = 70;
            // 
            // prqty
            // 
            this.prqty.Text = "P/T.Qty";
            this.prqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prqty.Width = 55;
            // 
            // trfqty
            // 
            this.trfqty.Text = "T/I.Qty";
            this.trfqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.trfqty.Width = 48;
            // 
            // retqty
            // 
            this.retqty.Text = "R.Qty";
            this.retqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.retqty.Width = 45;
            // 
            // bal
            // 
            this.bal.Text = "Bal";
            this.bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bal.Width = 36;
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.Blue;
            this.txtProdName.Location = new System.Drawing.Point(5, 93);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(238, 22);
            this.txtProdName.TabIndex = 184;
            this.txtProdName.TabStop = false;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 185;
            this.label1.Text = "Filter Product By Type";
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.lv_tracking);
            this.gb_info.Location = new System.Drawing.Point(251, 26);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(680, 465);
            this.gb_info.TabIndex = 186;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // lblMkey
            // 
            this.lblMkey.AutoSize = true;
            this.lblMkey.Enabled = false;
            this.lblMkey.Location = new System.Drawing.Point(583, 9);
            this.lblMkey.Name = "lblMkey";
            this.lblMkey.Size = new System.Drawing.Size(87, 20);
            this.lblMkey.TabIndex = 187;
            this.lblMkey.Text = "Final Stock of ";
            // 
            // txtFStkQty
            // 
            this.txtFStkQty.BackColor = System.Drawing.Color.White;
            this.txtFStkQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFStkQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFStkQty.Enabled = false;
            this.txtFStkQty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFStkQty.ForeColor = System.Drawing.Color.Blue;
            this.txtFStkQty.Location = new System.Drawing.Point(818, 7);
            this.txtFStkQty.MaxLength = 50;
            this.txtFStkQty.Name = "txtFStkQty";
            this.txtFStkQty.ReadOnly = true;
            this.txtFStkQty.Size = new System.Drawing.Size(73, 23);
            this.txtFStkQty.TabIndex = 188;
            this.txtFStkQty.TabStop = false;
            this.txtFStkQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFStkQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFStkQty_KeyDown);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(252, 502);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(576, 25);
            this.txtRemark.TabIndex = 189;
            this.txtRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyDown);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(834, 502);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(82, 27);
            this.btn_Submit.TabIndex = 190;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cmbSelectUnit
            // 
            this.cmbSelectUnit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectUnit.FormattingEnabled = true;
            this.cmbSelectUnit.Location = new System.Drawing.Point(7, 40);
            this.cmbSelectUnit.Name = "cmbSelectUnit";
            this.cmbSelectUnit.Size = new System.Drawing.Size(235, 24);
            this.cmbSelectUnit.TabIndex = 191;
            this.cmbSelectUnit.SelectedIndexChanged += new System.EventHandler(this.cmbSelectUnit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 192;
            this.label2.Text = "Select Unit";
            // 
            // Audit_ReconcileStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSelectUnit);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtFStkQty);
            this.Controls.Add(this.lblMkey);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lvSearchItem);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Audit_ReconcileStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reconcile Product at the time of audit";
            this.Load += new System.EventHandler(this.Audit_ReconcileStock_Load);
            this.gb_info.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView lvSearchItem;
        internal System.Windows.Forms.ColumnHeader columnHeader18;
        internal System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ListView lv_tracking;
        private System.Windows.Forms.ColumnHeader mkey;
        private System.Windows.Forms.ColumnHeader Unit_name;
        private System.Windows.Forms.ColumnHeader dt;
        private System.Windows.Forms.ColumnHeader mkeytrf;
        private System.Windows.Forms.ColumnHeader prqty;
        private System.Windows.Forms.ColumnHeader trfqty;
        private System.Windows.Forms.ColumnHeader bal;
        internal System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader packtype;
        private System.Windows.Forms.Label lblMkey;
        internal System.Windows.Forms.TextBox txtFStkQty;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ColumnHeader retqty;
        private System.Windows.Forms.ComboBox cmbSelectUnit;
        private System.Windows.Forms.Label label2;
    }
}