using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eChandanCanteen
{
    public partial class Audit_ReconcileStock : Form
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient ws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();

        string _item_id = ""; string _item_name = ""; string _Master_key_id = ""; string _unitCode = "";
        public Audit_ReconcileStock()
        {
            InitializeComponent();
        }

        private void Audit_ReconcileStock_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 120);
            if (GlobalUsage.gRights == "FullRights")
            {
                this.lv_tracking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_tracking_KeyDown);
            }
            else
            {
                this.lv_tracking.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.lv_tracking_KeyDown);
            }
            //Fill Units
            cmbSelectUnit.SelectedIndexChanged -= new System.EventHandler(cmbSelectUnit_SelectedIndexChanged);
            DataSet ds = new DataSet(); 
            ds = ws.fillUnit();
            cmbSelectUnit.DisplayMember = "unit_name";
            cmbSelectUnit.ValueMember = "unit_code";
            cmbSelectUnit.DataSource = ds.Tables[0];
            cmbSelectUnit.SelectedIndex = -1;
            cmbSelectUnit.SelectedIndexChanged += new System.EventHandler(cmbSelectUnit_SelectedIndexChanged);
            cmbSelectUnit.Text = "Chandan HealthCare Ltd.(WareHouse)";
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Cursor.Current = Cursors.WaitCursor;
            string qry = "select * from ( ";
            qry += " select distinct Item_id,dbo.fngetitemname(item_id) item_name from stocks where unit_id='" + _unitCode + "'";//  and comp_code='CHCL'";
                        qry += ") xx where item_name like '" + txtProdName.Text + "%' order by item_name";
                        ds = ws.GetQueryResult(qry, "eIm_data");
            Fill_ProductName(ds);
            Cursor.Current = Cursors.Default;
        }
        private void Fill_ProductName(DataSet _ds)
        {
            lvSearchItem.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                #region Process Block To Fill List View "lvSearchItem"
                try
                {
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        lvSearchItem.Items.Clear();
                        foreach (DataRow dr in _ds.Tables[0].Rows)
                        {
                            ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                            ls.SubItems.Add(dr["Item_Name"].ToString());
                            lvSearchItem.Items.Add(ls);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Search Product",MessageBoxButtons.OK);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
                }
                #endregion
            }
        }

        private void lvSearchItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _item_id = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Text;
            _item_name = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text + "  :" + _item_id;
            gb_info.Text = _item_name;
            lv_tracking.Items.Clear();
            #region Fill List View "Lv_Tracking"
            Cursor.Current = Cursors.WaitCursor;
            Refresh_Lv_Tracking();
            Cursor.Current = Cursors.Default;
            #endregion
        }

        private void lvSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                #region Fill List View "Lv_Tracking"
                Refresh_Lv_Tracking();
                #endregion
            }
        }
        protected void Refresh_Lv_Tracking() {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            if (cmbSelectUnit.SelectedValue.ToString().ToUpper() == "HOLKO")
            {
                ds = ws.GetQueryResult("execute pTrackWareHouseItem '" + _item_id + "'", "eIm_Data");
                Fill_ListView(ds);
            }
            else
            {
                ds = ws.GetQueryResult("execute pTrackUnitItem '" + _item_id + "','" + cmbSelectUnit.SelectedValue.ToString().ToUpper() + "'", "eIm_Data");
                Fill_ListViewForUnit(ds);
            }
            Cursor.Current = Cursors.Default;
        }
        protected void Fill_ListView(DataSet _ds)
        {
            lv_tracking.BeginUpdate();
            #region Fill List View
            decimal tPurchQty = 0; decimal tTrfQty = 0; decimal tRetQty = 0; decimal tStkQty = 0; decimal stkQty = 0;
            if (_ds.Tables[0].Rows.Count > 0)
            {
                gb_info.Visible = true;
                string temp = "N/A"; string groupname = "Temp";
                decimal bal = 0;
                decimal purchQty = 0; decimal trfQty = 0; decimal retQty = 0;
                ListViewItem ls;
                lv_tracking.Items.Clear();
                lv_tracking.Columns[5].Text = "PurchQty";
                lv_tracking.Columns[6].Text = "TrfQty";
                lv_tracking.Columns[7].Text = "RetQty";
                try
                {
                    lv_tracking.BeginUpdate();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        #region Process Block
                        if (temp != dr["Master_key_id"].ToString())
                        {
                            tStkQty += stkQty;
                            if (groupname != "Temp")
                            {
                                ls = new ListViewItem(temp);
                                ls.SubItems.Add("Final Status : In Stock " + stkQty.ToString("##0"));
                                ls.SubItems.Add("->");
                                ls.SubItems.Add("->");
                                ls.SubItems.Add("->");
                                ls.SubItems.Add(purchQty.ToString("##"));
                                ls.SubItems.Add((trfQty-retQty).ToString("##"));
                                ls.SubItems.Add(retQty.ToString("##"));
                                ls.SubItems.Add(bal.ToString("##0"));
                                ls.Group = lv_tracking.Groups[groupname];
                                if(stkQty!=bal)
                               ls.ForeColor = Color.Red;
                                else
                                    ls.ForeColor = Color.Green;
                                ls.Font = new Font("Arial Narrow", 11, FontStyle.Bold);
                                lv_tracking.Items.Add(ls);
                            }
                            groupname = dr["Master_key_id"].ToString();
                            lv_tracking.Groups.Add(groupname, groupname);
                            temp = dr["Master_key_id"].ToString();
                            stkQty = Convert.ToDecimal(dr["stkqty"]);
                            bal = 0; trfQty = 0; purchQty = 0; retQty = 0;
                        }
                        bal = bal + Convert.ToDecimal(dr["purch_qty"]) - Convert.ToDecimal(dr["qty"]) +Convert.ToDecimal(dr["ret_qty"]);
                        purchQty += Convert.ToDecimal(dr["purch_qty"]);
                        trfQty += Convert.ToDecimal(dr["qty"]);
                        retQty += Convert.ToDecimal(dr["ret_qty"]);
                        tPurchQty += Convert.ToDecimal(dr["purch_qty"]);
                        tTrfQty += Convert.ToDecimal(dr["qty"]);
                        tRetQty += Convert.ToDecimal(dr["ret_qty"]);

                        ls = new ListViewItem(dr["master_key_id"].ToString());
                        ls.SubItems.Add(dr["unit_name"].ToString());
                        ls.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MM-yyyy"));
                        ls.SubItems.Add(dr["purch_id"].ToString());
                        ls.SubItems.Add(dr["pack_type"].ToString());
                        ls.SubItems.Add(Convert.ToInt32(dr["purch_qty"]).ToString("##0"));
                        ls.SubItems.Add(Convert.ToInt32(dr["qty"]).ToString("##0"));
                        ls.SubItems.Add(Convert.ToInt32(dr["ret_qty"]).ToString("##0"));
                        ls.SubItems.Add(bal.ToString("##0"));
                        ls.Group = lv_tracking.Groups[groupname];
                        if (dr["unit_id"].ToString().ToUpper() == "SHORT")
                            ls.ForeColor = Color.Maroon;
                        lv_tracking.Items.Add(ls);
                        #endregion
                    }
                    ls = new ListViewItem("N/A");
                    ls.SubItems.Add("Final Status : In Stock " + stkQty.ToString("##0"));
                    ls.SubItems.Add("->");
                    ls.SubItems.Add("->");
                    ls.SubItems.Add("->");
                    ls.SubItems.Add(purchQty.ToString("##"));
                    ls.SubItems.Add((trfQty - retQty).ToString("##"));
                    ls.SubItems.Add(retQty.ToString("##"));
                    ls.SubItems.Add(bal.ToString("##0"));
                    ls.Group = lv_tracking.Groups[groupname];
                    if (stkQty != bal)
                        ls.ForeColor = Color.Red;
                    else
                        ls.ForeColor = Color.Green;
                    ls.Font = new Font("Arial Narrow", 11, FontStyle.Bold);
                    lv_tracking.Items.Add(ls);
                    lv_tracking.EndUpdate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            tStkQty += stkQty;
            if ((tPurchQty - tTrfQty + tRetQty) != tStkQty)
                gb_info.ForeColor = Color.Red;
            else
                gb_info.ForeColor = Color.Green;

            _item_id = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Text;
            _item_name = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text + "  [" + _item_id + "] Running Stock " + (tPurchQty - tTrfQty + tRetQty).ToString("##0") + " In Stocks : " + tStkQty.ToString("##0");
            gb_info.Text = _item_name;
            #endregion
            lv_tracking.EndUpdate();
        }
        protected void Fill_ListViewForUnit(DataSet _ds)
        {
            lv_tracking.BeginUpdate();
            #region Fill List View
            decimal tRecQty = 0; decimal tIssueQty = 0; decimal tRetQty = 0; decimal tStkQty = 0; decimal stkQty = 0;
            if (_ds.Tables[0].Rows.Count > 0)
            {
                gb_info.Visible = true;
                string temp = "N/A"; string groupname = "Temp";
                decimal bal = 0;
                decimal recQty = 0; decimal issueQty = 0; decimal retQty = 0;
                ListViewItem ls;
                lv_tracking.Columns[5].Text = "TrfQty";
                lv_tracking.Columns[6].Text = "IssQty";
                lv_tracking.Columns[7].Text = "RetQty";

                lv_tracking.Items.Clear();
                try
                {
                    lv_tracking.BeginUpdate();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        #region Process Block
                        if (temp != dr["Master_key_id"].ToString())
                        {
                            tStkQty += stkQty;
                            if (groupname != "Temp")
                            {
                                ls = new ListViewItem(temp);
                                ls.SubItems.Add("Final Status : In Stock " + stkQty.ToString("##0"));
                                ls.SubItems.Add("->");
                                ls.SubItems.Add("->");
                                ls.SubItems.Add("->");
                                ls.SubItems.Add(recQty.ToString("##"));
                                ls.SubItems.Add((issueQty).ToString("##"));
                                ls.SubItems.Add(retQty.ToString("##"));
                                ls.SubItems.Add(bal.ToString("##0"));
                                ls.Group = lv_tracking.Groups[groupname];
                                if (stkQty != bal)
                                    ls.ForeColor = Color.Red;
                                else
                                    ls.ForeColor = Color.Green;
                                ls.Font = new Font("Arial Narrow", 11, FontStyle.Bold);
                                lv_tracking.Items.Add(ls);
                            }
                            groupname = dr["Master_key_id"].ToString();
                            lv_tracking.Groups.Add(groupname, groupname);
                            temp = dr["Master_key_id"].ToString();
                            stkQty = Convert.ToDecimal(dr["stkqty"]);
                            bal = 0; issueQty = 0; recQty = 0; retQty = 0;
                        }
                        bal = bal + Convert.ToDecimal(dr["trf_qty"]) - Convert.ToDecimal(dr["issue_qty"]) -Convert.ToDecimal(dr["ret_qty"]);
                        recQty += Convert.ToDecimal(dr["trf_qty"]);
                        issueQty += Convert.ToDecimal(dr["issue_qty"]);
                        retQty += Convert.ToDecimal(dr["ret_qty"]);
                        tRecQty += Convert.ToDecimal(dr["trf_qty"]);
                        tIssueQty += Convert.ToDecimal(dr["issue_qty"]);
                        tRetQty += Convert.ToDecimal(dr["ret_qty"]);

                        ls = new ListViewItem(dr["master_key_id"].ToString());
                        ls.SubItems.Add(dr["unit_name"].ToString());
                        ls.SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MM-yyyy"));
                        ls.SubItems.Add(dr["trf_id"].ToString());
                        ls.SubItems.Add(dr["pack_type"].ToString());
                        ls.SubItems.Add(Convert.ToInt32(dr["trf_qty"]).ToString("##0"));
                        ls.SubItems.Add(Convert.ToInt32(dr["issue_qty"]).ToString("##0"));
                        ls.SubItems.Add(Convert.ToInt32(dr["ret_qty"]).ToString("##0"));
                        ls.SubItems.Add(bal.ToString("##0"));
                        ls.Group = lv_tracking.Groups[groupname];
                        lv_tracking.Items.Add(ls);
                        #endregion
                    }
                    ls = new ListViewItem("N/A");
                    ls.SubItems.Add("Final Status : In Stock " + stkQty.ToString("##0"));
                    ls.SubItems.Add("->");
                    ls.SubItems.Add("->");
                    ls.SubItems.Add("->");
                    ls.SubItems.Add(recQty.ToString("##"));
                    ls.SubItems.Add((issueQty).ToString("##"));
                    ls.SubItems.Add(retQty.ToString("##"));
                    ls.SubItems.Add(bal.ToString("##0"));
                    ls.Group = lv_tracking.Groups[groupname];
                    if (stkQty != bal)
                        ls.ForeColor = Color.Red;
                    else
                        ls.ForeColor = Color.Green;
                    ls.Font = new Font("Arial Narrow", 11, FontStyle.Bold);
                    lv_tracking.Items.Add(ls);
                    lv_tracking.EndUpdate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            tStkQty += stkQty;
            if ((tRecQty - tIssueQty - tRetQty) != tStkQty)
                gb_info.ForeColor = Color.Red;
            else
                gb_info.ForeColor = Color.Green;

            _item_id = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Text;
            _item_name = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text + "  [" + _item_id + "] Running Stock " + (tRecQty - tIssueQty - tRetQty).ToString("##0") + " In Stocks : " + tStkQty.ToString("##0");
            gb_info.Text = _item_name;
            #endregion
            lv_tracking.EndUpdate();
        }

        private void lv_tracking_KeyDown(object sender, KeyEventArgs e)
        {
            #region Stock Updation Process
            string qry = "";
            if (lv_tracking.FocusedItem!=null)
            {
            if (e.KeyCode == Keys.Return && lv_tracking.Items[lv_tracking.FocusedItem.Index].SubItems[1].Text.Substring(0, 12).ToUpper() == "FINAL STATUS")
            {
                lblMkey.Enabled = true; txtFStkQty.Enabled = true;
                lblMkey.Text = "Final Stock of [" + lv_tracking.Items[lv_tracking.FocusedItem.Index - 1].SubItems[0].Text + "]";
                txtFStkQty.Text = lv_tracking.Items[lv_tracking.FocusedItem.Index].SubItems[8].Text;
                _Master_key_id = lv_tracking.Items[lv_tracking.FocusedItem.Index-1].SubItems[0].Text;
                txtFStkQty.Focus();
            }
            if (e.KeyCode == Keys.Delete && lv_tracking.Items[lv_tracking.FocusedItem.Index].SubItems[1].Text.ToUpper() == "SHORT")
            {
                try
                {
                    DialogResult res = MessageBox.Show("Are You Confirm To Delete(Y/N)", "Delete Record", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        qry = "delete from trf_items where trf_id='" + lv_tracking.Items[lv_tracking.FocusedItem.Index].SubItems[3].Text;
                        qry += "' and master_key_id='" + lv_tracking.Items[lv_tracking.FocusedItem.Index].SubItems[0].Text + "' and trf_to='Short'";
                        ws.QueryExecute(qry, "eIm_data");
                        Refresh_Lv_Tracking();
                    }
                    //  lblMkey.Text = "Final Stock of [" + lv_tracking.Items[lv_tracking.FocusedItem.Index].SubItems[3].Text.ToUpper() + "]";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            #endregion
        }

        private void txtFStkQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    if (Convert.ToDecimal(txtFStkQty.Text) >= 0)
                    {
                        DialogResult res = MessageBox.Show("Are you Confirm  To Update", "Stock Updation", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            string qry = "update  stocks set qty=" + Convert.ToDecimal(txtFStkQty.Text).ToString("##0") + " where  master_key_id='" + _Master_key_id + "' and unit_id='HOLKO' and comp_code='CHCL'";
                            ws.QueryExecute(qry, "eIm_data");
                            Refresh_Lv_Tracking();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update Stock Quantity", MessageBoxButtons.OK);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
                }
            }
        }

        private void lv_tracking_Enter(object sender, EventArgs e)
        {
            lblMkey.Enabled = false; txtFStkQty.Enabled = false ;
        }

        private void lv_tracking_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMkey.Enabled = false; txtFStkQty.Enabled = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txtRemark.Text.Length > 0)
            {
                btn_Submit.Enabled = false; 
                string qry = "execute pAudit_Info 'Auditor','Insert','" + GlobalUsage.gLogin_id + "','" + _item_id + "','" + txtRemark.Text.Replace("'", " ") + "'";
                ws.QueryExecute(qry, "eIm_Data");
                txtRemark.Text = "";
            }
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_Submit.Enabled = true;
                btn_Submit.Focus();
            }
            else
            {
                btn_Submit.Enabled = false;
            }
        }

        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lvSearchItem.Items.Count > 0)
                {
                    lvSearchItem.Focus();
                    lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Selected = true;
                }
                else
                {
                    txtProdName.Focus();
                }
            }
        }

        private void cmbSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _unitCode = cmbSelectUnit.SelectedValue.ToString();
        }

    }
}
