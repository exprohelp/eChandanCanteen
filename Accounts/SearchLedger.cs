using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;

namespace eIM
{
    public partial class SearchLedger : Form
    {
        public delegate void sendCorpId(string text,string ldName);
        int Focus_Index = 0;
        public SearchLedger()
        {
            InitializeComponent();
        }

        private void frmSearchLedger_Load(object sender, EventArgs e)
        {
            SqlConnection con = DBConnection.GetConnection(true, "eMediCentral");
            string qry = @"select ld_code,upper(ld_name) ld_name from ledgerMaster where unit_id='" + GlobalUsage.gUnit_Id + "' order by ld_name";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem ls = new ListViewItem(dr["ld_Code"].ToString());
                    ls.SubItems.Add(dr["ld_name"].ToString());
                    lv_ledger.Items.Add(ls);
                }
                lv_ledger.Items[0].Focused = true;
            }
            con.Close();
        }

        private void frmSearchLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { this.Close(); }
            else if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;
                DisplayLedgerInfo UseForm = new DisplayLedgerInfo();
                sendCorpId del = new sendCorpId(UseForm.rcvLdCode);
                int k = lv_ledger.FocusedItem.Index;
                del(this.lv_ledger.SelectedItems[0].Text, this.lv_ledger.Items[k].SubItems[1].Text);
                UseForm.Show();
                Cursor.Current = Cursors.Default;
            }
        } 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           SearchLedgers(txtSearch.Text);
        }
        #region Search Ledger
        protected void SearchLedgers(string Search)
        {
            if (lv_ledger.Items.Count > 0)
            {
                lv_ledger.Refresh(); string logic = "";
                Focus_Index = 0;
                for (int i = 0; i < lv_ledger.Items.Count; i++)
                {
                    lv_ledger.Items[i].Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lv_ledger.Items[i].ForeColor = Color.White;
                    int l = Search.Length;
                    if (l > 0)
                    {
                        if (lv_ledger.Items[i].SubItems[1].Text.Length >= l)
                        {
                            if (lv_ledger.Items[i].SubItems[1].Text.Substring(0, l).ToUpper() == Search.ToUpper())
                            {
                                if (logic == "")
                                { Focus_Index = i; }
                                lv_ledger.Items[i].Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                lv_ledger.Items[i].EnsureVisible();
                                logic = "ok";
                                lv_ledger.Items[i].ForeColor = Color.YellowGreen;
                            }
                        }
                    }
                    else
                    {
                        lv_ledger.Items[0].Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lv_ledger.Items[0].EnsureVisible();
                    }
                }
            }
        }
        #endregion

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Down)
            {
                lv_ledger.Refresh();
                lv_ledger.Focus();
                for (int i = 0; i < lv_ledger.Items.Count; i++)
                {
                    lv_ledger.Items[i].Focused = false;
                    lv_ledger.Items[i].Selected = false;
                }
                lv_ledger.Items[Focus_Index].Focused = true;
                lv_ledger.Items[Focus_Index].Selected = true;
            }
        }

       
    }
}
