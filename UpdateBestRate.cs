using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Server;
using ExPro.Client;
namespace eChandanCanteen
{
    public partial class UpdateBestRate : Form
    {
        string _item_id = "";
        ListViewItem item;
        int X = 0; int Y = 0;   int position = 0; 
        string subItemText = "";
        int selectedSubItem = 0;

        Inventory_WebServices.Inventory_WebServicesSoapClient ws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        private System.Windows.Forms.TextBox ChangeRate = new System.Windows.Forms.TextBox();
        public UpdateBestRate()
        {
            InitializeComponent();
             #region Initialize TextBox ChangeRate
                ChangeRate.Size = new System.Drawing.Size(0, 0);
                ChangeRate.Location = new System.Drawing.Point(0, 0);
                ChangeRate.TextAlign = HorizontalAlignment.Right;
                this.lv_BestRate.Controls.Add(this.ChangeRate);
                ChangeRate.LostFocus += new System.EventHandler(this.ChangeRateFocusExit);
                ChangeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChangeRateKeyPress);
                ChangeRate.Hide();
            #endregion
        }
        private void ChangeRateKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 27)
            {
                if (e.KeyChar == 13)
                {
                        item.SubItems[selectedSubItem].Text = ChangeRate.Text;
                        //TransferToShortage(item.SubItems[0].Text,Convert.ToDecimal(ChangeRate.Text));
                }
                lv_BestRate.Focus();
            }
        }
        private void ChangeRateFocusExit(object sender, System.EventArgs e)
        {
            ChangeRate.Hide();
        }
        private void UpdateBestRate_Load(object sender, EventArgs e)
        {
            string qry = "select item_id,item_name from item_master order by item_name;";
            DataSet ds = new DataSet();
            ds = ws.GetQueryResult(qry, "eIm_Data");
            this.cb_items.SelectedIndexChanged -= new System.EventHandler(this.cb_items_SelectedIndexChanged);
            cb_items.DataSource = ds.Tables[0];
            cb_items.ValueMember = "item_id";
            cb_items.DisplayMember = "item_name";
            this.cb_items.SelectedIndexChanged += new System.EventHandler(this.cb_items_SelectedIndexChanged);
        }

        private void cb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            _item_id= cb_items.SelectedValue.ToString();
            gb1.Text = cb_items.Text;
            #region Fill List View lv_BestRate
            DataSet ds = new DataSet();
            Cursor.Current = Cursors.WaitCursor;
            ds = ws.GetQueryResult("execute pBestRateList '" + _item_id + "'", "eIm_Data");
            lv_BestRate.Items.Clear();
            string temp = "";
            if (ds.Tables[0].Rows.Count > 0)
            {
                lv_BestRate.BeginUpdate();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (temp != dr["vend_name"].ToString())
                    {
                        lv_BestRate.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                        temp = dr["vend_name"].ToString();
                    } 
                    ListViewItem ls = new ListViewItem(dr["vend_code"].ToString());
                    ls.SubItems.Add(dr["mfd_id"].ToString());
                    ls.SubItems.Add(dr["mfd_name"].ToString());
                    ls.SubItems.Add(dr["pack_size"].ToString());
                    ls.SubItems.Add(Convert.ToDecimal(dr["pack_qty"]).ToString("###.00"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["app_rate"]).ToString("###.00"));
                    ls.SubItems.Add(dr["auto_id"].ToString());
                    ls.Group = lv_BestRate.Groups[dr["vend_name"].ToString()];
                   if(dr["app_flag"].ToString()=="Y")
                        lv_BestRate.Items.Add(ls).Checked=true;
                    else
                        lv_BestRate.Items.Add(ls);
                    lv_BestRate.EndUpdate();
                }
            Cursor.Current = Cursors.WaitCursor;
            #endregion
            }
            ds.Dispose();
        }

        private void lv_BestRate_MouseDown(object sender, MouseEventArgs e)
        {
            item = lv_BestRate.GetItemAt(e.X, e.Y);
            X = e.X;
            Y = e.Y;
        }

        private void lv_BestRate_Click(object sender, EventArgs e)
        {
            // Check whether the subitem was clicked
            int x = getXaxisWidth(lv_BestRate);
            subItemText = item.SubItems[selectedSubItem].Text;
            string column = lv_BestRate.Columns[selectedSubItem].Text;
            if (column == "Rate")
            {
                int y = item.Bounds.Bottom - item.Bounds.Top;
                ChangeRate.Size = new System.Drawing.Size(x, y);
                ChangeRate.Location = new System.Drawing.Point(position, item.Bounds.Y);
                ChangeRate.Show();
                ChangeRate.Text = subItemText;
                ChangeRate.SelectAll();
                ChangeRate.Focus();
            }
        }
        protected int getXaxisWidth(ListView lv)
        {
            int start = X;
            int end = lv.Columns[0].Width;
            int i = 0;
            for (i = 0; i < lv.Columns.Count; i++)
            {
                if (start > position && start < end)
                {
                    selectedSubItem = i;
                    break;
                }
                position = end;
                end += lv.Columns[i].Width;
                if (start > position && start < end)
                {
                    selectedSubItem = i;
                    break;
                }
            }
            return end - position;
        }

        private void lv_BestRate_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                Cursor.Current = Cursors.WaitCursor;
                string auto_id = e.Item.SubItems[6].Text;
                string qry = "update best_rate_info set app_flag='Y',app_by='" + GlobalUsage.gLogin_id + "',app_date=getdate() where auto_id=" + auto_id + " ";
                string msg = ws.QueryExecute(qry, "eIM_Data");
                Cursor.Current = Cursors.Default;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                string auto_id = e.Item.SubItems[6].Text;
                string qry = "update best_rate_info set app_flag='N',app_by='" + GlobalUsage.gLogin_id + "',app_date=getdate() where auto_id=" + auto_id + " ";
                string msg = ws.QueryExecute(qry, "eIM_Data");
                Cursor.Current = Cursors.Default;
              }
        }

    }
}
