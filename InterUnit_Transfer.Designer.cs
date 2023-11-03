namespace eChandanCanteen
{
    partial class InterUnit_Transfer
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lv_Product = new System.Windows.Forms.ListView();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.lv_PurchBillInfo = new System.Windows.Forms.ListView();
            this.auto_id = new System.Windows.Forms.ColumnHeader();
            this.ProductName = new System.Windows.Forms.ColumnHeader();
            this.BatchNo = new System.Windows.Forms.ColumnHeader();
            this.ExpDate = new System.Windows.Forms.ColumnHeader();
            this.NPR = new System.Windows.Forms.ColumnHeader();
            this.Pack_Size = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.cmbPackSize = new System.Windows.Forms.ComboBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtNpr = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbManufacurer = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTrfId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxInterUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.btnPostTrf = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.lv_Product);
            this.groupBox3.Controls.Add(this.lv_PurchBillInfo);
            this.groupBox3.Controls.Add(this.cmbPackSize);
            this.groupBox3.Controls.Add(this.txtExpDate);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.txtNpr);
            this.groupBox3.Controls.Add(this.txtBatchNo);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(4, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(870, 318);
            this.groupBox3.TabIndex = 149;
            this.groupBox3.TabStop = false;
            // 
            // lv_Product
            // 
            this.lv_Product.BackColor = System.Drawing.SystemColors.Info;
            this.lv_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19});
            this.lv_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Product.FullRowSelect = true;
            this.lv_Product.GridLines = true;
            this.lv_Product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_Product.Location = new System.Drawing.Point(6, 4);
            this.lv_Product.Name = "lv_Product";
            this.lv_Product.Size = new System.Drawing.Size(342, 20);
            this.lv_Product.TabIndex = 168;
            this.lv_Product.TabStop = false;
            this.lv_Product.UseCompatibleStateImageBehavior = false;
            this.lv_Product.View = System.Windows.Forms.View.Details;
            this.lv_Product.Visible = false;
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
            this.columnHeader19.Width = 254;
            // 
            // lv_PurchBillInfo
            // 
            this.lv_PurchBillInfo.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_PurchBillInfo.BackColor = System.Drawing.Color.LightBlue;
            this.lv_PurchBillInfo.BackgroundImageTiled = true;
            this.lv_PurchBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.auto_id,
            this.ProductName,
            this.BatchNo,
            this.ExpDate,
            this.NPR,
            this.Pack_Size,
            this.Qty,
            this.Amount});
            this.lv_PurchBillInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_PurchBillInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lv_PurchBillInfo.FullRowSelect = true;
            this.lv_PurchBillInfo.GridLines = true;
            this.lv_PurchBillInfo.LabelEdit = true;
            this.lv_PurchBillInfo.Location = new System.Drawing.Point(4, 62);
            this.lv_PurchBillInfo.Name = "lv_PurchBillInfo";
            this.lv_PurchBillInfo.Size = new System.Drawing.Size(860, 250);
            this.lv_PurchBillInfo.TabIndex = 167;
            this.lv_PurchBillInfo.UseCompatibleStateImageBehavior = false;
            this.lv_PurchBillInfo.View = System.Windows.Forms.View.Details;
            this.lv_PurchBillInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_PurchBillInfo_KeyDown);
            // 
            // auto_id
            // 
            this.auto_id.Width = 0;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 301;
            // 
            // BatchNo
            // 
            this.BatchNo.Text = "Batch";
            this.BatchNo.Width = 120;
            // 
            // ExpDate
            // 
            this.ExpDate.Text = "Exp Date";
            this.ExpDate.Width = 110;
            // 
            // NPR
            // 
            this.NPR.Text = "NPR";
            this.NPR.Width = 65;
            // 
            // Pack_Size
            // 
            this.Pack_Size.Text = "Pack Size";
            this.Pack_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pack_Size.Width = 108;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 49;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 75;
            // 
            // cmbPackSize
            // 
            this.cmbPackSize.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbPackSize.DropDownWidth = 92;
            this.cmbPackSize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackSize.FormattingEnabled = true;
            this.cmbPackSize.ItemHeight = 15;
            this.cmbPackSize.Location = new System.Drawing.Point(600, 40);
            this.cmbPackSize.Name = "cmbPackSize";
            this.cmbPackSize.Size = new System.Drawing.Size(109, 23);
            this.cmbPackSize.TabIndex = 166;
            this.cmbPackSize.Text = "Select";
            this.cmbPackSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPackSize_KeyDown);
            // 
            // txtExpDate
            // 
            this.txtExpDate.BackColor = System.Drawing.Color.White;
            this.txtExpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExpDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.ForeColor = System.Drawing.Color.Blue;
            this.txtExpDate.Location = new System.Drawing.Point(427, 40);
            this.txtExpDate.MaxLength = 5;
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(110, 23);
            this.txtExpDate.TabIndex = 146;
            this.txtExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpDate_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(788, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 15);
            this.label17.TabIndex = 165;
            this.label17.Text = "Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(732, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 161;
            this.label14.Text = "Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(651, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 159;
            this.label11.Text = "Pack Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 157;
            this.label9.Text = "Batch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 156;
            this.label6.Text = "NPR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 155;
            this.label4.Text = "Exp_Date";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(758, 38);
            this.txtAmount.MaxLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(79, 23);
            this.txtAmount.TabIndex = 153;
            this.txtAmount.TabStop = false;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Blue;
            this.txtQty.Location = new System.Drawing.Point(709, 40);
            this.txtQty.MaxLength = 0;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(48, 23);
            this.txtQty.TabIndex = 149;
            this.txtQty.TabStop = false;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // txtNpr
            // 
            this.txtNpr.BackColor = System.Drawing.Color.White;
            this.txtNpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNpr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNpr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNpr.ForeColor = System.Drawing.Color.Blue;
            this.txtNpr.Location = new System.Drawing.Point(536, 40);
            this.txtNpr.MaxLength = 0;
            this.txtNpr.Name = "txtNpr";
            this.txtNpr.Size = new System.Drawing.Size(64, 23);
            this.txtNpr.TabIndex = 147;
            this.txtNpr.TabStop = false;
            this.txtNpr.Text = "0";
            this.txtNpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNpr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNpr_KeyDown);
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.BackColor = System.Drawing.Color.LightGray;
            this.txtBatchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBatchNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.ForeColor = System.Drawing.Color.Blue;
            this.txtBatchNo.Location = new System.Drawing.Point(306, 40);
            this.txtBatchNo.MaxLength = 15;
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(121, 23);
            this.txtBatchNo.TabIndex = 145;
            this.txtBatchNo.TabStop = false;
            this.txtBatchNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatchNo_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.cmbManufacurer);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.txtProdName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 70);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            // 
            // cmbManufacurer
            // 
            this.cmbManufacurer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbManufacurer.FormattingEnabled = true;
            this.cmbManufacurer.Location = new System.Drawing.Point(264, 33);
            this.cmbManufacurer.Name = "cmbManufacurer";
            this.cmbManufacurer.Size = new System.Drawing.Size(163, 24);
            this.cmbManufacurer.TabIndex = 135;
            this.cmbManufacurer.SelectedIndexChanged += new System.EventHandler(this.cmbManufacurer_SelectedIndexChanged);
            this.cmbManufacurer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbManufacurer_KeyDown_1);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(260, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(107, 18);
            this.label26.TabIndex = 134;
            this.label26.Text = "Manufacturer";
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.Blue;
            this.txtProdName.Location = new System.Drawing.Point(6, 33);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(251, 24);
            this.txtProdName.TabIndex = 112;
            this.txtProdName.TabStop = false;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdName_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 132;
            this.label7.Text = "Product Name";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox4.Controls.Add(this.txtTrfId);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbxInterUnit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(4, -4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(870, 70);
            this.groupBox4.TabIndex = 150;
            this.groupBox4.TabStop = false;
            // 
            // txtTrfId
            // 
            this.txtTrfId.BackColor = System.Drawing.Color.LightGray;
            this.txtTrfId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrfId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTrfId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrfId.ForeColor = System.Drawing.Color.Blue;
            this.txtTrfId.Location = new System.Drawing.Point(651, 27);
            this.txtTrfId.MaxLength = 16;
            this.txtTrfId.Name = "txtTrfId";
            this.txtTrfId.Size = new System.Drawing.Size(211, 31);
            this.txtTrfId.TabIndex = 146;
            this.txtTrfId.TabStop = false;
            this.txtTrfId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrfId_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 135;
            this.label3.Text = "Transfer Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 134;
            this.label1.Text = " Select Unit";
            // 
            // cbxInterUnit
            // 
            this.cbxInterUnit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbxInterUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInterUnit.FormattingEnabled = true;
            this.cbxInterUnit.ItemHeight = 15;
            this.cbxInterUnit.Location = new System.Drawing.Point(108, 30);
            this.cbxInterUnit.Name = "cbxInterUnit";
            this.cbxInterUnit.Size = new System.Drawing.Size(319, 23);
            this.cbxInterUnit.TabIndex = 133;
            this.cbxInterUnit.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(677, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "Total Amount";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmt.Location = new System.Drawing.Point(765, 472);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmt.TabIndex = 152;
            // 
            // btnPostTrf
            // 
            this.btnPostTrf.BackColor = System.Drawing.Color.Black;
            this.btnPostTrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostTrf.ForeColor = System.Drawing.Color.White;
            this.btnPostTrf.Location = new System.Drawing.Point(6, 465);
            this.btnPostTrf.Name = "btnPostTrf";
            this.btnPostTrf.Size = new System.Drawing.Size(142, 34);
            this.btnPostTrf.TabIndex = 153;
            this.btnPostTrf.Text = "Complete";
            this.btnPostTrf.UseVisualStyleBackColor = false;
            this.btnPostTrf.Click += new System.EventHandler(this.btnPostTrf_Click);
            // 
            // InterUnit_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(883, 508);
            this.Controls.Add(this.btnPostTrf);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "InterUnit_Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterUnit_Transfer";
            this.Load += new System.EventHandler(this.InterUnit_Transfer_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.ListView lv_Product;
        internal System.Windows.Forms.ColumnHeader columnHeader18;
        internal System.Windows.Forms.ColumnHeader columnHeader19;
        internal System.Windows.Forms.ListView lv_PurchBillInfo;
        private System.Windows.Forms.ColumnHeader auto_id;
        internal System.Windows.Forms.ColumnHeader ProductName;
        internal System.Windows.Forms.ColumnHeader BatchNo;
        internal System.Windows.Forms.ColumnHeader ExpDate;
        internal System.Windows.Forms.ColumnHeader NPR;
        internal System.Windows.Forms.ColumnHeader Pack_Size;
        internal System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ComboBox cmbPackSize;
        internal System.Windows.Forms.TextBox txtExpDate;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtNpr;
        internal System.Windows.Forms.TextBox txtBatchNo;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.TextBox txtProdName;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxInterUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmt;
        internal System.Windows.Forms.TextBox txtTrfId;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbManufacurer;
        private System.Windows.Forms.Button btnPostTrf;
    }
}