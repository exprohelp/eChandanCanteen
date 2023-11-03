using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eChandanCanteen.Canteen
{
    public partial class IssueProduct : Telerik.WinControls.UI.RadForm
    {
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Label lblPack;
  
        DataSet dsProductList = new DataSet();
        public IssueProduct()
        {
            InitializeComponent();
        }
        private void ProductList(string logic,string prm1)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','" + logic + "','" + prm1 + "','N/A','N/A'";
                dsProductList = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgProduct.DataSource = dsProductList.Tables[0];

                ddlIssueTo.Items.AddRange(Config.FillTelrikCombo(dsProductList.Tables[1]));
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel p = sender as System.Windows.Forms.Panel;
            p.BackColor = Color.LightPink;
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel p = sender as System.Windows.Forms.Panel;
            p.BackColor = System.Drawing.Color.Silver; ;
        }
        private void ProductIssue_Load(object sender, EventArgs e)
        {
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 60);
            ProductList("IssueProductList", "ALL");
            ddlIssueTo.SelectedIndex = 0;
         }
        decimal _disc_perc = 0;
        string  _prodType = string.Empty;
        string  _masterkey = string.Empty;
        string  _item_name = string.Empty;
        string  _itemid = string.Empty;
        string  _result = string.Empty;
        private void MasterTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductSelection(dgProduct.CurrentRow.Cells["item_id"].Value.ToString());
            }
        }
        private void ProductSelection(string item_id)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                 string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','StocksInfo','" + item_id + "','N/A','N/A'";
                 DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                
                 dgProductDetail.DataSource = ds.Tables[0];
                 if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count==0)
                 {
                     txtRate.Text = "0";
                     _masterkey ="";
                  
                     txtNet.Text = "0";
                     txtQty.Select();
                     txtQty.Text = "1";
                     txtQty.SelectionStart = 0;
                     txtQty.SelectionLength = txtQty.Text.Length;  

                     MessageBox.Show("Retail product can not sale without stocks");

                 }

                _itemid = ds.Tables[1].Rows[0]["item_id"].ToString();
                _prodType = ds.Tables[1].Rows[0]["prodType"].ToString();
                _item_name = ds.Tables[1].Rows[0]["item_name"].ToString();
                txtProdDisplay.Text = _item_name;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
                {
                     txtQty.Focus();
                     txtRate.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["mrp"]).ToString("##.0");
                    _masterkey = ds.Tables[0].Rows[0]["master_key_id"].ToString();
                   
                     txtQty.Select();
                     txtQty.Text = "1";
                     txtQty.SelectionStart = 0;
                     txtQty.SelectionLength = txtQty.Text.Length;  

                }
                else if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 1)
                {
                    txtRate.Text = "0";
                    _masterkey = "";
                    txtNet.Text = "0";
                    dgProductDetail.Focus();
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void MasterTemplate_Click_1(object sender, EventArgs e)
        {
            SelectionByProductDetail();

        }
        private void SelectionByProductDetail()
        {

            txtQty.Focus();
            txtRate.Text = dgProductDetail.CurrentRow.Cells["mrp"].Value.ToString();
            _masterkey = dgProductDetail.CurrentRow.Cells["master_key_id"].Value.ToString();
            txtQty.Select();
            txtQty.Text = "1";
            txtQty.SelectionStart = 0;
            txtQty.SelectionLength = txtQty.Text.Length;
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(txtQty.Text) > 0)
            {
                try
                {
                    if (ddlIssueTo.SelectedItem.ToString() != "Select")
                    {
                        _result = GlobalUsage.canteenProxy.IssueToUse(GlobalUsage.gUnit_Id, _itemid, _masterkey, Convert.ToInt32(txtQty.Text), GlobalUsage.gLogin_id, ddlIssueTo.SelectedItem.ToString());
                        if (_result.Contains("Success"))
                        {
                            GridViewRowInfo gr = dgProdDet.Rows.AddNew();
                            gr.Cells["master_key_id"].Value = _masterkey;
                            gr.Cells["item_name"].Value = _item_name;
                            gr.Cells["item_id"].Value = _itemid;
                            gr.Cells["prodType"].Value = _prodType;
                            gr.Cells["qty"].Value = Convert.ToDecimal(txtQty.Text);
                            gr.Cells["auto_id"].Value = _result.Split('~')[1];
                            dgProduct.Focus();
                        }
                        else
                        { MessageBox.Show(_result); }
                    }
                    else
                    { MessageBox.Show("please select department"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            { MessageBox.Show("Invalid Quantity"); }
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            btnAdd.Focus();
        }
        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                GlobalUsage.canteenProxy.DeleteIssuedItems(out _result,Convert.ToInt32(dgProdDet.CurrentRow.Cells["auto_id"].Value));
                if (_result.Contains("Success"))
                    e.Row.Delete();
                else
                    MessageBox.Show(_result);
            }
        }
        string _custname = string.Empty;
        string _sale_no = string.Empty;
        private void MasterTemplate_KeyDown_1(object sender, KeyEventArgs e)
        {
            SelectionByProductDetail();
        }

        private void radPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
   

       
    }
}
