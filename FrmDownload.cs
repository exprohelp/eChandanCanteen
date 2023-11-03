using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using eChandanCanteen.Inventory_WebServices;
using System.Diagnostics;
namespace eChandanCanteen
{
    public partial class FrmDownload : Form
    {
        string _Result = string.Empty;
        Inventory_WebServicesSoapClient ws = new Inventory_WebServicesSoapClient();
        int count = 0;
        byte[] _data;
        public FrmDownload()
        {
            InitializeComponent();
        }
        private void cmdDownload_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = Application.StartupPath + "\\AutoUpdater\\ExProAutoUpdater.exe";
            string args = GlobalUsage.gLogin_id.Trim() + " " + Application.ProductName.Trim() + " " + GlobalUsage.gUnit_Id + " " + Application.ProductVersion.Trim() + " " + Environment.MachineName.ToString();
            p.StartInfo.Arguments = args;
            p.Start();
            Application.Exit();
        }
       
     
    }
}
