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
    public partial class BillingAnalysis : Form
    {
        DateTime pFromDate= new DateTime();
        DateTime pToDate = new DateTime();
        DataSet pDS = new DataSet();
      
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient ws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public BillingAnalysis()
        {
            InitializeComponent();
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                pFromDate = dtFrom.Value;
                pToDate = dtTo.Value;
                backgroundWorker1.RunWorkerAsync();
                pbPurchageFillInfo.Visible = true;
             }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
              string qry = @"exec PurchaseBillAnalysis '" + pFromDate.ToString("yyyy/MM/dd") + "','" + pToDate.ToString("yyyy/MM/dd") + "' ";
              try { pDS = ws.GetQueryResult(qry, "eIM_Data"); }
              catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillData();
            pbPurchageFillInfo.Visible = false;
        }
        private void FillData()
        {
            if (pDS.Tables.Count > 0)
            {
                lv_Detail.Items.Clear();
                decimal total = 0;
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    string temp = "Temp";
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        if (temp != dr["vend_name"].ToString())
                        {
                            lv_Detail.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                            temp = dr["vend_name"].ToString();
                        }
                        if (Convert.ToInt32(dr["daycount"]) > 15)
                        {
                            ListViewItem lvi = new ListViewItem(dr["PURCH_ID"].ToString());
                            lvi.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MMM-yyyy"));
                            lvi.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MMM-yyyy"));
                            lvi.SubItems.Add(dr["daycount"].ToString());
                            lvi.SubItems.Add(Convert.ToDecimal(dr["roundoff"]).ToString("####.00"));
                            lvi.SubItems.Add(dr["emp_name"].ToString());
                            lvi.Group = lv_Detail.Groups[dr["vend_name"].ToString()];
                            lv_Detail.Items.Add(lvi).BackColor=Color.Red;
                            total+= Convert.ToDecimal(dr["roundoff"]);
                        }
                        else
                        {
                            ListViewItem lvi = new ListViewItem(dr["PURCH_ID"].ToString());
                            lvi.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MMM-yyyy"));
                            lvi.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MMM-yyyy"));
                            lvi.SubItems.Add(dr["daycount"].ToString()); 
                            lvi.SubItems.Add(Convert.ToDecimal(dr["roundoff"]).ToString("####.00"));
                            lvi.SubItems.Add(dr["emp_name"].ToString());
                            lvi.Group = lv_Detail.Groups[dr["vend_name"].ToString()];
                            lv_Detail.Items.Add(lvi);
                            total+= Convert.ToDecimal(dr["roundoff"]);
                        }
                    }
                    lblTotal.Text = "Total Amount : "+total.ToString("##.##");
                }
            }
        }
        private void BillingAnalysis_Load(object sender, EventArgs e)
        {
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd/MM/yyyy";
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
        }
   

     
      
    }
}
