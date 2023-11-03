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
using eChandanCanteen.Inventory_WebServices;
namespace eChandanCanteen
{
    public partial class goods_return : Form
    {
        string _Trf_ID = "New";
        DataSet ds = new DataSet();
        string pUnit_code, pItem_Id, pMaster_key_Id, pMfd_Id,pQty;
        DataSet _ds = new DataSet();
        string _Action = "";
        decimal total_amt = 0;
        Inventory_WebServicesSoapClient lws = new Inventory_WebServicesSoapClient();
        public goods_return()
        {
            InitializeComponent();
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            _Action = "SearchProduct";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return | e.KeyCode == Keys.Down) && (lv_Product.Items.Count > 0 && txtProdName.Text.Length > 0))
            {
                lv_Product.Focus();
                lv_Product.Items[0].Selected = true;
            }
        }
        private void cmbSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            pUnit_code = ((ExproComboBox)cmbSelectUnit.SelectedItem).Value;
        }
        private void cmbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                progressBar1.Visible = true;
                _Action = "ProductDetail";
                if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
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
                    pMfd_Id = lv_Details.FocusedItem.SubItems[7].Text;

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
        private void cmbUnitName_KeyDown(object sender, KeyEventArgs e)
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
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem ls = new ListViewItem(dr["Master_key_Id"].ToString());
                        ls.SubItems.Add(dr["rec_id"].ToString());
                        ls.SubItems.Add(dr["item_name"].ToString());
                        ls.SubItems.Add(dr["batch_no"].ToString());
                        ls.SubItems.Add(dr["pack_type"].ToString());
                        ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy"));
                         ls.SubItems.Add(dr["pack_qty"].ToString());
                        ls.SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("###"));
                        lv_PurchBillInfo.Items.Add(ls);
                        lv_PurchBillInfo.Focus();
                        lv_PurchBillInfo.Items[0].Selected = true;
                    }
                   txtTransferId.Text= _Trf_ID;
                }
               
            }
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
                        result = lws.Delete_TransferProduct(lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[1].Text,"N");
                        if (result == "ItemDeleted")
                        {
                            total_amt = total_amt - Convert.ToDecimal(lv_PurchBillInfo.Items[index].SubItems[9].Text);
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
            token = lws.CompleteTransfer(txtTransferId.Text);
            MessageBox.Show(token);
        }
        public void fillListViewNewRecord()
        {
            fillListView();
        }
        private void lv_Product_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
        }
        private void btnFillRecords_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_Action == "FillUnit")
            {
                try
                {
                    _ds = lws.GetQueryResult("select unit_name,unit_code from unit_info", "eIM_Data");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (_Action == "SearchProduct")
            {
                try
                {
                    string qry = @" SELECT im.item_id,im.item_Name, isnull((select SUM(qty) from stocks where unit_id = '" + pUnit_code + "' and  ";
                           qry+=" item_id=im.item_id),0) AS qty FROM  dbo.item_master im WHERE im.item_name like '"+txtProdName.Text+"'+'%' ";
                    _ds = lws.GetQueryResult(qry, "eIM_Data");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (_Action == "ProductDetail")
            {
                try
                {
                   _ds=lws.getProductIdentity(pItem_Id,pUnit_code,"-");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (_Action=="TransferProduct")
            {
                string[] Fill_Record_Info = new string[11];
                Fill_Record_Info[0] ="HOLKO";
                Fill_Record_Info[1] = pMaster_key_Id;
                Fill_Record_Info[2] = pQty;
                Fill_Record_Info[3] =_Trf_ID;
                Fill_Record_Info[4] = pMfd_Id;
                Fill_Record_Info[5] = pUnit_code;
                Fill_Record_Info[6] = GlobalUsage.gLogin_id;
                Fill_Record_Info[7] = "N/A";
                Fill_Record_Info[8] = "-";
                try
                {
                    string [] ar= lws.TransferStocks(Fill_Record_Info).Split('|');
                    _Trf_ID=ar[1];
                    _Action = "FillListView";
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (_Action =="FillListView")
            {
                try
                {
                    _ds = lws.GetQueryResult("exec GoodsReturnRec '" + _Trf_ID + "','" + pUnit_code + "' ","eIM_Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action =="FillUnit")
            {
                cmbSelectUnit.Items.Clear(); 
                cmbSelectUnit.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
                cmbSelectUnit.SelectedIndex =0;
            }
            if (_Action =="SearchProduct")
            {
                SearchProduct();
            }
            if (_Action =="ProductDetail")
            {
                ProductDetail();
            }
            if (_Action =="TransferProduct")
            {
                txtTransferId.Text=_Trf_ID;
            }
            if (_Action == "FillListView")
            {
                fillListView();
            }
            progressBar1.Visible = false;
        }
        private void goods_return_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            _Action = "FillUnit";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
        }
        public void ProductDetail()
        {
            lv_Product.Visible = false;
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    lv_Details.Location = new System.Drawing.Point(150, 62);//5, 187);
                    lv_Details.Size = new System.Drawing.Size(602, 170);
                    lv_Details.Visible = true;
                    lv_Details.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem ls = new ListViewItem(dr["master_key_id"].ToString());
                        ls.SubItems.Add(dr["batch_no"].ToString());
                        ls.SubItems.Add(dr["pack_type"].ToString());
                        ls.SubItems.Add(dr["pack_qty"].ToString());
                        ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy"));
                        ls.SubItems.Add(dr["mfd_name"].ToString());
                        ls.SubItems.Add(dr["mfd_id"].ToString());
                        ls.SubItems.Add(dr["qty"].ToString());
                        lv_Details.Items.Add(ls);
                    }
                    lv_Details.Focus();
                    lv_Details.Items[0].Selected = true;
                }
            }
           
        }
        public void SearchProduct()
        {
            lv_Product.Location = new System.Drawing.Point(2, 62);//5, 187);
            lv_Product.Size = new System.Drawing.Size(382,200);
            lv_Product.Visible = true;
            lv_Product.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem ls=new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
                        ls.SubItems.Add(dr["qty"].ToString());
                        lv_Product.Items.Add(ls);
                    }
                }

            }
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                pQty = txtQty.Text;
                progressBar1.Visible = true;
                _Action = "TransferProduct";
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

    }
}
        
