using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace   eChandanCanteen
{
    public partial class Opth_slip : Telerik.WinControls.UI.RadForm
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        string file_path = string.Empty;
        string _result = string.Empty;
        public Opth_slip()
        {
               InitializeComponent();
        }

        private void PDF_Viwer_Load(object sender, EventArgs e)
        {
            dtDate.Value = System.DateTime.Now;
            dtTo.Value = System.DateTime.Now;
            loadSlip();
        }
        private void loadSlip()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgOpthSlip.DataSource = lws.GetQueryResult(" execute [dbo].[pOpthalmic_Queries] '','" + dtDate.Value.ToString("yyyy/MM/dd") + "','" +dtTo.Value.ToString("yyyy/MM/dd") + "','','','OPTH-SLIP','' ", "Hospital").Tables[0];
            Cursor.Current = Cursors.Default;
   
        }
        private void dgOpthSlip_CommandCellClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                string order_no = string.Empty;
                Telerik.WinControls.UI.GridViewRowInfo row = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).RowInfo;
                if (((sender as Telerik.WinControls.UI.GridCommandCellElement)).Value.ToString() == "Open")
                { 
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                    try
                    {
                        byte[] data =lws.DownloadFile(row.Cells[7].Value.ToString(),out _result);
                        //this.radPdfViewer2.UnloadDocument();
                        System.IO.File.WriteAllBytes(Application.StartupPath + "\\" + "OPTHSLIP.PDF", data);
                       // this.radPdfViewer2.LoadDocument(Application.StartupPath + "\\" + "OPTHSLIP.PDF");
                        System.Diagnostics.Process.Start(Application.StartupPath + "\\" + "OPTHSLIP.PDF");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                }
                else if (((sender as Telerik.WinControls.UI.GridCommandCellElement)).Value.ToString() == "Not Confirmed")
                {
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                    try
                    {
                        _result = lws.QueryExecute("update OPTH_Documents set c_rec_flag='Y' where trn_no='" + row.Cells[0].Value.ToString() + "' and doctype='OPTH-SLIP' ", "Hospital");
                        if(_result.Contains("Success"))
                        {  MessageBox.Show("Successfully Confirmed");}
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                }
                else if (((sender as Telerik.WinControls.UI.GridCommandCellElement)).Value.ToString() == "Not Dispatched")
                {
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                    try
                    {
                        _result = lws.QueryExecute("update OPTH_Documents set c_trf_flag='Y' where trn_no='" + row.Cells[0].Value.ToString() + "' and doctype='OPTH-SLIP'  and c_rec_flag='Y' ", "Hospital");
                        if (_result.Contains("Success"))
                        { MessageBox.Show("Successfully Dispatched"); }
                        else
                        { MessageBox.Show("Not Dispatched"); }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btngO_Click(object sender, EventArgs e)
        {
            loadSlip();
        }
    }
}
