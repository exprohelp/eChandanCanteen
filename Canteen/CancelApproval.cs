using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace eChandanCanteen.Canteen
{

    public partial class CancelApproval : Telerik.WinControls.UI.RadForm
    {
        string _saleType = string.Empty;
        string _custname = string.Empty;
        string _partyid = string.Empty;
         public CancelApproval()
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
            FillUnApprovedList();
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.Value = rdp_from.Value;
            FillUnApprovedList();
        }

        private void FillUnApprovedList()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','SR:UnApproved','1900/01/01','1900/01/01','N/A'";
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
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','SaleInvoiceDetal','" + rgv_report.CurrentRow.Cells["sale_inv_no"].Value.ToString() + "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgProdDet.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if(txtRemark.Text.Trim().Length > 0)
                {
                    string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','ApproveCancellation','" + rgv_report.CurrentRow.Cells["sale_inv_no"].Value.ToString() + "','" + GlobalUsage.gLogin_id + "','" + txtRemark.Text + "'";
                    GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen");
                    MessageBox.Show("Approved");
                    FillUnApprovedList();
                }
                else
                {
                    MessageBox.Show("Remark is blank");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
