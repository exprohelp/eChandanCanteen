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
    public partial class AppPurchItems : Form
    {
        DataSet _dsItem = new DataSet();
        Inventory_WebServicesSoapClient ws = new Inventory_WebServicesSoapClient();
        string _ItemId = "";
        string _UnitCode = "";
        public AppPurchItems()
        {
            InitializeComponent();
        }
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            string qry = "select Item_id,item_name from item_master where item_name like '"+txtProduct.Text+"%' order by item_name ";
            try
            {
                _dsItem = ws.GetQueryResult(qry, "eIM_Data");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            itemhelpgrid.Items.Clear();
            if(_dsItem.Tables.Count > 0)
            {
                if (_dsItem.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _dsItem.Tables[0].Rows)
                    {
                        itemhelpgrid.Items.Add(dr["item_id"].ToString());
                        itemhelpgrid.Items[itemhelpgrid.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                    }
                }
            }
        }
        private void AppPurchItems_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = ws.fillUnit();
            cbxUnit.SelectedIndexChanged -= new EventHandler(this.cbxUnit_SelectedIndexChanged);
            cbxUnit.DisplayMember="unit_name";
            cbxUnit.ValueMember  ="unit_code";
            cbxUnit.DataSource = ds.Tables[0];
            cbxUnit.SelectedIndex = -1;
            cbxUnit.SelectedIndexChanged += new EventHandler(this.cbxUnit_SelectedIndexChanged);
            Cursor.Current = Cursors.Default;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            FillRightGrid();
        }
        private void cbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(cbxUnit.SelectedValue!=null)
            _UnitCode = cbxUnit.SelectedValue.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = " pCreateAppUnitProduct '"+_UnitCode+"','"+_ItemId+"','"+GlobalUsage.gLogin_id+"' ";
                ws.QueryExecute(qry, "eIM_Data");
                FillRightGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemhelpgrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ItemId=itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].Text;
        }
        public void FillRightGrid()
        {
            try
            {
                string qry = @"select app.auto_id,item_name from app_purch_product app inner join item_master 
                             im on im.item_id=app.item_id where unit_id='" + _UnitCode + "' order by item_name ";
                DataSet ds = ws.GetQueryResult(qry, "eIM_Data");
                lvappitem.Items.Clear();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lvappitem.Items.Add(dr["auto_id"].ToString());
                        lvappitem.Items[lvappitem.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lvappitem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                     
                    string qry ="delete from app_purch_product where auto_id=" + lvappitem.Items[lvappitem.FocusedItem.Index].Text + " ";
                    ws.QueryExecute(qry, "eIM_Data");
                    lvappitem.Items[lvappitem.FocusedItem.Index].Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
       }
    }
}
