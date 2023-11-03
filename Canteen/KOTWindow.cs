using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using Microsoft.AspNet.SignalR.Client;

namespace eChandanCanteen.Canteen
{
    
    public partial class KOTWindow : Telerik.WinControls.UI.RadForm
    {
        HubConnection connection;
        static IHubProxy _hub;
        public KOTWindow()
        {
            InitializeComponent();
        }
        private void KOTWindow_Load(object sender, EventArgs e)
        {
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
            TokenListPanel();
            ConnectToSignalRServer();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TokenListPanel();
        }
        private void TokenListPanel2()
        {
            try
            {
              
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','KOTTokenList','-','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                int xloc = 6; int yloc = 5; int count = 0;
                PanelBooked.Controls.Clear();
                PanelCooking.Controls.Clear();
                PanelReady.Controls.Clear();

                var listBooked = ds.Tables[0].AsEnumerable().Where(x => x.Field<string>("TokenStatus")== "Booked").Select(y=>new { TokenStatus = y.Field<string>("TokenStatus"), TokenNo=y.Field<int>("TokenNo"), SaleNo = y.Field<string>("sale_inv_no") });
                var listCooking =ds.Tables[0].AsEnumerable().Where(x => x.Field<string>("TokenStatus")== "Cooking").Select(y=>new { TokenStatus = y.Field<string>("TokenStatus"), TokenNo=y.Field<int>("TokenNo"), SaleNo = y.Field<string>("sale_inv_no") });
                var listReady = ds.Tables[0].AsEnumerable().Where(x => x.Field<string>("TokenStatus") == "Ready").Select(y => new { TokenStatus = y.Field<string>("TokenStatus"), TokenNo = y.Field<int>("TokenNo"), SaleNo = y.Field<string>("sale_inv_no") });

                foreach (var t in listBooked)
                {
                      NonFickeringPanel pnlItem = GetButtonPanel(t.TokenNo.ToString(), t.SaleNo,"Cooking");
                      pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                      PanelBooked.Controls.Add(pnlItem);
                      xloc = xloc + 205;
                      count++;
                      if (count % 2 == 0)
                      { yloc = yloc + 108; xloc = 6; }
                }
                xloc = 6;  yloc = 5;  count = 0;
                foreach (var t in listCooking)
                {
                    NonFickeringPanel pnlItem = GetButtonPanel(t.TokenNo.ToString(), t.SaleNo,"Ready");
                    pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                    PanelCooking.Controls.Add(pnlItem);
                    xloc = xloc + 205;
                    count++;
                    if (count % 2 == 0)
                    { yloc = yloc + 108; xloc = 6; }
                }
                xloc = 6; yloc = 5; count = 0;
                foreach (var t in listReady)
                {
                    NonFickeringPanel pnlItem = GetButtonPanel(t.TokenNo.ToString(), t.SaleNo, "Deliver");
                    pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                    PanelReady.Controls.Add(pnlItem);
                    xloc = xloc + 205;
                    count++;
                    if (count % 2 == 0)
                    { yloc = yloc + 108; xloc = 6; }
                }
                //#region Booked Block
                //foreach ( var t in listBooked)
                //{
                //    var yield = PanelBooked.Controls.OfType<Panel>().Where(x => x.Tag.ToString() == t.TokenNo.ToString());
                //    if (yield.Count()==0)
                //    {
                //        Panel pnlItem = GetButtonPanel(t.TokenNo.ToString(), t.SaleNo, t.TokenStatus);
                //        pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                //        PanelBooked.Controls.Add(pnlItem);
                //        xloc = xloc + 205;
                //        count++;
                //        if (count % 2 == 0)
                //        { yloc = yloc + 108; xloc = 6; }
                //    }
             
                //}
                //System.Drawing.Point loctemp = new System.Drawing.Point();
                //System.Drawing.Point swap_loc = new System.Drawing.Point();
                //int traversePoint = -1;
                //foreach (var ctr in PanelBooked.Controls)
                //{
                //    Panel pnl = ctr as Panel;
                //    var list = listBooked.Where(x => x.TokenNo==Convert.ToUInt32(pnl.Tag));
                //    if(!list.Any())
                //    {
                //        loctemp = pnl.Location;
                //        traversePoint = Convert.ToInt32(pnl.Tag);
                //        PanelBooked.Controls.Remove(pnl);
                //    }
                //}
                //if(traversePoint>0)
                //{
                //    int count2 = 1;
                //    foreach(var ctr in PanelBooked.Controls)
                //    {
                //        Panel pnl = ctr as Panel;
                //        if(Convert.ToUInt32(pnl.Tag) > traversePoint)
                //        {
                //            swap_loc = ((Panel)(PanelBooked.Controls["Panle" + pnl.Tag])).Location;
                //            ((Panel)(PanelBooked.Controls["Panle" + pnl.Tag])).Location = loctemp;
                //            loctemp = swap_loc;
                //        }
                    
                //    }
                    
                //    PanelBooked.Refresh();
                //}
                //#endregion
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void TokenListPanel()
        {
            try
            {

                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','KOTTokenList','-','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                int xbookloc = 6; int ybookloc = 5; int bookcount = 0;
                int xcookloc = 6; int ycookloc = 5; int cookcount = 0;
                int xreadyloc = 6; int yreadyloc = 5; int readycount = 0;

                PanelBooked.Controls.Clear();
                PanelCooking.Controls.Clear();
                PanelReady.Controls.Clear();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if(dr["TokenStatus"].ToString()== "Booked")
                    { 
                        NonFickeringPanel pnlItem = GetButtonPanel(dr["TokenNo"].ToString(), dr["sale_inv_no"].ToString(),"Cooking");
                        pnlItem.Location = new System.Drawing.Point(xbookloc, ybookloc);
                        PanelBooked.Controls.Add(pnlItem);
                        xbookloc = xbookloc + 205;
                        bookcount++;
                        if (bookcount % 2 == 0)
                        { ybookloc = ybookloc + 108; xbookloc = 6; }
                    }
                    if (dr["TokenStatus"].ToString() == "Cooking")
                    {
                        NonFickeringPanel pnlItem = GetButtonPanel(dr["TokenNo"].ToString(), dr["sale_inv_no"].ToString(), "Ready");
                        pnlItem.Location = new System.Drawing.Point(xcookloc, ycookloc);
                        PanelCooking.Controls.Add(pnlItem);
                        xcookloc = xcookloc + 205;
                        cookcount++;
                        if (cookcount % 2 == 0)
                        { ycookloc = ycookloc + 108; xcookloc = 6; }
                    }
                    if (dr["TokenStatus"].ToString() == "Ready")
                    {
                        NonFickeringPanel pnlItem = GetButtonPanel(dr["TokenNo"].ToString(), dr["sale_inv_no"].ToString(), "Deliver");
                        pnlItem.Location = new System.Drawing.Point(xreadyloc, yreadyloc);
                        PanelReady.Controls.Add(pnlItem);
                        xreadyloc = xreadyloc + 205;
                        readycount++;
                        if (readycount % 2 == 0)
                        { yreadyloc = yreadyloc + 108; xreadyloc = 6; }
                    }
                }
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private NonFickeringPanel GetButtonPanel(string TokenNo, string sale_inv_no,string actionname)
        {
            NonFickeringPanel pnlItem = new NonFickeringPanel();
            System.Windows.Forms.Label   lblToken  = new System.Windows.Forms.Label();
            System.Windows.Forms.Button  btnSaleNo = new System.Windows.Forms.Button();
            System.Windows.Forms.Button  btnStatus = new System.Windows.Forms.Button();
            System.Windows.Forms.Button  btnPrint  = new System.Windows.Forms.Button();

            pnlItem.BackColor = System.Drawing.Color.Silver;
            pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlItem.Name = "Panle"+TokenNo.ToString();
            pnlItem.Tag = TokenNo;
            pnlItem.Size = new System.Drawing.Size(197, 100);
            pnlItem.TabIndex = 0;
            pnlItem.MouseEnter += new EventHandler(Panel_MouseEnter);
            pnlItem.MouseLeave += new EventHandler(Panel_MouseLeave);

            lblToken.AutoSize = true;
            lblToken.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblToken.Location = new System.Drawing.Point(9, 10);
            lblToken.Name = "lbl" + TokenNo.ToString();
            lblToken.Size = new System.Drawing.Size(49, 37);
            lblToken.TabIndex = 0;
            lblToken.Text = TokenNo.ToString();
            // 
            // button1
            // 
            btnSaleNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaleNo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            btnSaleNo.Location = new System.Drawing.Point(8, 64);
            btnSaleNo.Name = "btnSale"+TokenNo.ToString();
            btnSaleNo.Size = new System.Drawing.Size(115, 27);
            btnSaleNo.TabIndex = 2;
            btnSaleNo.Click += new EventHandler(btnSaleNo_Click);
            btnSaleNo.Text =sale_inv_no.ToString();
            btnSaleNo.UseVisualStyleBackColor = true;

            btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnStatus.Location = new System.Drawing.Point(130, 64);
            btnStatus.Name = "btnCook";
            btnStatus.Size = new System.Drawing.Size(60,27);
            btnStatus.Click += new EventHandler(btnStatus_Click);
            btnStatus.TabIndex = 0;
            btnStatus.Text = actionname;
            btnStatus.Tag = TokenNo.ToString();
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrint.Image = global::eChandanCanteen.Properties.Resources.printer16;
            btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnPrint.Location = new System.Drawing.Point(155, 5);
            btnPrint.Name = "btnPrint";
            btnPrint.Click += new EventHandler(btnPrint_Click);
            btnPrint.Tag = sale_inv_no;
            btnPrint.Size = new System.Drawing.Size(35, 32);
            btnPrint.TabIndex = 1;

            pnlItem.Controls.Add(lblToken);
            pnlItem.Controls.Add(btnSaleNo);
            pnlItem.Controls.Add(btnStatus);
            pnlItem.Controls.Add(btnPrint);
            return pnlItem;
        }
        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                string sale_inv_no = ((Button)btn.Parent.Controls["btnSale" + btn.Tag.ToString()]).Text;
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gLogin_id + "','ChangeStatus'," + btn.Tag + ",'" + btn.Text + "','" + sale_inv_no + "'";
                GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally {}
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                PrintBill(btn.Tag.ToString());
            }
            catch (Exception ex) { }
        }
        private void btnSaleNo_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','SaleInfo','" + btn.Text + "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgProdDet.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }
        Microsoft.Reporting.WinForms.LocalReport report_KOT = new Microsoft.Reporting.WinForms.LocalReport();
        private void PrintBill(string sale_inv_no)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','PrintBill','" + sale_inv_no + "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                
                report_KOT.Refresh();
                report_KOT.DataSources.Clear();
                report_KOT.ReportPath = @"msReport\KOT.rdlc";
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
                report_KOT.PrintToPrinter(3.2f, 8.3f, 0.1f, 0.1f, 0.1f, 0.1f);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Cursor.Current = Cursors.Default; }
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
        public void ConnectToSignalRServer()
        {
            try
            {
                string url = System.Configuration.ConfigurationManager.AppSettings["URL"].ToString();
                connection = new HubConnection(url, "username=" + GlobalUsage.gLogin_id + "");
                _hub = connection.CreateHubProxy("canteenHub");
                connection.Start().Wait();
                if(connection.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                {
                   connection.Closed += Connection_Closed;
                }
                //ConnectToSignalRServer().Start();
                try
                {
                    _hub.On<string, string>("addMessage", (name, message) => this.Invoke((Action)(() => StartFillingSync())) );
                }
                catch (Exception ex) { }
            }
            catch (Exception ex) { }
        }
        private async void Connection_Closed()
        {

        }
        private void StartFillingSync()
        {
            if (!backgroundWorker1.IsBusy) { backgroundWorker1.RunWorkerAsync(); }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TokenListPanel();
        }
    }
}
