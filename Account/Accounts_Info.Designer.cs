namespace eChandanCanteen.Account
{
    partial class Accounts_Info
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
            this.pnl_control = new System.Windows.Forms.Panel();
            this.pnl_options = new System.Windows.Forms.Panel();
            this.btn_Contra = new System.Windows.Forms.Button();
            this.btn_Journal = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_Receipt = new System.Windows.Forms.Button();
            this.btn_accounts = new System.Windows.Forms.Button();
            this.btn_merge = new System.Windows.Forms.Button();
            this.btn_ChangeUnit = new System.Windows.Forms.Button();
            this.pnl_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_control.Location = new System.Drawing.Point(128, 2);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(990, 510);
            this.pnl_control.TabIndex = 0;
            // 
            // pnl_options
            // 
            this.pnl_options.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_options.Controls.Add(this.btn_ChangeUnit);
            this.pnl_options.Controls.Add(this.btn_merge);
            this.pnl_options.Controls.Add(this.btn_accounts);
            this.pnl_options.Controls.Add(this.btn_Receipt);
            this.pnl_options.Controls.Add(this.btn_payment);
            this.pnl_options.Controls.Add(this.btn_Journal);
            this.pnl_options.Controls.Add(this.btn_Contra);
            this.pnl_options.Location = new System.Drawing.Point(2, 2);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(121, 510);
            this.pnl_options.TabIndex = 1;
            // 
            // btn_Contra
            // 
            this.btn_Contra.BackColor = System.Drawing.Color.White;
            this.btn_Contra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contra.Location = new System.Drawing.Point(1, 3);
            this.btn_Contra.Name = "btn_Contra";
            this.btn_Contra.Size = new System.Drawing.Size(117, 30);
            this.btn_Contra.TabIndex = 0;
            this.btn_Contra.Text = "Contra";
            this.btn_Contra.UseVisualStyleBackColor = false;
            this.btn_Contra.Click += new System.EventHandler(this.btn_Contra_Click);
            // 
            // btn_Journal
            // 
            this.btn_Journal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Journal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Journal.Location = new System.Drawing.Point(0, 32);
            this.btn_Journal.Name = "btn_Journal";
            this.btn_Journal.Size = new System.Drawing.Size(117, 30);
            this.btn_Journal.TabIndex = 1;
            this.btn_Journal.Text = "Journal";
            this.btn_Journal.UseVisualStyleBackColor = false;
            this.btn_Journal.Click += new System.EventHandler(this.btn_Journal_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.LightYellow;
            this.btn_payment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Location = new System.Drawing.Point(0, 62);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(117, 30);
            this.btn_payment.TabIndex = 2;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_Receipt
            // 
            this.btn_Receipt.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Receipt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Receipt.Location = new System.Drawing.Point(1, 92);
            this.btn_Receipt.Name = "btn_Receipt";
            this.btn_Receipt.Size = new System.Drawing.Size(117, 30);
            this.btn_Receipt.TabIndex = 3;
            this.btn_Receipt.Text = "Receipt";
            this.btn_Receipt.UseVisualStyleBackColor = false;
            this.btn_Receipt.Click += new System.EventHandler(this.btn_Receipt_Click);
            // 
            // btn_accounts
            // 
            this.btn_accounts.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_accounts.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accounts.Location = new System.Drawing.Point(1, 158);
            this.btn_accounts.Name = "btn_accounts";
            this.btn_accounts.Size = new System.Drawing.Size(117, 30);
            this.btn_accounts.TabIndex = 4;
            this.btn_accounts.Text = "Accounts Info";
            this.btn_accounts.UseVisualStyleBackColor = false;
            this.btn_accounts.Click += new System.EventHandler(this.btn_accounts_Click);
            // 
            // btn_merge
            // 
            this.btn_merge.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_merge.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_merge.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_merge.Location = new System.Drawing.Point(0, 223);
            this.btn_merge.Name = "btn_merge";
            this.btn_merge.Size = new System.Drawing.Size(117, 30);
            this.btn_merge.TabIndex = 5;
            this.btn_merge.Text = "Merge A/C";
            this.btn_merge.UseVisualStyleBackColor = false;
            // 
            // btn_ChangeUnit
            // 
            this.btn_ChangeUnit.BackColor = System.Drawing.Color.Salmon;
            this.btn_ChangeUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeUnit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_ChangeUnit.Location = new System.Drawing.Point(0, 256);
            this.btn_ChangeUnit.Name = "btn_ChangeUnit";
            this.btn_ChangeUnit.Size = new System.Drawing.Size(117, 30);
            this.btn_ChangeUnit.TabIndex = 6;
            this.btn_ChangeUnit.Text = "Change Unit";
            this.btn_ChangeUnit.UseVisualStyleBackColor = false;
            // 
            // Accounts_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 514);
            this.Controls.Add(this.pnl_options);
            this.Controls.Add(this.pnl_control);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Accounts_Info";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Accounting System ";
            this.Load += new System.EventHandler(this.Accounts_Info_Load);
            this.pnl_options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_control;
        private System.Windows.Forms.Panel pnl_options;
        private System.Windows.Forms.Button btn_Contra;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_Journal;
        private System.Windows.Forms.Button btn_Receipt;
        private System.Windows.Forms.Button btn_accounts;
        private System.Windows.Forms.Button btn_ChangeUnit;
        private System.Windows.Forms.Button btn_merge;
    }
}