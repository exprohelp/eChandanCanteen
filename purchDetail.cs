using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eChandanCanteen
{
    public partial class purchDetail : Form
    {
        string purchId = "";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        DataSet ds = new DataSet();
        public purchDetail(string purch_id)
        {
            this.purchId = purch_id;
            InitializeComponent();
        }
        private void purchDetail_Load(object sender, EventArgs e)
        {
            string qry=" exec Cur_Purchase_Record '"+purchId+"'";
            try
            {
                ds = lws.GetQueryResult(qry, "eIM_Data");
                if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count>0)
                {
                    DataRow dr = ds.Tables[1].Rows[0];
                    this.Text = "Purchase By  " + dr["vend_name"].ToString() + ", Invoice No " + dr["inv_no"].ToString() + ", Purchase Id " + purchId + ", Voucher No " + dr["voucher_no"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorReporting obj = new ErrorReporting(ex);
                obj.Owner = this;
                obj.Show();
            }
            if(ds.Tables[0].Rows.Count>0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    listView1.Items.Add(dr["item_name"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["mfd_name"].ToString());
                 
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                    if (Convert.ToDateTime(dr["exp_date"]).ToString("MMM-yyyy") != "1900-01-01")
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MMM-yyyy"));
                    else
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("######.00"));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["quantity"]).ToString("####"));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["disper"]).ToString("######.##"));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["it_free"]).ToString("#####"));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["tax_rate"]).ToString("######.##"));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["tax_amount"]).ToString("######.##"));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("######.##"));
                                 
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
              string msg=lws.QueryExecute("exec pCreatePurchBankInfo '"+purchId+"','"+txtBank.Text+"','"+txtDetail.Text+"','"+GlobalUsage.gLogin_id+"' ", "eIM_Data");
              if(msg=="Success")
              { MessageBox.Show("Successfully Saved"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
