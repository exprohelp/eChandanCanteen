namespace eChandanCanteen
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.gbxAunthenticate = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblpsw = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtpsw = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tmm_Sales = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_POS = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_SaleRegister = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_Reports = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_CreditConsumption = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_CancelBill = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_Kot = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_TokenDisplay = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_Tat = new Telerik.WinControls.UI.RadMenuItem();
            this.tmm_Master = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_Product = new Telerik.WinControls.UI.RadMenuItem();
            this.rssm_NewProduct = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_Vendor = new Telerik.WinControls.UI.RadMenuItem();
            this.tmm_Purchase = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_PurchaseFeeding = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_PurchaseBill = new Telerik.WinControls.UI.RadMenuItem();
            this.tmm_IssueProduct = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_IssueProduct = new Telerik.WinControls.UI.RadMenuItem();
            this.tmm_Stocks = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_UnitStocks = new Telerik.WinControls.UI.RadMenuItem();
            this.tmm_Accounts = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_AccountsInfo = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_AmtReceiveFromStaff = new Telerik.WinControls.UI.RadMenuItem();
            this.trm_Audit = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_AuditStock = new Telerik.WinControls.UI.RadMenuItem();
            this.trm_Utility = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_UpdateSoftware = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_BuildMenu = new Telerik.WinControls.UI.RadMenuItem();
            this.rsm_LoginRights = new Telerik.WinControls.UI.RadMenuItem();
            this.mainMenu = new Telerik.WinControls.UI.RadMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rsm_ApproveCancellation = new Telerik.WinControls.UI.RadMenuItem();
            this.gbxAunthenticate.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAunthenticate
            // 
            this.gbxAunthenticate.BackColor = System.Drawing.Color.Gray;
            this.gbxAunthenticate.Controls.Add(this.progressBar1);
            this.gbxAunthenticate.Controls.Add(this.lblMessage);
            this.gbxAunthenticate.Controls.Add(this.btnLogin);
            this.gbxAunthenticate.Controls.Add(this.lblpsw);
            this.gbxAunthenticate.Controls.Add(this.lblLoginName);
            this.gbxAunthenticate.Controls.Add(this.txtLoginId);
            this.gbxAunthenticate.Controls.Add(this.txtpsw);
            this.gbxAunthenticate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAunthenticate.ForeColor = System.Drawing.Color.White;
            this.gbxAunthenticate.Location = new System.Drawing.Point(804, 370);
            this.gbxAunthenticate.Name = "gbxAunthenticate";
            this.gbxAunthenticate.Size = new System.Drawing.Size(212, 113);
            this.gbxAunthenticate.TabIndex = 5;
            this.gbxAunthenticate.TabStop = false;
            this.gbxAunthenticate.Text = "Authenticate";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 78);
            this.progressBar1.MarqueeAnimationSpeed = 40;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(102, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(65, 114);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 14;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogin.Location = new System.Drawing.Point(132, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 30);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblpsw
            // 
            this.lblpsw.AutoSize = true;
            this.lblpsw.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpsw.Location = new System.Drawing.Point(11, 53);
            this.lblpsw.Name = "lblpsw";
            this.lblpsw.Size = new System.Drawing.Size(63, 20);
            this.lblpsw.TabIndex = 12;
            this.lblpsw.Text = "Password";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.Location = new System.Drawing.Point(21, 24);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(53, 20);
            this.lblLoginName.TabIndex = 11;
            this.lblLoginName.Text = "Login Id";
            // 
            // txtLoginId
            // 
            this.txtLoginId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoginId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginId.Location = new System.Drawing.Point(88, 22);
            this.txtLoginId.MaxLength = 10;
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(107, 22);
            this.txtLoginId.TabIndex = 7;
            // 
            // txtpsw
            // 
            this.txtpsw.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpsw.Location = new System.Drawing.Point(88, 48);
            this.txtpsw.Name = "txtpsw";
            this.txtpsw.PasswordChar = '*';
            this.txtpsw.Size = new System.Drawing.Size(107, 22);
            this.txtpsw.TabIndex = 8;
            this.txtpsw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpsw_KeyDown);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // tmm_Sales
            // 
            this.tmm_Sales.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_POS,
            this.rsm_SaleRegister,
            this.rsm_Reports,
            this.rsm_CreditConsumption,
            this.rsm_CancelBill,
            this.rsm_Kot,
            this.rsm_TokenDisplay,
            this.rsm_Tat,
            this.rsm_ApproveCancellation});
            this.tmm_Sales.Name = "tmm_Sales";
            this.tmm_Sales.Text = "Sale";
            // 
            // rsm_POS
            // 
            this.rsm_POS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_POS.Name = "rsm_POS";
            this.rsm_POS.Text = "Point Of Sale (Pos)";
            this.rsm_POS.Click += new System.EventHandler(this.rsm_POS_Click);
            // 
            // rsm_SaleRegister
            // 
            this.rsm_SaleRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_SaleRegister.Name = "rsm_SaleRegister";
            this.rsm_SaleRegister.Text = "Sale Register";
            this.rsm_SaleRegister.Click += new System.EventHandler(this.rsm_SaleRegister_Click);
            // 
            // rsm_Reports
            // 
            this.rsm_Reports.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_Reports.Name = "rsm_Reports";
            this.rsm_Reports.Text = "Reports";
            this.rsm_Reports.Click += new System.EventHandler(this.rsm_Reports_Click);
            // 
            // rsm_CreditConsumption
            // 
            this.rsm_CreditConsumption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_CreditConsumption.Name = "rsm_CreditConsumption";
            this.rsm_CreditConsumption.Text = "Credit Party Consumtion Report";
            this.rsm_CreditConsumption.Click += new System.EventHandler(this.rsm_CreditConsumption_Click);
            // 
            // rsm_CancelBill
            // 
            this.rsm_CancelBill.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_CancelBill.Name = "rsm_CancelBill";
            this.rsm_CancelBill.Text = "Cancel Bill";
            this.rsm_CancelBill.Click += new System.EventHandler(this.rsm_CancelBill_Click);
            // 
            // rsm_Kot
            // 
            this.rsm_Kot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_Kot.Name = "rsm_Kot";
            this.rsm_Kot.Text = "KOT";
            this.rsm_Kot.Click += new System.EventHandler(this.rsm_Kot_Click);
            // 
            // rsm_TokenDisplay
            // 
            this.rsm_TokenDisplay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_TokenDisplay.Name = "rsm_TokenDisplay";
            this.rsm_TokenDisplay.Text = "Token Display";
            this.rsm_TokenDisplay.Click += new System.EventHandler(this.rsm_TokenDisplay_Click);
            // 
            // rsm_Tat
            // 
            this.rsm_Tat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_Tat.Name = "rsm_Tat";
            this.rsm_Tat.Text = "TAT Report";
            this.rsm_Tat.Click += new System.EventHandler(this.rsm_Tat_Click);
            // 
            // tmm_Master
            // 
            this.tmm_Master.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_Product,
            this.rsm_Vendor});
            this.tmm_Master.Name = "tmm_Master";
            this.tmm_Master.Text = "Master";
            // 
            // rsm_Product
            // 
            this.rsm_Product.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_Product.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rssm_NewProduct});
            this.rsm_Product.Name = "rsm_Product";
            this.rsm_Product.Text = "Product";
            // 
            // rssm_NewProduct
            // 
            this.rssm_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rssm_NewProduct.Name = "rssm_NewProduct";
            this.rssm_NewProduct.Text = "New Product";
            this.rssm_NewProduct.Click += new System.EventHandler(this.rssm_NewProduct_Click);
            // 
            // rsm_Vendor
            // 
            this.rsm_Vendor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_Vendor.Name = "rsm_Vendor";
            this.rsm_Vendor.Text = "Vendor";
            this.rsm_Vendor.Click += new System.EventHandler(this.rsm_Vendor_Click);
            // 
            // tmm_Purchase
            // 
            this.tmm_Purchase.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_PurchaseFeeding,
            this.rsm_PurchaseBill});
            this.tmm_Purchase.Name = "tmm_Purchase";
            this.tmm_Purchase.Text = "Purchase";
            // 
            // rsm_PurchaseFeeding
            // 
            this.rsm_PurchaseFeeding.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_PurchaseFeeding.Name = "rsm_PurchaseFeeding";
            this.rsm_PurchaseFeeding.Text = "Purchase Feeding";
            this.rsm_PurchaseFeeding.Click += new System.EventHandler(this.rsm_PurchaseFeeding_Click);
            // 
            // rsm_PurchaseBill
            // 
            this.rsm_PurchaseBill.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_PurchaseBill.Name = "rsm_PurchaseBill";
            this.rsm_PurchaseBill.Text = "Purchase Bills";
            this.rsm_PurchaseBill.Click += new System.EventHandler(this.rsm_PurchaseBill_Click);
            // 
            // tmm_IssueProduct
            // 
            this.tmm_IssueProduct.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_IssueProduct});
            this.tmm_IssueProduct.Name = "tmm_IssueProduct";
            this.tmm_IssueProduct.Text = "Issue Product";
            // 
            // rsm_IssueProduct
            // 
            this.rsm_IssueProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_IssueProduct.Name = "rsm_IssueProduct";
            this.rsm_IssueProduct.Text = "Issue Product";
            this.rsm_IssueProduct.Click += new System.EventHandler(this.rsm_IssueProduct_Click);
            // 
            // tmm_Stocks
            // 
            this.tmm_Stocks.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_UnitStocks});
            this.tmm_Stocks.Name = "tmm_Stocks";
            this.tmm_Stocks.Text = "Stocks";
            // 
            // rsm_UnitStocks
            // 
            this.rsm_UnitStocks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_UnitStocks.Name = "rsm_UnitStocks";
            this.rsm_UnitStocks.Text = "Unit Stocks";
            this.rsm_UnitStocks.Click += new System.EventHandler(this.rsm_UnitStocks_Click);
            // 
            // tmm_Accounts
            // 
            this.tmm_Accounts.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_AccountsInfo,
            this.rsm_AmtReceiveFromStaff});
            this.tmm_Accounts.Name = "tmm_Accounts";
            this.tmm_Accounts.Text = "Accounts";
            // 
            // rsm_AccountsInfo
            // 
            this.rsm_AccountsInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_AccountsInfo.Name = "rsm_AccountsInfo";
            this.rsm_AccountsInfo.Text = "Accounts Info";
            this.rsm_AccountsInfo.Click += new System.EventHandler(this.rsm_AccountsInfo_Click);
            // 
            // rsm_AmtReceiveFromStaff
            // 
            this.rsm_AmtReceiveFromStaff.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_AmtReceiveFromStaff.Name = "rsm_AmtReceiveFromStaff";
            this.rsm_AmtReceiveFromStaff.Text = "Amount Receive From Staff";
            this.rsm_AmtReceiveFromStaff.Click += new System.EventHandler(this.rsm_AmtReceiveFromStaff_Click);
            // 
            // trm_Audit
            // 
            this.trm_Audit.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_AuditStock});
            this.trm_Audit.Name = "trm_Audit";
            this.trm_Audit.Text = "Audit";
            // 
            // rsm_AuditStock
            // 
            this.rsm_AuditStock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_AuditStock.Name = "rsm_AuditStock";
            this.rsm_AuditStock.Text = "Audit Stocks";
            this.rsm_AuditStock.Click += new System.EventHandler(this.rsm_AuditStock_Click);
            // 
            // trm_Utility
            // 
            this.trm_Utility.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rsm_UpdateSoftware,
            this.rsm_BuildMenu,
            this.rsm_LoginRights});
            this.trm_Utility.Name = "trm_Utility";
            this.trm_Utility.Text = "Utility";
            // 
            // rsm_UpdateSoftware
            // 
            this.rsm_UpdateSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsm_UpdateSoftware.Name = "rsm_UpdateSoftware";
            this.rsm_UpdateSoftware.Text = "Update Software";
            this.rsm_UpdateSoftware.Click += new System.EventHandler(this.rsm_UpdateSoftware_Click);
            // 
            // rsm_BuildMenu
            // 
            this.rsm_BuildMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsm_BuildMenu.Name = "rsm_BuildMenu";
            this.rsm_BuildMenu.Text = "Build Menu";
            this.rsm_BuildMenu.Click += new System.EventHandler(this.rsm_BuildMenu_Click);
            // 
            // rsm_LoginRights
            // 
            this.rsm_LoginRights.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_LoginRights.Name = "rsm_LoginRights";
            this.rsm_LoginRights.Text = "Login Rights";
            this.rsm_LoginRights.Click += new System.EventHandler(this.rsm_LoginRights_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Enabled = false;
            this.mainMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tmm_Sales,
            this.tmm_Master,
            this.tmm_Purchase,
            this.tmm_IssueProduct,
            this.tmm_Stocks,
            this.tmm_Accounts,
            this.trm_Audit,
            this.trm_Utility});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1028, 20);
            this.mainMenu.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eChandanCanteen.Properties.Resources.canteen;
            this.pictureBox1.Location = new System.Drawing.Point(382, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 173);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // rsm_ApproveCancellation
            // 
            this.rsm_ApproveCancellation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rsm_ApproveCancellation.Name = "rsm_ApproveCancellation";
            this.rsm_ApproveCancellation.Text = "Approve Cancellation";
            this.rsm_ApproveCancellation.Click += new System.EventHandler(this.rsm_ApproveCancellation_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1028, 518);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxAunthenticate);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canteen Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.gbxAunthenticate.ResumeLayout(false);
            this.gbxAunthenticate.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAunthenticate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblpsw;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtpsw;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadMenuItem tmm_Sales;
        private Telerik.WinControls.UI.RadMenuItem rsm_POS;
        private Telerik.WinControls.UI.RadMenuItem rsm_SaleRegister;
        private Telerik.WinControls.UI.RadMenuItem rsm_Reports;
        private Telerik.WinControls.UI.RadMenuItem rsm_CreditConsumption;
        private Telerik.WinControls.UI.RadMenuItem rsm_CancelBill;
        private Telerik.WinControls.UI.RadMenuItem rsm_Kot;
        private Telerik.WinControls.UI.RadMenuItem rsm_TokenDisplay;
        private Telerik.WinControls.UI.RadMenuItem rsm_Tat;
        private Telerik.WinControls.UI.RadMenuItem tmm_Master;
        private Telerik.WinControls.UI.RadMenuItem rsm_Product;
        private Telerik.WinControls.UI.RadMenuItem rssm_NewProduct;
        private Telerik.WinControls.UI.RadMenuItem rsm_Vendor;
        private Telerik.WinControls.UI.RadMenuItem tmm_Purchase;
        private Telerik.WinControls.UI.RadMenuItem tmm_IssueProduct;
        private Telerik.WinControls.UI.RadMenuItem tmm_Stocks;
        private Telerik.WinControls.UI.RadMenuItem tmm_Accounts;
        private Telerik.WinControls.UI.RadMenuItem trm_Audit;
        private Telerik.WinControls.UI.RadMenuItem trm_Utility;
        private Telerik.WinControls.UI.RadMenuItem rsm_PurchaseFeeding;
        private Telerik.WinControls.UI.RadMenuItem rsm_PurchaseBill;
        private Telerik.WinControls.UI.RadMenuItem rsm_IssueProduct;
        private Telerik.WinControls.UI.RadMenuItem rsm_UnitStocks;
        private Telerik.WinControls.UI.RadMenuItem rsm_AccountsInfo;
        private Telerik.WinControls.UI.RadMenuItem rsm_AmtReceiveFromStaff;
        private Telerik.WinControls.UI.RadMenuItem rsm_AuditStock;
        private Telerik.WinControls.UI.RadMenuItem rsm_UpdateSoftware;
        private Telerik.WinControls.UI.RadMenuItem rsm_BuildMenu;
        private Telerik.WinControls.UI.RadMenuItem rsm_LoginRights;
        private Telerik.WinControls.UI.RadMenu mainMenu;
        private Telerik.WinControls.UI.RadMenuItem rsm_ApproveCancellation;
    }
}

