using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using eInventory.InternalMail;
namespace eInventory
{
    public partial class RepeatingControl : UserControl
    {

        eInventory.WorkStation_WebServices.WorkStation_WebServices ws = new WorkStation_WebServices.WorkStation_WebServices();
        InternalMail.InternalMail_WebServiceSoapClient fws = new InternalMail.InternalMail_WebServiceSoapClient();
        string  _ConvDateTime = "";
        string _fromTo = "";
        string _Detail = "";
        string _Attachment = "";
        string _FilePath = string.Empty;
        string RecId = ""; 
        byte[] data;
        public  RepeatingControl()
        {
            InitializeComponent();
        }
        public  string SetConvDateTime
        {
            get { return _ConvDateTime; }
            set { _ConvDateTime = value; }
        }
        public  string SetFromTo
        {
            get { return _fromTo; }
            set { _fromTo = value; }
        }
        public  string ConvDetail
        {
            get { return _Detail; }
            set { _Detail = value; }
        }
        public  string Attachment
        {
            get { return _Attachment; }
            set { _Attachment = value; }
        }
        public string FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }
        private void RepeatingControl_Load(object sender, EventArgs e)
        { 
            lblDateTime.Text="Date :"+_ConvDateTime;
            lblFromTo.Text = SetFromTo;
            txtConv.Text=_Detail;
            LinkDownload.Text = _Attachment;
            LinkDownload.Tag = _FilePath;
        }
        private void LinkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Attachment=((LinkLabel)sender).Text;
            string[] t1 = ((LinkLabel)sender).Tag.ToString().Split('$');
            string filepath = t1[0];
            string[] t   = filepath.Split('\\');
            string[] ext = filepath.Split('\\');
            byte[] data=null;
            string _Result = "";
            if (filepath.Contains("I:") && filepath.Contains("Int_Mail"))
            {
                data = ws.DownloadMailFile(filepath, out _Result);
            }
            else
            {
                string file_name = "At_" + t1[1] + "_" + _Attachment.Trim(); //get file object as FileInfo
                data = fws.DownLoadFileFromWebServer(file_name,"AttachInfo");
            }
            if (data!=null)
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                string stored_at = fd.SelectedPath + "\\" + _Attachment;
                File.WriteAllBytes(stored_at, data);
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_Attachment != "N/A")
            {
                string file_name="At_"+RecId.Trim()+"_"+_Attachment.Trim(); //get file object as FileInfo
                data = null;
                try { data = fws.DownLoadFileFromWebServer(file_name,"AttachInfo"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible =false;
            if (_Attachment != "N/A")
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                if (fd.SelectedPath != "")
                {
                    string stored_at = fd.SelectedPath + "\\" + _Attachment;
                    File.WriteAllBytes(stored_at, data);
                }
            }
        }
    }
}
