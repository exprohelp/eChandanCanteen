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
    public partial class InterUnit_Transfer : Form
    {
        
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        string pItem_Id = "";
        string pmfd_id = "";
        decimal total_amt = 0;
        public InterUnit_Transfer()
        {
            InitializeComponent();
        }
        private void InterUnit_Transfer_Load(object sender, EventArgs e)
        {
            DataSet ds= lws.GetQueryResult("Select * from inter_unit order by unit_name ","eIM_Data");
            cbxInterUnit.DisplayMember = "unit_name";
            cbxInterUnit.ValueMember = "unit_id";
            cbxInterUnit.DataSource = ds.Tables[0];
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lv_Product.Location = new System.Drawing.Point(5, 0);//5, 187);
            lv_Product.Size = new System.Drawing.Size(280, 150);
            lv_Product.Visible = true;
            lv_Product.Items.Clear();
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                if (txtProdName.Text.Length > 0)
                {
                    DataSet ds = lws.SearchProduct(txtProdName.Text);
                    DataRow[] drary = ds.Tables[0].Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
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
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                lv_Product.Visible = false;
                Cursor.Current = Cursors.WaitCursor;
                string result = CheckInternet.CheckNet();
                if (result == "TRUE")
                {
                    DataSet ds = lws.getMfdAndPackOfItem(pItem_Id);
                    if (ds.Tables.Count == 2)
                    {
                        DataRow[] drary = ds.Tables[0].Select();
                        cmbManufacurer.Items.Clear();
                        foreach (DataRow dr in drary)
                        {
                            cmbManufacurer.Items.Add(dr["mfd_name"].ToString());
                            pmfd_id = dr["mfd_id"].ToString();
                        }
                        cmbManufacurer.Text = "Select";
                        DataRow[] drary1 = ds.Tables[1].Select();
                        cmbPackSize.Items.Clear();
                        foreach (DataRow dr1 in drary1)
                        {
                            cmbPackSize.Items.Add(dr1["pack_size"].ToString());
                        }
                        cmbPackSize.Text = "Select";
                    }
                    if ((object)cmbManufacurer.SelectedValue != null)
                        cmbManufacurer.SelectedIndex = 0;
                    if ((object)cmbPackSize.SelectedValue != null)
                        cmbPackSize.SelectedIndex = 0;
                }
                else
                {

                    MessageBox.Show("Check Internet Connection", "ExPro Help");
                }
                Cursor.Current = Cursors.Arrow;
                cmbManufacurer.Select();
            }

        }
        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return | e.KeyCode == Keys.Down) && (lv_Product.Items.Count > 0 && txtProdName.Text.Length > 0))
            {
                lv_Product.Focus();
                lv_Product.Items[0].Selected = true;
            }
        }
        private void cmbManufacurer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtBatchNo.Focus();
        }
        private void txtBatchNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               txtExpDate.Focus();
        }
        private void txtExpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               txtNpr.Focus();
        }
        private void txtNpr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbPackSize.Focus();
        }
        private void cmbPackSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtQty.Focus();
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
               string[] Fill_Record_Info = new string[13];
               if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPackSize.Text == "Select" || cmbPackSize.Text == "")
                    {
                        MessageBox.Show("Select Pack Size");
                        return;
                    }
                    if (cmbManufacurer.Text == "Select" || cmbManufacurer.Text == "")
                    {
                        MessageBox.Show("Select Manufacturer");
                        return;
                    }
                    if (txtTrfId.Text == "")
                    {
                        MessageBox.Show("Enter Transfer Id ");
                        return;
                    }
                    Fill_Record_Info[0] = txtTrfId.Text;
                    Fill_Record_Info[1] = GlobalUsage.gUnit_Id;
                    Fill_Record_Info[2] = cbxInterUnit.SelectedValue.ToString();
                    Fill_Record_Info[3] = GlobalUsage.gCmpCode;
                    Fill_Record_Info[4] = pmfd_id;
                    Fill_Record_Info[5] = pItem_Id;
                    Fill_Record_Info[6] = txtBatchNo.Text;
                    if (txtExpDate.Text != "")
                    {
                        string[] t = txtExpDate.Text.Split('-');
                        DateTime dt = new DateTime(Convert.ToInt32("20" + t[1]), Convert.ToInt32(t[0]), 1);
                        Fill_Record_Info[7] = dt.ToString("yyyy-MM-dd");
                    }
                    else
                        Fill_Record_Info[7] = "1900-01-01";
                    Fill_Record_Info[8] = txtNpr.Text;
                    Fill_Record_Info[9] = cmbPackSize.Text;
                    Fill_Record_Info[10] = txtQty.Text;
                    Fill_Record_Info[11] = "0";
                    Fill_Record_Info[12] = GlobalUsage.gLogin_id;
                    try
                    {
                        lws.InterUnitTransfer(Fill_Record_Info);
                        fillListView();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.ToString().Substring(1,200)); }
                }
        }
        private void txtFreeQty_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        public void fillListView()
        {
            lv_PurchBillInfo.Items.Clear();
            DataSet ds = lws.getTrfRecord(txtTrfId.Text,"HOLKO");
            DataRow[] drary = ds.Tables[0].Select();
            total_amt = 0;
            foreach (DataRow dr in drary)
            {
                ListViewItem ls = new ListViewItem(dr["rec_id"].ToString());
                ls.SubItems.Add(dr["item_name"].ToString());
                ls.SubItems.Add(dr["batch_no"].ToString());
                ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy"));
                ls.SubItems.Add(Convert.ToDecimal(dr["npr"]).ToString("###.00"));
                ls.SubItems.Add(dr["pack_type"].ToString());
                ls.SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("###.00"));
                ls.SubItems.Add(Convert.ToDecimal(Convert.ToString(Convert.ToDecimal(dr["npr"]) * Convert.ToDecimal(dr["qty"]))).ToString("###.00"));
                lv_PurchBillInfo.Items.Add(ls);
                lv_PurchBillInfo.Focus();
                total_amt += Convert.ToDecimal(dr["npr"]) * Convert.ToDecimal(dr["qty"]);
            }
            lblTotalAmt.Text =total_amt.ToString("###.00");
            txtProdName.Focus();
            txtProdName.Select();
        }
        private void cmbManufacurer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((object)cmbManufacurer.SelectedValue != null)
                pmfd_id = cmbManufacurer.SelectedValue.ToString();
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
                    result=lws.Delete_InterUnitTransferProduct(lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[0].Text);
                    if (result =="ItemDeleted")
                    {
                        total_amt=total_amt-Convert.ToDecimal(lv_PurchBillInfo.Items[index].SubItems[7].Text);
                        lblTotalAmt.Text = total_amt.ToString("###.00");
                        lv_PurchBillInfo.Items[index].Remove();
                    }
                    else
                    {
                        MessageBox.Show("Can not delete item  because it's Locked");
                    }
                }
            }
        }
        private void txtTrfId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fillListView();
            }
        }
        private void cmbManufacurer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBatchNo.Focus();
            }
        }
        private void btnPostTrf_Click(object sender, EventArgs e)
        {
            string voucher_no =lws.VoucherPosting(GlobalUsage.gUnit_Id, cbxInterUnit.Text, "STOCK TRANSFER", total_amt, "Vide Transfer Id No " + txtTrfId.Text, GlobalUsage.gLogin_id);
            MessageBox.Show(voucher_no);
        }
    
    }
}
