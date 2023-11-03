using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ExPro.Client;
using ExPro.Server;
using System.Data.SqlClient;
namespace eChandanCanteen
{
    public partial class OrderGeneration : Form
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient ws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        DataSet _ds = new DataSet();
        string  _Action = "";
        DataSet _dsItem =new DataSet();
        string  _Item_Id = "";
        string  _PackSize= "";
        string _deleteing_Id = "";
        decimal _Qty=0;
        string _Msg = "";
        public OrderGeneration()
        {
            InitializeComponent();
        }
        private void OrderGeneration_Load(object sender, EventArgs e)
        {
            string qry="select Item_id,item_name from item_master order by item_name;";
            try
            {
                _dsItem = ws.GetQueryResult(qry, "eIM_Data");
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}
        }
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (_dsItem.Tables.Count > 0)
            {
                if (_dsItem.Tables[0].Rows.Count > 0)
                {
                    itemhelpgrid.Items.Clear();
                    itemhelpgrid.Visible = true;
                    DataRow[] drarr = _dsItem.Tables[0].Select("item_name like '"+txtProduct.Text+"%' ");
                    foreach (DataRow dr in drarr)
                    {
                        itemhelpgrid.Items.Add(dr["item_id"].ToString());
                        itemhelpgrid.Items[itemhelpgrid.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                    }
                }
            }
        }
        private void itemhelpgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                #region Process
                _Item_Id = itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].SubItems[0].Text;
                 txtProduct.Text = itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].SubItems[1].Text;
                 DataSet ds = new DataSet();
                 ds = ws.GetQueryResult("Execute pGetLatestPackSizeWithPendingOrder '"+GlobalUsage.gUnit_Id+"','"+_Item_Id+"','"+GlobalUsage.gLogin_id+"',"+DateTime.Now.Second.ToString(), "eIm_Data");
                 itemhelpgrid.Visible = false;
                 txtProduct.Select();
                 txtProduct.Focus(); 
                 if(ds.Tables.Count > 0)
                 {
                     if(ds.Tables[0].Rows.Count > 0)
                     {
                         DataRow[] drarr = ds.Tables[0].Select("item_id='"+_Item_Id+"' ");
                         cbxPack.Items.Clear();
                         //cbxPack.Items.Add("Select");
                         foreach (DataRow dr in drarr)
                         {
                             cbxPack.Items.Add(dr["pack_size"].ToString());
                             txtPendOrder.Text =Convert.ToDecimal(dr["PendOrder"]).ToString("###.00");
                             txtPqty.Text = Convert.ToDecimal(dr["pack_qty"]).ToString("###");
                         }
                         
                         cbxPack.SelectedIndex = 0;
                         if (cbxPack.Items.Count == 1)
                             cbxPack.Enabled = false;
                     }
                 }     
#endregion
                txtqty.Focus();
            }
        }
        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                itemhelpgrid.Focus();
                itemhelpgrid.Items[0].Selected = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                cbxPack.Focus();
            }
        }
        public void FillOrderedProduct()
        { 
            lv_Issued.Items.Clear();
            foreach(DataRow dr in _ds.Tables[0].Rows)
            {
                lv_Issued.Items.Add(dr["auto_id"].ToString());
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add((dr["pack_size"].ToString())+"/"+Convert.ToDecimal(dr["pack_qty"]).ToString("###"));
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("####.00"));
            }
            txtProduct.Select();
            txtProduct.Focus();
        }
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] t=cbxPack.SelectedItem.ToString().Split('x');
                string[] r=t[1].Split(' ');
                decimal tQty = Convert.ToDecimal(txtqty.Text); //* Convert.ToDecimal(t[0].ToString()) * Convert.ToDecimal(r[0].ToString());
                decimal baseQty = Convert.ToDecimal(txtPqty.Text);//Convert.ToDecimal(r[0].ToString()) * Convert.ToDecimal(t[0].ToString());
                if (tQty % baseQty == 0)
                {
                    _Qty= Convert.ToDecimal(txtqty.Text);
                    _PackSize=cbxPack.SelectedItem.ToString();
                    progressBar1.Visible = true;
                    _Action ="Feeding";
                    if(!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                else
                { MessageBox.Show("Please put valid quantity"); }
            }
        }
        private void cbxPack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtqty.Focus();
            }
        }
        private void lv_Issued_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                _deleteing_Id= lv_Issued.Items[lv_Issued.FocusedItem.Index].Text;
                try
                {
                     progressBar1.Visible = true;
                     _Action = "DeleteProduct";
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if(_Action=="Feeding")
            {
                try
                {
                    _Msg = ws.CreateOrderInfo(GlobalUsage.gUnit_Id, _Item_Id, GlobalUsage.gLogin_id, _PackSize,Convert.ToDecimal(txtPqty.Text), _Qty);
                    string qry = @"select im.item_name,oi.auto_id,oi.pack_size,oi.pack_qty,
                       oi.qty from item_master im inner join order_info oi on im.item_id=oi.item_id
                       where unit_id='" + GlobalUsage.gUnit_Id + "' and convert(varchar(10),oi.cr_date,111)=convert(varchar(10),getDate(),111)";
                    _ds = ws.GetQueryResult(qry, "eIM_Data");
                }
                catch (Exception ex) {MessageBox.Show(ex.Message);}
            }
            if (_Action == "DeleteProduct")
            {
                try
                {
                    ws.QueryExecute("delete from order_info where auto_id=" + _deleteing_Id + " ", "eIM_Data");
                    string qry = @"select im.item_name,oi.auto_id,oi.pack_size,
                    oi.qty from item_master im inner join order_info oi on im.item_id=oi.item_id
                    where unit_id='" + GlobalUsage.gUnit_Id + "' and convert(varchar(10),oi.cr_date,111)=convert(varchar(10),getDate(),111) order by oi.auto_id ";
                   _ds = ws.GetQueryResult(qry, "eIM_Data");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message);}
            }
            if (_Action == "FillOrder")
            {
                try
                {
                    string qry = @"select im.item_name,oi.auto_id,oi.pack_size,
                    oi.qty from item_master im inner join order_info oi on im.item_id=oi.item_id
                    where unit_id='" + GlobalUsage.gUnit_Id + "' and convert(varchar(10),oi.cr_date,111)=convert(varchar(10),getDate(),111) order by oi.auto_id ";
                    _ds = ws.GetQueryResult(qry, "eIM_Data");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "Feeding")
            {
               if(_Msg=="success"){ FillOrderedProduct(); }
            }
            if (_Action=="DeleteProduct")
            {
               FillOrderedProduct();
            }
            if (_Action=="FillOrder")
            {
                FillOrderedProduct();
            }
            progressBar1.Visible =false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            _Action = "FillOrder";
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void txtqty_Enter(object sender, EventArgs e)
        {
            txtqty.SelectAll();
        }

        private void txtProduct_Enter(object sender, EventArgs e)
        {
            txtProduct.SelectAll();
        }

    }
}
