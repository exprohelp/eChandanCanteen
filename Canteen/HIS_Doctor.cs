using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using System.Runtime.Serialization.Json;
using Telerik.WinControls.UI.Export;

namespace eChandanCanteen.Canteen
{
    public partial class HIS_Doctor : Telerik.WinControls.UI.RadForm
    {
        public event SearchUpdateEventHandler SearchUpdated;
        hisProxy.ChandanPharmacyServicesSoapClient obj = new hisProxy.ChandanPharmacyServicesSoapClient();
        public HIS_Doctor()
        {
            InitializeComponent();
        }

        private void HIS_Doctor_Load(object sender, EventArgs e)
        {
            StaffList();
            dgDOCTOR.Focus();
        }
        private void StaffList()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','CHLProfessionalList','-','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry,"ChandanCanteen");
                DataTable dt = ds.Tables[0];
                dgDOCTOR.DataSource = dt;

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void DoctorList()
        {
            try
            {
                 Cursor.Current = Cursors.WaitCursor;
                string str=obj.LoadDoctor();
                DataTable dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(str);
                dgDOCTOR.DataSource = dt;
                //ExportToExcelML exporter = new ExportToExcelML(this.dgDOCTOR);
                //exporter.FileExtension = "xls";
                //exporter.SummariesExportOption = SummariesOption.ExportAll;
                //exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                //string fileName = Application.StartupPath + "SalesData.xls";
                //exporter.RunExport(fileName);
                //Cursor.Current = Cursors.WaitCursor;
                //System.Diagnostics.Process.Start(fileName);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dgDOCTOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string freetea="0";
                if (dgDOCTOR.CurrentRow.Cells["free_tea"].Value != null)
                {
                    freetea = dgDOCTOR.CurrentRow.Cells["free_tea"].Value.ToString();
                }


                string docname = dgDOCTOR.CurrentRow.Cells["DoctorName"].Value.ToString() + "[" + dgDOCTOR.CurrentRow.Cells["Doctor_ID"].Value.ToString() + "]" + ":" + dgDOCTOR.CurrentRow.Cells["Doctor_ID"].Value.ToString() + ":" + freetea;
                SearchUpdatedEventArgs valueArgs = new SearchUpdatedEventArgs(docname);
                SearchUpdated(this, valueArgs);
                this.Dispose();
                this.Close();
            }
        }

        private void rbHIS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHIS.Checked)
                DoctorList();

        }

        private void rbempmaster_CheckedChanged(object sender, EventArgs e)
        {
            if (rbempmaster.Checked)
                StaffList();

        }
    }
}
