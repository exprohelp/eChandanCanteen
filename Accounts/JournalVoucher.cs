 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using ExPro.Server;
using System.Data.SqlClient;

namespace eIM
{
    public partial class JournalVoucher : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder cb = new SqlCommandBuilder();
        int Focus_Index=0;
        string LedgerFor = "";
        public JournalVoucher()
        {
            InitializeComponent();
        }
        #region FOR FILLING ld_Name
        private void txtdebitAC_TextChanged(object sender, EventArgs e)
        {
            if (txtdebitAC.Text.Length == 0)
            {
                lv_ledger.Visible = false;
                return ;
            }
            FillLedgerName("Debit", txtdebitAC.Text);
        }
       
        #endregion 
        private void txtdebitAC_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down))
            {
                LedgerFor = "Debit";
                lv_ledger.Focus();
            }
            if ((e.KeyCode == Keys.Return))
            {
                txtdebit_amt.Focus();
                txtdebit_amt.SelectAll();
            }
        }
        private void lv_ledger_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape))
            {
                if (lv_ledger.Items.Count > 0 && LedgerFor=="Debit" )
                {
                    this.txtdebitAC.Enter -= new System.EventHandler(this.txtdebitAC_Enter);
                    this.txtdebitAC.TextChanged -= new System.EventHandler(this.txtdebitAC_TextChanged);
                    txtdebitAC.Text = lv_ledger.FocusedItem.Text;
                    txtdebitAC.Focus();
                    txtdebitAC.SelectAll();
                    this.txtdebitAC.Enter += new System.EventHandler(this.txtdebitAC_Enter);
                    this.txtdebitAC.TextChanged += new System.EventHandler(this.txtdebitAC_TextChanged);
                }
                if (lv_ledger.Items.Count > 0 && LedgerFor == "Credit")
                {
                    this.txtCreditAC.TextChanged -= new System.EventHandler(this.txtCreditAC_TextChanged);
                    this.txtCreditAC.Enter -= new System.EventHandler(this.txtCreditAC_Enter);
                    txtCreditAC.Text = lv_ledger.FocusedItem.Text;
                    txtCreditAC.Focus();
                    txtCreditAC.SelectAll();
                    this.txtCreditAC.TextChanged += new System.EventHandler(this.txtCreditAC_TextChanged);
                    this.txtCreditAC.Enter += new System.EventHandler(this.txtCreditAC_Enter);
                }
            }
        }
        #region Function For Convert Date And Numeric Value checking
        public string DateToSql(DateTime dtp)
        {
            string temp;
            temp = dtp.ToString("yyyy/MM/dd");
            return temp;
        }
        public static void checkNumbers(TextBox txt)
        {
            string str1 = "";
            Int32 count;

            for (count = 0; count <= txt.Text.Length - 1; count++)
            {
                if (char.IsNumber(txt.Text, count))
                {
                    str1 = "OK";
                }
                else
                {
                    MessageBox.Show("Only Numbers Are Allowed");
                    txt.Focus(); txt.Clear(); txt.Select();
                }
            }
        }
        #endregion
        private void txtCreditAC_TextChanged(object sender, EventArgs e)
        {
            if (txtCreditAC .Text.Length == 0)
            {
                lv_ledger.Visible = false;
                return ;
            }
            FillLedgerName("Credit", txtCreditAC.Text);
        }
        private void txtCreditAC_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Down))
            {
                LedgerFor = "Credit";
                lv_ledger.Focus();
            }
            if ((e.KeyCode == Keys.Return))
            {
                txtNarration.Focus();
                txtNarration.SelectAll();
            }
        }
        #region SAVE RECORDS AND FILL LIST VIEW
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (MessageBox.Show("Are You Sure Want To Save", "Expro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection sqlcon = DBConnection.GetConnection(true, "eMediCentral");
                    SqlCommand cmd = new SqlCommand("pVoucherPosting", sqlcon);
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string voucher_no = Config.NewVoucherNo(GlobalUsage.gUnit_Id);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 1500;
                        cmd.Parameters.Add("unit_id", SqlDbType.VarChar, 10).Value = GlobalUsage.gUnit_Id;
                        cmd.Parameters.Add("voucher_date", SqlDbType.VarChar, 10).Value = DateTime.Now.ToString("yyyy/MM/dd");
                        cmd.Parameters.Add("voucher_type", SqlDbType.VarChar, 10).Value = "Jrnl";
                        cmd.Parameters.Add("cr_Ledger", SqlDbType.VarChar, 100).Value = txtCreditAC.Text;
                        cmd.Parameters.Add("dr_Ledger", SqlDbType.VarChar, 100).Value = txtdebitAC.Text;
                        cmd.Parameters.Add("amount", SqlDbType.Money).Value = Convert.ToInt32(txtCredit_amt.Text);
                        cmd.Parameters.Add("narration", SqlDbType.VarChar, 100).Value = txtNarration.Text;
                        cmd.Parameters.Add("login_id", SqlDbType.VarChar, 10).Value = GlobalUsage.gOperator;
                        cmd.Parameters.Add("voucher_no", SqlDbType.VarChar, 15).Value =voucher_no;
                        cmd.Parameters.Add("result", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        string result = cmd.Parameters["result"].Value.ToString();
                        MessageBox.Show(result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Printing print = new Printing();
                        print.Voucher(voucher_no, txtdebitAC.Text, txtCreditAC.Text, Convert.ToDecimal(txtCredit_amt.Text), txtNarration.Text);
                        RefreshGrid();
                        this.txtCreditAC.TextChanged -= new System.EventHandler(this.txtCreditAC_TextChanged);
                        this.txtCreditAC.Enter -= new System.EventHandler(this.txtCreditAC_Enter);
                        this.txtdebitAC.Enter -= new System.EventHandler(this.txtdebitAC_Enter);
                        this.txtdebitAC.TextChanged -= new System.EventHandler(this.txtdebitAC_TextChanged);
                        txtCredit_amt.Text = "";
                        txtdebit_amt.Text = "";
                        txtdebitAC.Text = "";
                        txtCreditAC.Text = "";
                        txtNarration.Text = "";
                        this.txtdebitAC.Enter += new System.EventHandler(this.txtdebitAC_Enter);
                        this.txtdebitAC.TextChanged += new System.EventHandler(this.txtdebitAC_TextChanged);
                        this.txtCreditAC.TextChanged += new System.EventHandler(this.txtCreditAC_TextChanged);
                        this.txtCreditAC.Enter += new System.EventHandler(this.txtCreditAC_Enter);
                        Cursor.Current = Cursors.Default;
                    }
                    catch (Exception Ex)
                    {
                        DbManager.SaveErrorLog(GlobalUsage.gUnit_Id, "eMediCentral", ErrorTracker.ErrorHistory(Ex));
                    }

                    finally { sqlcon.Close(); }
                }
            }
        }
        #endregion
        private void VoucherFeeding_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            RefreshGrid();
        }
        private void lv_Ld_detail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dlgresult = MessageBox.Show("Are You sure want to delete Selected Recored ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgresult.ToString() == "Yes")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DbManager.QueryExecute("delete from vouchermaster where mast_id="+lv_Ld_detail.FocusedItem.Text,"eMediCentral" );
                    RefreshGrid();
                    Cursor.Current = Cursors.Default;
                }
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.P)
            {
                Printing print = new Printing();
                string Voucher_No = lv_Ld_detail.FocusedItem.SubItems[1].Text;
                string PayBy=lv_Ld_detail.FocusedItem.SubItems[4].Text;
                string PayTo=lv_Ld_detail.FocusedItem.SubItems[3].Text;
                decimal Amount=Convert.ToDecimal(lv_Ld_detail.FocusedItem.SubItems[5].Text);
                string Narration=lv_Ld_detail.FocusedItem.SubItems[6].Text;
                if(MessageBox.Show("is Printer Ready (Y/N)","ExPro Help",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    print.Voucher(Voucher_No.ToString(), PayBy.ToString(), PayTo.ToString(), Amount, Narration.ToString());
            }
        }
        #region Fill Ledger Information
        protected void FillLedgerName(string ldType, string ledgerName)
        {
             lv_ledger.Visible = true;
             string qry="";
             if (ldType == "Debit" && ledgerName.Length > 0)
             { LedgerFor = "Debit"; SearchLedger(txtdebitAC.Text); }
             else if (ldType == "Debit" && ledgerName.Length == 0)
             { qry = @"select ld_name from ledgermaster where code_category!=6 order by ld_name"; LedgerFor = "Debit"; lv_ledger.Items.Clear(); }
             else if (ldType == "Credit" && ledgerName.Length > 0)
             { LedgerFor = "Credit"; SearchLedger(txtCreditAC.Text); }
             else if (ldType == "Credit" && ledgerName.Length == 0)
             { qry = @"select ld_name from ledgermaster where code_category!=6 order by ld_name"; LedgerFor = "Credit"; lv_ledger.Items.Clear(); }
             if (ledgerName.Length == 0)
             {
                 ds = DbManager.GetQueryResult(qry, "eMediCentral");
                 try
                 {
                     foreach (DataRow dr in ds.Tables[0].Rows)
                     {
                         ListViewItem li = new ListViewItem(dr["ld_name"].ToString());
                         lv_ledger.Items.Add(li);
                     }
                 }
                 catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help"); txtdebitAC.Text = ""; }
             }
        }
        #endregion   
        private void txtdebitAC_Enter(object sender, EventArgs e)
        {
            FillLedgerName("Debit", txtdebitAC.Text);
        }
        private void txtCreditAC_Enter(object sender, EventArgs e)
        {
            FillLedgerName("Credit", txtCreditAC.Text);
        }
        private void txtdebit_amt_KeyDown(object sender, KeyEventArgs e)
        {
            checkNumbers(txtdebit_amt);
            if (txtdebit_amt.Text.Length == 0)
                txtCredit_amt.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                txtCredit_amt.Text = txtdebit_amt.Text;
                txtCreditAC.Focus();
                txtCreditAC.SelectAll();
            }
            if (e.KeyCode != Keys.Enter)
                txtdebit_amt.Focus();
        }
        private void txtCreditAC_Leave(object sender, EventArgs e)
        {
            lv_ledger.Visible = false;
        }
        protected void RefreshGrid() {
            lv_Ld_detail.Items.Clear(); 
            string qry = "SELECT VoucherMaster.mast_id,VoucherMaster.voucher_no, VoucherMaster.vch_type, VoucherMaster.vch_date, LedgerMaster.ld_name AS PayBy,";
            qry += " LedgerMaster_1.ld_name AS PayTo, VoucherMaster.ledg_debit, VoucherMaster.ledg_credit, VoucherMaster.amount,";
            qry += " VoucherMaster.narration FROM  ( LedgerMaster LedgerMaster_1 INNER JOIN ";
            qry += " VoucherMaster ON LedgerMaster_1.ld_code = VoucherMaster.ledg_credit) INNER JOIN ";
            qry += " LedgerMaster ON VoucherMaster.ledg_debit = LedgerMaster.ld_code ";
            qry += " WHERE VoucherMaster.vch_type='Jrnl' and  convert(varchar(10),vch_date,111) = '" + DateTime.Now.ToString("yyyy/MM/dd") + "'";
            try
            {
                SqlConnection sqlcon = DBConnection.GetConnection(true, "eMediCentral");
                SqlCommand cmd = new SqlCommand(qry, sqlcon);
                cmd.CommandType=CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read()){
                    ListViewItem li = new ListViewItem(dr["mast_id"].ToString());
                    li.SubItems.Add(dr["voucher_no"].ToString());
                    li.SubItems.Add(Convert.ToDateTime(dr["vch_date"]).ToString("dd/MM/yyyy"));
                    li.SubItems.Add(dr["PayBy"].ToString());
                    li.SubItems.Add(dr["PayTo"].ToString());
                    li.SubItems.Add(dr["amount"].ToString());
                    li.SubItems.Add(dr["narration"].ToString());
                    lv_Ld_detail.Items.Add(li);
                }
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                DbManager.SaveErrorLog(GlobalUsage.gUnit_Id, "eMediCentral", ErrorTracker.ErrorHistory(ex));
            }
  
        }
        private void lv_ledger_Leave(object sender, EventArgs e)
        {
            lv_ledger.Visible = false;
        }
        private void lv_Ld_detail_Enter(object sender, EventArgs e)
        {
            lv_ledger.Visible = false;
        }
        #region Search Ledger
        protected void SearchLedger(string Search)
        {
            if (lv_ledger.Items.Count > 0)
            {
                //lv_ledger.Items[lv_ledger.Items.Count - 1].EnsureVisible();
                lv_ledger.Items[lv_ledger.Items.Count - 1].Focused = true;
                Focus_Index = 0;
                for (int i = 0; i < lv_ledger.Items.Count; i++)
                {
                    lv_ledger.Items[i].Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lv_ledger.Items[i].Selected = false;
                    int l = Search.Length;
                    if (l > lv_ledger.Items[i].SubItems[0].Text.Length)
                        l = lv_ledger.Items[i].SubItems[0].Text.Length;
                    if (lv_ledger.Items[i].SubItems[0].Text.Substring(0, l).ToUpper() == Search.ToUpper())
                    {
                        if (Focus_Index == 0)
                        {
                            Focus_Index = i;
                            lv_ledger.Items[i].Focused = true;
                            lv_ledger.Items[i].Selected = true;
                        }
                        lv_ledger.Items[i].Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lv_ledger.Items[i].EnsureVisible();
                        //lv_ledger.TopItem = lv_ledger.Items[i];
                        //break;
                    }
                }
            }
        }
        #endregion

      
    }
    }

