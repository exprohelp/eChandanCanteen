namespace eChandanCanteen
{
    partial class ReconcileProduct
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lvConsumed = new System.Windows.Forms.ListView();
            this.unitname = new System.Windows.Forms.ColumnHeader();
            this.Trfid = new System.Windows.Forms.ColumnHeader();
            this.Masterkey = new System.Windows.Forms.ColumnHeader();
            this.Trf_date = new System.Windows.Forms.ColumnHeader();
            this.Purchqty = new System.Windows.Forms.ColumnHeader();
            this.Consumed = new System.Windows.Forms.ColumnHeader();
            this.ret = new System.Windows.Forms.ColumnHeader();
            this.Balance = new System.Windows.Forms.ColumnHeader();
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lvSearchItem = new System.Windows.Forms.ListView();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.Purch_id = new System.Windows.Forms.ColumnHeader();
            this.InvNo = new System.Windows.Forms.ColumnHeader();
            this.InvDate = new System.Windows.Forms.ColumnHeader();
            this.InvTotal = new System.Windows.Forms.ColumnHeader();
            this.InvTax = new System.Windows.Forms.ColumnHeader();
            this.InvDisc = new System.Windows.Forms.ColumnHeader();
            this.NetAmt = new System.Windows.Forms.ColumnHeader();
            this.RoundOff = new System.Windows.Forms.ColumnHeader();
            this.lv_unit = new System.Windows.Forms.ListView();
            this.Unit_id = new System.Windows.Forms.ColumnHeader();
            this.Unit = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltransfer = new System.Windows.Forms.Label();
            this.lv_DI_info = new System.Windows.Forms.ListView();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.DISPATCH = new System.Windows.Forms.ColumnHeader();
            this.ISSUED = new System.Windows.Forms.ColumnHeader();
            this.vRetQty = new System.Windows.Forms.ColumnHeader();
            this.vbal = new System.Windows.Forms.ColumnHeader();
            this.q = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btntrack = new System.Windows.Forms.Button();
            this.gb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvConsumed
            // 
            this.lvConsumed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvConsumed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.unitname,
            this.Trfid,
            this.Masterkey,
            this.Trf_date,
            this.Purchqty,
            this.Consumed,
            this.ret,
            this.Balance});
            this.lvConsumed.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsumed.ForeColor = System.Drawing.Color.Black;
            this.lvConsumed.FullRowSelect = true;
            this.lvConsumed.GridLines = true;
            this.lvConsumed.Location = new System.Drawing.Point(246, 158);
            this.lvConsumed.Name = "lvConsumed";
            this.lvConsumed.Size = new System.Drawing.Size(632, 130);
            this.lvConsumed.TabIndex = 181;
            this.ToolTip1.SetToolTip(this.lvConsumed, "Particular Purchase Consumption");
            this.lvConsumed.UseCompatibleStateImageBehavior = false;
            this.lvConsumed.View = System.Windows.Forms.View.Details;
            // 
            // unitname
            // 
            this.unitname.Text = "Unit Name";
            this.unitname.Width = 236;
            // 
            // Trfid
            // 
            this.Trfid.Text = "Transfer Id";
            this.Trfid.Width = 100;
            // 
            // Masterkey
            // 
            this.Masterkey.Text = "Master Key Id";
            this.Masterkey.Width = 0;
            // 
            // Trf_date
            // 
            this.Trf_date.Text = "Trf. Date";
            this.Trf_date.Width = 65;
            // 
            // Purchqty
            // 
            this.Purchqty.Text = "PurQty";
            this.Purchqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Purchqty.Width = 50;
            // 
            // Consumed
            // 
            this.Consumed.Text = "TrfQty";
            this.Consumed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Consumed.Width = 50;
            // 
            // ret
            // 
            this.ret.Text = "RetQty";
            this.ret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ret.Width = 50;
            // 
            // Balance
            // 
            this.Balance.Text = "Run.Bal";
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Balance.Width = 50;
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
            this.lv_tracking.Location = new System.Drawing.Point(9, 41);
            this.lv_tracking.Name = "lv_tracking";
            this.lv_tracking.Size = new System.Drawing.Size(665, 431);
            this.lv_tracking.TabIndex = 184;
            this.ToolTip1.SetToolTip(this.lv_tracking, "Click On Product To Fill This Grid");
            this.lv_tracking.UseCompatibleStateImageBehavior = false;
            this.lv_tracking.View = System.Windows.Forms.View.Details;
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
            this.prqty.Text = "PurQty";
            this.prqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prqty.Width = 50;
            // 
            // trfqty
            // 
            this.trfqty.Text = "Trf.Qty";
            this.trfqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.trfqty.Width = 48;
            // 
            // retqty
            // 
            this.retqty.Text = "RetQty";
            this.retqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.retqty.Width = 50;
            // 
            // bal
            // 
            this.bal.Text = "Bal";
            this.bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bal.Width = 36;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(786, 1);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 56;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.Blue;
            this.txtProdName.Location = new System.Drawing.Point(2, 22);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(240, 22);
            this.txtProdName.TabIndex = 178;
            this.txtProdName.TabStop = false;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdName_KeyDown);
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
            this.lvSearchItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvSearchItem.Location = new System.Drawing.Point(3, 45);
            this.lvSearchItem.Name = "lvSearchItem";
            this.lvSearchItem.Size = new System.Drawing.Size(237, 534);
            this.lvSearchItem.TabIndex = 179;
            this.lvSearchItem.TabStop = false;
            this.lvSearchItem.UseCompatibleStateImageBehavior = false;
            this.lvSearchItem.View = System.Windows.Forms.View.Details;
            this.lvSearchItem.SelectedIndexChanged += new System.EventHandler(this.lvSearchItem_SelectedIndexChanged);
            this.lvSearchItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvSearchItem_KeyDown_1);
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
            // lv_Detail
            // 
            this.lv_Detail.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_Detail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_Detail.BackgroundImageTiled = true;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Purch_id,
            this.InvNo,
            this.InvDate,
            this.InvTotal,
            this.InvTax,
            this.InvDisc,
            this.NetAmt,
            this.RoundOff});
            this.lv_Detail.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.ForeColor = System.Drawing.Color.Black;
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(245, 22);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(735, 133);
            this.lv_Detail.TabIndex = 180;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            this.lv_Detail.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Detail_ItemSelectionChanged);
            // 
            // Purch_id
            // 
            this.Purch_id.Text = "Purchage Id";
            this.Purch_id.Width = 135;
            // 
            // InvNo
            // 
            this.InvNo.Text = "Inv No";
            this.InvNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvNo.Width = 102;
            // 
            // InvDate
            // 
            this.InvDate.Text = "Inv Date";
            this.InvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvDate.Width = 112;
            // 
            // InvTotal
            // 
            this.InvTotal.Text = "Inv Total";
            this.InvTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvTotal.Width = 81;
            // 
            // InvTax
            // 
            this.InvTax.Text = "Inv Tax";
            this.InvTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvTax.Width = 67;
            // 
            // InvDisc
            // 
            this.InvDisc.Text = "Inv Disc";
            this.InvDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvDisc.Width = 70;
            // 
            // NetAmt
            // 
            this.NetAmt.Text = "Net Amt";
            this.NetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NetAmt.Width = 69;
            // 
            // RoundOff
            // 
            this.RoundOff.Text = "Round Off";
            this.RoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RoundOff.Width = 74;
            // 
            // lv_unit
            // 
            this.lv_unit.BackColor = System.Drawing.Color.Silver;
            this.lv_unit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Unit_id,
            this.Unit,
            this.Qty});
            this.lv_unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_unit.ForeColor = System.Drawing.Color.Black;
            this.lv_unit.FullRowSelect = true;
            this.lv_unit.GridLines = true;
            this.lv_unit.Location = new System.Drawing.Point(246, 313);
            this.lv_unit.Name = "lv_unit";
            this.lv_unit.Size = new System.Drawing.Size(390, 265);
            this.lv_unit.TabIndex = 182;
            this.lv_unit.UseCompatibleStateImageBehavior = false;
            this.lv_unit.View = System.Windows.Forms.View.Details;
            this.lv_unit.SelectedIndexChanged += new System.EventHandler(this.lv_unit_SelectedIndexChanged);
            this.lv_unit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_unit_KeyDown);
            // 
            // Unit_id
            // 
            this.Unit_id.Text = "unit_id";
            this.Unit_id.Width = 1;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit";
            this.Unit.Width = 250;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 90;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(8, 1);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(0, 16);
            this.lblProduct.TabIndex = 183;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(247, 292);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 184;
            this.label1.Text = "Stock At Unit";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblUnit.Location = new System.Drawing.Point(333, 4);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUnit.Size = new System.Drawing.Size(0, 13);
            this.lblUnit.TabIndex = 185;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(548, 337);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 186;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(533, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 13);
            this.label5.TabIndex = 187;
            this.label5.Text = "Press  F1  to Search Product ,Ctrl+U to go on Unit,Ctrl+P,to go on purchase";
            // 
            // lbltransfer
            // 
            this.lbltransfer.AutoSize = true;
            this.lbltransfer.Location = new System.Drawing.Point(982, 523);
            this.lbltransfer.Name = "lbltransfer";
            this.lbltransfer.Size = new System.Drawing.Size(0, 13);
            this.lbltransfer.TabIndex = 188;
            // 
            // lv_DI_info
            // 
            this.lv_DI_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_DI_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.DISPATCH,
            this.ISSUED,
            this.vRetQty,
            this.vbal,
            this.q});
            this.lv_DI_info.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DI_info.ForeColor = System.Drawing.Color.Black;
            this.lv_DI_info.FullRowSelect = true;
            this.lv_DI_info.GridLines = true;
            this.lv_DI_info.Location = new System.Drawing.Point(642, 313);
            this.lv_DI_info.Name = "lv_DI_info";
            this.lv_DI_info.Size = new System.Drawing.Size(338, 263);
            this.lv_DI_info.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_DI_info.TabIndex = 2;
            this.lv_DI_info.UseCompatibleStateImageBehavior = false;
            this.lv_DI_info.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "DATE";
            this.date.Width = 100;
            // 
            // DISPATCH
            // 
            this.DISPATCH.Text = "R.Qty";
            this.DISPATCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DISPATCH.Width = 50;
            // 
            // ISSUED
            // 
            this.ISSUED.Text = "I.Qty";
            this.ISSUED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ISSUED.Width = 50;
            // 
            // vRetQty
            // 
            this.vRetQty.Text = "R.Qty";
            this.vRetQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vRetQty.Width = 50;
            // 
            // vbal
            // 
            this.vbal.Tag = "";
            this.vbal.Text = "R.BAL";
            this.vbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vbal.Width = 50;
            // 
            // q
            // 
            this.q.Tag = "Numeric";
            this.q.Width = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(639, 292);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 189;
            this.label2.Text = "Dispatch && Issue of Selected Product";
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.lv_tracking);
            this.gb_info.Controls.Add(this.button1);
            this.gb_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_info.Location = new System.Drawing.Point(245, 22);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(678, 238);
            this.gb_info.TabIndex = 190;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "Master Key Wise Stock Info.";
            this.gb_info.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(592, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 183;
            this.button1.Text = "Close Me";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntrack
            // 
            this.btntrack.BackColor = System.Drawing.Color.LightCoral;
            this.btntrack.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrack.ForeColor = System.Drawing.Color.Yellow;
            this.btntrack.Location = new System.Drawing.Point(925, 158);
            this.btntrack.Name = "btntrack";
            this.btntrack.Size = new System.Drawing.Size(50, 147);
            this.btntrack.TabIndex = 191;
            this.btntrack.Text = "Track of Keys";
            this.btntrack.UseVisualStyleBackColor = false;
            this.btntrack.Click += new System.EventHandler(this.btntrack_Click);
            // 
            // ReconcileProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(982, 583);
            this.Controls.Add(this.btntrack);
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_DI_info);
            this.Controls.Add(this.lbltransfer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lv_unit);
            this.Controls.Add(this.lvConsumed);
            this.Controls.Add(this.lv_Detail);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lvSearchItem);
            this.Controls.Add(this.txtProdName);
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReconcileProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reconcile Products";
            this.Load += new System.EventHandler(this.ReconcileProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReconcileProduct_KeyDown);
            this.gb_info.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.TextBox txtProdName;
        internal System.Windows.Forms.ListView lvSearchItem;
        internal System.Windows.Forms.ColumnHeader columnHeader18;
        internal System.Windows.Forms.ColumnHeader columnHeader19;
        internal System.Windows.Forms.ListView lv_Detail;
        internal System.Windows.Forms.ColumnHeader Purch_id;
        internal System.Windows.Forms.ColumnHeader InvNo;
        internal System.Windows.Forms.ColumnHeader InvDate;
        internal System.Windows.Forms.ColumnHeader InvTotal;
        internal System.Windows.Forms.ColumnHeader InvTax;
        internal System.Windows.Forms.ColumnHeader InvDisc;
        internal System.Windows.Forms.ColumnHeader NetAmt;
        private System.Windows.Forms.ColumnHeader RoundOff;
        private System.Windows.Forms.ListView lvConsumed;
        private System.Windows.Forms.ColumnHeader Trfid;
        private System.Windows.Forms.ColumnHeader Purchqty;
        private System.Windows.Forms.ColumnHeader Consumed;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ListView lv_unit;
        private System.Windows.Forms.ColumnHeader Unit_id;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.Label lblProduct;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUnit;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltransfer;
        private System.Windows.Forms.ListView lv_DI_info;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader DISPATCH;
        private System.Windows.Forms.ColumnHeader ISSUED;
        private System.Windows.Forms.ColumnHeader vbal;
        private System.Windows.Forms.ColumnHeader q;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Trf_date;
        private System.Windows.Forms.ColumnHeader unitname;
        private System.Windows.Forms.ColumnHeader Masterkey;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Button btntrack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ret;
        private System.Windows.Forms.ListView lv_tracking;
        private System.Windows.Forms.ColumnHeader mkey;
        private System.Windows.Forms.ColumnHeader Unit_name;
        private System.Windows.Forms.ColumnHeader dt;
        private System.Windows.Forms.ColumnHeader mkeytrf;
        private System.Windows.Forms.ColumnHeader packtype;
        private System.Windows.Forms.ColumnHeader prqty;
        private System.Windows.Forms.ColumnHeader trfqty;
        private System.Windows.Forms.ColumnHeader retqty;
        private System.Windows.Forms.ColumnHeader bal;
        private System.Windows.Forms.ColumnHeader vRetQty;
    }
}