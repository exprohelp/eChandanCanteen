using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;

namespace   eChandanCanteen
{
    public partial class OPTH_Report : Telerik.WinControls.UI.RadForm
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        string file_path = string.Empty;
        string _result = string.Empty;
        public OPTH_Report()
        {
               InitializeComponent();
        }

        private void PDF_Viwer_Load(object sender, EventArgs e)
        {
            dtDate.Value = System.DateTime.Now;
            dtTo.Value = System.DateTime.Now;
            
        }
        private void loadSlip()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgOpthSlip.DataSource = lws.GetQueryResult(" execute [dbo].[pOpthalmic_Queries] '','" + dtDate.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','','','OPTH-DISPATCH-STATUS','' ", "Hospital").Tables[0];
            Cursor.Current = Cursors.Default;
        }
        private void btngO_Click(object sender, EventArgs e)
        {
            loadSlip();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ExportToExcelML exporter = new ExportToExcelML(this.dgOpthSlip);
            exporter.FileExtension = "xls";
            exporter.SummariesExportOption = SummariesOption.ExportAll;
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            string fileName =Application.StartupPath+"ExportedData.xls";
            exporter.RunExport(fileName);
            System.Diagnostics.Process.Start(fileName);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }
     
    }
}
