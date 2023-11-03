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

    public partial class CancelProduct : Telerik.WinControls.UI.RadForm
    {
        string _saleType = string.Empty;
        string _custname = string.Empty;
        string _partyid = string.Empty;
         public CancelProduct()
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
                if((Convert.ToDecimal(rgv_report.CurrentRow.Cells["total"].Value)<0 ) || (rgv_report.CurrentRow.Cells["old_sale_inv_no"].Value.ToString().Length>3))
                { MessageBox.Show("This bill is already cancelled"); return; }


                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','SaleInfoForCancel','" + rgv_report.CurrentRow.Cells["sale_inv_no"].Value.ToString() + "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                _saleType = ds.Tables[0].Rows[0]["sale_type"].ToString();
                _custname = ds.Tables[0].Rows[0]["cust_name"].ToString();
                _partyid = ds.Tables[0].Rows[0]["party_id"].ToString();
                dgProdDet.DataSource = ds.Tables[1];
                txtOldSaleInvno.Text = rgv_report.CurrentRow.Cells["sale_inv_no"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgProdDet_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dgProdDet.CurrentRow.Cells["allow_cancel"].Value.ToString().ToUpper() == "Y")
            {
                if(dgProdDet.CurrentRow.Cells["markForCancel"].Value.ToString() == "N")
                  dgProdDet.CurrentRow.Cells["markForCancel"].Value = "Y";
                else
                  dgProdDet.CurrentRow.Cells["markForCancel"].Value = "N";
               
                RebindSum();
            }
         
        }
        private void RebindSum()
        {
            decimal Total = 0;
            decimal discount = 0;
            decimal Net = 0;
            btnSave.Enabled = false;
            foreach (GridViewRowInfo r in dgProdDet.Rows)
            {
                if (r.Cells["markForCancel"].Value.ToString() == "Y")
                {
                    Total = Total + Convert.ToDecimal(r.Cells["amount"].Value);
                    discount = discount + Convert.ToDecimal(r.Cells["discount"].Value);
                    Net = Net + Convert.ToDecimal(r.Cells["Net"].Value);
                    btnSave.Enabled = true;
                }
            }
            var x = Net - Math.Truncate(Net);
            txtTotal.Text = Total.ToString();
            txtTotalDisc.Text = (discount + x).ToString();
            txtTotNet.Text = (Net - x).ToString();
          
            if (dgProdDet.Rows.Count > 0)
            { btnSave.Enabled = true; }
            else
            { btnSave.Enabled = false; }
        }

        private void dgProdDet_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["markForCancel"].Value.ToString() == "Y")
             e.RowElement.ForeColor = Color.Red;
            else
             e.RowElement.ForeColor = Color.Black;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel bill", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                btnSave.Enabled = false;
                DataTable dt = new DataTable();
                dt.Columns.Add("item_id", typeof(string));
                dt.Columns.Add("master_key_id", typeof(string));
                dt.Columns.Add("sold_qty", typeof(string));
                dt.Columns.Add("dis_per", typeof(string));
                dt.Columns.Add("net", typeof(string));
                dt.Columns.Add("FreeGiven", typeof(string));
                foreach (GridViewRowInfo r in dgProdDet.Rows)
                {
                    if (r.Cells["markForCancel"].Value.ToString() == "Y")
                    {
                        DataRow dr = dt.NewRow();
                        dr["item_id"] = r.Cells["item_id"].Value.ToString();
                        dr["master_key_id"] = r.Cells["master_key_id"].Value.ToString();
                        dr["sold_qty"] = (0 - Convert.ToInt32(r.Cells["qty"].Value));
                        dr["dis_per"] = r.Cells["disc_perc"].Value.ToString();
                        dr["net"] = (0 - Convert.ToInt32(r.Cells["net"].Value));
                        dr["FreeGiven"] = r.Cells["FreeGiven"].Value.ToString();
                        dt.Rows.Add(dr);
                    }
                }
                string _result = string.Empty;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    string paymode = "CA";
                    if (txtRemark.Text.Trim().Length > 5)
                    {
                        string sale_no = GlobalUsage.canteenProxy.Retail_InsertSale(out _result, ds, GlobalUsage.gUnit_Id, "N/A", _saleType, "N/A", paymode, "Cancelled", _custname, _partyid, _custname, "N/A", GlobalUsage.gLogin_id, _partyid, txtOldSaleInvno.Text, txtRemark.Text,0);
                        if (sale_no.Contains("S"))
                        {
                            MessageBox.Show("Successfully Cancelled");
                        }
                        else
                        { MessageBox.Show(_result); }
                    }
                    else { MessageBox.Show("More than 5 charactor required in remark"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

    }
}
