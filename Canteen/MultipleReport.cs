using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using iTextSharp.text;
using iTextSharp.text.pdf;


using System.IO;

namespace eChandanCanteen.Canteen
{
    public partial class MultipleReport : Telerik.WinControls.UI.RadForm
    {
        string _report_name = string.Empty;
        public MultipleReport()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(ddlReport.Text == "User Collection Report")
            {
                UserwiseCollection();
            }
            else if (ddlReport.Text == "Bill Wise Report")
            {
                BillWiseReport();
            }
            else if (ddlReport.Text == "Item Wise Report")
            {
                ProductSaleReport();
            }
            else if (ddlReport.Text == "Consumption Report")
            {
                ConsumptionReport();
            }
            else if (ddlReport.Text == "Stock Report")
            {
                StockReport();
            }
            else if (ddlReport.Text == "Receivable Report")
            {
                ReceivableReport();
            }

        }
        private void ReceivableReport()
        {
            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','','ReceivableReport' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            string date = "Date From " + dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtTo.Value.ToString("dd-MM-yyyy");
            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:60%;font-size:14px;background-color:lightgray'>RECEVIABLE REPORT <br/>" + date + "</span>");
            sb.Append("<table style='width:60%;border-collapse:collapse;' border='1' cellpadding='0' bordercolor='black' >");
            sb.Append("<tr>");
            sb.Append("<th style='width:80%;font-size:12px;text-align:left'> <b style='color:Maroon'>&nbsp;Name of Staff</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:right'><b style='color:Maroon'>&nbsp;Amount&nbsp;</th>");
            sb.Append("</tr>");
            decimal t_amount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                sb.Append("<tr>");
                sb.Append("<td style='width:80%;font-size:12px;text-align:left;font-weight:bold'>&nbsp;" + dr["cust_name"].ToString() + "&nbsp;</td>");
                sb.Append("<td style='width:20%;font-size:12px;text-align:right;font-weight:bold'>&nbsp;" + (Convert.ToDecimal(dr["amount"])).ToString("###0.00") + "&nbsp;</td>");
                sb.Append("</tr>");
                t_amount += Convert.ToDecimal(dr["amount"]);
            }
            sb.Append("<tr>");
            sb.Append("<td style='width:80%;font-size:14px;text-align:right;font-weight:bold'>Total</td>");

            sb.Append("<td style='width:20%;font-size:14px;text-align:right;font-weight:bold'>" + t_amount.ToString("#.#") + "&nbsp;</td>");
            sb.Append("</tr>");
            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();
  
        }
        private void UserwiseCollection()
        {
            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','"+dtFrom.Value.ToString("yyyy/MM/dd")+"','"+dtTo.Value.ToString("yyyy/MM/dd")+"','','UserWiseCollection' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            string date = "Date From " + dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtTo.Value.ToString("dd-MM-yyyy");
            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:60%;font-size:14px;background-color:lightgray'>USER WISE COLLECTION REPORT <br/>" + date + "</span>");
            sb.Append("<table style='width:60%;border-collapse:collapse;' border='1' cellpadding='0' bordercolor='black' >");
            sb.Append("<tr>");
            sb.Append("<th style='width:40%;font-size:12px;text-align:left'> <b style='color:Maroon'>&nbsp;User Name</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:right'><b style='color:Maroon'>&nbsp;Cash&nbsp;</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:right'><b style='color:Maroon'>&nbsp;Swap Card&nbsp;</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:right'><b style='color:Maroon'>&nbsp;Total&nbsp;</th>");
            sb.Append("</tr>");
            decimal t_cash = 0;
            decimal t_swapcard = 0;
            decimal t_total = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                  sb.Append("<tr>");
                  sb.Append("<td style='width:40%;font-size:12px;text-align:left;font-weight:bold'>&nbsp;" + dr["emp_name"].ToString() + "&nbsp;</td>");
                  sb.Append("<td style='width:20%;font-size:12px;text-align:right;font-weight:bold'>&nbsp;" + Convert.ToDecimal(dr["cash"]).ToString("0") + "&nbsp;</td>");
                  sb.Append("<td style='width:20%;font-size:12px;text-align:right;font-weight:bold'>&nbsp;" + Convert.ToDecimal(dr["swapcard"]).ToString("0") + "&nbsp;</td>");
                  sb.Append("<td style='width:20%;font-size:12px;text-align:right;font-weight:bold'>&nbsp;" + (Convert.ToDecimal(dr["cash"]) + Convert.ToDecimal(dr["swapcard"])).ToString("0") + "&nbsp;</td>");
                  sb.Append("</tr>");
                  t_cash += Convert.ToDecimal(dr["cash"]);
                  t_swapcard += Convert.ToDecimal(dr["swapcard"]);
                  t_total += (Convert.ToDecimal(dr["cash"]) + Convert.ToDecimal(dr["swapcard"]));
            }
            sb.Append("<tr>");
            sb.Append("<td style='width:40%;font-size:14px;text-align:right;font-weight:bold'>Total</td>");
            sb.Append("<td style='width:20%;font-size:14px;text-align:right;font-weight:bold'>" + t_cash.ToString("#.#") + "&nbsp;</td>");
            sb.Append("<td style='width:20%;font-size:14px;text-align:right;font-weight:bold'>" + t_swapcard.ToString("#.#") + "&nbsp;</td>");
            sb.Append("<td style='width:20%;font-size:14px;text-align:right;font-weight:bold'>" + t_total.ToString("#.#") + "&nbsp;</td>");
            sb.Append("</tr>");
            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();
     
        }
        private void BillWiseReport()
        {
            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','','BillWiseReport' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            string date = "Date From " + dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtTo.Value.ToString("dd-MM-yyyy");
            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:100%;font-size:14px;background-color:lightgray'>BILL WISE REPORT <br/>" + date + "</span>");
            sb.Append("<table style='width:100%;border-collapse:collapse;' border='1' cellpadding='0' bordercolor='black' >");
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:left'><b style='color:Maroon'>Sale No</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:left'><b style='color:Maroon'>Sale Date</th>");
            sb.Append("<th style='width:30%;font-size:12px;text-align:left'><b style='color:Maroon'>Customer Name</th>");
            sb.Append("<th style='width:12%;font-size:12px;text-align:right'><b style='color:Maroon'>Total</th>");
            sb.Append("<th style='width:11%;font-size:12px;text-align:right'><b style='color:Maroon'>Discount</th>");
            sb.Append("<th style='width:12%;font-size:12px;text-align:right'><b style='color:Maroon'>Net</th>");
            sb.Append("</tr>");
          
            decimal t_Total = 0;
            decimal t_discount = 0;
            decimal t_net = 0;
            decimal p_total = 0;
            decimal p_discount = 0;
            decimal p_net = 0;
            string temp = string.Empty;
            int count = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (temp != dr["custType"].ToString())
                {
                    if (count>0)
                    {
                        sb.Append("<tr style='background-color:lightgray'>");
                        sb.Append("<td style='width:15%;font-size:12px;text-align:left'></td>");
                        sb.Append("<td style='width:20%;font-size:12px;text-align:left'></td>");
                        sb.Append("<td style='width:30%;font-size:12px;text-align:right'>Summary</td>");
                        sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" +p_total.ToString("0") + "&nbsp;</td>");
                        sb.Append("<td style='width:11%;font-size:12px;text-align:right'>" + p_discount.ToString("0") + "&nbsp;</td>");
                        sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + p_net.ToString("0") + "&nbsp;</td>");
                        sb.Append("</tr>");
                    }

                    sb.Append("<tr style='background-color:lightgray'>");
                    sb.Append("<td style='width:100%;font-size:12px;text-align:left' colspan='6'>" + dr["custType"].ToString() + "</td>");
                    sb.Append("</tr>");
                    temp = dr["custType"].ToString();

                    p_total = 0;
                    p_discount = 0;
                    p_net = 0;
                }
                sb.Append("<tr>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:left'>" + dr["sale_inv_no"].ToString() + "</td>");
                sb.Append("<td style='width:20%;font-size:12px;text-align:left'>" + dr["sale_date"].ToString() + "</td>");
                sb.Append("<td style='width:30%;font-size:12px;text-align:left'>" + dr["cust_name"].ToString() + "</td>");
                sb.Append("<td style='width:12%;font-size:12px;text-align:right'>"+Convert.ToDecimal(dr["Total"]).ToString("0") + "&nbsp;</td>");
                sb.Append("<td style='width:11%;font-size:12px;text-align:right'>"+Convert.ToDecimal(dr["discount"]).ToString("0")+ "&nbsp;</td>");
                sb.Append("<td style='width:12%;font-size:12px;text-align:right'>"+Convert.ToDecimal(dr["Net"]).ToString("0") + "&nbsp;</td>");
                sb.Append("</tr>");

                p_total += Convert.ToDecimal(dr["Total"]);
                p_discount += Convert.ToDecimal(dr["discount"]);
                p_net += Convert.ToDecimal(dr["Net"]);

                t_Total += Convert.ToDecimal(dr["Total"]);
                t_discount += Convert.ToDecimal(dr["discount"]);
                t_net += Convert.ToDecimal(dr["Net"]);
                
                count++;
            }
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<td style='width:15%;font-size:12px;text-align:left'></td>");
            sb.Append("<td style='width:20%;font-size:12px;text-align:left'></td>");
            sb.Append("<td style='width:30%;font-size:12px;text-align:right'>Summary</td>");
            sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + p_total.ToString("0") + "&nbsp;</td>");
            sb.Append("<td style='width:11%;font-size:12px;text-align:right'>" + p_discount.ToString("0") + "&nbsp;</td>");
            sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + p_net.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");

            sb.Append("<tr>");
            sb.Append("<td colspan='3' style='width:40%;font-size:12px;text-align:right'>Total</td>");
            sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + t_Total.ToString("0") + "&nbsp;</td>");
            sb.Append("<td style='width:11%;font-size:12px;text-align:right'>" + t_discount.ToString("0") + "&nbsp;</td>");
            sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + t_net.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");
            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();
  

        }
      
        private void ProductSaleReport()
        {
            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','','ItemWiseReport' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            string date = "Date From " + dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtTo.Value.ToString("dd-MM-yyyy");

            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:100%;font-size:14px;background-color:lightgray'>PRODUCT WISE COLLECTION REPORT <br/>" + date + "</span>");
            sb.Append("<table style='width:100%;border-collapse:collapse;' border='1' cellpadding='0' bordercolor='black' >");
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<th style='width:40%;font-size:12px;text-align:left'><b style='color:Maroon'>Item Name</th>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:right'><b style='color:Maroon'>Qty</th>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:right'><b style='color:Maroon'>Total</th>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:right'><b style='color:Maroon'>Discount</th>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:right'><b style='color:Maroon'>Net</th>");
            sb.Append("</tr>");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                sb.Append("<tr>");
                sb.Append("<td style='width:40%;font-size:12px;text-align:left'>" + dr["item_name"].ToString() + "&nbsp;</td>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:right'>" + dr["Qty"].ToString() + "&nbsp;</td>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:right'>" + Convert.ToInt32(dr["Total"]).ToString("0") + "&nbsp;</td>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:right'>" + Convert.ToInt32(dr["discount"]).ToString("0") + "&nbsp;</td>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:right'>" + Convert.ToInt32(dr["net"]).ToString("0") + "&nbsp;</td>");
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();

        }
        private void ConsumptionReport()
        {
            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','','ConsumptionReport' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            string date = "Date From " + dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtTo.Value.ToString("dd-MM-yyyy");
            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:100%;font-size:14px;background-color:lightgray'>CONSUMPTION REPORT <br/>" + date + "</span>");
            sb.Append("<table style='width:100%;border-collapse:collapse;' border='1' cellpadding='0' bordercolor='black' >");
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:left'><b style='color:Maroon'>Cons. Date</th>");
            sb.Append("<th style='width:50%;font-size:12px;text-align:left'><b style='color:Maroon'>Product Name</th>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:right'><b style='color:Maroon'>Issued Qty</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:right'><b style='color:Maroon'>Amount</th>");
            sb.Append("</tr>");

            decimal t_Total = 0;
            decimal g_Total = 0;
            string temp = string.Empty;
            int count = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (temp != dr["IssuedTo"].ToString())
                {
                    if (count > 0)
                    {
                        sb.Append("<tr style='background-color:lightgray'>");
                        sb.Append("<td style='width:30%;font-size:12px;text-align:right' colspan='3' >Summary</td>");
                        sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + t_Total.ToString("0") + "&nbsp;</td>");
                        sb.Append("</tr>");
                    }
                    sb.Append("<tr style='background-color:lightgray'>");
                    sb.Append("<td style='width:100%;font-size:12px;text-align:left' colspan='4'>" + dr["IssuedTo"].ToString() + "</td>");
                    sb.Append("</tr>");
                    t_Total = 0;
                    temp = dr["IssuedTo"].ToString();
                }
                sb.Append("<tr>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:left'>" + dr["Issuedate"].ToString() + "</td>");
                sb.Append("<td style='width:50%;font-size:12px;text-align:left'>" + dr["item_name"].ToString() + "</td>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:right'>" + dr["Issued_Qty"].ToString() + "</td>");
                sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + Convert.ToDecimal(dr["amount"]).ToString("0") + "&nbsp;</td>");
                sb.Append("</tr>");

                t_Total += Convert.ToDecimal(dr["amount"]);
                g_Total += Convert.ToDecimal(dr["amount"]);
                count++;
            }
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<td style='width:30%;font-size:12px;text-align:right' colspan='3' >Summary</td>");
            sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + t_Total.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");


            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<td style='width:30%;font-size:12px;text-align:right' colspan='3' >Summary</td>");
            sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + g_Total.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");

            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();

        }
        private void StockReport()
        {
            StringBuilder sb = new StringBuilder();
            string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','','StockReport' ";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            string date = "";
            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:100%;font-size:14px;background-color:lightgray'>STOCK REPORT <br/>" + date + "</span>");
            sb.Append("<table style='width:100%;border-collapse:collapse;' border='1' cellpadding='0' bordercolor='black' >");
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<th style='width:65%;font-size:12px;text-align:left'><b style='color:Maroon'>Product Name</th>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:right'><b style='color:Maroon'>Qty</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:right'><b style='color:Maroon'>Amount</th>");
            sb.Append("</tr>");

            decimal t_Total = 0;
            decimal g_Total = 0;
            string temp = string.Empty;
            int count = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (temp != dr["prodType"].ToString())
                {
                    if (count > 0)
                    {
                        sb.Append("<tr style='background-color:lightgray'>");
                        sb.Append("<td style='width:30%;font-size:12px;text-align:right' colspan='2' >Summary</td>");
                        sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + t_Total.ToString("0") + "&nbsp;</td>");
                        sb.Append("</tr>");
                    }
                    sb.Append("<tr style='background-color:lightgray'>");
                    sb.Append("<td style='width:100%;font-size:12px;text-align:left' colspan='3'>" + dr["prodType"].ToString() + "</td>");
                    sb.Append("</tr>");
                    t_Total = 0;
                    temp = dr["prodType"].ToString();
                }
                sb.Append("<tr>");
                sb.Append("<td style='width:65%;font-size:12px;text-align:left'>" + dr["item_name"].ToString() + "</td>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:right'>" + dr["Qty"].ToString() + "</td>");
                sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + Convert.ToDecimal(dr["amount"]).ToString("0") + "&nbsp;</td>");
                sb.Append("</tr>");

                t_Total += Convert.ToDecimal(dr["amount"]);
                g_Total += Convert.ToDecimal(dr["amount"]);
                count++;
            }
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<td style='width:30%;font-size:12px;text-align:right' colspan='2' >Summary</td>");
            sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + t_Total.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");


            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<td style='width:30%;font-size:12px;text-align:right' colspan='2' >Summary</td>");
            sb.Append("<td style='width:20%;font-size:12px;text-align:right'>" + g_Total.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");

            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();

        }
   
        private void MultipleReport_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 60); 
            dtFrom.Value = System.DateTime.Now;
            dtTo.Value = System.DateTime.Now;
            ddlReport.SelectedIndex = 0;
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
        }

        private void ddlReport_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlReport.SelectedItem.ToString() == "Stock Report")
            { gbDate.Enabled = false; }
            else
            { gbDate.Enabled = true; }
        }
    }


}
