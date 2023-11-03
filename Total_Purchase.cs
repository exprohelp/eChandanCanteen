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
    public partial class Total_Purchase : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();
        DateTime _FromDate = new DateTime();
        DateTime _ToDate = new DateTime();
        Inventory_WebServicesSoapClient lws = new Inventory_WebServicesSoapClient();
        public Total_Purchase()
        {
            InitializeComponent();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string qry = @"exec pPurchInfoDatewise '" + _FromDate.ToString("yyyy/MM/dd") + "','" + _ToDate.ToString("yyyy/MM/dd") + "' ";
            try { _ds = lws.GetQueryResult(qry, "eIM_Data"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rgvInfo.DataSource = _ds.Tables[0];
        
            pbPurchageFillInfo.Visible = false;
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                _FromDate = dtFrom.Value;
                _ToDate = dtTo.Value;
                pbPurchageFillInfo.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Process is running...");
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Telerik.WinControls.UI.Export.ExportToExcelML exporter = new Telerik.WinControls.UI.Export.ExportToExcelML(this.rgvInfo);
                exporter.SheetName = "Purchase";
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MIS";
                if (!System.IO.Directory.Exists(mydocpath))
                {
                    System.IO.Directory.CreateDirectory(mydocpath);
                }
                string fileName = mydocpath + "\\PurchaseInfo.xls";
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void Total_Purchase_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today;
        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }

       
    }
}
