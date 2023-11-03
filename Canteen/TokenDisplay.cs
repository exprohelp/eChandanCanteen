using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eChandanCanteen.Canteen
{

    public partial class TokenDisplay : Telerik.WinControls.UI.RadForm
    {
        int tokenCount = 0;
        HubConnection connection;
        static IHubProxy _hub;
        int width_screen = 0;
        public TokenDisplay()
        {
            InitializeComponent();
            this.SetScreenToFirstNonPrimary();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
        public void ConnectToSignalRServer()
        {
            try
            {
                string url = System.Configuration.ConfigurationManager.AppSettings["URL"].ToString();
                connection = new HubConnection(url, "username=" + GlobalUsage.gLogin_id + "");
                _hub = connection.CreateHubProxy("canteenHub");
                connection.Start().Wait();
                if (connection.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                {
                    connection.Closed += Connection_Closed;
                }
                //ConnectToSignalRServer().Start();
                _hub.On<string, string>("addMessage", (name, message) =>
                 this.Invoke((Action)(() =>StartFillingSync()))
                );
            }
            catch (Exception ex) { MessageBox.Show("Host is not responding please check..."); }
        }
        private void TokenListPanel()
        {
            try
            {
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','ReadyTokenList','-','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                MasterPanel.Controls.Clear();
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0 )
                {
                    //Single Layout
                    if (ds.Tables[0].Rows.Count <= 2)
                    {
                        int yloc = 5;
                        var listReady = ds.Tables[0].AsEnumerable().Select(y => new { TokenStatus = y.Field<string>("TokenStatus"), TokenNo = y.Field<int>("TokenNo"), SaleNo = y.Field<string>("sale_inv_no") });
                        foreach (var t in listReady)
                        {
                            NonFickeringPanel pnlItem = GetButtonPanel(t.TokenNo.ToString(), (width_screen - 60));
                            pnlItem.Location = new System.Drawing.Point(20, yloc);
                            MasterPanel.Controls.Add(pnlItem);
                            yloc = yloc + 310;
                        }
                    }
                    else
                    {
                        //Double Layout
                        int yloc = 5; int xloc = 20;
                        int count=0;
                        var listReady = ds.Tables[0].AsEnumerable().Select(y => new { TokenStatus = y.Field<string>("TokenStatus"), TokenNo = y.Field<int>("TokenNo"), SaleNo = y.Field<string>("sale_inv_no") });
                        foreach (var t in listReady)
                        {
                            int half_width=(width_screen - 70) / 2;
                            NonFickeringPanel pnlItem = GetButtonPanel(t.TokenNo.ToString(), half_width);
                            pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                            MasterPanel.Controls.Add(pnlItem);
                            yloc = yloc + 310;
                           
                            count++;
                            if (count % 2 == 0)
                            { yloc = 5; xloc = half_width + 40; }
                         }
                    }
                }
                if(ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows.Count > tokenCount)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                    simpleSound.Play();
                }
                tokenCount = ds.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private NonFickeringPanel GetButtonPanel(string TokenNo,int panel_width)
        {
            NonFickeringPanel pnlItem = new NonFickeringPanel();
            System.Windows.Forms.Label lblToken = new System.Windows.Forms.Label();
            
            pnlItem.BackColor = System.Drawing.Color.Silver;
            pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlItem.Name = "Panle" + TokenNo.ToString();
            pnlItem.Tag = TokenNo;
            pnlItem.BackColor = System.Drawing.Color.Black;
            pnlItem.Size = new System.Drawing.Size(panel_width, 300);
            pnlItem.TabIndex = 0;
           
            lblToken.AutoSize = true;
            lblToken.Font = new System.Drawing.Font("Segoe UI", 200F, System.Drawing.FontStyle.Bold);
            lblToken.Location = new System.Drawing.Point(180,0);
            lblToken.Name=TokenNo.ToString();
            lblToken.Size = new System.Drawing.Size(49, 37);
            lblToken.TabIndex = 0;
            lblToken.ForeColor = System.Drawing.Color.Yellow;
            lblToken.Text =TokenNo.ToString();
            pnlItem.Controls.Add(lblToken);
    
            return pnlItem;
        }
        private async void Connection_Closed()
        {
        }
        private void TokenDisplay_Load(object sender, EventArgs e)
        {
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
            width_screen = this.Width;
            TokenListPanel();
            lblToken.Location = new Point(width_screen / 2 - lblToken.Width / 2, 1);
            ConnectToSignalRServer();
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
