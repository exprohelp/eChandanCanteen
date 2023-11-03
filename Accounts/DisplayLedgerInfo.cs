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
    public partial class DisplayLedgerInfo : Form
    {
        private string ledgerCode; string ledegerName; private string shop_Code = GlobalUsage.gUnit_Id;
        string frDate = ""; string toDt = "";
        SqlCommand cmd;
        public DisplayLedgerInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        public void rcvLdCode(string LedgerId, string ldName)
        {
            ledgerCode = LedgerId;
            ledegerName = ldName;
            SearchLedger form1 = new SearchLedger();
            form1.Show();
            form1.Close();
        }
        private void frmDisplayLedger_Load(object sender, EventArgs e)
        {
            grpDate.Visible = false;
            lblFrom.Text = System.DateTime.Now.Date.ToString("dd-MM-yyyy");
            lblTo.Text = System.DateTime.Now.Date.ToString("dd-MM-yyyy");
            frDate = System.DateTime.Now.Date.ToString("yyyy/MM/dd");
            toDt = System.DateTime.Now.Date.ToString("yyyy/MM/dd");
            this.Text = "Display Ledger" + "(" + ledegerName + ")";
            lblLedgerName.Text = ledegerName;
            fillGrid();
        }
        private void fillGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            decimal OpCredit = 0; string qry;
            decimal OpDebit = 0;
            decimal CuDebit = 0;
            decimal CuCredit = 0;
            SqlConnection con = DBConnection.GetConnection(true, "eMediCentral");
            cmd = new SqlCommand("select * from ledgermaster where ld_code=" + ledgerCode.ToString() + " and unit_id='" + shop_Code + "'", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            //For Debit
            if (dr["crdr"].ToString().ToUpper() == "DR")
                OpDebit = Convert.ToDecimal(dr["opening"].ToString());
            //For Credit
            else if (dr["crdr"].ToString().ToUpper() == "CR")
                OpCredit = Convert.ToDecimal(dr["opening"].ToString());
            cmd.Dispose(); dr.Close(); dr.Dispose();

            //Calculate Opening Balance
            if (shop_Code.ToString().ToUpper() != "ALL")
                qry = "select isnull((sum(isnull(cr_amount,0))),0) as Credit,isnull((sum(isnull(db_amount,0))),0) as debit from ledgerbooks where vch_date<'" + Convert.ToDateTime("01/01/2007").ToString("yyyy-MM-dd") + "' and ldg_credit = " + ledgerCode + " and unitcode='" + shop_Code + "'";
            else
                qry = "select isnull((sum(isnull(cr_amount,0))),0) as Credit,isnull((sum(isnull(db_amount,0))),0) as debit from ledgerbooks where vch_date<'" + Convert.ToDateTime("01/01/2007").ToString("yyyy-MM-dd") + "' and ldg_credit = " + ledgerCode;
            cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataReader dr1 = cmd.ExecuteReader();
            dr1.Read();
            //If RS!Debit > RS!Credit Then
            if ((OpDebit + Convert.ToDecimal(dr1["Debit"])) >= (OpCredit + Convert.ToDecimal(dr1["Credit"])))
            {
                if (OpDebit > 0)
                {
                    OpDebit = OpDebit + Convert.ToDecimal(dr1["Debit"]) - Convert.ToDecimal(dr1["Credit"]);
                    OpCredit = 0;
                }
                else
                {
                    OpDebit = Convert.ToDecimal(dr1["Debit"]) - OpCredit - Convert.ToDecimal(dr1["Credit"]);
                    OpCredit = 0;
                }
            }
            else if ((OpDebit + Convert.ToDecimal(dr1["Debit"])) < (OpCredit + Convert.ToDecimal(dr1["Credit"])))
            //RS!Credit > RS!Debit Then
            {
                if (OpDebit > 0)
                {
                    OpCredit = Convert.ToDecimal(dr1["Credit"]) - OpDebit - Convert.ToDecimal(dr1["Debit"]);
                    OpDebit = 0;
                }
                else
                {
                    OpCredit = Convert.ToDecimal(dr1["Credit"]) + OpCredit - Convert.ToDecimal(dr1["Debit"]);
                    OpDebit = 0;
                }
            }
            cmd.Dispose(); dr1.Close(); dr1.Dispose();
            cmd = new SqlCommand("ViewLedger", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ledgercode", SqlDbType.Int, 10).Value = ledgerCode;
            cmd.Parameters.Add("@from", SqlDbType.VarChar, 10).Value = frDate;
            cmd.Parameters.Add("@to", SqlDbType.VarChar, 10).Value = toDt;
            cmd.Parameters.Add("@ShopCode", SqlDbType.VarChar, 10).Value = GlobalUsage.gUnit_Id;

            SqlDataReader dr2 = cmd.ExecuteReader();
            //Fill Grid
            CuDebit = 0;
            CuCredit = 0;
            lv_ledger.Items.Clear();
            while (dr2.Read())
            {
                ListViewItem lv = new ListViewItem(dr2["ldg_id"].ToString());
                //rsUnit!Sh_name
                SqlConnection con1 = DBConnection.GetConnection(true, "eMediCentral");
                cmd = new SqlCommand("select sh_name from shop_master where sh_code='" + dr2["UnitCode"].ToString().Trim() + "'", con1);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 1500;
                SqlDataReader dr3 = cmd.ExecuteReader();
                if (dr3.HasRows)
                {
                    dr3.Read();
                    lv.SubItems.Add(dr3["sh_name"].ToString()); dr3.Close(); dr3.Dispose();
                }
                else
                { lv.SubItems.Add("Nothing"); dr3.Close(); }
                dr3.Dispose();
                lv.SubItems.Add(Convert.ToDateTime(dr2["vch_date"]).ToString("dd/MM/yyyy"));
                lv.SubItems.Add(dr2["particular"].ToString());
                lv.SubItems.Add(dr2["vch_type"].ToString());
                lv.SubItems.Add(dr2["voucher_no"].ToString());
                //For Debit
                decimal dbAmt = Convert.ToDecimal(dr2["db_amount"]) == 0 ? 0 : Convert.ToDecimal(dr2["db_amount"].ToString());
                lv.SubItems.Add(Convert.ToDecimal(dbAmt).ToString("###.##"));
                CuDebit = CuDebit + Convert.ToDecimal(dr2["db_amount"].ToString());
                //For Credit 
                decimal crAMt = Convert.ToDecimal(dr2["cr_amount"]) == 0 ? 0 : Convert.ToDecimal(dr2["cr_amount"].ToString());
                lv.SubItems.Add(Convert.ToDecimal(crAMt).ToString("###.##"));
                CuCredit = CuCredit + Convert.ToDecimal(dr2["cr_amount"].ToString());
                lv.SubItems.Add(dr2["narration"].ToString());
                lv.SubItems.Add(dr2["UnitCode"].ToString());
                lv_ledger.Items.Add(lv); con1.Close();
            } dr2.Close(); dr2.Dispose();
            decimal ClDebit = 0;
            decimal ClCredit = 0;
            decimal OpDeb = OpDebit > 0 ? Convert.ToDecimal(OpDebit.ToString("##.00")) : 0;
            lblOpDebit.Text = OpDeb + " Dr";
            decimal OpCr = OpCredit > 0 ? Convert.ToDecimal(OpCredit.ToString("##.00")) : 0;
            lblOpCredit.Text = OpCr + " Cr";

            decimal cuDeb = CuDebit > 0 ? Convert.ToDecimal(CuDebit.ToString("##.00")) : 0;
            lblCuDebit.Text = cuDeb + " Dr";
            decimal cuCr = CuCredit > 0 ? Convert.ToDecimal(CuCredit.ToString("##.00")) : 0;
            lblCuCredit.Text = cuCr + " Cr";

            ClDebit = OpDebit == 0 ? 0 : OpDebit + CuDebit;
            ClCredit = OpCredit == 0 ? 0 : OpCredit + CuCredit;
            string ClosingBalance;
            ClosingBalance = "Nil";
            if (ClDebit >= ClCredit)
            {
                lblClDebit.Text = Convert.ToDecimal(ClDebit - ClCredit).ToString("###.00") + " Dr";
                lblClCredit.Text = "";
                ClosingBalance = Convert.ToDecimal(ClDebit - ClCredit).ToString("###.00") + " Dr";
            }
            if (ClCredit > ClDebit)
            {
                lblClCredit.Text = Convert.ToDecimal(ClCredit - ClDebit).ToString("###.00") + " Cr";
                lblClDebit.Text = "";
                ClosingBalance = Convert.ToDecimal(ClCredit - ClDebit).ToString("###.00") + " Cr";
            }
            con.Close();
            Cursor.Current = Cursors.Default;
        }
        private void frmDisplayLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt && e.KeyCode == Keys.F2)
            {
                grpDate.Visible = true;
                txtFrom.Focus();
                txtFrom.SelectAll();
                txtFrom.Text = System.DateTime.Now.Date.ToString("dd/MM/yyyy");
                txtTo.Text = System.DateTime.Now.Date.ToString("dd/MM/yyyy");
            }
            if (e.KeyCode == Keys.Escape && grpDate.Visible == false)
            {
                this.Close();
            }
        }
        private void RepDisplayLedger()
        {
            LedgerRep lp = new LedgerRep();
            ReportViewer rpView = new ReportViewer();
            rpView.txtLdName.Text = ledegerName.ToString();
            rpView.txtFrom.Text = frDate;
            rpView.txtTo.Text = toDt;
            reportLedegerDisplay ds = new reportLedegerDisplay();
            SqlConnection con = DBConnection.GetConnection(true, "eMediCentral");
            cmd = new SqlCommand("ViewLedger", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ledgercode", SqlDbType.Int, 10).Value = Convert.ToInt32(ledgerCode);
            cmd.Parameters.Add("@from", SqlDbType.VarChar, 10).Value = frDate;
            cmd.Parameters.Add("@to", SqlDbType.VarChar, 10).Value = toDt;
            cmd.Parameters.Add("@ShopCode", SqlDbType.VarChar, 10).Value = shop_Code;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "LedegerDisplay");
            lp.SetDataSource(ds);
            rpView.crystalReportViewer1.ReportSource = lp;
            rpView.Show();
            con.Close();

        }
        private void btnPrntPreview_Click(object sender, EventArgs e)
        {
            RepDisplayLedger();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblFrom.Text = txtFrom.Text;
            lblTo.Text = txtTo.Text;
            string[] df = txtFrom.Text.ToString().Split('/');
            frDate = df[2] + "/" + df[1] + "/" + df[0];
            string[] dl = txtTo.Text.ToString().Split('/');
            toDt = dl[2] + "/" + dl[1] + "/" + dl[0];
            grpDate.Visible = false;
            fillGrid();
        }
        private void txtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTo.Focus();
            if (e.KeyCode == Keys.Escape)
                grpDate.Visible = false;
        }
        private void txtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSubmit.Focus();
            if (e.KeyCode == Keys.Escape)
                grpDate.Visible = false;
        }
        private void btnSubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                grpDate.Visible = false;
        }
    }
}
