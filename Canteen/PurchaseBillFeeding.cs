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
using Telerik.WinControls.UI;
namespace eChandanCanteen
{
  
    public partial class PurchaseBillFeeding : Telerik.WinControls.UI.RadForm
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string pItem_Id, pvendor_code="Select",pmfd_id="Select";
        string pExpDate = "";
        string _PurchAllow = "Y";
        decimal _BestRate = 0;
        int tax_id = 0;
        string pPackSize = "Select"; string _BillType = string.Empty;
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public PurchaseBillFeeding()
        {
            InitializeComponent();
        }
        private void Lfc_BillFeeding_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 80); 
           _BillType = "T";
           Cursor.Current = Cursors.WaitCursor;
           Application.Idle -= new EventHandler(OnLoaded); //remove the handle because it only use for once

            //cmbBillType.SelectedIndex = cmbBillType.FindString("Con");
           cmbCash_Credit.SelectedIndex = cmbCash_Credit.FindString("Cre");
           cmbStockistName.Select();
           cmbPurchOrder.Items.Clear();
           cmbStockistName.Items.Clear();
           ds = GlobalUsage.canteenProxy.getPurchIds(600);
          
           DataRow[] drary = ds.Tables[0].Select();
           cmbPurchOrder.Items.Insert(0, "AUTO GENERATE");
           cmbPurchOrder.SelectedIndex = 0;
           foreach (DataRow dr in drary)
           {
               cmbPurchOrder.Items.Add(dr[0].ToString());
           }
           string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','AppVendList','-','N/A','N/A'";
           DataSet ds1 = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");

           cmbStockistName.SelectedIndexChanged -= new System.EventHandler(cmbStockistName_SelectedIndexChanged);
           cmbStockistName.Items.Add(new ExproComboBox("Select", "Select"));
           foreach (DataRow dr in ds1.Tables[0].Rows)
           {
               cmbStockistName.Items.Add(new ExproComboBox(dr["vend_code"], dr["vend_name"].ToString()));
           }
           dgTaxList.DataSource = ds1.Tables[1];

           cmbStockistName.SelectedIndexChanged += new System.EventHandler(cmbStockistName_SelectedIndexChanged);

            cmbCash_Credit.Items.Add(new ExproComboBox("Select", "Select"));
            foreach (DataRow dr in ds1.Tables[2].Rows)
            {
                cmbCash_Credit.Items.Add(new ExproComboBox(dr["accountID"], dr["employeeName"].ToString()));
            }


            Cursor.Current = Cursors.Default;
        }
        public void fillListView()
        {
          
            dgPiGrid.Rows.Clear();
            try
            {
                ds =GlobalUsage.canteenProxy.getPurchaseRecordByPurchId(txtPurchaseId.Text);
                DataRow[] drary = ds.Tables[0].Select();
                foreach (DataRow dr in drary)
                {
                    GridViewRowInfo gv = dgPiGrid.Rows.NewRow();
                    gv.Cells["auto_id"].Value = dr["auto_id"].ToString();
                    gv.Cells["item_name"].Value=dr["item_name"].ToString();
                    gv.Cells["hsn"].Value = dr["hsn"].ToString();
                    gv.Cells["mfd_name"].Value = dr["mfd_name"].ToString();
                    gv.Cells["batch_no"].Value = dr["batch_no"].ToString();
                    gv.Cells["exp_date"].Value = Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy");
                    gv.Cells["trade"].Value = Convert.ToDecimal(dr["trade"]).ToString("###.00");
                    gv.Cells["quantity"].Value = Convert.ToDecimal(dr["quantity"]).ToString("###.00");
                    gv.Cells["it_free"].Value = Convert.ToDecimal(dr["it_free"]).ToString("###.00");
                    gv.Cells["tax_rate"].Value = Convert.ToDecimal(dr["tax_rate"]).ToString("###.00");
                    gv.Cells["disper"].Value = Convert.ToDecimal(dr["disper"]).ToString("###.00");
                    gv.Cells["amount"].Value = Convert.ToDecimal(dr["amount"]).ToString("###.00");
                    dgPiGrid.Rows.Add(gv);
                }
                lbl_ItemNo.Text = "No of Item : " + dgPiGrid.Rows.Count.ToString("##");
                DataRow[] drary1 = ds.Tables[1].Select();
                foreach (DataRow dr1 in drary1)
                {
                    //Conversion.Val(txtQty.Text)).ToString("###.00");
                    txtTotal.Text = dr1["inv_total"].ToString();
                    txtTotal.Text = Conversion.Val(txtTotal.Text).ToString("###.00");

                    txtDiscount.Text = dr1["inv_discount"].ToString();
                    txtDiscount.Text = Conversion.Val(txtDiscount.Text).ToString("###.00");

                    txtCGST.Text = Conversion.Val(dr1["CGST_AMT"].ToString()).ToString("###.00");
                    txtSGST.Text = Conversion.Val(dr1["SGST_AMT"].ToString()).ToString("###.00");
                    txtIGST.Text = Conversion.Val(dr1["IGST_AMT"].ToString()).ToString("###.00");

                    txtTax.Text = dr1["inv_tax"].ToString();
                    txtTax.Text = Conversion.Val(txtTax.Text).ToString("###.00");


                    txtPay.Text = dr1["roundoff"].ToString();
                    txtPay.Text = Conversion.Val(txtPay.Text).ToString("###.00");
                    txtNet.Text = dr1["netamount"].ToString();
                    txtNet.Text = Conversion.Val(txtNet.Text).ToString("###.00");
                    txtInvoiceNo.Text = dr1["inv_no"].ToString();
                    dtpInvDate.Text = dr1["inv_date"].ToString();
                    txtInvoiceNo.Text = dr1["inv_no"].ToString();
                    string[] x;
                    x = dr1["vend_name"].ToString().Split(',');
                    cmbStockistName.Text = x[0].ToString();
                    txtStockistAddress.Text = dr1["vend_name"].ToString();
                    if (dr1["voucher_no"].ToString().Length > 10)
                    {
                        btnComplete.Enabled = false;
                        lblPosted.Text = "This bill is Already Posted";
                    }
                    else
                    {
                        btnComplete.Enabled=true;
                        lblPosted.Text = "Please Post The Bill";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            
            }
        }
      
        private void OnLoaded(object sender, EventArgs args)
        {
          
        }
        private void btnFillRecords_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fillListView();
            Cursor.Current = Cursors.Default;
        }
        private void cmbPurchOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
            txtPurchaseId.Text = cmbPurchOrder.Text;
            if (cmbPurchOrder.Text == "AUTO GENERATE")
            {
                newBillProcess();
            }
        }

        private void newBillProcess()
        {
            ClearAll();
            dgPiGrid.Rows.Clear();
            cmbStockistName.SelectedIndexChanged -= new EventHandler(cmbStockistName_SelectedIndexChanged);
            cmbStockistName.SelectedIndex = -1;
            cmbStockistName.Select();
            txtStockistAddress.Text = "";
            txtProdName.TextChanged -= new EventHandler(txtProdName_TextChanged);
            txtProdName.Text = "";
            txtInvoiceNo.Text = "";

            txtTotal.Text = "";
            txtTax.Text = "";
            txtDiscount.Text = "";
            txtNet.Text = "";
            txtPay.Text = "";
            cmbStockistName.SelectedIndexChanged += new EventHandler(cmbStockistName_SelectedIndexChanged);
            txtProdName.TextChanged += new EventHandler(txtProdName_TextChanged);
        }

        public void ClearAll()
        {
            txtBatchNo.Text = "";
            txtExpDate.Text ="";
            txtTrade.Text = "0";
            txtMRP.Text = "0";
            txtQty.Text = "0";
            txtFreeQty.Text = "0";
            txtDis_Per.Text = "0";
            txtAmount.Text ="0";
            txtProdName.Text = "";
            txtTrade.Enabled = true;
        }
        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return | e.KeyCode == Keys.Down) && (lv_Product.Items.Count > 0 && txtProdName.Text.Length > 0))
            {
                lv_Product.Focus();
                lv_Product.Items[0].Selected = true;
            }
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
              
               if(txtProdName.Text.Length >3)
               {
                Cursor.Current = Cursors.WaitCursor;
                lv_Product.Location = new System.Drawing.Point(4, 208);//5, 187);
                lv_Product.Size = new System.Drawing.Size(423, 150);
                lv_Product.Visible = true;
                lv_Product.Items.Clear();
                try
                   {
                       string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','SearchProductForPurchase','" + txtProdName.Text + "','N/A','N/A'";
                       ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                       foreach (DataRow dr in ds.Tables[0].Rows)
                       {
                           ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                           ls.SubItems.Add(dr["Item_Name"].ToString());
                           ls.SubItems.Add(dr["hsn"].ToString());
                           ls.SubItems.Add(dr["pack_type"].ToString());
                           ls.SubItems.Add(dr["pack_qty"].ToString());
                           ls.SubItems.Add(dr["taxIncluded"].ToString());
                           ls.SubItems.Add(dr["prodType"].ToString());
                           lv_Product.Items.Add(ls);
                       }
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
               
                   }

               }
               Cursor.Current = Cursors.Arrow;
        }
        string _productType = string.Empty;
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
                txtProdName.TextChanged -= new EventHandler(txtProdName_TextChanged);
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                txtProdName.TextChanged += new EventHandler(txtProdName_TextChanged);
                txtHSNCode.Text = lv_Product.FocusedItem.SubItems[2].Text;
                cmbPackSize.Text = lv_Product.FocusedItem.SubItems[3].Text;
                txtPackqty.Text = lv_Product.FocusedItem.SubItems[4].Text;
                _productType=lv_Product.FocusedItem.SubItems[6].Text;
                lblProdType.Text = "Product Type : " + _productType;
                lv_Product.Visible = false;
                if (_productType.Contains("RawMaterial"))
                {
                    txtHSNCode.Text = "-";
                    txtBatchNo.Text = "-";
                    cmbTax.Text = "1";
                    cmbTax.Enabled = true;
                    txtPerc.Text = "0";
                    txtTrade.Focus();
                }
                else
                {
                    txtBatchNo.Focus();
                    cmbTax.Text = "0";
                    cmbTax.Enabled = true;
                    txtPerc.Text ="0";
                }
            }
        }
        private void txtBatchNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtExpDate.Select();
            }
        }
        private void cmbManufacurer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
               txtHSNCode.Select();
            }
        }
        protected string getExpDate(string txtDate)
        {
            if (txtDate.Length == 0)
            { MessageBox.Show("Enter date", "ExPro Help"); return "Fail"; }
            if (txtDate.Length > 0)
            {
                if (txtDate == "-")
                { pExpDate = "1900-01-01"; return pExpDate; }

                int dasCaount = 0;
                char[] Char1 = txtDate.ToCharArray(0, txtDate.Length);
                foreach (char s in Char1)
                {
                    if (s == '-') { dasCaount = dasCaount + 1; }
                }
                if (dasCaount == 0 || dasCaount > 1)
                { return "Fail"; }

                if (txtDate.Length > 5 || txtDate.Length < 5)
                { return "Fail"; }
                string[] t = txtDate.Split('-');
                if (t[0].Length > 2 || t[0].Length < 2)
                { return "Fail"; }
                if (t[1].Length > 2 || t[1].Length < 2)
                { return "Fail"; }
                try { if (Convert.ToInt32(t[0]) > 12) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                try { if (Convert.ToInt32(t[1]) > 1000) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                string century = DateTime.Now.ToString("yyyy").Substring(0, 2);
                pExpDate = century + t[1] + '-' + t[0] + '-' + "01";
            }
            return pExpDate;
        }
        private void txtExpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtTrade.Focus();
        }
        private void txtTrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtMRP.Focus();
                txtReason.Text = "";
               _PurchAllow = "Y";
               _BestRate = 0;
                panelRemark.Visible = false;
            }
        }
        private void txtTrade_Enter(object sender, EventArgs e)
        {
            txtTrade.Select();
        }
        private void txtMRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                cmbPackSize .Focus();
        }
        private void txtMRP_Enter(object sender, EventArgs e)
        {
            txtMRP.Select();
            if (_productType.ToUpper() != "RETAIL")
            {
                txtMRP.Text = txtTrade.Text;
                txtMRP.ReadOnly = true;
            }
            else
            {
                txtMRP.ReadOnly = false;
            }
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtFreeQty.Focus();
        }
        private void txtQty_Enter(object sender, EventArgs e)
        {
            txtQty.Select();
        }
        private void txtFreeQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!_productType.Contains("RawMaterial"))
                {
                    cmbTax.Focus();
                  
                }
                else
                { txtDis_Per.Focus(); }

            }
        }
        private void txtFreeQty_Enter(object sender, EventArgs e)
        {
            txtFreeQty.SelectAll();
        }
      
        private void txttaxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtDis_Per.Focus();
        }
        private void txtDis_Per_Enter(object sender, EventArgs e)
        {
            txtDis_Per.Select();

        }
        private void txtDis_Per_Leave(object sender, EventArgs e)
        {
            if (txtDis_Per.Text.Length == 0)
            {
                txtDis_Per.Text = "0";
            }
        }
        private void txtDis_Per_KeyDown(object sender, KeyEventArgs e)
        {
            decimal stkqty = 0;
            string packqty= txtPackqty.Text;
            if (e.KeyCode == Keys.Return)
            txtAmount.Text = (Conversion.Val(txtTrade.Text) * Conversion.Val(txtQty.Text)).ToString("###.00");
            if (e.KeyCode == Keys.Return)
            {
                stkqty=Conversion.Val(txtQty.Text)*Conversion.Val(packqty);
                DialogResult res = MessageBox.Show("Stock Will Be Updated By "+stkqty.ToString("###")+" Qty", "Stock Updation Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    InsertPurchase();
                }
                else
                {
                    txtProdName.Focus();
                }
            }
            Cursor.Current = Cursors.Arrow;
        }
        public void InsertPurchase()
        {
                Cursor.Current = Cursors.WaitCursor;
                string[] Fill_Record_Info = new string[23];
                //Insert Purchase Record
                Cursor.Current = Cursors.WaitCursor;
                pmfd_id ="";
                if (txtPackqty.Text=="" || Convert.ToInt32(txtPackqty.Text)==0)
                {
                    MessageBox.Show("input proper Pack qty");
                    return;
                }
                if (pvendor_code == "Select")
                {
                    MessageBox.Show("Select Vendor ");
                    return;
                }
                if (txtInvoiceNo.Text == "")
                {
                    MessageBox.Show("Select Invoice No ");
                    return;
                }
                if (dtpInvDate.Text == "")
                {
                    MessageBox.Show("Select Invoice Date ");
                    return;
                }
            if (Convert.ToDecimal(txtMRP.Text)< Convert.ToDecimal(txtTrade.Text))
            {
                MessageBox.Show("Select/Check MRP");
                return;
            }

            string _exp_date =string.Empty;
                if (txtExpDate.Text != "")
                {
                    string[] t = txtExpDate.Text.Split('-');
                    DateTime dt = new DateTime(Convert.ToInt32("20" + t[1]), Convert.ToInt32(t[0]), 1);
                    _exp_date = dt.ToString("yyyy-MM-dd");
                }
                else
                {
                    _exp_date ="1900-01-01";
                    panelRemark.Visible = false;
                }
                string token = "";
                try
                {
                    token = GlobalUsage.canteenProxy.Ins_Purchase(txtPurchaseId.Text, GlobalUsage.gUnit_Id, GlobalUsage.gCmpCode, _BillType, pvendor_code, txtInvoiceNo.Text, Convert.ToDateTime(dtpInvDate.Value).ToString("yyyy/MM/dd"), pItem_Id, txtHSNCode.Text, pmfd_id, txtBatchNo.Text, _exp_date, Convert.ToDecimal(txtMRP.Text), Convert.ToDecimal(txtTrade.Text),
                    cmbPackSize.Text,Convert.ToInt32(txtPackqty.Text), Convert.ToInt32(txtQty.Text), Convert.ToInt32(txtFreeQty.Text), Convert.ToDecimal(txtDis_Per.Text), tax_id, _BestRate, txtReason.Text, GlobalUsage.gLogin_id);
                    txtReason.Text = "";
                    _PurchAllow = "Y";
                    _BestRate = 0;
                    txtPurchaseId.Text = token;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
                }
                fillListView();
                ClearAll();
                txtProdName.Select();
                Cursor.Current = Cursors.Default;
        }
        public decimal CheckBestRateConstraints(string vend_code, string mfd_id, string item_id, string pack_size, decimal rate)
        {
           DataSet ds=lws.GetQueryResult("pCheckBestRateInfo '"+vend_code+"','"+mfd_id+"','"+item_id+"','"+pack_size+"' ","eIM_Data");
           if(Convert.ToDecimal(ds.Tables[0].Rows[0][0])!=0)
           {
               if(Convert.ToDecimal(txtTrade.Text)>Convert.ToDecimal(ds.Tables[0].Rows[0][0]))
               {
                  _PurchAllow="N";
                  this.panelRemark.Location = new System.Drawing.Point(813, 209);
                  panelRemark.Visible = true;
                  txtReason.Focus();
               }
               else
               {
                  _PurchAllow="Y";
                   panelRemark.Visible =false;
               }
           }
           return Convert.ToDecimal(ds.Tables[0].Rows[0][0]);
        }
        private void txtDis_Per_MouseClick(object sender, MouseEventArgs e)
        {
            txtDis_Per.SelectAll();
        }
        private void cmbStockistName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
            pvendor_code = ((ExproComboBox)cmbStockistName.SelectedItem).Value;
            txtStockistAddress.Text = cmbStockistName.Text.ToString () ;
        }
        private void cmbStockistName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtInvoiceNo.Focus();
        }
        public string DateToSql(DateTime dtp)
        {
            string temp;
            temp = dtp.ToString("yyyy/MM/dd");
            return temp;
        }
        private void txtInvoiceNo_Enter(object sender, EventArgs e)
        {
            txtInvoiceNo.Select();
        }
        private void dtpInvDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtProdName.Focus();
        }
        private void txtInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                dtpInvDate .Focus();
        }
        private void cmbPackSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtQty.Focus();
        }
     
        private void cmbTaxType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                cmbTax.Focus();
        }
        private void cmbTax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                dgTaxList.Visible = true;
                dgTaxList.Focus();
                dgTaxList.Location = new Point(905, 207);
                dgTaxList.Rows[0].IsSelected = true;
            }
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            string postIn = ((ExproComboBox)cmbCash_Credit.SelectedItem).Value;
            if(postIn=="Select")
            {
                MessageBox.Show("Select Payment Mode?", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string[] Fill_Record_Info = new string[6];
            Fill_Record_Info[0] = txtPurchaseId.Text;
            Fill_Record_Info[1] = txtAdjusted.Text;
            Fill_Record_Info[2] = txtPlusMinus .Text ;
            Fill_Record_Info[3] = postIn;
            Fill_Record_Info[4] = "N/A";
            Fill_Record_Info[5] = GlobalUsage.gLogin_id;
            string token = "";
            try
            {
                token =GlobalUsage.canteenProxy.PurchasePosting(Fill_Record_Info);
                MessageBox.Show(token);
                cmbPurchOrder.Text = "AUTO GENERATE";
                //newBillProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            
            }
            
       }
        private void lv_PurchBillInfo_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtQty_Leave(object sender, EventArgs e)
        {
            txtAmount.Text=(Convert.ToDecimal(txtTrade.Text) * Convert.ToDecimal(txtQty.Text)).ToString();
            decimal stkqty = Convert.ToDecimal(txtPackqty.Text) * Convert.ToDecimal(txtQty.Text);
        }
        private void btn_FillBill_Click(object sender, EventArgs e)
        {

        }
        private void cmbPackSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pPackSize = ((ExproComboBox)cmbPackSize.SelectedItem).NewDescription;
        }
        private void grpPament_Enter(object sender, EventArgs e)
        {

        }
        private void Lfc_BillFeeding_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.P)
            {
                PH_byItem obj = new PH_byItem(pItem_Id);
                obj.Owner = this;
                obj.Show();
            }
        }
        private void txtReason_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panelRemark.Visible = false;
                InsertPurchase();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet purchds = lws.GetQueryResult("pGetPurchBillPrint '" + txtPurchaseId.Text + "' ", "eIM_Data");
            eChandanCanteen.CrPrintPurch crt = new eChandanCanteen.CrPrintPurch();
            crt.Database.Tables[0].SetDataSource(purchds.Tables[0]);
            crt.Database.Tables[1].SetDataSource(purchds.Tables[1]);
            crt.Database.Tables[2].SetDataSource(purchds.Tables[2]);
            crt.SetParameterValue("Checkedby", purchds.Tables[2].Rows[0]["app_by"].ToString());
            frmCommonRpt frm = new frmCommonRpt();
            frm.crystalReportViewer1.ReportSource = crt;
            Cursor.Current = Cursors.Default;
            frm.Show();
        }

        private void rbEstimate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstimate.Checked)
                _BillType = "E";
           
        }

        private void rb_TaxInv_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_TaxInv.Checked)
                _BillType = "T";
        }

        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            string result;
            Cursor.Current = Cursors.WaitCursor;
            if(MessageBox.Show("Are You Sure Want To Delete", "Expro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    result =GlobalUsage.canteenProxy.Delete_Purchase(dgPiGrid.CurrentRow.Cells["auto_id"].Value.ToString(), txtPurchaseId.Text);
                    if (result == "ItemDeleted")
                    {
                        dgPiGrid.CurrentRow.Delete();
                    }
                    else
                    {
                        MessageBox.Show("Can not delete item  because Invoice has already Posted ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private void dgTaxList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tax_id = Convert.ToInt32(dgTaxList.CurrentRow.Cells["tax_id"].Value);
                cmbTax.Text = tax_id.ToString();
                dgTaxList.Visible = false;
                txtPerc.Text =dgTaxList.CurrentRow.Cells["tax_rate"].Value.ToString();
                txtDis_Per.Focus();
                txtDis_Per.Select();
            }
        }

        private void txtHSNCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBatchNo.Focus();
            }
        }

      
       }
     
   }


