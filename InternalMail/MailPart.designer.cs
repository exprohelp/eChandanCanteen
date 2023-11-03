namespace eInventory


{
    partial class MailPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_new = new System.Windows.Forms.TabPage();
            this.lv_new_mails = new System.Windows.Forms.ListView();
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AutoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Conv_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_old = new System.Windows.Forms.TabPage();
            this.lv_old_view = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_create = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtbrowse = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtConversation = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlPerson = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLookFor = new System.Windows.Forms.TextBox();
            this.Tab_Search = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lv_SearchMail = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCloseOldMail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl2.SuspendLayout();
            this.tab_new.SuspendLayout();
            this.tab_old.SuspendLayout();
            this.tab_create.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tab_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl2.Controls.Add(this.tab_new);
            this.tabControl2.Controls.Add(this.tab_old);
            this.tabControl2.Controls.Add(this.tab_create);
            this.tabControl2.Controls.Add(this.Tab_Search);
            this.tabControl2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(3, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(728, 464);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tab_new
            // 
            this.tab_new.BackColor = System.Drawing.Color.PowderBlue;
            this.tab_new.Controls.Add(this.lv_new_mails);
            this.tab_new.Location = new System.Drawing.Point(4, 23);
            this.tab_new.Name = "tab_new";
            this.tab_new.Padding = new System.Windows.Forms.Padding(3);
            this.tab_new.Size = new System.Drawing.Size(720, 437);
            this.tab_new.TabIndex = 0;
            this.tab_new.Text = "Current Mail";
            this.tab_new.UseVisualStyleBackColor = true;
            // 
            // lv_new_mails
            // 
            this.lv_new_mails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_new_mails.BackColor = System.Drawing.Color.PowderBlue;
            this.lv_new_mails.CheckBoxes = true;
            this.lv_new_mails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.From,
            this.To,
            this.Subject,
            this.status,
            this.date,
            this.AutoId,
            this.Conv_id});
            this.lv_new_mails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lv_new_mails.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_new_mails.FullRowSelect = true;
            this.lv_new_mails.GridLines = true;
            this.lv_new_mails.Location = new System.Drawing.Point(1, 2);
            this.lv_new_mails.Name = "lv_new_mails";
            this.lv_new_mails.Size = new System.Drawing.Size(719, 430);
            this.lv_new_mails.TabIndex = 0;
            this.lv_new_mails.UseCompatibleStateImageBehavior = false;
            this.lv_new_mails.View = System.Windows.Forms.View.Details;
            this.lv_new_mails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_new_mails_KeyDown);
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 127;
            // 
            // To
            // 
            this.To.Text = "To";
            this.To.Width = 99;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 265;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 110;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 87;
            // 
            // AutoId
            // 
            this.AutoId.Text = "AutoId";
            this.AutoId.Width = 0;
            // 
            // Conv_id
            // 
            this.Conv_id.Text = "Conv_id";
            this.Conv_id.Width = 0;
            // 
            // tab_old
            // 
            this.tab_old.BackColor = System.Drawing.Color.PowderBlue;
            this.tab_old.Controls.Add(this.lv_old_view);
            this.tab_old.Location = new System.Drawing.Point(4, 23);
            this.tab_old.Name = "tab_old";
            this.tab_old.Padding = new System.Windows.Forms.Padding(3);
            this.tab_old.Size = new System.Drawing.Size(720, 437);
            this.tab_old.TabIndex = 1;
            this.tab_old.Text = "Previous Mail";
            this.tab_old.UseVisualStyleBackColor = true;
            // 
            // lv_old_view
            // 
            this.lv_old_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_old_view.BackColor = System.Drawing.Color.PowderBlue;
            this.lv_old_view.CheckBoxes = true;
            this.lv_old_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6});
            this.lv_old_view.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_old_view.FullRowSelect = true;
            this.lv_old_view.GridLines = true;
            this.lv_old_view.Location = new System.Drawing.Point(-1, 2);
            this.lv_old_view.Name = "lv_old_view";
            this.lv_old_view.Size = new System.Drawing.Size(721, 553);
            this.lv_old_view.TabIndex = 1;
            this.lv_old_view.UseCompatibleStateImageBehavior = false;
            this.lv_old_view.View = System.Windows.Forms.View.Details;
            this.lv_old_view.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_old_view_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "To";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subject";
            this.columnHeader3.Width = 280;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "AutoId";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Conv_id";
            this.columnHeader6.Width = 0;
            // 
            // tab_create
            // 
            this.tab_create.BackColor = System.Drawing.Color.LightBlue;
            this.tab_create.Controls.Add(this.groupBox4);
            this.tab_create.Controls.Add(this.groupBox3);
            this.tab_create.Controls.Add(this.groupBox1);
            this.tab_create.ForeColor = System.Drawing.Color.Black;
            this.tab_create.Location = new System.Drawing.Point(4, 23);
            this.tab_create.Name = "tab_create";
            this.tab_create.Size = new System.Drawing.Size(720, 437);
            this.tab_create.TabIndex = 2;
            this.tab_create.Text = "Create Mail";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Controls.Add(this.btnBrowse);
            this.groupBox4.Controls.Add(this.txtbrowse);
            this.groupBox4.Location = new System.Drawing.Point(3, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(701, 62);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(643, 13);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(50, 43);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Black;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(563, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 28);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtbrowse
            // 
            this.txtbrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbrowse.Location = new System.Drawing.Point(132, 23);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(425, 22);
            this.txtbrowse.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtConversation);
            this.groupBox3.Controls.Add(this.txtSubject);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(5, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(698, 202);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtConversation
            // 
            this.txtConversation.Location = new System.Drawing.Point(133, 49);
            this.txtConversation.Name = "txtConversation";
            this.txtConversation.Size = new System.Drawing.Size(514, 138);
            this.txtConversation.TabIndex = 4;
            this.txtConversation.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Location = new System.Drawing.Point(132, 21);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(515, 22);
            this.txtSubject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conversation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ddlPerson);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLookFor);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ddlPerson
            // 
            this.ddlPerson.FormattingEnabled = true;
            this.ddlPerson.Location = new System.Drawing.Point(350, 19);
            this.ddlPerson.Name = "ddlPerson";
            this.ddlPerson.Size = new System.Drawing.Size(297, 22);
            this.ddlPerson.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Black;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(270, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(74, 27);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Look For :";
            // 
            // txtLookFor
            // 
            this.txtLookFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLookFor.Location = new System.Drawing.Point(132, 19);
            this.txtLookFor.Name = "txtLookFor";
            this.txtLookFor.Size = new System.Drawing.Size(127, 22);
            this.txtLookFor.TabIndex = 0;
            // 
            // Tab_Search
            // 
            this.Tab_Search.BackColor = System.Drawing.Color.LightBlue;
            this.Tab_Search.Controls.Add(this.btnSearch);
            this.Tab_Search.Controls.Add(this.label5);
            this.Tab_Search.Controls.Add(this.label4);
            this.Tab_Search.Controls.Add(this.dtTo);
            this.Tab_Search.Controls.Add(this.dtFrom);
            this.Tab_Search.Controls.Add(this.lv_SearchMail);
            this.Tab_Search.Location = new System.Drawing.Point(4, 23);
            this.Tab_Search.Name = "Tab_Search";
            this.Tab_Search.Size = new System.Drawing.Size(720, 437);
            this.Tab_Search.TabIndex = 3;
            this.Tab_Search.Text = "Search Mail";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(360, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(74, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "To Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "From Date";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(240, 6);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(112, 22);
            this.dtTo.TabIndex = 4;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(71, 6);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(109, 22);
            this.dtFrom.TabIndex = 3;
            this.dtFrom.Value = new System.DateTime(2009, 5, 30, 23, 27, 0, 0);
            this.dtFrom.Leave += new System.EventHandler(this.dtFrom_Leave);
            // 
            // lv_SearchMail
            // 
            this.lv_SearchMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_SearchMail.BackColor = System.Drawing.Color.PowderBlue;
            this.lv_SearchMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lv_SearchMail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_SearchMail.FullRowSelect = true;
            this.lv_SearchMail.GridLines = true;
            this.lv_SearchMail.Location = new System.Drawing.Point(0, 33);
            this.lv_SearchMail.Name = "lv_SearchMail";
            this.lv_SearchMail.Size = new System.Drawing.Size(733, 528);
            this.lv_SearchMail.TabIndex = 2;
            this.lv_SearchMail.UseCompatibleStateImageBehavior = false;
            this.lv_SearchMail.View = System.Windows.Forms.View.Details;
            this.lv_SearchMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_SearchMail_KeyDown);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "From";
            this.columnHeader8.Width = 112;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "To";
            this.columnHeader9.Width = 105;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Subject";
            this.columnHeader10.Width = 287;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Status";
            this.columnHeader11.Width = 101;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Date";
            this.columnHeader12.Width = 96;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "AutoId";
            this.columnHeader13.Width = 0;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Conv_id";
            this.columnHeader14.Width = 0;
            // 
            // btnCloseOldMail
            // 
            this.btnCloseOldMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseOldMail.BackColor = System.Drawing.Color.Black;
            this.btnCloseOldMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCloseOldMail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseOldMail.ForeColor = System.Drawing.Color.White;
            this.btnCloseOldMail.Location = new System.Drawing.Point(3, 472);
            this.btnCloseOldMail.Name = "btnCloseOldMail";
            this.btnCloseOldMail.Size = new System.Drawing.Size(79, 31);
            this.btnCloseOldMail.TabIndex = 11;
            this.btnCloseOldMail.Text = "Close";
            this.btnCloseOldMail.UseVisualStyleBackColor = false;
            this.btnCloseOldMail.Click += new System.EventHandler(this.btnCloseOldMail_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(3, 472);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 31);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(619, 476);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // MailPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(731, 504);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCloseOldMail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MailPart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Press \' F1\' to close and open ";
            this.Load += new System.EventHandler(this.MailPart_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MailPart_KeyDown);
            this.tabControl2.ResumeLayout(false);
            this.tab_new.ResumeLayout(false);
            this.tab_old.ResumeLayout(false);
            this.tab_create.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tab_Search.ResumeLayout(false);
            this.Tab_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_new;
        private System.Windows.Forms.ListView lv_new_mails;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader AutoId;
        private System.Windows.Forms.ColumnHeader Conv_id;
        private System.Windows.Forms.TabPage tab_old;
        private System.Windows.Forms.ListView lv_old_view;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tab_create;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtbrowse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtConversation;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLookFor;
        private System.Windows.Forms.TabPage Tab_Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.ListView lv_SearchMail;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnCloseOldMail;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}