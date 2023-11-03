using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eChandanCanteen
{
    public partial class ucUploadScanedDoc : UserControl
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        OpenFileDialog dlg = new OpenFileDialog();
        string _DocId = string.Empty;
        string _DocType = string.Empty;
        string _result = "";
        string _extention = "";
        public ucUploadScanedDoc()
        {
            InitializeComponent();
        }
        public string DocId
        {
            get { return _DocId; }
            set { _DocId = value; }
        }
        public string DocType
        {
            get { return _DocType; }
            set { _DocType = value; }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dlg.ShowDialog();
            if (dlg.FileName.Length>3)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(dlg.FileName);
                txtpath.Text = dlg.FileName;
               _extention = fi.Extension;
               lblMsg.Text = "File Size: " + ((Convert.ToDecimal(fi.Length) / 1048576)).ToString("##.00") + " MB";
               if (((Convert.ToDecimal(fi.Length) / 1048576)) > 2)
               { btnSave.Enabled = false; MessageBox.Show("File size should not be more than 2 MB"); }
               else
               { btnSave.Enabled = true; }
            }
        }
        private void ucUploadScanedDoc_Load(object sender, EventArgs e)
        {
            txtDocType.Text =_DocType.ToUpper();
            txtDocId.Text =_DocId.ToUpper();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               Cursor.Current = Cursors.WaitCursor;
               btnSave.Enabled = false;
              _result =lws.Insert_ScanedDocument(_DocId, _DocType, GlobalUsage.gLogin_id,GlobalUsage.gUnit_Id,System.IO.File.ReadAllBytes(txtpath.Text));
               lblMsg.Text = _result;
               Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
