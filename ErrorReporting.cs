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
    public partial class ErrorReporting : Form
    {
        Exception ex = new Exception();
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws=new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public ErrorReporting(Exception ex1)
        {
            ex = ex1;
            InitializeComponent();
        }
        private void ErrorReporting_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        public static string ErrorHistory(Exception ex)
        {
            string[] errorarray = ex.StackTrace.Split('\\');
            string[] line = errorarray[errorarray.Length - 1].Split(':');
            string error = errorarray[errorarray.Length - 2] + "|" + ex.TargetSite.ReflectedType.FullName+ "|" + line[0] + "|" + line[1] + "|" + ex.Message;
            return error;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try { lws.SaveErrorLog(GlobalUsage.gUnit_Id, ErrorHistory(ex)); }catch (Exception ex) { }
        }
    }
}
