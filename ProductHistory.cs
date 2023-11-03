using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eChandanCanteen.Inventory_WebServices;
namespace eChandanCanteen
{
    public partial class ProductHistory : Form
    {
        Inventory_WebServicesSoapClient lws = new Inventory_WebServicesSoapClient();
        DateTime pFromDate = new DateTime();
        DateTime pToDate = new DateTime();
        DataSet dsProduct = new DataSet();
        DataSet dsHistory = new DataSet();
        string pItemId = "";
        string pAction = "";
        public ProductHistory()
        {
            InitializeComponent();
        }
        public void FillProduct()
        {
            cmbModSelectProd.Items.Add(new ExproComboBox("Select", "Select"));
            if (dsProduct.Tables.Count > 0)
            {
                if (dsProduct.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsProduct.Tables[0].Rows)
                    {
                        cmbModSelectProd.Items.Add(new ExproComboBox(dr["item_id"], dr["item_name"].ToString()));
                    }
                }
            cmbModSelectProd.SelectedIndex =0;
            }
        }
        private void ProductHistory_Load(object sender, EventArgs e)
        {
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd/MM/yyyy";
            try
            {
              dsProduct = lws.GetQueryResult("Select Item_id,item_name from item_master where item_name!='' order by item_name ", "eIM_Data");
              FillProduct();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if(pAction=="ProductHistory")
            {
                string qry = @"exec pProductHistory '" + pFromDate.ToString("yyyy/MM/dd") + "','" + pToDate.ToString("yyyy/MM/dd") + "','" + pItemId + "','by_date'  ";
                try { dsHistory=lws.GetQueryResult(qry, "eIM_Data"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
             if(pAction == "LoadProduct")
                 FillProduct();
             if (pAction == "ProductHistory")
                 FillData();    
                 pbPurchageFillInfo.Visible = false;
        }
        private void FillData()
        {
            if (dsHistory.Tables.Count > 0)
            {
                lv_Detail.Items.Clear();
                if (dsHistory.Tables[0].Rows.Count > 0)
                {
                    string temp = "Temp";
                    foreach (DataRow dr in dsHistory.Tables[0].Rows)
                    {
                        if (temp != dr["vend_name"].ToString())
                        {
                            lv_Detail.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                            temp = dr["vend_name"].ToString();
                        }
                       ListViewItem lvi = new ListViewItem(dr["mfd_name"].ToString());
                       lvi.SubItems.Add(dr["inv_no"].ToString());
                       lvi.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MMM-yyyy"));
                       lvi.SubItems.Add(dr["pack_type"].ToString());
                       lvi.SubItems.Add(dr["pack_qty"].ToString());
                       lvi.SubItems.Add(Convert.ToDecimal(dr["Quantity"]).ToString("##"));
                       lvi.SubItems.Add(Convert.ToDecimal(dr["NPR"]).ToString("####.00"));
                       lvi.Group = lv_Detail.Groups[dr["vend_name"].ToString()];
                       lv_Detail.Items.Add(lvi);
                       
                    }
                    
                }
            }

        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                pItemId = ((ExproComboBox)cmbModSelectProd.SelectedItem).Value;
                pFromDate =dtFrom.Value;
                pToDate =dtTo.Value;
                backgroundWorker1.RunWorkerAsync();
                pbPurchageFillInfo.Visible = true;
                pAction ="ProductHistory";
            }
     
        }
        private void cmbModSelectProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   
    }
}
