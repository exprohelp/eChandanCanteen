using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
namespace eChandanCanteen.Canteen
{
    
    public partial class TATReport : Telerik.WinControls.UI.RadForm
    {
        public TATReport()
        {
            InitializeComponent();
        }
        private void KOTWindow_Load(object sender, EventArgs e)
        {
            rdp_from.Value = System.DateTime.Now;
            rdp_to.Value = System.DateTime.Now;
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }
        private void btnSaleNo_Click(object sender, EventArgs e)
        {
         
        }
        Microsoft.Reporting.WinForms.LocalReport report_KOT = new Microsoft.Reporting.WinForms.LocalReport();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','TAT','" +rdp_from.Value.ToString("yyyy/MM/dd")+ "','" +rdp_to.Value.ToString("yyyy/MM/dd")+"','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                var delaycount = ds.Tables[0].AsEnumerable().Where(x => x.Field<string>("delay_flag") == "Y").Count();
                radRadialGauge1.Value =(100- delaycount);
                rgv_report.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_report_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','SaleInfo','" + rgv_report.CurrentRow.Cells["sale_inv_no"].Value.ToString()+ "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgProdDet.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void rgv_report_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["delay_flag"].Value.ToString() == "Y")
                e.RowElement.ForeColor = Color.Red;
            else
                e.RowElement.ForeColor = Color.Black;
            

        }
    }
}
