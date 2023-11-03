using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eChandanCanteen.Canteen
{
    public partial class CreditConsumptionReport : Telerik.WinControls.UI.RadForm
    {
        string _report_name = string.Empty;
        public CreditConsumptionReport()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            BillWiseReport();
            Cursor.Current = Cursors.Default;
        }
        private void BillWiseReport()
        {
            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','" + ddlCreditorList.SelectedValue.ToString() + "','ConsumedProductByCreditor' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            string date = "Date From " + dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtTo.Value.ToString("dd-MM-yyyy");
            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:100%;font-size:14px;background-color:lightgray'>SALE REPORT OF PARTY " + ddlCreditorList.SelectedItem.ToString() + "<br/>" + date + "</span>");
            sb.Append("<table style='width:100%;' >");
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<th style='width:60%;font-size:12px;text-align:left'><b style='color:Maroon'>Product Name</th>");
            sb.Append("<th style='width:30%;font-size:12px;text-align:left'><b style='color:Maroon'>Product Name</th>");
            sb.Append("<th style='width:10%;font-size:12px;text-align:right'><b style='color:Maroon'>Sale Qty</th>");
            sb.Append("<th style='width:10%;font-size:12px;text-align:right'><b style='color:Maroon'>Net</th>");
            sb.Append("</tr>");
            decimal totalcost = 0;
            decimal rebate = 0;
            decimal net = 0;
            string temp = string.Empty;
            string str=string.Empty;
            int count=1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (temp != dr["sale_inv_no"].ToString())
                {
                    str ="Sale No: " + dr["sale_inv_no"].ToString() + "  Sale Date :  " + dr["sale_date"].ToString() + "  Total : " + Convert.ToDecimal(dr["Total"]).ToString("0") + "  Discount: " + Convert.ToDecimal(dr["discount"]).ToString("0") + " Net : " + Convert.ToDecimal(dr["net"]).ToString("0");
                    sb.Append("<tr>");
                    sb.Append("<td style='width:100%;font-size:12px;text-align:left;font-weight:bold' colspan='4'>" + str + " </td>");
                    sb.Append("</tr>");
                    temp = dr["sale_inv_no"].ToString();
                    totalcost =totalcost+ Convert.ToDecimal(dr["Total"]);
                    rebate = rebate + Convert.ToDecimal(dr["discount"]);
                    net = net + Convert.ToDecimal(dr["net"]);
                    count = 1;
                }
                sb.Append("<tr>");
                sb.Append("<td style='width:60%;font-size:11px;text-align:left'></td>");
                sb.Append("<td style='width:30%;font-size:11px;text-align:left'>" +count+" : "+dr["item_name"].ToString() + "</td>");
                sb.Append("<td style='width:10%;font-size:11px;text-align:right'>" + Convert.ToDecimal(dr["sale_qty"]).ToString("0") + "&nbsp;</td>");
                sb.Append("<td style='width:10%;font-size:11px;text-align:right'>" + Convert.ToDecimal(dr["amount"]).ToString("0") + "&nbsp;</td>");
                sb.Append("</tr>");
                count++;
            }
            str = "Total : " + totalcost.ToString("0") + "  Discount : " + rebate.ToString("0") + " Net : " + net.ToString("0");
            sb.Append("<tr>");
            sb.Append("<td style='width:100%;font-size:16px;text-align:right;font-weight:bold;background-color:gray;color:black' colspan='4'>" + str + " </td>");
            sb.Append("</tr>");
            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();

        }
      
        private void MultipleReport_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 60); 
            dtFrom.Value = System.DateTime.Now;
            dtTo.Value = System.DateTime.Now;
            ddlCreditorList.SelectedIndex = 0;
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();

            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','','CreditorList' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            ddlCreditorList.Items.AddRange(Config.FillTelrikCombo(ds.Tables[0]));
            ddlCreditorList.SelectedIndex = 0;
        }

        private void ddlReport_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlCreditorList.SelectedItem.ToString() == "Stock Report")
            { gbDate.Enabled = false; }
            else
            { gbDate.Enabled = true; }
        }
    }


}
