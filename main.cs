using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Media;
using System.Linq;
using eChandanCanteen.Inventory_WebServices;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eChandanCanteen
{
    public partial class main : Form
    {
        Size size = new Size();
        string stock_amt = "";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new Inventory_WebServicesSoapClient();
        DataSet ds = new DataSet();
        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            size = rec.Size;
            int x, y = 0;
            x = (rec.Width - 283) / 2;
            y = (rec.Height - 173) / 2;
            pictureBox1.Location = new Point(x, y);
            x = rec.Width - 210;
            y = rec.Height - 180;
            gbxAunthenticate.Location = new Point(x, y);
      
            toolStripStatusLabel1.Text = "Selected Company :"+GlobalUsage.gCmpCode;
            this.Text = "Canteen Management Module : eChandanCanteen Ver. " + Application.ProductVersion.ToString();
            //gbxAunthenticate.Visible = false;
            
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
        
        }
    
        private void purchaseFeedingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
      
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewManufacturer obj = new NewManufacturer("");
            obj.Owner = this;
            obj.Show();
        }
        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void vendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            NewCustomer obj = new NewCustomer();
            obj.Owner = this;
            obj.Show();
        }
        private void unitStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
             progressBar1.Visible = true;
             btnLogin.Visible = false; 
             if(!backgroundWorker1.IsBusy)
             backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string qry = "exec pCheckLogin '" + txtLoginId.Text + "','" + txtpsw.Text + "'";
                ds =GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ds.Tables[0].Rows.Count== 1)
            {
                DataRow dr;
                dr = ds.Tables[0].Rows[0];
                GlobalUsage.gUnit_Id = "CHCANT";
                GlobalUsage.gLogin_id = txtLoginId.Text;
                GlobalUsage.gCmpCode = "CHL";
                GlobalUsage.gRights = dr["accesslevel"].ToString();
                gbxAunthenticate.Visible = false;
                toolStripStatusLabel1.Text ="Selected Company : " + GlobalUsage.gCmpCode;
                this.Text = "Canteen Management System : eChandanCanteen Ver. " + Application.ProductVersion.ToString();
                EnableAccordingToRights(ds.Tables[1]);
            }
            else
            {
                btnLogin.Visible = true;
                progressBar1.Visible = false;
                lblMessage.Text = "Unable to Pass Authentication.";
                txtpsw.Text = "";
                GlobalUsage.gRights = "";
                gbxAunthenticate.Visible = true;
                txtLoginId.Focus();
            }
            progressBar1.Visible = false;
        }
        public void ControlLog()
        {
            #region Command Tab Menu
            for (int i = 0; i < this.mainMenu.Items.Count; i++)
            {
                RadMenuItem mm_menu = this.mainMenu.Items[i] as RadMenuItem;
                for (int j = 0; j < mm_menu.Items.Count; j++)
                {
                    RadMenuItem sm_menu = mm_menu.Items[j] as RadMenuItem;
                    if (sm_menu.Items.Count > 0)
                    {
                        for (int k = 0; k < sm_menu.Items.Count; k++)
                        {
                            RadMenuItem ssm_menu = sm_menu.Items[k] as RadMenuItem;
                            try
                            {
                                string qry = "execute Insert_Modify_AppMenu_master '" + Application.ProductName + "','" + mm_menu.Name.ToString() + "','" + mm_menu.Text + "','" + sm_menu.Name.ToString() + "','" + sm_menu.Text + "','" + ssm_menu.Name.ToString() + "','" + ssm_menu.Text + "','Insert','' ";
                                GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen");
                            }
                            catch (Exception ex) { }
                        }
                    }
                    else
                    {
                        try
                        {
                            string qry = "execute Insert_Modify_AppMenu_master '" + Application.ProductName + "','" + mm_menu.Name.ToString() + "','" + mm_menu.Text + "','" + sm_menu.Name.ToString() + "','" + sm_menu.Text + "','" + sm_menu.Name.ToString() + "','" + sm_menu.Text + "','Insert','' ";
                            GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen");
                        }
                        catch (Exception ex) { }
                    }

                }
            }
            #endregion
        }
        private void EnableAccordingToRights(DataTable dt)
        {
            try
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                var menu = dt.AsEnumerable().Select(o => new {  menuName = o.Field<string>("smm_name"),IsActive = o.Field<string>("IsActive") }).ToList();
                #region Command Tab Menu
                for (int i = 0; i < this.mainMenu.Items.Count; i++)
                {
                    RadMenuItem mm_menu = this.mainMenu.Items[i] as RadMenuItem;
                    for (int j = 0; j < mm_menu.Items.Count; j++)
                    {
                        RadMenuItem sm_menu = mm_menu.Items[j] as RadMenuItem;
                        if (sm_menu.Items.Count > 0)
                        {
                            for (int k = 0; k < sm_menu.Items.Count; k++)
                            {
                                RadMenuItem ssm_menu = sm_menu.Items[k] as RadMenuItem;
                                var T = menu.Where(X => X.menuName == ssm_menu.Name && X.IsActive == "Y");
                                if (T.Count() > 0)
                                {
                                    mainMenu.Enabled = true;
                                    ssm_menu.Enabled = true;
                                }
                                else
                                    ssm_menu.Enabled = false;
                            }
                        }
                        else
                        {
                            var t = menu.Where(X => X.menuName == sm_menu.Name && X.IsActive == "Y");
                            if (t.Count() > 0)
                            {
                                mainMenu.Enabled = true;
                                sm_menu.Enabled = true;
                            }
                            else
                                sm_menu.Enabled = false;
                        }

                    }
                }
                #endregion
            }
            catch (Exception ex) { Telerik.WinControls.RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { System.Windows.Forms.Cursor.Current = Cursors.Default; }
        }
        private void txtpsw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }
        private void changeCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCmp obj = new ChangeCmp();
            obj.SearchUpdated += new SearchUpdateEventHandler(changeCompany);
            obj.Owner = this;
            obj.Show();
        }
        private void shiftConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shift_Connection obj = new shift_Connection();
            obj.Owner = this;
            obj.Show();
        }
        private void changeCompany(object sender, SearchUpdatedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Selected Company : " + GlobalUsage.gCmpCode; ;
        }
        private void purchaseBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void productReceivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterUnit_Transfer obj = new InterUnit_Transfer();
            obj.Owner = this;
            obj.Show();
        }
        private void itemWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemWiseVendor obj = new ItemWiseVendor();
            obj.Owner = this;
            obj.Show();
        }
        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList obj = new ProductList();
            obj.Owner = this;
            obj.Show();
        }
        private void productRconsilationtToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Inventory_WebServicesSoapClient webServ = new Inventory_WebServicesSoapClient();
            // Create a delegate to handle the callback
            // Make an Asynchronous Call by calling 
            // the Begin method of the proxy class
            string qry =@"SELECT SUM(qty*mi.upr) rate from stocks inner join masterkey_info mi on stocks.master_key_id=mi.master_key_id 
            where stocks.unit_id='HOLKO'";
            //webServ.BeginGetQueryResult(qry,"eIM_Data",asyncCall,null);
			//Do some process while the web 
            //service is processing the request
          
        }
        private void rsm_POS_Click(object sender, EventArgs e)
        {
            Canteen.ProductSale obj = new Canteen.ProductSale();
            obj.Owner = this;
            obj.Show();
        }
        private void rsm_SaleRegister_Click(object sender, EventArgs e)
        {
            Canteen.SaleReport obj = new Canteen.SaleReport();
            obj.Owner = this;
            obj.Show();
        }
        private void rsm_Reports_Click(object sender, EventArgs e)
        {
            Canteen.MultipleReport obj = new Canteen.MultipleReport();
            obj.Owner = this;
            obj.Show();
        }
        private void rsm_CreditConsumption_Click(object sender, EventArgs e)
        {
            eChandanCanteen.Canteen.CreditConsumptionReport UseForm = new eChandanCanteen.Canteen.CreditConsumptionReport();
            UseForm.Owner = this;
            UseForm.Show();
        }
        private void rsm_CancelBill_Click(object sender, EventArgs e)
        {
            eChandanCanteen.Canteen.CancelProduct UseForm = new eChandanCanteen.Canteen.CancelProduct();
            UseForm.Owner = this;
            UseForm.Show();
        }

        private void rsm_Kot_Click(object sender, EventArgs e)
        {
            eChandanCanteen.Canteen.KOTWindow UseForm = new eChandanCanteen.Canteen.KOTWindow();
            UseForm.Owner = this;
            UseForm.Show();
        }

        private void rsm_TokenDisplay_Click(object sender, EventArgs e)
        {
            eChandanCanteen.Canteen.TokenDisplay UseForm = new eChandanCanteen.Canteen.TokenDisplay();
            UseForm.Owner = this;
            UseForm.Show();
        }
        private void rsm_Tat_Click(object sender, EventArgs e)
        {
            Canteen.TATReport UseForm = new Canteen.TATReport();
            UseForm.Owner = this;
            UseForm.Show();
        }

        private void rssm_NewProduct_Click(object sender, EventArgs e)
        {
            Canteen.ProductMaster obj = new Canteen.ProductMaster();
            obj.Owner = this;
            obj.Show();
        }
        private void rsm_Vendor_Click(object sender, EventArgs e)
        {
            NewVendor obj = new NewVendor();
            obj.Owner = this;
            obj.Show();
        }

        private void rsm_PurchaseFeeding_Click(object sender, EventArgs e)
        {
            PurchaseBillFeeding obj = new PurchaseBillFeeding();
            obj.Owner = this;
            obj.Show();
        }
        private void rsm_PurchaseBill_Click(object sender, EventArgs e)
        {
            PurchaseBillInfo obj = new PurchaseBillInfo();
            obj.Owner = this;
            obj.Show();
        }

        private void rsm_IssueProduct_Click(object sender, EventArgs e)
        {
            Canteen.IssueProduct obj = new Canteen.IssueProduct();
            obj.Owner = this;
            obj.Show();
        }
        private void rsm_UnitStocks_Click(object sender, EventArgs e)
        {
            StockAtUnit obj = new StockAtUnit();
            obj.Owner = this;
            obj.Show();
        }

        private void rsm_AmtReceiveFromStaff_Click(object sender, EventArgs e)
        {

            Canteen.PaymentReceiving obj = new Canteen.PaymentReceiving();
            obj.Owner = this;
            obj.Show();
        }

        private void rsm_AuditStock_Click(object sender, EventArgs e)
        {
            AuditStock obj = new AuditStock();
            obj.Owner = this;
            obj.Show();
        }

        private void rsm_UpdateSoftware_Click(object sender, EventArgs e)
        {
            AutoUpdater UseForm = new AutoUpdater();
            UseForm.Owner = this;
            UseForm.Show();
        }

        private void rsm_BuildMenu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ControlLog();
            Cursor.Current = Cursors.Default;
        }

        private void rsm_LoginRights_Click(object sender, EventArgs e)
        {
            eChandanCanteen.utility.menuRights UseForm = new eChandanCanteen.utility.menuRights("eChandanCanteen");
            UseForm.Owner = this;
            UseForm.Show();
        }

        private void rsm_AccountsInfo_Click(object sender, EventArgs e)
        {
            eChandanCanteen.Account.Accounts_Info UseForm = new eChandanCanteen.Account.Accounts_Info();
            UseForm.Owner = this;
            UseForm.Show();
        }

        private void rsm_ApproveCancellation_Click(object sender, EventArgs e)
        {
            eChandanCanteen.Canteen.CancelApproval UseForm = new eChandanCanteen.Canteen.CancelApproval();
            UseForm.Owner = this;
            UseForm.Show();
        }
    }
}