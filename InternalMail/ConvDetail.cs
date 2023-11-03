using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eInventory.WorkStation_WebServices;
using System.IO;
namespace eInventory
{
    public partial class ConvDetail : Form
    {
        eInventory.WorkStation_WebServices.WorkStation_WebServices ws = new WorkStation_WebServices.WorkStation_WebServices();
        OpenFileDialog ofdg = new OpenFileDialog();
        Size sz = new Size();
        string Conversation = "";
        DataSet pDS = new DataSet();
        string filename = "";
        string pAction = "";
        string SubjectId="";
        string msgfrom = "";
        string msgto = "";
        string Subject = "";
        string Conv_id = "";
        byte[] data;
        public ConvDetail(string Sub_Id,string Convid,string msg_from,string msg_to,string Subject_detail )
        {
            this.SubjectId=Sub_Id;
            this.msgfrom = msg_from;
            this.msgto = msg_to;
            this.Subject = Subject_detail;
            this.Conv_id = Convid;
            InitializeComponent();
        }
        private void ConvDetail_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                pAction = "LoadDetail";
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Visible = true;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pAction == "LoadDetail")
            {
                string query = @"update communication set viewstatus='Old' where subject_id='" +SubjectId+ "' and (conv_id='" +GlobalUsage.gLogin_id+ "')";
                try
                {
                     ws.QueeryExecute(query, "eManagement");
                     pDS = ws.GetConversationDetail(GlobalUsage.gLogin_id, Conv_id, Subject, SubjectId); 
                }
                catch (Exception ex) { }
            }
         
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pAction == "LoadDetail")
            {
              lblFromTo.Text="From : " + msgfrom + " To : " +msgto ;
              lblSubject.Text="Subject :" +Subject;
              FillConvDetail();
            }
            progressBar1.Visible = false;
            pDS.Clear();
            pDS.Dispose();
        }
        void FillConvDetail()
        {
            if (pDS.Tables.Count > 0)
            {
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    int y =3;
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        RepeatingControl rpc = new RepeatingControl();
                        rpc.SetConvDateTime =dr["co_date"].ToString();
                        rpc.SetFromTo = "From    : " + dr["conv_name"].ToString() + "  To : " + dr["loginname"].ToString();
                        rpc.ConvDetail=dr["Conversation"].ToString();
                        rpc.Attachment=dr["file_name"].ToString();
                        rpc.FilePath= dr["att_file"].ToString()+"$"+dr["RecId"].ToString();
                        rpc.Location = new System.Drawing.Point(8, y);
                        panel1.Controls.Add(rpc);
                        y = y + 135;
                    }
                }
            }     
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = string.Empty;
                if (txtbrowse.Text.Length > 2)
                {
                    System.IO.FileInfo fi = new FileInfo(txtbrowse.Text);
                    FileName = fi.Name;
                    data = File.ReadAllBytes(txtbrowse.Text);
                }
                else
                    data = null;
                string msg = ws.CreateNewMail(GlobalUsage.gLogin_id,Conv_id,SubjectId,txtConversation.Text,FileName,data,"REPLY");
                MessageBox.Show(msg);
             
             }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
             Cursor.Current = Cursors.Default;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdg.ShowDialog();
            txtbrowse.Text = ofdg.FileName;
        }
        }
}
