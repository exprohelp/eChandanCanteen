namespace eInventory.InternalMail


{
    partial class NewAssignment
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Old = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.btnOpenDoc = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lv_WorkersWork = new System.Windows.Forms.ListView();
            this.jobId = new System.Windows.Forms.ColumnHeader();
            this.Subject = new System.Windows.Forms.ColumnHeader();
            this.jobdate = new System.Windows.Forms.ColumnHeader();
            this.targetdate = new System.Windows.Forms.ColumnHeader();
            this.finishdate = new System.Windows.Forms.ColumnHeader();
            this.Tab_New = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_AssignedWork = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Tab_Old.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.Tab_New.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Old);
            this.tabControl1.Controls.Add(this.Tab_New);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 481);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Tab_Old
            // 
            this.Tab_Old.BackColor = System.Drawing.Color.LightBlue;
            this.Tab_Old.Controls.Add(this.groupBox5);
            this.Tab_Old.Controls.Add(this.groupBox7);
            this.Tab_Old.Location = new System.Drawing.Point(4, 24);
            this.Tab_Old.Name = "Tab_Old";
            this.Tab_Old.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Old.Size = new System.Drawing.Size(751, 453);
            this.Tab_Old.TabIndex = 1;
            this.Tab_Old.Text = "Create New Job";
            this.Tab_Old.Click += new System.EventHandler(this.Tab_Old_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox5.Controls.Add(this.txtSubject);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.txtDescription);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(8, 163);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(737, 266);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Press [ CTRL+N ] to Create New Job";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.Silver;
            this.txtSubject.Location = new System.Drawing.Point(10, 40);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(721, 23);
            this.txtSubject.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveJob);
            this.groupBox3.Controls.Add(this.btnOpenDoc);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(461, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 58);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Upload Document Section";
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSaveJob.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveJob.ForeColor = System.Drawing.Color.White;
            this.btnSaveJob.Location = new System.Drawing.Point(156, 17);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(60, 31);
            this.btnSaveJob.TabIndex = 15;
            this.btnSaveJob.Text = "Transfer";
            this.btnSaveJob.UseVisualStyleBackColor = false;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOpenDoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpenDoc.ForeColor = System.Drawing.Color.White;
            this.btnOpenDoc.Location = new System.Drawing.Point(9, 19);
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Size = new System.Drawing.Size(70, 29);
            this.btnOpenDoc.TabIndex = 15;
            this.btnOpenDoc.Text = "Browse ";
            this.btnOpenDoc.UseVisualStyleBackColor = false;
            this.btnOpenDoc.Click += new System.EventHandler(this.btnOpenDoc_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkUrgent);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(34, 200);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 59);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Priority Level";
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(12, 22);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(64, 19);
            this.chkUrgent.TabIndex = 0;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescription.Location = new System.Drawing.Point(8, 86);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(723, 103);
            this.txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subject ";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox7.Controls.Add(this.lv_WorkersWork);
            this.groupBox7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox7.Location = new System.Drawing.Point(6, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(739, 154);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Job in Queue [Selected Workers]";
            // 
            // lv_WorkersWork
            // 
            this.lv_WorkersWork.BackColor = System.Drawing.Color.LightBlue;
            this.lv_WorkersWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jobId,
            this.Subject,
            this.jobdate,
            this.targetdate,
            this.finishdate});
            this.lv_WorkersWork.Font = new System.Drawing.Font("Calibri", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_WorkersWork.ForeColor = System.Drawing.Color.Black;
            this.lv_WorkersWork.FullRowSelect = true;
            this.lv_WorkersWork.GridLines = true;
            this.lv_WorkersWork.Location = new System.Drawing.Point(5, 21);
            this.lv_WorkersWork.Name = "lv_WorkersWork";
            this.lv_WorkersWork.Size = new System.Drawing.Size(728, 125);
            this.lv_WorkersWork.TabIndex = 0;
            this.lv_WorkersWork.UseCompatibleStateImageBehavior = false;
            this.lv_WorkersWork.View = System.Windows.Forms.View.Details;
            this.lv_WorkersWork.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_WorkersWork_ItemSelectionChanged);
            this.lv_WorkersWork.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_WorkersWork_KeyDown);
            // 
            // jobId
            // 
            this.jobId.Text = "jobid";
            this.jobId.Width = 1;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 391;
            // 
            // jobdate
            // 
            this.jobdate.Text = "Job Date";
            this.jobdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jobdate.Width = 100;
            // 
            // targetdate
            // 
            this.targetdate.Text = "Target Date";
            this.targetdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.targetdate.Width = 100;
            // 
            // finishdate
            // 
            this.finishdate.Text = "FinishDate";
            this.finishdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finishdate.Width = 111;
            // 
            // Tab_New
            // 
            this.Tab_New.BackColor = System.Drawing.Color.LightBlue;
            this.Tab_New.Controls.Add(this.label1);
            this.Tab_New.Controls.Add(this.txtDetail);
            this.Tab_New.Controls.Add(this.panel1);
            this.Tab_New.Controls.Add(this.groupBox1);
            this.Tab_New.Location = new System.Drawing.Point(4, 24);
            this.Tab_New.Name = "Tab_New";
            this.Tab_New.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_New.Size = new System.Drawing.Size(751, 453);
            this.Tab_New.TabIndex = 0;
            this.Tab_New.Text = "Assigned Job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Job Detail";
            // 
            // txtDetail
            // 
            this.txtDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDetail.Location = new System.Drawing.Point(13, 194);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(723, 76);
            this.txtDetail.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 148);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.lv_AssignedWork);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job in Queue [Selected Workers]";
            // 
            // lv_AssignedWork
            // 
            this.lv_AssignedWork.BackColor = System.Drawing.Color.LightBlue;
            this.lv_AssignedWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_AssignedWork.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_AssignedWork.ForeColor = System.Drawing.Color.Maroon;
            this.lv_AssignedWork.FullRowSelect = true;
            this.lv_AssignedWork.GridLines = true;
            this.lv_AssignedWork.Location = new System.Drawing.Point(4, 19);
            this.lv_AssignedWork.Name = "lv_AssignedWork";
            this.lv_AssignedWork.Size = new System.Drawing.Size(726, 133);
            this.lv_AssignedWork.TabIndex = 1;
            this.lv_AssignedWork.UseCompatibleStateImageBehavior = false;
            this.lv_AssignedWork.View = System.Windows.Forms.View.Details;
            this.lv_AssignedWork.SelectedIndexChanged += new System.EventHandler(this.lv_AssignedWork_SelectedIndexChanged);
            this.lv_AssignedWork.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_AssignedWork_ItemSelectionChanged);
            this.lv_AssignedWork.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_AssignedWork_KeyDown);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "jobid";
            this.columnHeader3.Width = 1;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject";
            this.columnHeader4.Width = 401;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Job Date";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Target Date";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Finish Date";
            this.columnHeader7.Width = 100;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(634, 486);
            this.progressBar1.Maximum = 70;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(132, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // NewAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(771, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "NewAssignment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information To IT Division";
            this.Load += new System.EventHandler(this.NewAssignment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewAssignment_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.Tab_Old.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.Tab_New.ResumeLayout(false);
            this.Tab_New.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_New;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Tab_Old;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView lv_WorkersWork;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader jobdate;
        private System.Windows.Forms.ColumnHeader finishdate;
        private System.Windows.Forms.ColumnHeader jobId;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSaveJob;
        private System.Windows.Forms.ListView lv_AssignedWork;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOpenDoc;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader targetdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label1;

    }
}