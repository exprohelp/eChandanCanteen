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
    public partial class NewManufacturer : Form
    {
        string pMfdId="", pModMfdId="";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public event SearchUpdateEventHandler SearchUpdated;
        public NewManufacturer(string pMFiD)
        {
            pMfdId = pMFiD;
            InitializeComponent();
        }
        public void SaveManufacturer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = lws.NewAndModifyManufacturer("N/A", txtManufacturer.Text, txtAddress.Text, txtPhNo.Text, txtMobNo.Text, txtEmailId.Text,"insert");
                    MessageBox.Show("Saved Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ErrorRport obj = new ErrorRport();
                    obj.SendError(ex);
            
                }
                txtManufacturer.Text = "";
                txtAddress.Text = "";
                txtPhNo.Text = "";
                txtMobNo.Text = "";
                txtEmailId .Text="";
                txtManufacturer.Select();


            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
            txtManufacturer.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtManufacturer .Text .Length >0)
            {
            SaveManufacturer();
            }
            else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");
                txtManufacturer.Select();
            }
        }

       

        private void txtManufacturer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtAddress .Select ();
            }

        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtPhNo.Select ();
            }

        }

        private void txtPhNo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               txtMobNo .Select ();
            }

        }

        private void txtMobNo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
              txtEmailId .Select ();
            }

        }

        private void txtEmailId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              btnAdd .PerformClick ();
              txtManufacturer.Focus();
              txtManufacturer.Select();
              txtManufacturer.Text = "";
              txtMobNo.Text = "";
              txtPhNo.Text = "";
              txtAddress.Text = "";
              txtEmailId.Text = "";
            }

        }

        private void txtPhNo_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtPhNo); 

        }

        private void txtMobNo_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtMobNo ); 

        }

        private void cmbSelectManu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtModManu.Select();
                ModifyProduct();
            }
        }

        private void txtModManu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtModAdd .Select();
            }
        }

        private void txtModAdd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtModPhNo.Select();
            }
        }

        private void txtModPhNo_KeyDown(object sender, KeyEventArgs e)
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
                txtModEmailId .Select();
            }
        }

        private void txtModEmailId_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnModify.PerformClick () ;
                cmbSelectManu.Select();
            }
        }

        private void txtModPhNo_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtModPhNo ); 
           

        }

        private void txtModMOb_KeyUp(object sender, KeyEventArgs e)
        {
            GlobalUsage.checkNumbers(this, txtModMOb ); 

        }
        public void FillManuFacturer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            if (result == "TRUE")
            {
                DataSet ds = lws.fillManufacturerList();
                cmbSelectManu.SelectedIndexChanged -= new System.EventHandler(cmbSelectManu_SelectedIndexChanged);

                cmbSelectManu.DisplayMember = "mfd_name";
                cmbSelectManu.ValueMember  = "mfd_id";

                cmbSelectManu.DataSource = ds.Tables[0];
                cmbSelectManu.SelectedIndex = -1;
                cmbSelectManu.SelectedIndexChanged += new System.EventHandler(cmbSelectManu_SelectedIndexChanged);
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
            

        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 1)
            {
                FillManuFacturer();
            }
           cmbSelectManu.Select();
           cmbSelectManu.SelectedText = "Select";

           
        }

        private void cmbSelectManu_SelectedIndexChanged(object sender, EventArgs e)
        {
            pMfdId  = cmbSelectManu.SelectedValue.ToString();

        }
        public void ModifyProduct()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                DataSet ds = lws.fillManufacturerDetail(pMfdId);
                DataRow[] drary = ds.Tables[0].Select();
                foreach (DataRow dr in drary)
                {
                   pModMfdId = dr["mfd_id"].ToString();
                   
                   txtModAdd.Text = dr["address"].ToString();
                   txtModManu .Text  = dr["mfd_name"].ToString();
                   txtModPhNo .Text = dr["phone"].ToString();
                   txtModMOb .Text = dr["mobile"].ToString();
                   txtModEmailId .Text = dr["email_id"].ToString();
                }
               
            }
            else
            {

                MessageBox.Show("Check Internet Connection", "ExPro Help");
            }
            Cursor.Current = Cursors.Arrow;
            

        }
        public void SaveModifyManufacturer()
        {
            Cursor.Current = Cursors.WaitCursor;
            string result = CheckInternet.CheckNet();
            string ReturnValue = "";
            if (result == "TRUE")
            {
                try
                {
                    ReturnValue = lws.NewAndModifyManufacturer(pMfdId, txtModManu.Text, txtModAdd.Text, txtModPhNo.Text, txtModMOb.Text, txtModEmailId.Text, "update");
                    MessageBox.Show("Successfully Updated");
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
            if (cmbSelectManu.Text!= "Select" && txtModManu.Text .Length >0 )
            {
                SaveModifyManufacturer();
            }
            else
            {
                MessageBox.Show("Please Check The Inserted Item", "ExPro Help");
                cmbSelectManu.Select();
            }
            cmbSelectManu.Select();
            txtModEmailId.Text = "";
            txtModManu.Text = "";
            txtModPhNo.Text = "";
            txtModAdd.Text = "";
            txtModMOb.Text = "";
        }

        private void NewManufacturer_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NewManufacturer_FormClosing(object sender, FormClosingEventArgs e)
        {
            SearchUpdatedEventArgs valueArgs = new SearchUpdatedEventArgs(pMfdId);
            SearchUpdated(this, valueArgs);
            this.Dispose();
            this.Close();
        }
    }
}
