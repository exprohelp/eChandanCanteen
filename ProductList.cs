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
    public partial class ProductList : Form
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public ProductList()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string qry = @"SELECT distinct dbo.item_master.item_Name, dbo.pack_size_info.pack_size, dbo.pack_size_info.pack_qty 
                         FROM dbo.item_master INNER JOIN dbo.pack_size_info ON dbo.item_master.item_id = dbo.pack_size_info.Item_id
                         where dbo.item_master.item_name like '"+txtProdut.Text+"%' order by dbo.item_master.item_name ";
            DataSet ds = lws.GetQueryResult(qry,"eIM_Data");
            Cursor.Current = Cursors.Default;
            FillPackWiseProduct(ds);
        }
        private void FillPackWiseProduct(DataSet pDS)
        {
            if (pDS.Tables.Count > 0)
            {
                listView1.Items.Clear();
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        listView1.Groups.Add(dr["item_name"].ToString(), dr["item_name"].ToString());
                    }
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem("");
                        lvi.SubItems.Add(dr["pack_size"].ToString());
                        lvi.SubItems.Add(dr["pack_qty"].ToString());
                        lvi.Group =listView1.Groups[dr["item_name"].ToString()];
                        listView1.Items.Add(lvi);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string qry = @"SELECT distinct dbo.item_master.item_Name, dbo.mfd_master.mfd_name
                           FROM dbo.item_master INNER JOIN  dbo.mfd_master ON dbo.item_master.item_id = dbo.mfd_master.item_id
                           where dbo.item_master.item_name like '" +textBox1.Text + "%' order by dbo.item_master.item_name ";
            DataSet ds = lws.GetQueryResult(qry, "eIM_Data");
            Cursor.Current = Cursors.Default;
            FillManufacturerWiseProduct(ds);
        }
        private void FillManufacturerWiseProduct(DataSet pDS)
        {
            if (pDS.Tables.Count > 0)
            {
                listView2.Items.Clear();
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        listView2.Groups.Add(dr["item_name"].ToString(), dr["item_name"].ToString());
                    }
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem("");
                        lvi.SubItems.Add(dr["mfd_name"].ToString());
                        lvi.Group = listView2.Groups[dr["item_name"].ToString()];
                        listView2.Items.Add(lvi);
                    }
                }
            }
        }


    }
}
