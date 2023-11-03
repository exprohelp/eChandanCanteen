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
    public partial class ItemWiseVendor : Form
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        DataSet ds = new DataSet();
        public ItemWiseVendor()
        {
            InitializeComponent();
        }
        private void lv_Product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            if (txtProdName.Text.Length > 0)
            {
                try
                {
                    ds = lws.SearchProduct(txtProdName.Text);
                    DataRow[] drary = ds.Tables[0].Select();
                    lv_Product.Items.Clear();
              
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
                        lv_Product.Items.Add(ls);
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

        private void lv_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string pItem_id=lv_Product.Items[lv_Product.FocusedItem.Index].SubItems[0].Text;
                    string qry = @"SELECT distinct dbo.Vendor_info.vend_Name, dbo.Purch_Master.comp_code, dbo.Purch_Master.Inv_No,dbo.Purch_Master.Inv_Date, dbo.Purch_Master.Purch_id 
                                 FROM  dbo.Purch_Items INNER JOIN dbo.Purch_Master ON dbo.Purch_Items.Purch_id = dbo.Purch_Master.Purch_id INNER JOIN
                                 dbo.Vendor_info ON dbo.Purch_Master.Vendor_Code = dbo.Vendor_info.vend_code where dbo.Purch_Items.item_id='" + pItem_id + "' and dbo.Purch_Master.comp_code='"+GlobalUsage.gCmpCode+"' order by dbo.Vendor_info.vend_Name";
                    ds = lws.GetQueryResult(qry,"eIM_Data");
                    FillData(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
            
                }


            }
        }
        private void FillData(DataSet pDS)
        {
            if (pDS.Tables.Count > 0)
            {
                lv_Vendor.Items.Clear();
                if (pDS.Tables[0].Rows.Count > 0)
                {
                   
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        lv_Vendor.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                    }
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem("");
                        lvi.SubItems.Add(dr["comp_code"].ToString());
                        lvi.SubItems.Add(dr["purch_Id"].ToString());
                        lvi.SubItems.Add(dr["inv_no"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MMM-yyyy"));
                        lvi.Group = lv_Vendor.Groups[dr["vend_name"].ToString()];
                        lv_Vendor.Items.Add(lvi);
                    }
                    lv_Vendor.Items[0].Selected = true;
                    lv_Vendor.Focus();
                }
              
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

        private void lv_Vendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
        private void FillPurchaseInfo(DataSet pDS)
        {
            if (pDS.Tables.Count > 0)
            {
                listView1.Items.Clear();
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        listView1.Items.Add(dr["item_name"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["mfd_name"].ToString());
                        listView1.Items[listView1.Items.Count-1].SubItems.Add(dr["batch_no"].ToString());
                        listView1.Items[listView1.Items.Count-1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                        listView1.Items[listView1.Items.Count-1].SubItems.Add(dr["pack_type"].ToString());
                        listView1.Items[listView1.Items.Count-1].SubItems.Add(dr["pack_qty"].ToString());
                        listView1.Items[listView1.Items.Count-1].SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("##.##"));
                        listView1.Items[listView1.Items.Count-1].SubItems.Add(Convert.ToDecimal(dr["npr"]).ToString("##.##"));
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToInt32(dr["Quantity"]).ToString());
                   }
                }
            }
            pDS.Clear();
        }

        private void lv_Vendor_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if ((object)lv_Vendor.FocusedItem != null)
            {
                string purch_id = lv_Vendor.Items[lv_Vendor.FocusedItem.Index].SubItems[2].Text;
                string qry = @"SELECT   distinct  TOP (100) PERCENT dbo.item_master.item_Name, dbo.Purch_Items.npr, dbo.Purch_Items.MRP, dbo.Purch_Items.pack_type, 
                                 dbo.Purch_Items.Batch_No, dbo.Purch_Items.Exp_Date, dbo.Purch_Items.pack_qty, dbo.Purch_Items.Quantity, dbo.mfd_master.mfd_name
                                 FROM  dbo.item_master INNER JOIN dbo.Purch_Items ON dbo.item_master.item_id = dbo.Purch_Items.Item_id INNER JOIN
                                 dbo.mfd_master ON dbo.Purch_Items.mfd_id = dbo.mfd_master.mfd_id WHERE dbo.Purch_Items.Purch_id = '" + purch_id + "' ORDER BY dbo.item_master.item_Name ";
                DataSet ds = lws.GetQueryResult(qry, "eIM_Data");
                FillPurchaseInfo(ds);
            }
        }

        private void ItemWiseVendor_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
       
        }


    }
}
