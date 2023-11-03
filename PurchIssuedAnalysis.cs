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
    public partial class PurchIssuedAnalysis : Form
    {
        string _Action = "";
        string _Item_Id = "";
        string _item_name = "";
        Inventory_WebServicesSoapClient lws = new Inventory_WebServicesSoapClient();
        DataSet  _ds = new DataSet();
        public PurchIssuedAnalysis()
        {
            InitializeComponent();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_Action == "LoadProduct")
            {
                try { _ds =lws.GetQueryResult("Select Item_id,item_name from item_master where item_name!='' order by item_name ", "eIM_Data"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (_Action == "ProductHistory")
            {
                string qry=@"exec pGetPurchaseAndIssuedList '"+_Item_Id+"' ";
                try { _ds = lws.GetQueryResult(qry, "eIM_Data"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "LoadProduct")
                FillProduct();
            if (_Action == "ProductHistory")
                FillData();
            pbPurchageFillInfo.Visible = false;  
        }
        public void FillProduct()
        {
            cmbModSelectProd.Items.Add(new ExproComboBox("Select", "Select"));
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        cmbModSelectProd.Items.Add(new ExproComboBox(dr["item_id"], dr["item_name"].ToString()));
                    }
                    cmbModSelectProd.SelectedIndex = 0;
                }
            }
        }
        private void FillData()
        {
            m_list.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                int purch_qty = 0;
                int issue_qty = 0;
                int bal = 0;
              
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    int count = 1;
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        if (count == 1)
                        {
                            purch_qty = Convert.ToInt32(dr["purch_qty"]);
                            m_list.Items.Add("Head Office (Lucknow)");
                            m_list.Items[m_list.Items.Count - 1].SubItems.Add(purch_qty.ToString());
                            m_list.Items[m_list.Items.Count - 1].SubItems.Add("0");
                            m_list.Items[m_list.Items.Count - 1].SubItems.Add(Convert.ToInt32(dr["purch_qty"]).ToString());
                            bal = Convert.ToInt32(dr["purch_qty"]);
                        }
                        else
                        {
                            bal = bal - Convert.ToInt32(dr["Dispatch_qty"]);
                            m_list.Items.Add(dr["unit_name"].ToString());
                            m_list.Items[m_list.Items.Count - 1].SubItems.Add("0");
                            m_list.Items[m_list.Items.Count - 1].SubItems.Add(Convert.ToInt32(dr["Dispatch_qty"]).ToString());
                            m_list.Items[m_list.Items.Count - 1].SubItems.Add(bal.ToString());
                            issue_qty+=Convert.ToInt32(dr["Dispatch_qty"]);
                        }
                        count++;
                       
                    }
                    m_list.Items.Add("");
                    m_list.Items[m_list.Items.Count - 1].SubItems.Add("Total Dispatch");
                    m_list.Items[m_list.Items.Count - 1].SubItems.Add(issue_qty.ToString());
                    m_list.Items[m_list.Items.Count - 1].SubItems.Add("");
               }
            }
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                 pbPurchageFillInfo.Visible = true;
                _Action = "ProductHistory";
                 backgroundWorker1.RunWorkerAsync();
             }
        }
        private void PurchIssuedAnalysis_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                pbPurchageFillInfo.Visible = true;
                _Action = "LoadProduct";
                backgroundWorker1.RunWorkerAsync();
            }
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
       
        }
        private void cmbModSelectProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Item_Id =((ExproComboBox)cmbModSelectProd.SelectedItem).Value;
            _item_name= ((ExproComboBox)cmbModSelectProd.SelectedItem).NewDescription;
        }
        private void btnprintpreiview_Click(object sender, EventArgs e)
        {
            m_list.Title = "Produc Name : " + _item_name + "";
            m_list.FitToPage =true;
            m_list.PrintPreview();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            m_list.Title = "Produc Name : " + _item_name + "";
            m_list.FitToPage = true;
            m_list.Print();
        }
    }
}
