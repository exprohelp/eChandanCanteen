namespace eChandanCanteen
{
    partial class UpdateBestRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBestRate));
            this.cb_items = new System.Windows.Forms.ComboBox();
            this.lv_BestRate = new System.Windows.Forms.ListView();
            this.br_vendcode = new System.Windows.Forms.ColumnHeader();
            this.br_mfdid = new System.Windows.Forms.ColumnHeader();
            this.br_mfdname = new System.Windows.Forms.ColumnHeader();
            this.br_packsize = new System.Windows.Forms.ColumnHeader();
            this.br_packqty = new System.Windows.Forms.ColumnHeader();
            this.br_apprate = new System.Windows.Forms.ColumnHeader();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.auto_id = new System.Windows.Forms.ColumnHeader();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_items
            // 
            this.cb_items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_items.FormattingEnabled = true;
            this.cb_items.Location = new System.Drawing.Point(1, 1);
            this.cb_items.Name = "cb_items";
            this.cb_items.Size = new System.Drawing.Size(286, 501);
            this.cb_items.TabIndex = 0;
            this.cb_items.SelectedIndexChanged += new System.EventHandler(this.cb_items_SelectedIndexChanged);
            // 
            // lv_BestRate
            // 
            this.lv_BestRate.BackColor = System.Drawing.Color.Teal;
            this.lv_BestRate.CheckBoxes = true;
            this.lv_BestRate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.br_vendcode,
            this.br_mfdid,
            this.br_mfdname,
            this.br_packsize,
            this.br_packqty,
            this.br_apprate,
            this.auto_id});
            this.lv_BestRate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_BestRate.ForeColor = System.Drawing.Color.White;
            this.lv_BestRate.FullRowSelect = true;
            this.lv_BestRate.GridLines = true;
            this.lv_BestRate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_BestRate.Location = new System.Drawing.Point(6, 18);
            this.lv_BestRate.Name = "lv_BestRate";
            this.lv_BestRate.Size = new System.Drawing.Size(311, 451);
            this.lv_BestRate.TabIndex = 3;
            this.lv_BestRate.UseCompatibleStateImageBehavior = false;
            this.lv_BestRate.View = System.Windows.Forms.View.Details;
            this.lv_BestRate.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_BestRate_ItemChecked);
            this.lv_BestRate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_BestRate_MouseDown);
            this.lv_BestRate.Click += new System.EventHandler(this.lv_BestRate_Click);
            // 
            // br_vendcode
            // 
            this.br_vendcode.Text = "Tick";
            this.br_vendcode.Width = 16;
            // 
            // br_mfdid
            // 
            this.br_mfdid.Text = "mfdid";
            this.br_mfdid.Width = 0;
            // 
            // br_mfdname
            // 
            this.br_mfdname.Text = "Manufacture";
            this.br_mfdname.Width = 100;
            // 
            // br_packsize
            // 
            this.br_packsize.Text = "Pack Size";
            this.br_packsize.Width = 86;
            // 
            // br_packqty
            // 
            this.br_packqty.Text = "PQty";
            this.br_packqty.Width = 43;
            // 
            // br_apprate
            // 
            this.br_apprate.Text = "Rate";
            this.br_apprate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.br_apprate.Width = 48;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lv_BestRate);
            this.gb1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(293, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(322, 478);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "[XXXXXXXXXXXXX]";
            // 
            // auto_id
            // 
            this.auto_id.Text = "autoid";
            this.auto_id.Width = 0;
            // 
            // UpdateBestRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(621, 502);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.cb_items);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateBestRate";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Best Rate of a Product With Their Size";
            this.Load += new System.EventHandler(this.UpdateBestRate_Load);
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_items;
        private System.Windows.Forms.ListView lv_BestRate;
        private System.Windows.Forms.ColumnHeader br_vendcode;
        private System.Windows.Forms.ColumnHeader br_mfdid;
        private System.Windows.Forms.ColumnHeader br_mfdname;
        private System.Windows.Forms.ColumnHeader br_packsize;
        private System.Windows.Forms.ColumnHeader br_packqty;
        private System.Windows.Forms.ColumnHeader br_apprate;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.ColumnHeader auto_id;

    }
}