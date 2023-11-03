using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;

namespace eChandanCanteen.Canteen
{
    public partial class SaleReport : Telerik.WinControls.UI.RadForm
    {
        Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
        Microsoft.Reporting.WinForms.LocalReport report_KOT = new Microsoft.Reporting.WinForms.LocalReport();

        public SaleReport()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 60);
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();

            this.reportViewer1.RefreshReport();
        }
        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.Value = rdp_from.Value;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','SalesInfo','" + rdp_from.Value.ToString("yyyy/MM/dd") + "','" + rdp_to.Value.ToString("yyyy/MM/dd") + "','N/A'";
                ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                rgv_report.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void rgv_report_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','PrintBill','" + rgv_report.CurrentRow.Cells["sale_inv_no"].Value.ToString() + "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");

                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = @"msReport\receit.rdlc";
                ReportParameter rp = new ReportParameter("ReportType", "Duplicate");
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
                reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Cursor.Current = Cursors.Default; }

        }
        private void btnXL_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcelML exporter = new ExportToExcelML(this.rgv_report);
                exporter.FileExtension = "xls";
                exporter.SummariesExportOption = SummariesOption.ExportAll;
                exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                string fileName = Application.StartupPath + "SalesData.xls";
                exporter.RunExport(fileName);
                Cursor.Current = Cursors.WaitCursor;
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','PrintBill','" + rgv_report.CurrentRow.Cells["sale_inv_no"].Value.ToString() + "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");

                report.Refresh();
                report.DataSources.Clear();
                report.ReportPath = @"msReport\receit.rdlc";
                ReportParameter rp = new ReportParameter("ReportType","Duplicate");
                report.SetParameters(new ReportParameter[] { rp });
                report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
                report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
                report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
                report.PrintToPrinter(3.2f, 8.3f, 0.1f, 0.1f, 0.1f, 0.1f);

                //KOT Printing
                report_KOT.Refresh();
                report_KOT.DataSources.Clear();
                report_KOT.ReportPath = @"msReport\KOT.rdlc";
                ReportParameter rpk = new ReportParameter("ReportType", "Duplicate");
                report_KOT.SetParameters(new ReportParameter[] { rpk });
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
                report_KOT.PrintToPrinter(3.2f, 8.3f, 0.1f, 0.1f, 0.1f, 0.1f);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
