using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Server;
using ExPro.Client;
namespace eChandanCanteen
{
    public partial class BestRateManagement : Form
    {
        Inventory_WebServices.Inventory_WebServicesSoapClient ws = new Inventory_WebServices.Inventory_WebServicesSoapClient();
        public BestRateManagement()
        {
            InitializeComponent();
        }
        private void BestRateManagement_Load(object sender, EventArgs e)
        {
            string qry = @"select vend_name+','+address as vend_name,vend_code from vendor_info order by vend_name";
            DataSet ds =ws.GetQueryResult(qry,"eIM_Data");
            cbxVendor.Items.Clear();
            cbxVendor.Items.AddRange(Config.FillCombo(ds.Tables[0]));
            cbxVendor.SelectedIndex = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string qry = @"select item_name,item_id from item_master where item_name like '"+txtsearchKey.Text+"%'";
            try
            {
                DataSet ds = ws.GetQueryResult(qry, "eIM_Data");
                cbxItem.SelectedIndexChanged -= new EventHandler(cbxItem_SelectedIndexChanged);
                cbxItem.Items.Clear();
                cbxItem.Items.AddRange(Config.FillCombo(ds.Tables[0]));
                cbxItem.SelectedIndex = 0;
                cbxItem.SelectedIndexChanged += new EventHandler(cbxItem_SelectedIndexChanged);
            }
            catch (Exception ex) {MessageBox.Show(ex.Message);}
            Cursor.Current = Cursors.Default;
        }
        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string item_id= ((ExproComboBox)cbxItem.SelectedItem).Value;
            string qry ="select pack_size,pack_size pk from pack_size_info where item_id='" + item_id + "' ";
                  qry +="select mfd_name,mfd_id from mfd_master where item_id='" + item_id + "' order by mfd_name ";
          
            try
            {
                DataSet ds = ws.GetQueryResult(qry, "eIM_Data");
                cbxPackSize.Items.Clear();
                cbxPackSize.Items.AddRange(Config.FillCombo(ds.Tables[0]));
                cbxPackSize.SelectedIndex = 0;
                cbxMfd.Items.Clear();
                cbxMfd.Items.AddRange(Config.FillCombo(ds.Tables[1]));
                cbxMfd.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(((ExproComboBox)cbxVendor.SelectedItem).Value=="Select")
            { MessageBox.Show("Please select Vendor "); return; }
            if (((ExproComboBox)cbxMfd.SelectedItem).Value =="Select")
            { MessageBox.Show("Please select Manufacturer "); return ; }
            if (((ExproComboBox)cbxItem.SelectedItem).Value=="Select")
            { MessageBox.Show("Please select Product "); return; }
            if (((ExproComboBox)cbxPackSize.SelectedItem).Value == "Select")
            { MessageBox.Show("Please select Packs "); return ; }
            try
            {
                ws.CreateBestRate(((ExproComboBox)cbxVendor.SelectedItem).Value, ((ExproComboBox)cbxMfd.SelectedItem).Value, ((ExproComboBox)cbxItem.SelectedItem).Value, ((ExproComboBox)cbxPackSize.SelectedItem).Value, Convert.ToDecimal(txtBestRate.Text));
                FillBestRateInfo(((ExproComboBox)cbxItem.SelectedItem).Value); 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }
        public void FillBestRateInfo(string Item_id)
        {
            DataSet ds = ws.GetQueryResult(" exec pGetBestRateInfo '" + Item_id + "' ","eIM_Data");
            lvbestrateinfo.Items.Clear();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string temp="";
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (temp != dr["vend_name"].ToString())
                        {
                            lvbestrateinfo.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                            temp = dr["vend_name"].ToString();
                        }
                        ListViewItem ls = new ListViewItem(dr["mfd_name"].ToString());
                        ls.SubItems.Add(dr["item_name"].ToString());
                        ls.SubItems.Add(dr["pack_size"].ToString());
                        ls.SubItems.Add(Convert.ToDecimal(dr["app_rate"]).ToString("###.00"));
                        ls.SubItems.Add(dr["auto_id"].ToString());
                        ls.Group = lvbestrateinfo.Groups[dr["vend_name"].ToString()];
                        lvbestrateinfo.Items.Add(ls);
                    }
                }
                else
                { MessageBox.Show("No Record Exists"); }
            }
            else
            { MessageBox.Show("No Record Exists"); }
        }
        public void FillAllBestRateInfo(string Item_id)
        {
            DataSet ds = ws.GetQueryResult("exec pGetBestRateInfo '" + Item_id + "'","eIM_Data");
            lvReport.Items.Clear();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string temp = "";
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (temp != dr["vend_name"].ToString())
                        {
                            lvReport.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                            temp = dr["vend_name"].ToString();
                        }
                        ListViewItem ls = new ListViewItem(dr["mfd_name"].ToString());
                        ls.SubItems.Add(dr["item_name"].ToString());
                        ls.SubItems.Add(dr["pack_size"].ToString());
                        ls.SubItems.Add(Convert.ToDecimal(dr["app_rate"]).ToString("###.00"));
                        ls.SubItems.Add(dr["auto_id"].ToString());
                        ls.Group = lvReport.Groups[dr["vend_name"].ToString()];
                        lvReport.Items.Add(ls);
                    }
                }
                else
                { MessageBox.Show("No Record Exists"); }
            }
            else
            { MessageBox.Show("No Record Exists"); }
        }
        private void btnViewExisting_Click(object sender, EventArgs e)
        {
            FillBestRateInfo(((ExproComboBox)cbxItem.SelectedItem).Value); 
        }
        private void lvbestrateinfo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                string qry = @"delete from best_rate_info where auto_id=" + lvbestrateinfo.Items[lvbestrateinfo.FocusedItem.Index].SubItems[5].Text + "";
                ws.QueryExecute(qry, "eIM_Data");
                FillBestRateInfo(((ExproComboBox)cbxItem.SelectedItem).Value); 
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            FillAllBestRateInfo("N/A");
        }
    }
}
