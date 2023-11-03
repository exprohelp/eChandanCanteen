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
    public partial class PH_byItem : Form
    {
        string _ItemId = "";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        DataSet dsHistory = new DataSet();
        public PH_byItem(string Item_id)
        {
            _ItemId = Item_id;
            InitializeComponent();
        }
        private void PH_byItem_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                pbPurchageFillInfo.Visible = true;
            }
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
       
        }
        private void FillData()
        {
            if (dsHistory.Tables.Count > 0)
            {
                lv_Detail.Items.Clear();
                if (dsHistory.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsHistory.Tables[0].Rows)
                    {
                        lv_Detail.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                    }
                    foreach (DataRow dr in dsHistory.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem("");
                        lvi.SubItems.Add(dr["mfd_name"].ToString());
                        lvi.SubItems.Add(dr["inv_no"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MMM-yyyy"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["Quantity"]).ToString("##"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("####.00"));
                        lvi.Group = lv_Detail.Groups[dr["vend_name"].ToString()];
                        lv_Detail.Items.Add(lvi);

                    }

                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             string qry = @"exec pProductHistory '1900/01/01','1900/01/01','"+_ItemId+"','by_item'  ";
             try { dsHistory = lws.GetQueryResult(qry, "eIM_Data"); }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillData();
            pbPurchageFillInfo.Visible = false;
        }

   
    }
}
