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
    public partial class NotReceived : Form
    {
        int animate, flag;
        string UnitId = "", itemId = "";
        Inventory_WebServicesSoapClient ws = new Inventory_WebServicesSoapClient();
        public NotReceived(int AnimationTime, int Flags,string unit_id,string Item_id)
        {
            animate=AnimationTime;
            flag = Flags;
            UnitId = unit_id;
            itemId = Item_id;
            InitializeComponent();
        }
        private void NotReceived_Load(object sender, EventArgs e)
        {
            string qry="pGetNotReceived '"+UnitId+"','"+itemId+"' ";
            DataSet ds = ws.GetQueryResult(qry, "eIM_Data");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listView1.Items.Add(dr["auto_id"].ToString());
                listView1.Items[listView1.Items.Count-1].SubItems.Add(dr["trf_id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
            }
            WinAPI.AnimateWindow(this.Handle, animate,flag);
        }

        private void NotReceived_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.Close();
            }
        }
    }
}
