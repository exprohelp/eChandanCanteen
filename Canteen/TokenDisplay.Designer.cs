namespace eChandanCanteen.Canteen
{
    partial class TokenDisplay
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
            this.nonFickeringPanel1 = new eChandanCanteen.Canteen.NonFickeringPanel();
            this.lblToken = new System.Windows.Forms.Label();
            this.MasterPanel = new eChandanCanteen.Canteen.NonFickeringPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nonFickeringPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // nonFickeringPanel1
            // 
            this.nonFickeringPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nonFickeringPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nonFickeringPanel1.Controls.Add(this.lblToken);
            this.nonFickeringPanel1.Location = new System.Drawing.Point(0, 1);
            this.nonFickeringPanel1.Name = "nonFickeringPanel1";
            this.nonFickeringPanel1.Size = new System.Drawing.Size(1135, 83);
            this.nonFickeringPanel1.TabIndex = 1;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold);
            this.lblToken.ForeColor = System.Drawing.Color.Lime;
            this.lblToken.Location = new System.Drawing.Point(366, 0);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(476, 81);
            this.lblToken.TabIndex = 0;
            this.lblToken.Text = "READY TOKENS";
            // 
            // MasterPanel
            // 
            this.MasterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MasterPanel.Location = new System.Drawing.Point(0, 81);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(1135, 539);
            this.MasterPanel.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // TokenDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 622);
            this.Controls.Add(this.nonFickeringPanel1);
            this.Controls.Add(this.MasterPanel);
            this.Name = "TokenDisplay";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TokenDisplay_Load);
            this.nonFickeringPanel1.ResumeLayout(false);
            this.nonFickeringPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NonFickeringPanel MasterPanel;
        private System.Windows.Forms.Label lblToken;
        private NonFickeringPanel nonFickeringPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
