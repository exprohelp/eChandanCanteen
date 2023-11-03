using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
namespace eChandanCanteen
{
    public partial class ReconcileProduct : Form  
    {
        string    _item_id = "";string   _item_name = "";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        DataSet pDS = new DataSet();
        int pItemIndex = 0;
        string pItemId = "";
        string pUnitId = "";
        string pAction = "";
        public ReconcileProduct()
        {
            InitializeComponent();
        }
        private void ReconcileProduct_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 120); 

            //WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            pAction = "SearchProduct";
            progressBar1.Visible = true;
            if(!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
        }
        private void fillProduct()
        {
            if (pDS.Tables.Count > 0)
            {
                try
                {
                    lvSearchItem.Items.Clear();
                    if (pDS.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in pDS.Tables[0].Rows)
                        {
                            ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                            ls.SubItems.Add(dr["Item_Name"].ToString());
                            lvSearchItem.Items.Add(ls);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
                }

            }
            pDS.Clear();
            pDS.Dispose();
            progressBar1.Visible = false;
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lvSearchItem.Focus();
                if((lvSearchItem.FocusedItem)!=null)
                lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Selected = true;
            }
        }
        private void lv_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pUnitId = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[2].Text;
                pAction = "FillProductDetail";
                progressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void ReconcileProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtProdName.Text = "";
                txtProdName.Focus();
            }
            //if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.P)
            //{
            //    if(lv_Detail.Items.Count > 0)
            //    {
            //        lv_Detail.Items[0].Selected = true;
            //        lv_Detail.Focus();
            //    }
            //}
            //if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.U)
            //{
            //    if (lv_unit.Items.Count > 0)
            //    {
            //        lv_unit.Items[0].Selected = true;
            //        lv_unit.Focus();
            //    }
            //}
        }
        private void cmdPurchase_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            pAction = "PurchaseInfo";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void fillPurchaseInfo()
        {
            pDS.Clear();
            pDS.Dispose();
            progressBar1.Visible =false;
        }
        private void lv_product_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pUnitId = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[2].Text;
            pAction = "FillProductDetail";
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if(pAction=="SearchProduct")
            {
                try
                {
                    pDS = lws.SearchProduct(txtProdName.Text);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }
            }
            if(pAction=="FillProductDetail")
            {
                try
                {
                    pDS=lws.GetTrfAndStockAndIssuedInformation(pItemId,pUnitId);
                }
                catch (Exception ex){MessageBox.Show(ex.Message);}
            }
            if(pAction == "PurchaseInfo")
            {
                try
                {
                    //pDS = lws.GetQueryResult(qry,"eIM_Data");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pAction=="SearchProduct")
                fillProduct();
            if (pAction == "PurchaseInfo")
                fillPurchaseInfo();
            progressBar1.Visible = false;
        }
        private void lvSearchItem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            pItemId = lvSearchItem.Items[e.ItemIndex].Text;
            lblProduct.Text = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text+"  :"+pItemId;
            pItemIndex = lvSearchItem.FocusedItem.Index;
            string Qry = "SELECT dbo.Stocks.warehouse, dbo.shop_master.sh_name, dbo.Stocks.Item_id, SUM(dbo.Stocks.Quantity) AS Sum_Qty ";
            Qry += " FROM  dbo.Stocks INNER JOIN dbo.shop_master ON dbo.Stocks.warehouse = dbo.shop_master.sh_code  where dbo.Stocks.Item_id='" + pItemId + "'";
            Qry += "  GROUP BY dbo.Stocks.warehouse, dbo.shop_master.sh_name, dbo.Stocks.Item_id  order by dbo.shop_master.sh_name ";
            DataSet pDS = lws.GetQueryResult(Qry, "eIM_Data"); ;
            if (pDS.Tables[0].Rows.Count > 0)
            {
                lvSearchItem.Items.Clear();
                foreach (DataRow dr in pDS.Tables[0].Rows)
                {
                    lvSearchItem.Items.Add(dr["sh_name"].ToString());
                    lvSearchItem.Items[lvSearchItem.Items.Count - 1].SubItems.Add(dr["sum_qty"].ToString());
                    lvSearchItem.Items[lvSearchItem.Items.Count - 1].SubItems.Add(dr["warehouse"].ToString());
                }
            }
        }
        private void lvSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lvSearchItem.Focus();
                lvSearchItem.Items[0].Selected = true;
             }
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            pAction = "SearchProduct";
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void lvSearchItem_KeyDown_1(object sender, KeyEventArgs e)
        {
        }
        private void FillUnitStockSummery(DataTable dt)
        {
            lv_unit.Items.Clear();
            this.lv_unit.SelectedIndexChanged-= new System.EventHandler(this.lv_unit_SelectedIndexChanged);
            if (dt.Rows.Count > 0)
            {
                string temp="Not Found";

                foreach (DataRow dr in dt.Rows)
                {
                    if (temp != dr["unit_name"].ToString())
                    {
                        lv_unit.Groups.Add(dr["unit_name"].ToString(), dr["unit_name"].ToString());
                        temp = dr["unit_name"].ToString();
                    }
                    ListViewItem ls = new ListViewItem(dr["unit_code"].ToString());
                    ls.SubItems.Add(dr["pack_type"].ToString());
                    ls.SubItems.Add(Convert.ToDecimal(dr["s_qty"]).ToString("###"));
                    ls.Group = lv_unit.Groups[dr["unit_name"].ToString()];
                    lv_unit.Items.Add(ls);
                }
                lv_unit.Items[0].Selected = true;
            }
            this.lv_unit.SelectedIndexChanged += new System.EventHandler(this.lv_unit_SelectedIndexChanged);
        }
        private void lv_unit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
            }
        }
        #region Dispatche/Issued and Balance Information
        protected void FillDispatchIssuedInfo(string item_id, string unit_id,string PackType)
        {
            Cursor.Current = Cursors.WaitCursor;
            #region Fill List View
            DataSet ds = new DataSet();
            ds = lws.GetQueryResult("execute pGetDispIssueInfo '" + item_id + "','"+PackType+"','" + unit_id + "','" + GlobalUsage.gLogin_id + "','Y'", "eIm_Data");
            lv_DI_info.Items.Clear();
            decimal bal = 0;
            decimal r = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                lv_DI_info.BeginUpdate();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    r=r+ Convert.ToDecimal(.00001);
                    bal += Convert.ToDecimal(dr["Dispatch"]) - Convert.ToDecimal(dr["issued"])- Convert.ToDecimal(dr["RetQty"]);
                    ListViewItem ls = new ListViewItem(Convert.ToDateTime(dr["date"]).ToString("dd-MM-yyyy"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["Dispatch"]).ToString("#0"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["issued"]).ToString("#0"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["RetQty"]).ToString("#0"));
                    ls.SubItems.Add(bal.ToString("###.00"));
                    ls.SubItems.Add(r.ToString());
                    //ls.SubItems.Add(r.ToString().Trim().Length.ToString()+"-"+r.ToString("###"));
                    lv_DI_info.Items.Add(ls);
                }
                lv_DI_info.EndUpdate();
            }
            #endregion
            Cursor.Current = Cursors.Default;
        }
        #endregion
        #region Purchase Information with Vendor
        private void FillPurchaseSummery(DataTable dt)
        {
                lv_Detail.Items.Clear();
                lvConsumed.Items.Clear();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["purch_Id"].ToString());
                        lvi.SubItems.Add(dr["inv_no"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MMM-yyyy"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["inv_total"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["inv_tax"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["inv_discount"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["netamount"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["roundoff"]).ToString("####.00"));
                        lv_Detail.Items.Add(lvi);
                    }
                }
        }
        #endregion
        #region Purchase Detail with Item Information
        private void FillPurchaseInfo(DataSet ds)
        {
            Cursor.Current = Cursors.WaitCursor;
            #region Fill List View
            lvConsumed.Items.Clear();
            decimal bal = 0;
            int r = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                lvConsumed.BeginUpdate();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    bal = bal + (Convert.ToDecimal(dr["purch_qty"]) - Convert.ToDecimal(dr["trf_qty"])) + Convert.ToDecimal(dr["ret_qty"]);
                    ListViewItem ls = new ListViewItem(dr["to_unit"].ToString());
                    ls.SubItems.Add(dr["trf_id"].ToString());
                    ls.SubItems.Add(dr["master_key_id"].ToString());
                    ls.SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MM-yyyy"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["purch_qty"]).ToString("#0"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["trf_qty"]).ToString("#0"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["ret_qty"]).ToString("#0"));
                    ls.SubItems.Add(bal.ToString("###.00"));
                    lvConsumed.Items.Add(ls);
                    r++;
                }
                lvConsumed.EndUpdate();
            }
            #endregion
            Cursor.Current = Cursors.Default;
        }
        #endregion
        private void lv_Detail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if((object)lv_Detail.FocusedItem != null)
            {
                string purch_id = lv_Detail.Items[e.ItemIndex].SubItems[0].Text;
                string qry = @"pGetPurchaseConsumed '" + purch_id + "','"+pItemId+"' ";
                try
                {
                    DataSet ds = lws.GetQueryResult(qry, "eIM_Data");
                    FillPurchaseInfo(ds);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message);}
            }
        }
        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lvSearchItem.Items.Count > 0)
                {
                    lvSearchItem.Focus();
                    lvSearchItem.Items[0].Selected = true;
                }
            }
        }

        private void btntrack_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Current = Cursors.WaitCursor;
            _item_id = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Text;
            _item_name = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text + "  :" + _item_id;
            gb_info.Text = _item_name;
            lv_tracking.Items.Clear();
            #region Fill List View "Lv_Tracking"
            Refresh_Lv_Tracking();
            Cursor.Current = Cursors.Default;
            #endregion
        }
        protected void Refresh_Lv_Tracking()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = lws.GetQueryResult("execute pTrackWareHouseItem '" + _item_id + "'", "eIm_Data");
            Fill_ListView(ds);
            Cursor.Current = Cursors.Default;
        }
        protected void Fill_ListView(DataSet _ds)
        {
            lv_tracking.BeginUpdate();
            #region Fill List View
            decimal tPurchQty = 0; decimal tTrfQty = 0; decimal tRetQty = 0; decimal tStkQty = 0; decimal stkQty = 0;
            lv_tracking.Items.Clear();
            if (_ds.Tables[0].Rows.Count > 0)
            {
                gb_info.Visible = true;
                string temp = "N/A"; string groupname = "Temp";
                decimal bal = 0;
                decimal purchQty = 0; decimal trfQty = 0; decimal retQty = 0;
                ListViewItem ls;
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
                            }
                            groupname = dr["Master_key_id"].ToString();
                            lv_tracking.Groups.Add(groupname, groupname);
                            temp = dr["Master_key_id"].ToString();
                            stkQty = Convert.ToDecimal(dr["stkqty"]);
                            bal = 0; trfQty = 0; purchQty = 0; retQty = 0;
                        }
                        bal = bal + Convert.ToDecimal(dr["purch_qty"]) - Convert.ToDecimal(dr["qty"]) + Convert.ToDecimal(dr["ret_qty"]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            gb_info.Visible = false;
        }

        private void lvSearchItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pItemId = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Text;
            lblProduct.Text = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text + "  :" + pItemId;
            pItemIndex = lvSearchItem.FocusedItem.Index;
            string Qry = @"pGetPurchAndUnitStockOfProduct '" + pItemId + "','PurchaseAndUnitStock','" + GlobalUsage.gCmpCode + "' ";
            try
            {
                lv_DI_info.Items.Clear();
                lv_unit.Items.Clear();
                DataSet ds = lws.GetQueryResult(Qry, "eIM_Data");
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    { FillUnitStockSummery(ds.Tables[0]); }
                    if (ds.Tables[1].Rows.Count > 0)
                    { FillPurchaseSummery(ds.Tables[1]); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }

        private void lv_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pUnitId = lv_unit.Items[lv_unit.FocusedItem.Index].SubItems[0].Text;
            lblUnit.Text = lv_unit.Items[lv_unit.FocusedItem.Index].SubItems[1].Text;

            FillDispatchIssuedInfo(pItemId, pUnitId, lv_unit.Items[lv_unit.FocusedItem.Index].SubItems[1].Text);
            lv_DI_info.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lv_DI_info.ListViewItemSorter = new ListViewItemComparer(5, lv_DI_info.Sorting);
            lv_DI_info.Sort();
            Cursor.Current = Cursors.Default;
        }
    
    }
}
