using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using ExPro.Server;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Telerik.WinControls.UI;
namespace eChandanCanteen
{
    public partial class Purchase_return : Form
    {
        DataSet ds = new DataSet();
        string pUnit_code, pItem_Id, pMaster_key_Id, pMfd_Id, pFromOrder = "N";
        decimal _qty = 0;
        decimal total_amt = 0;
        int selectedindex = 0;
        string text = "";
        string _trfIdGr = string.Empty;
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public Purchase_return()
        {
            InitializeComponent();
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lv_Product.Location = new System.Drawing.Point(2, 62);//5, 187);
            lv_Product.Size = new System.Drawing.Size(523, 250);
            lv_Product.Visible = true;
            lv_Product.Items.Clear();
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                if (txtProdName.Text.Length > 0)
                {
                    try
                    {
                        ds = lws.GetQueryResult("exec pSearchProductToDispatch '" + pUnit_code + "','" + txtProdName.Text + "','" + GlobalUsage.gCmpCode + "','ManualDispatch' ", "eIM_Data");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ErrorRport obj = new ErrorRport();
                        obj.SendError(ex);
                    }
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
                        ls.SubItems.Add(dr["o_qty"].ToString());
                        ls.SubItems.Add(dr["W_qty"].ToString());
                        ls.SubItems.Add(dr["U_qty"].ToString());
                        ls.SubItems.Add(dr["T_qty"].ToString());
                        lv_Product.Items.Add(ls);
                    }
                }
            }
            else
            {
                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
        }
        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return | e.KeyCode == Keys.Down) && (lv_Product.Items.Count > 0 && txtProdName.Text.Length > 0))
            {
                lv_Product.Focus();
                lv_Product.Items[0].Selected = true;
            }
        }
        private void stTrfToUnit_Load(object sender, EventArgs e)
        {
            GlobalUsage.gUnit_Id = "HOLKO";
            //WinAPI.AnimateWindow(this.Handle,1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
            pUnit_code = "GR01";
            Cursor.Current = Cursors.WaitCursor;
            string qry = "exec pGR_Queries '" + GlobalUsage.gUnit_Id + "','-','-','-','VendorList' ";
            DataSet ds1 = lws.GetQueryResult(qry, "eIM_Data");

            cmbStockistName.Items.Add(new ExproComboBox("Select", "Select"));
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cmbStockistName.Items.Add(new ExproComboBox(dr["vend_code"], dr["vend_name"].ToString()));
            }
            Cursor.Current = Cursors.Default;
        }
        private void cmbSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                string qry = @"select trf_id,locked from trf_master where trf_to='" + pUnit_code + "' and len(voucher_no)<10 and locked=0";
                ds = lws.GetQueryResult(qry, "eIM_Data");
                if (ds.Tables[0].Rows.Count > 0)
                    txtTransferId.Text = ds.Tables[0].Rows[0]["trf_id"].ToString();
                else
                    txtTransferId.Text = "New";

                fillListView();
                txtProdName.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            }
        }
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
                text = lv_Product.FocusedItem.SubItems[1].Text;
                txtQty.Text = lv_Product.FocusedItem.SubItems[2].Text;
                selectedindex = lv_Product.FocusedItem.Index;
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                lv_Product.Visible = false;
                Cursor.Current = Cursors.WaitCursor;
                string result = CheckInternet.CheckNet();
                if (result == "TRUE")
                {
                    try
                    {
                        ds = lws.getProductIdentity(pItem_Id, GlobalUsage.gUnit_Id, GlobalUsage.gCmpCode);
                        lv_Details.Location = new System.Drawing.Point(248, 62);//5, 187);
                        lv_Details.Size = new System.Drawing.Size(738, 170);
                        lv_Details.Visible = true;
                        lv_Details.Items.Clear();
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            lv_Details.Visible = false;
                            txtProdName.Select();
                            return;
                        }
                        DataRow[] drary = ds.Tables[0].Select();
                        foreach (DataRow dr in drary)
                        {
                            ListViewItem ls = new ListViewItem(dr["master_key_id"].ToString());
                            ls.SubItems.Add(dr["batch_no"].ToString());
                            ls.SubItems.Add(dr["pack_type"].ToString());
                            ls.SubItems.Add(dr["pack_qty"].ToString());
                            ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy"));
                            ls.SubItems.Add(Convert.ToDecimal(dr["upr"]).ToString("###.##"));
                            ls.SubItems.Add(dr["mfd_name"].ToString());
                            ls.SubItems.Add(dr["mfd_id"].ToString());
                            ls.SubItems.Add(dr["qty"].ToString());
                            //ls.SubItems.Add(dr["run_qty"].ToString());
                            lv_Details.Items.Add(ls);
                        }
                        lv_Details.Focus();
                        lv_Details.Items[0].Selected = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ErrorRport obj = new ErrorRport();
                        obj.SendError(ex);
                    }
                }
                else
                {

                    MessageBox.Show("Check Internet Connection", "ExPro Help");
                }
                Cursor.Current = Cursors.Arrow;

            }

        }
        private void lv_Details_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                string result = CheckInternet.CheckNet();
                if (result == "TRUE")
                {
                    pMaster_key_Id = lv_Details.FocusedItem.SubItems[0].Text;
                    txtBatchNo.Text = lv_Details.FocusedItem.SubItems[1].Text;
                    txtPackSize.Text = lv_Details.FocusedItem.SubItems[2].Text;
                    txtPacQty.Text = lv_Details.FocusedItem.SubItems[3].Text;
                    txtExpDate.Text = lv_Details.FocusedItem.SubItems[4].Text;
                    txtUpr.Text = lv_Details.FocusedItem.SubItems[5].Text;
                    pMfd_Id = lv_Details.FocusedItem.SubItems[7].Text;
                    // _qty = Convert.ToDecimal(lv_Details.FocusedItem.SubItems[9].Text);
                    lv_Details.Visible = false;
                    txtQty.Focus();
                    txtQty.SelectAll();
                }
                else
                {
                    MessageBox.Show("Check Internet Connection", "ExPro Help");
                    Cursor.Current = Cursors.Arrow;
                }
            }
        }
        private void cmbSelectUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtTransferId.Focus();
        }

        private void txtTransferId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtTransferId.Text == "NEW")
            {

                txtProdName.Focus();
            }
            else if (e.KeyCode == Keys.Return)
            {
                btnFillRecords.PerformClick();
            }
        }
        public void fillListView()
        {
            lv_PurchBillInfo.Items.Clear();
            try
            {
                ds = lws.getTrfRecord(txtTransferId.Text, pUnit_code);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            }
            total_amt = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem ls = new ListViewItem(dr["Master_key_Id"].ToString());
                ls.SubItems.Add(dr["rec_id"].ToString());
                ls.SubItems.Add(dr["item_name"].ToString());
                ls.SubItems.Add(dr["batch_no"].ToString());
                ls.SubItems.Add(dr["pack_type"].ToString());
                ls.SubItems.Add(dr["pack_qty"].ToString());
                ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy"));
                ls.SubItems.Add(Convert.ToDecimal(dr["upr"]).ToString("###.00"));
                ls.SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("###"));
                ls.SubItems.Add(Convert.ToDecimal(Convert.ToString(Convert.ToDecimal(dr["upr"]) * Convert.ToDecimal(dr["qty"]))).ToString("###.00"));
                lv_PurchBillInfo.Items.Add(ls);

                total_amt += Convert.ToDecimal(dr["upr"]) * Convert.ToDecimal(dr["qty"]);
            }
            lblTotalAmt.Text = total_amt.ToString("###.00");
            if (ds.Tables[1].Rows.Count > 0)
            {
                if (ds.Tables[1].Rows[0]["locked"].ToString() == "True")
                    btnComplete.Enabled = false;
                else
                    btnComplete.Enabled = true;
            }
            if (chkOrder.Checked)
            {
                SearchProduct();
            }
        }
        private void btnFillRecords_Click(object sender, EventArgs e)
        {
            fillListView();
        }
        private void lv_PurchBillInfo_KeyDown(object sender, KeyEventArgs e)
        {
            Int32 index = new Int32();
            string result;
            if (e.KeyCode == Keys.Delete)
            {
                index = lv_PurchBillInfo.FocusedItem.Index;
                if (MessageBox.Show("Are You Sure Want To Delete", "Expro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        result = lws.Delete_TransferProduct(lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[1].Text, pFromOrder);
                        if (result == "ItemDeleted")
                        {
                            total_amt = total_amt - Convert.ToDecimal(lv_PurchBillInfo.Items[index].SubItems[9].Text);
                            lblTotalAmt.Text = total_amt.ToString("###.00");
                            lv_PurchBillInfo.Items[index].Remove();
                            if (chkOrder.Checked)
                            {
                                SearchProduct();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Can not delete item  because it's Locked");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ErrorRport obj = new ErrorRport();
                        obj.SendError(ex);
                    }
                }
            }
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            string token = "";
            token = lws.CompleteTransfer(txtTransferId.Text);
            MessageBox.Show(token);
        }
        public void fillListViewNewRecord()
        {
            string[] Fill_Record_Info = new string[11];
            Fill_Record_Info[0] = pUnit_code;
            Fill_Record_Info[1] = pMaster_key_Id;
            Fill_Record_Info[2] = txtQty.Text;
            Fill_Record_Info[3] = txtTransferId.Text;
            Fill_Record_Info[4] = pMfd_Id;
            Fill_Record_Info[5] = GlobalUsage.gUnit_Id;
            Fill_Record_Info[6] = GlobalUsage.gLogin_id;
            Fill_Record_Info[7] = "N/A";
            Fill_Record_Info[8] = GlobalUsage.gCmpCode;
            Fill_Record_Info[9] = pFromOrder;
            _qty = 0;
            try
            {
                string[] token = lws.TransferStocks(Fill_Record_Info).Split('|');
                if (token[0] != "Success")
                {
                    MessageBox.Show(token[0]);
                    return;
                }
                txtTransferId.Text = token[1];
                txtProdName.Focus();
                txtProdName.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            }
            fillListView();
        }
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (Convert.ToDecimal(txtQty.Text) < 0)
                {
                    MessageBox.Show("Negative Quantity Not Possible", "Dispatch Product", MessageBoxButtons.OK);
                    return;
                }
                #region Dispatch Product
                try
                {
                    txtAmount.Text = (Conversion.Val(txtUpr.Text) * Convert.ToInt32(txtQty.Text)).ToString("##.00");
                    fillListViewNewRecord();
                    txtProdName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
                }
                #endregion
            }
        }
        private void lv_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                int flags = WinAPI.AW_ACTIVATE | WinAPI.AW_VER_POSITIVE;
                //for extra effects
                flags |= WinAPI.AW_SLIDE;
                NotReceived obj = new NotReceived(1000, flags, pUnit_code, pItem_Id);
                obj.Show();
            }
        }
        private void lv_Product_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
        }
        private void chkOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrder.Checked)
            {
                SearchProduct();
                pFromOrder = "Y";
            }
            else
            {
                txtProdName.Enabled = true;
                txtProdName.Text = "";
                lv_Product.Visible = false;
                pFromOrder = "N";
            }
        }
        private void SearchProduct()
        {
            Cursor.Current = Cursors.WaitCursor;
            lv_Product.Location = new System.Drawing.Point(2, 62);
            lv_Product.Size = new System.Drawing.Size(523, 250);
            lv_Product.Visible = true;
            lv_Product.Items.Clear();
            txtProdName.Enabled = false;
            try
            {
                string qry = "exec pSearchProductToDispatch '" + pUnit_code + "','" + txtProdName.Text + "','" + GlobalUsage.gCmpCode + "','Order' ";
                ds = lws.GetQueryResult(qry, "eIM_Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            }
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                ls.SubItems.Add(dr["Item_Name"].ToString());
                ls.SubItems.Add(dr["o_qty"].ToString());
                ls.SubItems.Add(dr["W_qty"].ToString());
                ls.SubItems.Add(dr["U_qty"].ToString());
                ls.SubItems.Add(dr["T_qty"].ToString());
                lv_Product.Items.Add(ls);
            }
            if (lv_Product.Items.Count > 0)
            {
                lv_Product.Focus();
                lv_Product.Items[selectedindex].Selected = true;
                Cursor.Current = Cursors.Default;
            }
        }
     
        private void txtQty_Enter(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtProdName_Enter(object sender, EventArgs e)
        {
            txtProdName.SelectAll();
        }

        private void btnLoadTransferId_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "exec pGR_Queries '" + GlobalUsage.gUnit_Id + "','-','-','-','GET_GR_TRFIDS' ";
                ds = lws.GetQueryResult(qry, "eIM_Data");
                dgTrfId.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }
        private void dgTrfId_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                dgSelectedProduct.Rows.Clear();
                _vendorcode = string.Empty;
                _vendorName = string.Empty;
                _trfIdGr = dgTrfId.CurrentRow.Cells["trf_id"].Value.ToString();
                Cursor.Current = Cursors.WaitCursor;
                cmbStockistName.Enabled = true;
                btnProcessGR.Enabled = true;
                btnLockVendor.Enabled = true;
                string qry = "exec pGR_Queries '" + GlobalUsage.gUnit_Id + "','" + _trfIdGr + "','-','-','GET_DISPATCH_DETAIL' ";
                ds = lws.GetQueryResult(qry, "eIM_Data");
                dgTrfIdDetail.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }
        string _vendorcode = string.Empty;
        string _vendorName = string.Empty;
        private void btnLockVendor_Click(object sender, EventArgs e)
        {
            _vendorName = ((ExproComboBox)cmbStockistName.SelectedItem).NewDescription.ToString();
            _vendorcode = ((ExproComboBox)cmbStockistName.SelectedItem).Value.ToString();
            btnLockVendor.Enabled = false;
            cmbStockistName.Enabled = false;
        }

        private void dgTrfIdDetail_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (_vendorcode.Length > 2)
            {
                if (dgTrfIdDetail.CurrentRow.Cells["gr_no"].Value.ToString().Length < 5)
                {
                    GridViewRowInfo r = dgSelectedProduct.Rows.AddNew();
                    r.Cells["master_key_id"].Value = dgTrfIdDetail.CurrentRow.Cells["master_key_id"].Value.ToString();
                    r.Cells["item_id"].Value = dgTrfIdDetail.CurrentRow.Cells["item_id"].Value.ToString();
                    r.Cells["item_Name"].Value = dgTrfIdDetail.CurrentRow.Cells["item_Name"].Value.ToString();
                    r.Cells["pack_qty"].Value = dgTrfIdDetail.CurrentRow.Cells["pack_qty"].Value.ToString();
                    r.Cells["qty"].Value = dgTrfIdDetail.CurrentRow.Cells["qty"].Value.ToString();
                    r.Cells["batch_no"].Value = dgTrfIdDetail.CurrentRow.Cells["batch_no"].Value.ToString();
                    r.Cells["exp_date"].Value = dgTrfIdDetail.CurrentRow.Cells["exp_date"].Value.ToString();
                    r.Cells["npr"].Value = dgTrfIdDetail.CurrentRow.Cells["npr"].Value.ToString();
                    r.Cells["mrp"].Value = dgTrfIdDetail.CurrentRow.Cells["mrp"].Value.ToString();
                    r.Cells["amount"].Value = dgTrfIdDetail.CurrentRow.Cells["amount"].Value.ToString();
                    r.Cells["vendor_name"].Value = _vendorName;
                    r.Cells["vendor_code"].Value = _vendorcode;
                    dgTrfIdDetail.CurrentRow.Cells["gr_no"].Value = "Locked";
                    //dgTrfIdDetail.CurrentRow.Delete();
                }
            }
            else
            { MessageBox.Show("Vendor selection is mandatory"); }
            decimal amount = 0;
            foreach (GridViewRowInfo r in dgSelectedProduct.Rows)
            {
                amount = amount + Convert.ToDecimal(r.Cells["amount"].Value);
            }
            txtGRAmt.Text = amount.ToString();
        }
        string _result = string.Empty;
        private void btnProcessGR_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnProcessGR.Enabled = false;
            txtGR.Text = "New";
            foreach (GridViewRowInfo r in dgSelectedProduct.Rows)
            {
                txtGR.Text = lws.GR_Processing(out _result, _trfIdGr, r.Cells["master_key_id"].Value.ToString(), r.Cells["item_id"].Value.ToString(), GlobalUsage.gUnit_Id, Convert.ToInt32(r.Cells["qty"].Value), r.Cells["vendor_code"].Value.ToString(),
                Convert.ToDecimal(txtGRAmt.Text), GlobalUsage.gLogin_id, "GR:Processing", txtGR.Text);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dgSelectedProduct_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            e.Row.Delete();
            decimal amount = 0;
            foreach (GridViewRowInfo r in dgSelectedProduct.Rows)
            {
                amount = amount + Convert.ToDecimal(r.Cells["amount"].Value);
            }
            txtGRAmt.Text = amount.ToString();
        }

        private void dgTrfIdDetail_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["gr_no"].Value != null && e.RowElement.RowInfo.Cells["gr_no"].Value.ToString().Length > 5)
            { e.RowElement.ForeColor = Color.Red; }
            else
            { e.RowElement.ForeColor = Color.Black; }
        }

        private void btnGetDetail_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string logic = string.Empty;
                if (rbPending.Checked)
                {
                    logic = "PendingPostingList";
                    btnPostGR.Enabled = true;
                }
                else
                {
                    logic = "CompletedGR";
                    btnPostGR.Enabled = false;
                }
                string qry = "exec pGR_Queries '" + GlobalUsage.gUnit_Id + "','" + _trfIdGr + "','-','-','" + logic + "' ";
                ds = lws.GetQueryResult(qry, "eIM_Data");
                dgGRList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }
        private void dgGRList_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            decimal amount = 0;
            StringBuilder sb = new StringBuilder();

            DataSet ds = new DataSet();
            try
            {
                txtSelectedGR.Text = dgGRList.CurrentRow.Cells["gr_no"].Value.ToString();
                Cursor.Current = Cursors.WaitCursor;
                string qry = "exec pGR_Queries '" + GlobalUsage.gUnit_Id + "','-','" + dgGRList.CurrentRow.Cells["gr_no"].Value.ToString() + "','-','GR_DETAIL' ";
                ds = lws.GetQueryResult(qry, "eIM_Data");

                sb.Append("<html><body>");
                sb.Append("<table style='width:100%'>");
                sb.Append("<tr>");
                sb.Append("<td style='font-size:14px;text-align:center' colspan='8'><b style='color:Black'>Chandan Healthcare Ltd.<br><i style='font-size:10px'> Biotech Park Kursiroad Lucknow </i></td>");
                sb.Append("</tr>");

                sb.Append("<tr>");
                sb.Append("<td style='font-size:14px;text-align:left' colspan='8'><b style='color:Black'>Goods Return Number : " + dgGRList.CurrentRow.Cells["gr_no"].Value.ToString() + " </b></td>");
                sb.Append("</tr>");

                sb.Append("<tr>");
                sb.Append("<td style='font-size:8px;text-align:left' colspan='8'></td>");
                sb.Append("</tr>");


                sb.Append("<tr>");
                sb.Append("<td style='font-size:11px;text-align:left' colspan='8'><b style='color:Black'>Return To Vendor :" + ds.Tables[1].Rows[0]["vendor_name"].ToString() + " </b></td>");
                sb.Append("</tr>");

                sb.Append("<tr>");
                sb.Append("<td style='font-size:8px;text-align:left' colspan='8'></td>");
                sb.Append("</tr>");

                sb.Append("<tr style='background-color:Blue;'>");
                sb.Append("<td style='width:44%;font-size:12px;text-align:left'><b style='color:white'>Name of Product</b></td>");
                sb.Append("<td style='width:8%;font-size:12px;vertical-align:top;text-align:left'><b style='color:white'>Batch</b></td>");
                sb.Append("<td style='width:8%;font-size:12px;vertical-align:top;text-align:left'><b style='color:white'>Expiry</b></td>");
                sb.Append("<td style='width:6%;font-size:12px;vertical-align:top;text-align:center'><b style='color:white'>P.Qty</b></td>");
                sb.Append("<td style='width:6%;font-size:12px;vertical-align:top;text-align:right'><b style='color:white'>MRP</b></td>");
                sb.Append("<td style='width:6%;font-size:12px;vertical-align:top;text-align:right'><b style='color:white'>NPR</b></td>");
                sb.Append("<td style='width:6%;font-size:12px;vertical-align:top;text-align:right'><b style='color:white'>Quantity</b></td>");
                sb.Append("<td style='width:10%;font-size:12px;vertical-align:top;text-align:right'><b style='color:white'>Amount</b></td>");
                sb.Append("</tr>");


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                Cursor.Current = Cursors.WaitCursor;
                string temp = string.Empty;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sb.Append("<tr>");
                    sb.Append("<td style='width:44%;font-size:10px;text-align:left'>" + dr["item_name"].ToString() + "</td>");
                    sb.Append("<td style='width:8%;font-size:10px;vertical-align:top;text-align:left'>" + dr["batch_no"].ToString() + "</td>");
                    sb.Append("<td style='width:8%;font-size:10px;vertical-align:top;text-align:left'>" + dr["exp_date"].ToString() + "</td>");
                    sb.Append("<td style='width:6%;font-size:10px;vertical-align:top;text-align:center'>" + dr["pack_qty"].ToString() + "</td>");
                    sb.Append("<td style='width:6%;font-size:10px;vertical-align:top;text-align:right'>" + dr["mrp"].ToString() + "</td>");
                    sb.Append("<td style='width:6%;font-size:10px;vertical-align:top;text-align:right'>" + dr["npr"].ToString() + "</td>");
                    sb.Append("<td style='width:6%;font-size:10px;vertical-align:top;text-align:right'>" + dr["qty"].ToString() + "</td>");
                    sb.Append("<td style='width:10%;font-size:10px;vertical-align:top;text-align:right'>" + dr["amount"].ToString() + "</td>");
                    sb.Append("</tr>");
                    amount = amount + Convert.ToDecimal(dr["amount"]);
                }

                txtGRPostingAmount.Text = amount.ToString();
                sb.Append("<tr>");
                sb.Append("<td style='font-size:8px;text-align:left' colspan='8'></td>");
                sb.Append("</tr>");

                sb.Append("<tr>");
                sb.Append("<td style='font-size:11px;text-align:right' colspan='7'><b style='color:Black'>Amount :</b></td>");
                sb.Append("<td style='font-size:11px;text-align:right' ><b style='color:Black'><b>" + amount + " </b></td>");
                sb.Append("</tr>");

                sb.Append("</table>");
                sb.Append("</body></html>");
                webBrowser1.DocumentText = sb.ToString();
            }
        }

        private void btnPostGR_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                lws.GR_Processing(out _result, _trfIdGr, "-", "-", GlobalUsage.gUnit_Id, 0, "", Convert.ToDecimal(txtGRPostingAmount.Text), GlobalUsage.gLogin_id, "GR:Posting", txtSelectedGR.Text);
                if (_result.Contains("Success"))
                { dgGRList.CurrentRow.Delete(); }
                MessageBox.Show(_result);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }
    }
}

