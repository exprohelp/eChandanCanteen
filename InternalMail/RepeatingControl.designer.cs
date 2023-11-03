namespace eInventory
{
    partial class RepeatingControl
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
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblFromTo = new System.Windows.Forms.Label();
            this.txtConv = new System.Windows.Forms.RichTextBox();
            this.LinkDownload = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(15, 4);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(60, 15);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "DateTime";
            // 
            // lblFromTo
            // 
            this.lblFromTo.AutoSize = true;
            this.lblFromTo.Location = new System.Drawing.Point(16, 23);
            this.lblFromTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromTo.Name = "lblFromTo";
            this.lblFromTo.Size = new System.Drawing.Size(48, 15);
            this.lblFromTo.TabIndex = 1;
            this.lblFromTo.Text = "FromTo";
            // 
            // txtConv
            // 
            this.txtConv.Location = new System.Drawing.Point(19, 41);
            this.txtConv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConv.Name = "txtConv";
            this.txtConv.Size = new System.Drawing.Size(547, 66);
            this.txtConv.TabIndex = 2;
            this.txtConv.Text = "";
            // 
            // LinkDownload
            // 
            this.LinkDownload.AutoSize = true;
            this.LinkDownload.Location = new System.Drawing.Point(17, 109);
            this.LinkDownload.Name = "LinkDownload";
            this.LinkDownload.Size = new System.Drawing.Size(62, 15);
            this.LinkDownload.TabIndex = 3;
            this.LinkDownload.TabStop = true;
            this.LinkDownload.Text = "linkLabel1";
            this.LinkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkDownload_LinkClicked);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(465, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // RepeatingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LinkDownload);
            this.Controls.Add(this.txtConv);
            this.Controls.Add(this.lblFromTo);
            this.Controls.Add(this.lblDateTime);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RepeatingControl";
            this.Size = new System.Drawing.Size(577, 136);
            this.Load += new System.EventHandler(this.RepeatingControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblFromTo;
        private System.Windows.Forms.RichTextBox txtConv;
        private System.Windows.Forms.LinkLabel LinkDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
