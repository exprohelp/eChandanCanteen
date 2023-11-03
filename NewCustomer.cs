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
    public partial class NewCustomer : Form
    {
        string pStateCode, pCustomerCode, pModStateCode, pModCustomerCode;
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
       
        public NewCustomer()
        {
            InitializeComponent();
        }
        
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                FillState();
                txtCustomer .Select();
                cmbState.SelectedText = "Select";
                cmbDistrict.SelectedText = "Select";


            }
            if (TabControl1.SelectedIndex == 1)
            {
                FillModState();
                FillCustomer();
                txtCustomer .Select();
                cmbmodDistrict.Text  = "Select";
                cmbModState.Text = "Select";
                cmbSelectCustomer.Text = "Select";


            }
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbState.Select();
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
               txtAddress .Select();
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
                txtMobNo .Select();
            }
        }

        private void txtMobNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtEmailId .Select();
            }
        }

        private void txtEmailId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd .PerformClick();
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
                DataSet ds = lws.fillState();
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
                DataSet ds = lws.fillState();
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
                DataSet ds = lws.fillDistrict(pStateCode);
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
                cmbmodDistrict.DisplayMember = "Distt_name";
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

        private void cmbModState_SelectedIndexChanged(object sender, EventArgs e)
        {
            pModStateCode = cmbModState.SelectedValue.ToString();
            FillModDistrict();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            FillState();
            cmbState.Text = "Select";
            cmbDistrict.Text = "Select";
            txtCustomer .Select();
            cmbmodDistrict .Text = "Select";
            cmbModState.Text = "Select";
            cmbSelectCustomer .Text = "Select";
        }
        public void SaveCustomer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = lws.NewAndModifyCustomer("N/A", "N/A", txtCustomer.Text, txtAddress.Text, txtContact.Text, txtMobNo.Text, cmbState.Text, cmbDistrict.Text, txtEmailId.Text, "N/A", "insert");
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
            if (txtCustomer.Text.Length > 0)
            {
                SaveCustomer();
            }
                 else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");
                txtCustomer.Select();
            }
            
            txtCustomer .Select();
            txtCustomer .Text = "";
            txtEmailId .Text = "";
            txtMobNo.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
        }

        private void cmbSelectCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModCustomer .Select();
                ModifyCustomer();
            }
            
        }

        private void txtModCustomer_KeyDown(object sender, KeyEventArgs e)
        
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

        private void cmbModState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbmodDistrict .Select();
            }
        }

        private void cmbmodDistrict_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModContact .Select();
            }
        }

        private void txtModContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModMOb .Select();
            }
        }

        private void txtModMOb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModEmailId .Select();
            }
        }
        public void FillCustomer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds = lws.fillCustomer();
                cmbSelectCustomer .SelectedIndexChanged -= new System.EventHandler(cmbSelectCustomer_SelectedIndexChanged );

                cmbSelectCustomer.DisplayMember = "cust_name";
                cmbSelectCustomer.ValueMember = "cust_id";
                cmbSelectCustomer.DataSource = ds.Tables[0];
                cmbSelectCustomer.SelectedIndex = -1;

                cmbSelectCustomer.SelectedIndexChanged += new System.EventHandler(cmbSelectCustomer_SelectedIndexChanged);
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;


        }
        private void txtModEmailId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModify.PerformClick();
                    txtModEmailId.Text = "";
                    txtModCustomer.Text = "";
                    txtModContact.Text = "";
                    txtModMOb.Text = "";
                    txtModAdd.Text = "";
                    cmbSelectCustomer.Select();
                }
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
        public void ModifyCustomer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds = lws.fillCustomerDetail(pCustomerCode);
                DataRow[] drary = ds.Tables[0].Select();
                foreach (DataRow dr in drary)
                {
                    pModCustomerCode  = dr["cust_id"].ToString();
                    txtModCustomer .Text = dr["cust_name"].ToString();
                    txtModAdd.Text = dr["address"].ToString();
                    txtModContact.Text = dr["contact_no"].ToString();
                    txtModEmailId .Text = dr["email_id"].ToString();
                    txtModMOb.Text = dr["mobile_no"].ToString();

                    cmbModState.Text = dr["state"].ToString();
                    cmbmodDistrict.Text = dr["city"].ToString();


                }
            }
        }
        public void SaveModifyCustomer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = lws.NewAndModifyCustomer(pModCustomerCode, "N/A", txtModCustomer.Text, txtModAdd.Text, txtModContact.Text, txtModMOb.Text, cmbModState.Text, cmbmodDistrict.Text, txtModEmailId.Text, "N/A", "update");
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

        private void cmbSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            pCustomerCode  = cmbSelectCustomer .SelectedValue.ToString();

        }

       

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(txtModCustomer .Text .Length >0)
             SaveModifyCustomer();
            cmbSelectCustomer.Select();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
