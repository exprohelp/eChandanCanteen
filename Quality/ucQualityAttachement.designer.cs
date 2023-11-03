namespace eChandanCanteen
{
    partial class ucQualityAttachement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewApp = new System.Windows.Forms.Button();
            this.dtAppTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtAppFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lvComplaint = new System.Windows.Forms.ListView();
            this.COMPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PATIENTID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SUBJECT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COMPLAINTBY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LOGINBY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CRDATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnReSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewApp);
            this.groupBox1.Controls.Add(this.dtAppTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtAppFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 41);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnViewApp
            // 
            this.btnViewApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnViewApp.ForeColor = System.Drawing.Color.White;
            this.btnViewApp.Location = new System.Drawing.Point(846, 11);
            this.btnViewApp.Name = "btnViewApp";
            this.btnViewApp.Size = new System.Drawing.Size(88, 27);
            this.btnViewApp.TabIndex = 7;
            this.btnViewApp.Text = "View Report";
            this.btnViewApp.UseVisualStyleBackColor = false;
            this.btnViewApp.Click += new System.EventHandler(this.btnViewApp_Click);
            // 
            // dtAppTo
            // 
            this.dtAppTo.CustomFormat = "dd/MM/yyyy";
            this.dtAppTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAppTo.Location = new System.Drawing.Point(195, 15);
            this.dtAppTo.Name = "dtAppTo";
            this.dtAppTo.Size = new System.Drawing.Size(102, 20);
            this.dtAppTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtAppFrom
            // 
            this.dtAppFrom.CustomFormat = "dd/MM/yyyy";
            this.dtAppFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAppFrom.Location = new System.Drawing.Point(48, 15);
            this.dtAppFrom.Name = "dtAppFrom";
            this.dtAppFrom.Size = new System.Drawing.Size(114, 20);
            this.dtAppFrom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "From";
            // 
            // lvComplaint
            // 
            this.lvComplaint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.COMPID,
            this.PATIENTID,
            this.SUBJECT,
            this.COMPLAINTBY,
            this.LOGINBY,
            this.contact_no,
            this.CRDATE});
            this.lvComplaint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvComplaint.FullRowSelect = true;
            this.lvComplaint.GridLines = true;
            this.lvComplaint.HideSelection = false;
            this.lvComplaint.Location = new System.Drawing.Point(7, 47);
            this.lvComplaint.Name = "lvComplaint";
            this.lvComplaint.Size = new System.Drawing.Size(957, 249);
            this.lvComplaint.TabIndex = 13;
            this.lvComplaint.UseCompatibleStateImageBehavior = false;
            this.lvComplaint.View = System.Windows.Forms.View.Details;
            this.lvComplaint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvComplaint_KeyDown);
            this.lvComplaint.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvComplaint_MouseDoubleClick);
            // 
            // COMPID
            // 
            this.COMPID.Width = 0;
            // 
            // PATIENTID
            // 
            this.PATIENTID.Text = "PATIENT ID";
            this.PATIENTID.Width = 118;
            // 
            // SUBJECT
            // 
            this.SUBJECT.Text = "SUBJECT";
            this.SUBJECT.Width = 405;
            // 
            // COMPLAINTBY
            // 
            this.COMPLAINTBY.Text = "COMPLAINT BY";
            this.COMPLAINTBY.Width = 117;
            // 
            // LOGINBY
            // 
            this.LOGINBY.Text = "login by";
            this.LOGINBY.Width = 111;
            // 
            // contact_no
            // 
            this.contact_no.Text = "Contact No";
            this.contact_no.Width = 90;
            // 
            // CRDATE
            // 
            this.CRDATE.Text = "CR DATE";
            this.CRDATE.Width = 93;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(7, 443);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(957, 82);
            this.txtRemark.TabIndex = 168;
            // 
            // lvDetail
            // 
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader6});
            this.lvDetail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDetail.FullRowSelect = true;
            this.lvDetail.GridLines = true;
            this.lvDetail.HideSelection = false;
            this.lvDetail.Location = new System.Drawing.Point(7, 302);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(957, 118);
            this.lvDetail.TabIndex = 169;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            this.lvDetail.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDetail_ItemSelectionChanged);
            this.lvDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvDetail_KeyDown);
            this.lvDetail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDetail_MouseDoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "S.N.";
            this.columnHeader10.Width = 35;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "REMARK";
            this.columnHeader4.Width = 651;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Remark By";
            this.columnHeader5.Width = 153;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CR DATE";
            this.columnHeader8.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "docpath";
            this.columnHeader6.Width = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 170;
            this.label1.Text = "REMARK";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(699, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 15);
            this.label4.TabIndex = 171;
            this.label4.Text = "Enter On Selected Remark to download attachment";
            // 
            // txtPath1
            // 
            this.txtPath1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath1.Enabled = false;
            this.txtPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath1.Location = new System.Drawing.Point(7, 531);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.ReadOnly = true;
            this.txtPath1.Size = new System.Drawing.Size(771, 22);
            this.txtPath1.TabIndex = 174;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse1.ForeColor = System.Drawing.Color.White;
            this.btnBrowse1.Location = new System.Drawing.Point(784, 529);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(78, 24);
            this.btnBrowse1.TabIndex = 173;
            this.btnBrowse1.Text = "BROWSE";
            this.btnBrowse1.UseVisualStyleBackColor = false;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnReSend
            // 
            this.btnReSend.BackColor = System.Drawing.Color.Teal;
            this.btnReSend.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReSend.ForeColor = System.Drawing.Color.White;
            this.btnReSend.Location = new System.Drawing.Point(901, 527);
            this.btnReSend.Name = "btnReSend";
            this.btnReSend.Size = new System.Drawing.Size(63, 27);
            this.btnReSend.TabIndex = 172;
            this.btnReSend.Text = "SEND";
            this.btnReSend.UseVisualStyleBackColor = false;
            this.btnReSend.Click += new System.EventHandler(this.btnReSend_Click);
            // 
            // ucQualityAttachement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.btnReSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDetail);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lvComplaint);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucQualityAttachement";
            this.Size = new System.Drawing.Size(968, 577);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewApp;
        internal System.Windows.Forms.DateTimePicker dtAppTo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DateTimePicker dtAppFrom;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvComplaint;
        private System.Windows.Forms.ColumnHeader PATIENTID;
        private System.Windows.Forms.ColumnHeader SUBJECT;
        private System.Windows.Forms.ColumnHeader COMPLAINTBY;
        private System.Windows.Forms.ColumnHeader COMPID;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader CRDATE;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader LOGINBY;
        private System.Windows.Forms.ColumnHeader contact_no;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnReSend;
    }
}
