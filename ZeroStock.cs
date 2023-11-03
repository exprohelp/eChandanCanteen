using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eChandanCanteen.Inventory_WebServices;
namespace eChandanCanteen
{
    public partial class ZeroStock : Form
    {
        Inventory_WebServicesSoapClient lws = new Inventory_WebServicesSoapClient();
        public ZeroStock()
        {
            InitializeComponent();
        }

        private void ZeroStock_Load(object sender, EventArgs e)
        {
        }
        private void FillData(DataSet _ds)
        {
            m_list.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    string temp = "";
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        if (temp != dr["item_name"].ToString())
                        {
                           m_list.Groups.Add(dr["item_name"].ToString(), dr["item_name"].ToString());
                           temp = dr["item_name"].ToString();
                        }
                        m_list.Items.Add(dr["item_id"].ToString());
                        m_list.Items[m_list.Items.Count - 1].SubItems.Add(dr["unit_name"].ToString());
                        m_list.Items[m_list.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        m_list.Items[m_list.Items.Count - 1].SubItems.Add(Convert.ToInt32(dr["qty"]).ToString("##"));
                        m_list.Items[m_list.Items.Count - 1].Group = m_list.Groups[dr["item_name"].ToString()];
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string qry = @"exec pGetZeroStock";
            try { DataSet ds = lws.GetQueryResult(qry, "eIM_Data"); FillData(ds); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
 
        }
   
    }
}
