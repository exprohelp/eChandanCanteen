﻿namespace eChandanCanteen
{
    partial class goods_return
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
            this.grpPament = new System.Windows.Forms.GroupBox();
            this.btnFillRecords = new System.Windows.Forms.Button();
            this.cmbSelectUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransferId = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lv_Details = new System.Windows.Forms.ListView();
            this.masterKeyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MfdID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Product = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.W = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.lv_PurchBillInfo = new System.Windows.Forms.ListView();
            this.auto_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BatchNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PACKqTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPacQty = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpPament.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPament
            // 
            this.grpPament.Controls.Add(this.btnFillRecords);
            this.grpPament.Controls.Add(this.cmbSelectUnit);
            this.grpPament.Controls.Add(this.label2);
            this.grpPament.Controls.Add(this.txtTransferId);
            this.grpPament.Controls.Add(this.Label8);
            this.grpPament.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPament.ForeColor = System.Drawing.Color.White;
            this.grpPament.Location = new System.Drawing.Point(7, 2);
            this.grpPament.Name = "grpPament";
            this.grpPament.Size = new System.Drawing.Size(775, 64);
            this.grpPament.TabIndex = 123;
            this.grpPament.TabStop = false;
            this.grpPament.Text = "TRANSFER OF PRODUCT";
            // 
            // btnFillRecords
            // 
            this.btnFillRecords.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFillRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillRecords.ForeColor = System.Drawing.Color.White;
            this.btnFillRecords.Location = new System.Drawing.Point(654, 27);
            this.btnFillRecords.Name = "btnFillRecords";
            this.btnFillRecords.Size = new System.Drawing.Size(105, 27);
            this.btnFillRecords.TabIndex = 94;
            this.btnFillRecords.Text = "Fill Records";
            this.btnFillRecords.UseVisualStyleBackColor = false;
            this.btnFillRecords.Click += new System.EventHandler(this.btnFillRecords_Click);
            // 
            // cmbSelectUnit
            // 
            this.cmbSelectUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbSelectUnit.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectUnit.FormattingEnabled = true;
            this.cmbSelectUnit.ItemHeight = 18;
            this.cmbSelectUnit.Location = new System.Drawing.Point(98, 24);
            this.cmbSelectUnit.Name = "cmbSelectUnit";
            this.cmbSelectUnit.Size = new System.Drawing.Size(254, 26);
            this.cmbSelectUnit.TabIndex = 1;
            this.cmbSelectUnit.SelectedIndexChanged += new System.EventHandler(this.cmbSelectUnit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 87;
            this.label2.Text = "Select Unit";
            // 
            // txtTransferId
            // 
            this.txtTransferId.BackColor = System.Drawing.Color.White;
            this.txtTransferId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferId.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferId.ForeColor = System.Drawing.Color.Blue;
            this.txtTransferId.Location = new System.Drawing.Point(489, 27);
            this.txtTransferId.MaxLength = 10;
            this.txtTransferId.Name = "txtTransferId";
            this.txtTransferId.Size = new System.Drawing.Size(159, 26);
            this.txtTransferId.TabIndex = 3;
            this.txtTransferId.TabStop = false;
            this.txtTransferId.Text = "New";
            this.txtTransferId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransferId_KeyDown);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Calibri", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(400, 31);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(73, 18);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Transfer Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btnComplete);
            this.groupBox3.Controls.Add(this.lv_Details);
            this.groupBox3.Controls.Add(this.lv_Product);
            this.groupBox3.Controls.Add(this.txtProdName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.txtPackSize);
            this.groupBox3.Controls.Add(this.lv_PurchBillInfo);
            this.groupBox3.Controls.Add(this.txtExpDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPacQty);
            this.groupBox3.Controls.Add(this.txtBatchNo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 438);
            this.groupBox3.TabIndex = 147;
            this.groupBox3.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(639, 397);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(129, 32);
            this.progressBar1.TabIndex = 178;
            this.progressBar1.Visible = false;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(7, 397);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(145, 33);
            this.btnComplete.TabIndex = 177;
            this.btnComplete.Text = " Complete ";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lv_Details
            // 
            this.lv_Details.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_Details.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_Details.BackgroundImageTiled = true;
            this.lv_Details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masterKeyId,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1,
            this.MfdID,
            this.columnHeader8});
            this.lv_Details.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Details.ForeColor = System.Drawing.Color.Black;
            this.lv_Details.FullRowSelect = true;
            this.lv_Details.GridLines = true;
            this.lv_Details.Location = new System.Drawing.Point(10, 349);
            this.lv_Details.Name = "lv_Details";
            this.lv_Details.Size = new System.Drawing.Size(602, 22);
            this.lv_Details.TabIndex = 176;
            this.lv_Details.UseCompatibleStateImageBehavior = false;
            this.lv_Details.View = System.Windows.Forms.View.Details;
            this.lv_Details.Visible = false;
            this.lv_Details.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_Details_KeyUp);
            // 
            // masterKeyId
            // 
            this.masterKeyId.Text = "masterKey_Id";
            this.masterKeyId.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Batch";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pack Size";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pack Qty";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Exp Date";
            this.columnHeader6.Width = 91;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Manufacturer";
            this.columnHeader1.Width = 144;
            // 
            // MfdID
            // 
            this.MfdID.Text = "MfdID";
            this.MfdID.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Qty";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 57;
            // 
            // lv_Product
            // 
            this.lv_Product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19,
            this.W});
            this.lv_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Product.FullRowSelect = true;
            this.lv_Product.GridLines = true;
            this.lv_Product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_Product.Location = new System.Drawing.Point(9, 309);
            this.lv_Product.Name = "lv_Product";
            this.lv_Product.Size = new System.Drawing.Size(382, 34);
            this.lv_Product.TabIndex = 174;
            this.lv_Product.TabStop = false;
            this.lv_Product.UseCompatibleStateImageBehavior = false;
            this.lv_Product.View = System.Windows.Forms.View.Details;
            this.lv_Product.Visible = false;
            this.lv_Product.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Product_ItemSelectionChanged);
            this.lv_Product.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_Product_KeyUp);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Item Id";
            this.columnHeader18.Width = 0;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Item Name";
            this.columnHeader19.Width = 298;
            // 
            // W
            // 
            this.W.Text = "Qty";
            this.W.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdName.Font = new System.Drawing.Font("Calibri", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.Blue;
            this.txtProdName.Location = new System.Drawing.Point(8, 30);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(255, 27);
            this.txtProdName.TabIndex = 172;
            this.txtProdName.TabStop = false;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdName_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 173;
            this.label7.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(710, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 171;
            this.label1.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Blue;
            this.txtQty.Location = new System.Drawing.Point(663, 30);
            this.txtQty.MaxLength = 0;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(83, 27);
            this.txtQty.TabIndex = 170;
            this.txtQty.TabStop = false;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // txtPackSize
            // 
            this.txtPackSize.BackColor = System.Drawing.Color.White;
            this.txtPackSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPackSize.Font = new System.Drawing.Font("Calibri", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackSize.ForeColor = System.Drawing.Color.Blue;
            this.txtPackSize.Location = new System.Drawing.Point(382, 30);
            this.txtPackSize.MaxLength = 10;
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.ReadOnly = true;
            this.txtPackSize.Size = new System.Drawing.Size(111, 27);
            this.txtPackSize.TabIndex = 169;
            this.txtPackSize.TabStop = false;
            // 
            // lv_PurchBillInfo
            // 
            this.lv_PurchBillInfo.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_PurchBillInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lv_PurchBillInfo.BackgroundImageTiled = true;
            this.lv_PurchBillInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_PurchBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.auto_id,
            this.RecId,
            this.ProductName,
            this.BatchNo,
            this.Pack_Size,
            this.ExpDate,
            this.PACKqTY,
            this.Qty});
            this.lv_PurchBillInfo.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_PurchBillInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lv_PurchBillInfo.FullRowSelect = true;
            this.lv_PurchBillInfo.GridLines = true;
            this.lv_PurchBillInfo.Location = new System.Drawing.Point(8, 59);
            this.lv_PurchBillInfo.Name = "lv_PurchBillInfo";
            this.lv_PurchBillInfo.Size = new System.Drawing.Size(760, 332);
            this.lv_PurchBillInfo.TabIndex = 167;
            this.lv_PurchBillInfo.UseCompatibleStateImageBehavior = false;
            this.lv_PurchBillInfo.View = System.Windows.Forms.View.Details;
            this.lv_PurchBillInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_PurchBillInfo_KeyDown);
            // 
            // auto_id
            // 
            this.auto_id.Width = 0;
            // 
            // RecId
            // 
            this.RecId.Text = "RecId";
            this.RecId.Width = 0;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 255;
            // 
            // BatchNo
            // 
            this.BatchNo.Text = "Batch";
            this.BatchNo.Width = 120;
            // 
            // Pack_Size
            // 
            this.Pack_Size.Text = "Pack Size";
            this.Pack_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pack_Size.Width = 110;
            // 
            // ExpDate
            // 
            this.ExpDate.Text = "Exp Date";
            this.ExpDate.Width = 105;
            // 
            // PACKqTY
            // 
            this.PACKqTY.Text = "Pack Qty";
            this.PACKqTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PACKqTY.Width = 65;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 80;
            // 
            // txtExpDate
            // 
            this.txtExpDate.BackColor = System.Drawing.Color.White;
            this.txtExpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExpDate.Font = new System.Drawing.Font("Calibri", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.ForeColor = System.Drawing.Color.Blue;
            this.txtExpDate.Location = new System.Drawing.Point(493, 30);
            this.txtExpDate.MaxLength = 5;
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ReadOnly = true;
            this.txtExpDate.Size = new System.Drawing.Size(105, 27);
            this.txtExpDate.TabIndex = 146;
            this.txtExpDate.TabStop = false;
            this.txtExpDate.Text = "-";
            this.txtExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(592, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 161;
            this.label14.Text = "Pack Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(379, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 159;
            this.label11.Text = "Pack Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(261, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 157;
            this.label9.Text = "Batch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(490, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 155;
            this.label4.Text = "Exp_Date";
            // 
            // txtPacQty
            // 
            this.txtPacQty.BackColor = System.Drawing.Color.White;
            this.txtPacQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPacQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPacQty.Font = new System.Drawing.Font("Calibri", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacQty.ForeColor = System.Drawing.Color.Blue;
            this.txtPacQty.Location = new System.Drawing.Point(598, 30);
            this.txtPacQty.MaxLength = 0;
            this.txtPacQty.Name = "txtPacQty";
            this.txtPacQty.ReadOnly = true;
            this.txtPacQty.Size = new System.Drawing.Size(64, 27);
            this.txtPacQty.TabIndex = 149;
            this.txtPacQty.TabStop = false;
            this.txtPacQty.Text = "0";
            this.txtPacQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBatchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBatchNo.Font = new System.Drawing.Font("Calibri", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.ForeColor = System.Drawing.Color.Blue;
            this.txtBatchNo.Location = new System.Drawing.Point(263, 30);
            this.txtBatchNo.MaxLength = 15;
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(119, 27);
            this.txtBatchNo.TabIndex = 145;
            this.txtBatchNo.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // goods_return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(788, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpPament);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "goods_return";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Product";
            this.Load += new System.EventHandler(this.goods_return_Load);
            this.grpPament.ResumeLayout(false);
            this.grpPament.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpPament;
        private System.Windows.Forms.ComboBox cmbSelectUnit;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTransferId;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.ListView lv_PurchBillInfo;
        private System.Windows.Forms.ColumnHeader auto_id;
        internal System.Windows.Forms.ColumnHeader ProductName;
        internal System.Windows.Forms.ColumnHeader BatchNo;
        internal System.Windows.Forms.ColumnHeader ExpDate;
        internal System.Windows.Forms.ColumnHeader PACKqTY;
        internal System.Windows.Forms.ColumnHeader Pack_Size;
        internal System.Windows.Forms.ColumnHeader Qty;
        internal System.Windows.Forms.TextBox txtExpDate;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtPacQty;
        internal System.Windows.Forms.TextBox txtBatchNo;
        internal System.Windows.Forms.TextBox txtPackSize;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtProdName;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ListView lv_Product;
        internal System.Windows.Forms.ColumnHeader columnHeader18;
        internal System.Windows.Forms.ColumnHeader columnHeader19;
        internal System.Windows.Forms.ListView lv_Details;
        private System.Windows.Forms.ColumnHeader masterKeyId;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.ColumnHeader columnHeader4;
        internal System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.ColumnHeader columnHeader6;
        internal System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnFillRecords;
        private System.Windows.Forms.ColumnHeader RecId;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ColumnHeader MfdID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader W;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}