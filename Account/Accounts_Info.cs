using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eChandanCanteen.Account
{
    public partial class Accounts_Info : Form
    {
        public Accounts_Info()
        {
            InitializeComponent();
        }

        private void Accounts_Info_Load(object sender, EventArgs e)
        {
            this.Text = "Accounting Information of unit : " + GlobalUsage.gUnitName;
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 120); 
        }

        private void btn_Contra_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            accounts_library.Contra_Voucher obj = new accounts_library.Contra_Voucher(GlobalUsage.gUnit_Id, "eAccounts", GlobalUsage.gLogin_id);
            pnl_control.Controls.Clear();
            pnl_control.Controls.Add(obj);
            Cursor.Current = Cursors.Default;
        }

        private void btn_Journal_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            accounts_library.Journal_Voucher obj = new accounts_library.Journal_Voucher(GlobalUsage.gUnit_Id, "eAccounts", GlobalUsage.gLogin_id);
            pnl_control.Controls.Clear();
            pnl_control.Controls.Add(obj);
            Cursor.Current = Cursors.Default;
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            accounts_library.Payment_Voucher obj = new accounts_library.Payment_Voucher(GlobalUsage.gUnit_Id, "eAccounts", GlobalUsage.gLogin_id);
            pnl_control.Controls.Clear();
            pnl_control.Controls.Add(obj);
            Cursor.Current = Cursors.Default;
        }

        private void btn_Receipt_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            accounts_library.Receipt_Voucher obj = new accounts_library.Receipt_Voucher(GlobalUsage.gUnit_Id, "eAccounts", GlobalUsage.gLogin_id);
            pnl_control.Controls.Clear();
            pnl_control.Controls.Add(obj);
            Cursor.Current = Cursors.Default;
        }

        private void btn_accounts_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            accounts_library.View_Accounts obj = new accounts_library.View_Accounts(GlobalUsage.gUnitName,"-",GlobalUsage.gUnit_Id, "eAccounts", GlobalUsage.gLogin_id,"eChandanCanteen","LifeSciences","");
            pnl_control.Controls.Clear();
            pnl_control.Controls.Add(obj);
            Cursor.Current = Cursors.Default;
        }
    }
}
