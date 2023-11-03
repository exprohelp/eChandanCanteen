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
    public partial class NewProduct : Form
    {
        DataTable dt = new DataTable();
        string pCatId, pMfdId, pProductId, pModCatId, pModMfdId;
        string Result = "";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public NewProduct()
        {
            InitializeComponent();
        }
        public void SaveProduct()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = lws.CreateUpdateProduct(hsnCode.Text, "N/A", txtNameOfProduct.Text, pCatId, cmbPackSize.Text, Convert.ToInt32(txtNewRol.Text), cmbDistribution.Text,"", "insert");
                    MessageBox.Show(ReturnValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);

                }
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
        }


        private void NewProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCategory.Select();
            }
        }
        public void FillCategory()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();

            if (result == "TRUE")
            {
                DataSet ds = lws.fillCategory();
                cmbCategory.SelectedIndexChanged -= new System.EventHandler(cmbCategory_SelectedIndexChanged);
                cmbCategory.DisplayMember = "cat_name";//cat_id,cat_name 
                cmbCategory.ValueMember = "cat_id";
                cmbCategory.DataSource = ds.Tables[0];
                cmbCategory.SelectedIndex = -1;
                cmbCategory.SelectedIndexChanged += new System.EventHandler(cmbCategory_SelectedIndexChanged);

            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;

        }
        public void FillModCategory()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();

            if (result == "TRUE")
            {
                DataSet ds = lws.fillCategory();

                cmbModCategory.DisplayMember = "cat_name";//cat_id,cat_name 
                cmbModCategory.ValueMember = "cat_id";
                cmbModCategory.DataSource = ds.Tables[0];
                cmbModCategory.SelectedIndex = -1;
                cmbCategory.DisplayMember = "cat_name";//cat_id,cat_name 
                cmbCategory.ValueMember = "cat_id";
                cmbCategory.DataSource = ds.Tables[0];
                cmbCategory.SelectedIndex = -1;


            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;

        }
        public void fillPacks()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds = lws.fillPacks();
                cmbPackSize.DisplayMember = "pack_size";
                cmbPackSize.DataSource = ds.Tables[0];
                cmbPackSize.SelectedIndex = -1;
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;

        }
        public void fillModPacks()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds = lws.fillPacks();
                cmbModPack.DisplayMember = "pack_size";
                cmbModPack.DataSource = ds.Tables[0];
                cmbModPack.SelectedIndex = -1;
                cmbPackSize.DisplayMember = "pack_size";
                cmbPackSize.DataSource = ds.Tables[0];
                cmbPackSize.SelectedIndex = -1;
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;

        }
        public void FillModManuFacturer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                cmbModManu.SelectedIndexChanged -= new EventHandler(this.cmbModManu_SelectedIndexChanged);
                DataSet ds = lws.fillManufacturer();
              
                cmbModManu.DisplayMember = "mfd_name";
                cmbModManu.ValueMember = "mfd_id";
                cmbModManu.DataSource = ds.Tables[0];
                cmbModManu.SelectedIndex = -1;
                cmbModManu.SelectedIndexChanged += new EventHandler(this.cmbModManu_SelectedIndexChanged);
            }
            else
            {
                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;

        }
        private void NewProduct_Load(object sender, EventArgs e)
        {
            cmbDistribution.SelectedIndex = cmbDistribution.FindString("FU");
            txtNameOfProduct.Select();
            FillCategory();
            fillPacks();
        
            cmbCategory.Text = "Select";
            cmbPackSize.Text = "Select";
       
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((object)cmbCategory.SelectedValue != null)
                pCatId = cmbCategory.SelectedValue.ToString();
        }
        private void fillManufacturer(object sender, SearchUpdatedEventArgs e)
        {
            FillModManuFacturer();
        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
             if (txtNameOfProduct.Text.Length > 0 && Result == "True")
            {
                SaveProduct();
                Result = "";
            }
            else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");

            }
            txtNameOfProduct.Text = "";
            txtNameOfProduct.Select();

        }

        private void cmbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPackSize.Select();
            }
        }

        private void cmbPackSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDistribution.Select();
            }
        }

        private void cmbDistribution_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void cmbManufacurer_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtNpr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void txtNameOfProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNameOfProduct.Text.Length > 0)
            {
                cmbCategory.Select();
            }
        }
        public void PackingCreation()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = lws.createPackSize(txtPacking.Text, txtQty.Text, Convert.ToInt32(txtPackQty.Text), cmbPackCreUnit.Text, txtPacCreDis.Text);
                    MessageBox.Show(ReturnValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
                }
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPacCreDis.Text.Length > 0 && txtPacking.Text.Length > 0 && txtQty.Text.Length > 0 && cmbPackCreUnit.Text != "True")
            {
                PackingCreation();
            }
            else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");

            }
        }
        public void CatCreation()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = lws.feedCategory(txtCatCre.Text);
                    MessageBox.Show(ReturnValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);

                }

            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
        }
        private void btnCatCre_Click(object sender, EventArgs e)
        {
            if (txtCatCre.Text.Length > 0)
            {
                CatCreation();
            }
            else
            {
                txtCatCre.Select();
            }
        }
        public void FillUnit()
        {
            DataSet ds = lws.fillMeasurementInfo();
            cmbPackCreUnit.SelectedIndexChanged -= new System.EventHandler(cmbPackCreUnit_SelectedIndexChanged);

            cmbPackCreUnit.DisplayMember = "m_abbr";
            cmbPackCreUnit.DataSource = ds.Tables[0];
            cmbPackCreUnit.SelectedIndex = -1;
            cmbPackCreUnit.SelectedIndexChanged += new System.EventHandler(cmbPackCreUnit_SelectedIndexChanged);

        }
        public void FillProduct()
        {
            DataSet ds = lws.fillProduct();
            cmbModSelectProd.SelectedIndexChanged -= new System.EventHandler(cmbModSelectProd_SelectedIndexChanged);
            cmbModSelectProd.DisplayMember = "item_name";
            cmbModSelectProd.ValueMember = "item_id";

            cmbModSelectProd.DataSource = ds.Tables[0];
            cmbModSelectProd.SelectedIndex = -1;
            cmbModSelectProd.SelectedIndexChanged += new System.EventHandler(cmbModSelectProd_SelectedIndexChanged);

        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 3)
            {
                FillUnit();
                txtPacking.Select();
                cmbPackCreUnit.Text = "Select";

            }
            if (TabControl1.SelectedIndex == 2)
            {
                txtCatCre.Select();
            }
            if (TabControl1.SelectedIndex == 0)
            {
                txtNameOfProduct.Select();
                fillModPacks();
                FillModCategory();
                FillModManuFacturer();

            }
            if (TabControl1.SelectedIndex == 1)
            {
                cmbModSelectProd.Select();
                FillProduct();
                fillModPacks();
                FillModCategory();
                FillModManuFacturer();
                cmbModCategory.Text = "Select";
                cmbModManu.Text = "Select";
                cmbModPack.Text = "Select";
                cmbModSelectProd.Text = "Select";
                txtModiProdName.Text = "";
            }
        }

        private void cmbPackCreUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPacks.Text = txtQty.Text + 'x' + txtPacking.Text + " " + cmbPackCreUnit.Text;
        }

        private void cmbModSelectProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_PackDetails.Visible = false;
            pProductId = cmbModSelectProd.SelectedValue.ToString();
        }
        public void ModifyProduct()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                lv_PackDetails.Items.Clear();
                lv_PackDetails.Visible = true;
                DataSet ds = lws.fillProductMdfyDetail(pProductId);
                DataRow[] drary = ds.Tables[0].Select();
                foreach (DataRow dr in drary)
                {
                    pModCatId = dr["cat_id"].ToString();
                    pModMfdId = dr["mfd_id"].ToString();
                    txtmodRol.Text = dr["ROL"].ToString();
                    txtModiProdName.Text = dr["item_name"].ToString();
                    cmbModCategory.Text = dr["cat_name"].ToString();
                    cmbModDistri.Text = dr["dist_type"].ToString();
                    cmbModManu.Text = dr["mfd_name"].ToString();
                    hsnCode.Text = dr["hsn"].ToString();
                }
                DataRow[] drary1 = ds.Tables[1].Select();
                foreach (DataRow dr1 in drary1)
                {
                    ListViewItem ls = new ListViewItem(dr1["Autoid"].ToString());
                    ls.SubItems.Add(dr1["pack_size"].ToString());
                    ls.SubItems.Add(dr1["pack_qty"].ToString());
                    lv_PackDetails.Items.Add(ls);
                    cmbModPack.Text = dr1["pack_size"].ToString();
                }
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
            txtModiProdName.Select();

        }

        private void cmbModSelectProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ModifyProduct();
            }

        }



        private void txtModiProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbModCategory.Select();
            }

        }

        private void cmbModCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbModPack.Select();
            }

        }

        private void cmbModPack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbModDistri.Select();
            }

        }

        private void cmbModDistri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbModManu.Select();
            }

        }

        private void cmbModManu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtModPacQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModify.PerformClick();
                txtmodRol.Focus();
                txtmodRol.Select();
            }
        }
        public void SaveModifyProduct()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    if (txtModiProdName.Text.Length > 0)
                    {
                        ReturnValue = lws.CreateUpdateProduct(hsnCode.Text, pProductId, txtModiProdName.Text, pModCatId, cmbModPack.Text, Convert.ToInt32(txtmodRol.Text), cmbModDistri.Text, pModMfdId, "update");
                        MessageBox.Show(ReturnValue);
                    }
                    else
                    {
                        MessageBox.Show("Product Name should not be blank ");
                        return;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);

                }

            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            Result = ComboModChk();
            if (txtModiProdName.Text.Length > 0 && Result == "True")
            {
                SaveModifyProduct();
                Result = "";
            }
            else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");

            }

        }
        private void txtPackCrePack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Select();
            }

        }
        private void txtPackCreQuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPackCreUnit.Select();
            }

        }
        private void cmbPackCreUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPackQty.Select();
            }

        }
        private void txtPackCrePackQty_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtPacCreDis.Select();
            }

        }
        private void txtPacCreDis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate.PerformClick();
            }

        }
        private void txtModNpr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmodRol.Select();
            }

        }
        private void txtCatCre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCatCre.PerformClick();
            }

        }
      
        private string ComboModChk()
        {

            if (cmbModManu.Text != "Select" && cmbModCategory.Text != "Select" && cmbModPack.Text != "Select" && cmbModSelectProd.Text != "Select")
            {
                Result = "True";
            }
            return Result;

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbModManu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((object)cmbModManu.SelectedValue != null)
                pModMfdId = cmbModManu.SelectedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewManufacturer obj = new NewManufacturer("");
            obj.SearchUpdated += new SearchUpdateEventHandler(fillManufacturer);
            obj.Owner = this;
            obj.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewManufacturer obj = new NewManufacturer("");
            obj.SearchUpdated += new SearchUpdateEventHandler(fillManufacturer);
            obj.Owner = this;
            obj.Show();
        }
        private void cmbModCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModCategory.SelectedValue != null)
                pModCatId = cmbModCategory.SelectedValue.ToString();
        }
        private void txtPacking_Leave(object sender, EventArgs e)
        {
            lblPacks.Text = txtQty.Text + 'x' + txtPacking.Text + " " + cmbPackCreUnit.Text;
        }
        private void txtQty_Leave(object sender, EventArgs e)
        {
            lblPacks.Text = txtQty.Text + 'x' + txtPacking.Text + " " + cmbPackCreUnit.Text;
        }
        private void txtPackQty_Leave(object sender, EventArgs e)
        {
            // if((txtPackQty.Text !=txtQty.Text && txtPackQty.Text!=txtPacking.Text ))
            if (txtPackQty.Text.Length > 1)
            {
                txtPackQty.Text = "";
                MessageBox.Show("please put only valid quantity");
            }
        }



    }
}
