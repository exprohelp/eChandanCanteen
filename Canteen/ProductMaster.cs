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
    public partial class ProductMaster : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        string _itemid = string.Empty;
        public ProductMaster()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string discontinue="N";
                string taxable = "Y";
                if(txtProperProductName.Text.Length < 2)
                {
                    MessageBox.Show("Please input proper name");
                    return;
                }
                if (txtpacktype.Text.Length < 1)
                {
                    MessageBox.Show("Please input proper pack type");
                    return;
                }
                if(Convert.ToInt32(txtpackqty.Text)<=0)
                {
                    MessageBox.Show("Please input proper pack qty");
                    return;
                }
                if (ddlProdType.SelectedItem.ToString()=="Select")
                {
                    MessageBox.Show("Please select product use type");
                    return;
                }
                if (ddlProductCategory.SelectedItem.ToString() == "Select")
                {
                    MessageBox.Show("Please select product category");
                    return;
                }
                if(chkTaxable.Checked)
                { taxable = "Y"; }
                _result = GlobalUsage.canteenProxy.Insert_Modify_item_master("New", txtProperProductName.Text, Convert.ToInt32(txtpackqty.Text), txtpacktype.Text, ddlProductCategory.SelectedItem.ToString(), ddlProdType.Text, txthsn.Text, Convert.ToDecimal(txtRate.Text), Convert.ToDecimal(txtdiscPerc.Text), taxable,Convert.ToDecimal(taxrate.Text), Convert.ToInt32(txtROL.Text), "N", "Insert");
                MessageBox.Show(_result);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }
        private void btnProductCat_Click(object sender, EventArgs e)
        {
            try
            {
               _result = GlobalUsage.canteenProxy.feedCategory(ddlProductCategory.Text);
               FillCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);

            }
        }
        private void ProductMaster_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
                ddlProdType.SelectedIndex = 0;
                ddlProdType1.SelectedIndex = 0;
                FillCategory();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
     
        }

        private void FillCategory()
        {
            try
            {
                ddlProductCategory.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','CategoryList','N/A','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                ddlProductCategory.Items.AddRange(Config.FillTelrikCombo(ds.Tables[0]));
                ddlProductCategory.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            txtProperProductName.Text = txtProduct.Text.Trim() + ' ' + txtpacktype.Text.Trim();
        }

        private void txtpacktype_TextChanged(object sender, EventArgs e)
        {
            txtProperProductName.Text = txtProduct.Text.Trim() + ' ' + txtpacktype.Text.Trim();
        }

        private void ddlProdType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(ddlProdType.Text.Contains("Cooked"))
            { txtRate.Enabled = true; }
            else
            {  txtRate.Text = "0"; }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
            Cursor.Current = Cursors.WaitCursor;
            string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','ProductList','" + ddlProdType1.SelectedItem.ToString() + "','N/A','N/A'";
            DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            dgProduct.DataSource = ds.Tables[0];
            Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
         }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _itemid = dgProduct.CurrentRow.Cells[0].Value.ToString();
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','ProductDetail','" + _itemid + "','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    btnEdit.Enabled = true;
                    txtProperProductName.ReadOnly = false;
                    txtpacktype.Text = ds.Tables[0].Rows[0]["pack_type"].ToString();
                    txtpackqty.Text = ds.Tables[0].Rows[0]["pack_qty"].ToString();
                    txtdiscPerc.Text = ds.Tables[0].Rows[0]["discount_perc"].ToString();
                    txtProperProductName.Text = ds.Tables[0].Rows[0]["item_name"].ToString();
                    txtRate.Text = ds.Tables[0].Rows[0]["RATE"].ToString();
                    ddlProdType.Text = ds.Tables[0].Rows[0]["prodType"].ToString();
                    ddlProductCategory.Text = ds.Tables[0].Rows[0]["prodCategory"].ToString();
                    txthsn.Text = ds.Tables[0].Rows[0]["hsn"].ToString();
                    txtROL.Text = ds.Tables[0].Rows[0]["rol"].ToString();
                    taxrate.Text = ds.Tables[0].Rows[0]["taxPerc"].ToString();

                    if(ds.Tables[0].Rows[0]["discontinue"].ToString()=="Y")
                    { chkACTIVE.Checked=false;}
                    else{
                    chkACTIVE.Checked=true;
                    }
                    if(ds.Tables[0].Rows[0]["taxincluded"].ToString()=="Y")
                    { chkTaxable.Checked=true;}
                    else
                    {
                    chkACTIVE.Checked=false;
                    }
                      if(ddlProdType.Text.Contains("Cooked"))
                    { txtRate.Enabled = true; }
                    else
                    { txtRate.Enabled = false; txtRate.Text = "0"; }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string discontinue = "N";
                string taxable = "Y";
                if (txtProperProductName.Text.Length < 2)
                {
                    MessageBox.Show("Please input proper name");
                    return;
                }
                if (txtpacktype.Text.Length < 1)
                {
                    MessageBox.Show("Please input proper pack type");
                    return;
                }
                if (Convert.ToInt32(txtpackqty.Text) <= 0)
                {
                    MessageBox.Show("Please input proper pack qty");
                    return;
                }
                if (ddlProdType.SelectedItem.ToString() == "Select")
                {
                    MessageBox.Show("Please select product use type");
                    return;
                }
                if (ddlProductCategory.SelectedItem.ToString() == "Select")
                {
                    MessageBox.Show("Please select product category");
                    return;
                }
                if (chkTaxable.Checked)
                { taxable = "Y"; }
                if (chkACTIVE.Checked)
                { discontinue = "N"; }
                else
                { discontinue = "Y"; }
                _result = GlobalUsage.canteenProxy.Insert_Modify_item_master(_itemid, txtProperProductName.Text,Convert.ToInt32(txtpackqty.Text), txtpacktype.Text, ddlProductCategory.SelectedItem.ToString(), ddlProdType.Text, txthsn.Text, Convert.ToDecimal(txtRate.Text), Convert.ToDecimal(txtdiscPerc.Text), taxable,Convert.ToDecimal(taxrate.Text), Convert.ToInt32(txtROL.Text), "N", "Update");
                MessageBox.Show(_result);
                  }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            }

        private void splitPanel2_Click(object sender, EventArgs e)
        {

        }
        }
    
}
