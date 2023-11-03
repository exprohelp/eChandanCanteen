using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System.IO;

namespace eChandanCanteen
{
    
    public partial class WareHouseStock : Form
    {
        DataTable dt = new DataTable();
        DataSet _ds = new DataSet();
        string Logic = "Not_Zero";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public WareHouseStock()
        {
            InitializeComponent();
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblItem.Text = "XXXX";
            lv_Detail.Items.Clear();
            btn_trfToxl.Enabled = false;
            btnPrint.Enabled = false;
            if (chkZero.Checked)
                Logic = "INC_ZERO";
            else
                Logic = "Not_Zero";
            try
            {
                _ds = lws.GetQueryResult("execute pWareHouseStock '"+GlobalUsage.gUnit_Id+"','"+Logic+"' ", "eIM_Data");
                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    lblItem.Text = _ds.Tables[0].Rows.Count.ToString();
                    btnPrint.Enabled = true;
                    btn_trfToxl.Enabled = true;
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem lvi=new ListViewItem(dr["item_name"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["lp_date"]).ToString("dd-MM-yyyy"));
                        lvi.SubItems.Add(dr["lp_qty"].ToString());
                        lvi.SubItems.Add(dr["exp_date"].ToString());
                        lvi.SubItems.Add(Convert.ToDecimal(dr["best_rate"]).ToString("##.##"));
                        lvi.SubItems.Add(dr["qty"].ToString());
                        lv_Detail.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        
        }
   
        private void btn_trfToxl_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            Fbd.ShowDialog();
            string path = Fbd.SelectedPath + "\\WareHousestock_" + System.DateTime.Now.ToString("ddMMyyyy")+".csv";
            Cursor.Current = Cursors.WaitCursor;
            CreateCSVFile(_ds.Tables[0],path);
            Cursor.Current = Cursors.Default;
        }
         public void CreateCSVFile(DataTable dt, string strFilePath)
        {
            #region Export Grid to CSV
            // Create the CSV file to which grid data will be exported.
            StreamWriter sw = new StreamWriter(strFilePath, false);
            // First we will write the headers.
            //DataTable dt = m_dsProducts.Tables[0];
            int iColCount = dt.Columns.Count;
            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }

            sw.Write(sw.NewLine);
            // Now write all the rows.
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        sw.Write(dr[i].ToString());
                    }
                    if (i < iColCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
            #endregion
        }

        private void pbZeroStockUpdate_Click(object sender, EventArgs e)
        {

        }
 
       

        

       
       

        

       
    }
}
