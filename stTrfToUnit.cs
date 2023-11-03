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
namespace eIM
{
    public partial class stTrfToUnit : Form
    {
        DataSet ds = new DataSet();
        string pUnit_code, pItem_Id,pMaster_key_Id, pMfd_Id;
        decimal total_amt = 0;
        eIM.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eIM.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public stTrfToUnit()
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
                        ds = lws.GetQueryResult("exec pSearchProductToDispatch '" + pUnit_code + "','" + txtProdName.Text + "','"+GlobalUsage.gCmpCode+"' ", "eIM_Data");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ErrorRport obj = new ErrorRport();
                        obj.SendError(ex);

                    }
                    DataRow[] drary = ds.Tables[0].Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
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
            ds = lws.fillUnit();
            cmbSelectUnit.SelectedIndexChanged -= new System.EventHandler(cmbSelectUnit_SelectedIndexChanged);
            cmbSelectUnit.DisplayMember = "unit_name";
            cmbSelectUnit.ValueMember = "unit_code";
            cmbSelectUnit.DataSource = ds.Tables[0];
            cmbSelectUnit.SelectedIndex = -1;
            cmbSelectUnit.SelectedIndexChanged += new System.EventHandler(cmbSelectUnit_SelectedIndexChanged);
            WinAPI.AnimateWindow(this.Handle,1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
       
        }
        private void cmbSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUnitName.Items.Clear();
            if (cmbSelectUnit.SelectedIndex == -1)
            {
                cmbUnitName.Visible = false;
                Label3.Visible = false;
            }
            else
            {
                cmbUnitName.Visible = true;
                Label3.Visible = true;
                pUnit_code = cmbSelectUnit.SelectedValue.ToString();
            }
            try
            {
                string qry = @"select trf_id,locked from trf_master where trf_to='" + pUnit_code + "' union select 'New' trf_id,'0' locked order by trf_id desc ";
                ds = lws.GetQueryResult(qry,"eIM_Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            
            }
            DataRow[] drary = ds.Tables[0].Select();
            foreach (DataRow dr in drary)
            {
                cmbUnitName.Items.Add(dr["trf_id"].ToString());

            }
        }
        private void cmbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTransferId.Text = cmbUnitName.Text;
            if (txtTransferId.Text == "New")
                txtProdName.Select();
        }
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                lv_Product.Visible = false;
                Cursor.Current = Cursors.WaitCursor;
                string result = CheckInternet.CheckNet();
                if(result == "TRUE")
                {
                    try
                    {
                        ds = lws.getProductIdentity(pItem_Id, GlobalUsage.gUnit_Id, GlobalUsage.gCmpCode);
                        lv_Details.Location = new System.Drawing.Point(259, 62);//5, 187);
                        lv_Details.Size = new System.Drawing.Size(692, 170);
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
                txtPackSize.Text =lv_Details.FocusedItem.SubItems[2].Text;
                txtPacQty.Text = lv_Details.FocusedItem.SubItems[3].Text;
                txtExpDate.Text = lv_Details.FocusedItem.SubItems[4].Text;
                txtUpr.Text = lv_Details.FocusedItem.SubItems[5].Text;
                pMfd_Id = lv_Details.FocusedItem.SubItems[7].Text;

                lv_Details .Visible = false;
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
                cmbUnitName .Focus();
        }
        private void cmbUnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtTransferId.Focus();
        }
        private void txtTransferId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtTransferId.Text =="NEW")
            {

                txtProdName.Focus();
            }
            else if (e.KeyCode == Keys.Return)
            {
                btnFillRecords.PerformClick();
            }
        }
        public void  fillListView()
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
            DataRow[] drary = ds.Tables[0].Select();
            total_amt = 0;
            foreach (DataRow dr in drary)
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
              ls.SubItems.Add(Convert.ToDecimal(Convert.ToString(Convert.ToDecimal(dr["upr"]) * Convert.ToDecimal(dr["qty"]))).ToString ("###.00"));
              lv_PurchBillInfo.Items.Add(ls);
              lv_PurchBillInfo.Focus();
              lv_PurchBillInfo.Items[0].Selected = true;
              total_amt += Convert.ToDecimal(dr["upr"]) * Convert.ToDecimal(dr["qty"]);
            }
            lblTotalAmt.Text = total_amt.ToString("###.00");
            if(ds.Tables[1].Rows.Count>0)
            lblTrfDate.Text = Convert.ToDateTime(ds.Tables[1].Rows[0]["trf_date"]).ToString("dd-MMM-yyyy");
       }
        private void btnFillRecords_Click(object sender, EventArgs e)
        {
            fillListView ();
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
                        result = lws.Delete_TransferProduct(lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[1].Text);
                        if (result == "ItemDeleted")
                        {
                            total_amt = total_amt - Convert.ToDecimal(lv_PurchBillInfo.Items[index].SubItems[9].Text);
                            lblTotalAmt.Text = total_amt.ToString("###.00");
                            lv_PurchBillInfo.Items[index].Remove();

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
            token = lws.CompleteTransfer(txtTransferId.Text );
            MessageBox.Show(token);
        }
        public void  fillListViewNewRecord()
        {
            string[] Fill_Record_Info = new string[11];
            Fill_Record_Info[0] = pUnit_code;
            Fill_Record_Info[1] = pMaster_key_Id;
            Fill_Record_Info[2] = txtQty.Text;
            Fill_Record_Info[3] = txtTransferId.Text;
            Fill_Record_Info[4] = pMfd_Id;
            Fill_Record_Info[5] = GlobalUsage.gUnit_Id;
            Fill_Record_Info[6] = GlobalUsage.gOperator;
            Fill_Record_Info[7] = "N/A";
            Fill_Record_Info[8] = GlobalUsage.gCmpCode;
          
            string token = "";
            try
            {
                token = lws.TransferStocks(Fill_Record_Info);
                txtTransferId.Text = token.Substring(8);
           
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
                try
                {
                    txtAmount.Text =(Conversion.Val(txtUpr.Text) * Convert.ToInt32(txtQty.Text)).ToString("##.00");
                    fillListViewNewRecord();
                    txtProdName.Focus();
                    txtProdName.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
            
                }
                  
            }
        }
        private void lv_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                int  flags = WinAPI.AW_ACTIVATE | WinAPI.AW_VER_POSITIVE;
                //for extra effects
                flags |= WinAPI.AW_SLIDE;
                NotReceived obj = new NotReceived(1000,flags,pUnit_code,pItem_Id);
                obj.Show();
            }
        }
        private void lv_Product_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
               
        }
           
    }
}
        
