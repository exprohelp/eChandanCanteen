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
    public partial class NewVendor : Form
    {
        string pStateCode, pVendorCode, pModStateCode, pModVendorCode;
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
       
        public NewVendor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbState  .Select();
            }
        
        }

        private void cmbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDistrict .Select();
            }
        }

        private void cmbDistrict_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress  .Select();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContact .Select();
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtMobNo  .Select();
            }
        }

        private void txtMobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTinNo.Select();
            }
        }

        private void txtTinNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd .PerformClick ();
                txtvendor.Select();
            }
        }

        private void txtContact_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtContact); 


        }

        private void txtMobNo_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtMobNo); 
            
        }

        public void FillState()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds =GlobalUsage.canteenProxy.fillState();
                cmbState.SelectedIndexChanged -= new System.EventHandler(cmbState_SelectedIndexChanged);

                cmbState.DisplayMember = "statename";
                cmbState.ValueMember = "state_code";

                cmbState.DataSource = ds.Tables[0];
                cmbState.SelectedIndex = -1;
                cmbState.SelectedIndexChanged += new System.EventHandler(cmbState_SelectedIndexChanged);
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;


        }
        public void FillModState()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds =GlobalUsage.canteenProxy.fillState();
                cmbModState.SelectedIndexChanged -= new System.EventHandler(cmbModState_SelectedIndexChanged);

                cmbModState.DisplayMember = "statename";
                cmbModState.ValueMember = "state_code";

                cmbModState.DataSource = ds.Tables[0];
                cmbModState.SelectedIndex = -1;
                cmbModState.SelectedIndexChanged += new System.EventHandler(cmbModState_SelectedIndexChanged);

            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;


        }
        public void FillDistrict()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds =GlobalUsage.canteenProxy.fillDistrict(pStateCode);
                cmbDistrict.DisplayMember = "Distt_name";
                cmbDistrict.DataSource = ds.Tables[0];
                cmbDistrict.SelectedIndex = -1;
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;


        }
        public void FillModDistrict()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds = lws.fillDistrict(pModStateCode);
                cmbmodDistrict .DisplayMember = "Distt_name";
                cmbmodDistrict.DataSource = ds.Tables[0];
                cmbmodDistrict.SelectedIndex = -1;
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;

        }
        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            pStateCode = cmbState.SelectedValue.ToString();
            FillDistrict();
            
        }
        public void AddDocUploadControl()
        {
            UCSaveDoc rpc = new UCSaveDoc();
            rpc.DocType = "VENDOR";
            rpc.Location = new System.Drawing.Point(8, 5);
            panel1.Controls.Add(rpc);
        }
        private void NewVendor_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(Config.AddDocUploadControl("VENDOR", pVendorCode,575));
            FillState();
            cmbState.Text = "Select";
            cmbDistrict.Text = "Select";
            txtvendor.Select();
            cmbmodDistrict.Text = "Select";
            cmbModState.Text = "Select";
            cmbSelectVendor.Text = "Select";
        }
        public void FillVendor()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','AppVendList','-','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                cmbSelectVendor.SelectedIndexChanged -= new System.EventHandler(cmbSelectVendor_SelectedIndexChanged);

                cmbSelectVendor.DisplayMember = "vend_name";
                cmbSelectVendor.ValueMember = "vend_code";
                cmbSelectVendor.DataSource = ds.Tables[0];
                cmbSelectVendor.SelectedIndex = -1;

                cmbSelectVendor.SelectedIndexChanged += new System.EventHandler(cmbSelectVendor_SelectedIndexChanged);
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;


        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                FillState();
                txtvendor.Select();
                cmbState .Text = "Select";
                cmbDistrict.Text = "Select";

            }
            if (TabControl1.SelectedIndex == 1)
            {
               
                FillModState();
                FillVendor();
                cmbSelectVendor.Select();
                cmbSelectVendor.Focus();
                cmbModState.Text = "Select";
                cmbmodDistrict.Text = "Select";
                cmbSelectVendor.Text = "Select";
                
               
            }
        }
        public void SaveVendor()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = GlobalUsage.canteenProxy.NewAndModifyVendor("N/A", txtvendor.Text, txtAddress.Text, txtContact.Text, txtMobNo.Text, txtTinNo.Text, cmbState.Text, cmbDistrict.Text, "insert", txtRemark.Text, txtLedgerID.Text);
                    MessageBox.Show("Saved Successfully");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbDistrict .Text !="Select" && cmbState .Text !="Select" && txtvendor .Text .Length >0)
            {
               SaveVendor();
            }
            else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");
                txtvendor.Select();
            }
            txtvendor.Select();
            txtvendor.Text = "";
            txtTinNo.Text = "";
            txtMobNo.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";

        }

       

        private void txtModVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModAdd.Select();
            }
        }

        private void txtModAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbModState .Select();
            }
        }

        private void txtModContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModMOb.Select();
            }
        }

        private void txtModMOb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModTinNo .Select();
            }
        }

        private void txtModTinNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnModify .PerformClick ();
                txtModTinNo .Text ="";
                txtModVendor.Text = "";
                txtModContact.Text = "";
                txtModMOb.Text = "";
                txtModAdd.Text = "";
                txtLedgeridmdy.Text = "";
                cmbSelectVendor.Select();
            }
        }

       

        private void txtModContact_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtModContact); 
        }
        private void txtModMOb_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtModMOb); 

        }
        public void ModifyVendor()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','VendorDetail','" + pVendorCode + "','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                DataRow[] drary = ds.Tables[0].Select();
                foreach (DataRow dr in drary)
                {
                    pModVendorCode = dr["vend_code"].ToString();
                    txtModVendor.Text = dr["vend_name"].ToString();
                    txtModAdd.Text = dr["address"].ToString();
                    txtModContact.Text = dr["contact_no"].ToString();
                    txtModTinNo.Text = dr["tin_no"].ToString();
                    txtModMOb .Text = dr["mob_no"].ToString();
                    cmbModState.Text = dr["state"].ToString();
                    cmbmodDistrict.Text = dr["district"].ToString();
                    txtMdfyRemark.Text=dr["remarks"].ToString();
                    txtLedgeridmdy.Text = dr["ledger_id"].ToString();
                    GlobalUsage.DocId =dr["vend_code"].ToString();
                }
            }
        }
        public void SaveModifyVendor()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = GlobalUsage.canteenProxy.NewAndModifyVendor(pVendorCode, txtModVendor.Text, txtModAdd.Text, txtModContact.Text, txtModMOb.Text, txtModTinNo.Text, cmbModState.Text, cmbmodDistrict.Text, "update", txtMdfyRemark.Text, txtLedgeridmdy.Text);
                    MessageBox.Show("Updated Successfuly");
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
            if(txtModVendor.Text.Length > 0 && cmbmodDistrict.Text != "Select" && cmbModState.Text != "Select")
            {
               SaveModifyVendor();
            }
            else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");
                cmbSelectVendor.Select();
            }
           cmbSelectVendor.Select();
           txtModTinNo.Text = "";
           txtModVendor.Text = "";
           txtModContact.Text = "";
           txtModMOb.Text = "";
           txtModAdd.Text = "";
           txtMdfyRemark.Text = "";
            txtLedgerID.Text = "";
        }
        private void cmbSelectVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalUsage.DocId = cmbSelectVendor.SelectedValue.ToString();
            pVendorCode = cmbSelectVendor.SelectedValue.ToString();
            panel1.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(Config.AddDocUploadControl("VENDOR", pVendorCode,575));
        }
        private void cmbSelectVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModVendor .Select();
                ModifyVendor();
            }
        }
        private void cmbModState_SelectedIndexChanged(object sender, EventArgs e)
        {
            pModStateCode = cmbModState.SelectedValue.ToString();
            FillModDistrict();
        }

        private void cmbModState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbmodDistrict.Select();
            }
        }
        private void cmbmodDistrict_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModContact .Select();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FillVendorName();
            Cursor.Current = Cursors.Default;
        }
        private void FillVendorName()
        {
            lv_Vendor.Items.Clear();
            DataSet ds = lws.GetQueryResult("select vend_code,vend_name,address,ledger_id=isnull(ledger_id,'-') from vendor_info order by vend_name  ","eIM_Data");
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["vend_code"].ToString());
                        lvi.SubItems.Add(dr["vend_name"].ToString());
                        lvi.SubItems.Add(dr["address"].ToString());
                        lvi.SubItems.Add(dr["ledger_id"].ToString());
                        lv_Vendor.Items.Add(lvi);
                    }
                }
            }
        }
        private void lv_Vendor_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lvDoc.Items.Clear();
            DataSet ds = lws.GetQueryResult("select doc_subject,remarks,doc_path from Doc_info where doc_id='"+e.Item.Text+"' ","eIM_Data");
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["doc_path"].ToString());
                        lvi.SubItems.Add("download");
                        lvi.SubItems.Add(dr["doc_subject"].ToString());
                        lvi.SubItems.Add(dr["remarks"].ToString());
                        lvDoc.Items.Add(lvi);
                    }
                }
            }
        }
         
    }
}
