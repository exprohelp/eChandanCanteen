using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
namespace eChandanCanteen
{
    public partial class ucQualityAttachement : UserControl
    {
        string _result = "";
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient ws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        string _complaint_id = string.Empty;
        System.IO.FileInfo fiP;
        byte[] data = null; DataSet _ds = new DataSet();
        System.IO.MemoryStream ms = null;
   
        public ucQualityAttachement()
        {
            InitializeComponent();
        }

        private void btnViewApp_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = ws.Quality_Querries(out _result, "-", GlobalUsage.gUnit_Id, dtAppFrom.Value.ToString("yyyy/MM/dd"), dtAppTo.Value.ToString("yyyy/MM/dd"), "-", "ALL_COMPLAINT");
            lvComplaint.Items.Clear();
            if (ds.Tables[0].Rows.Count > 0)
            {
                string temp = "Temp";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (temp != dr["branch"].ToString())
                    {
                        lvComplaint.Groups.Add(dr["branch"].ToString(), dr["branch"].ToString());
                        temp = dr["branch"].ToString();
                    }
                    ListViewItem ls = new ListViewItem(dr["compl_id"].ToString());
                    ls.SubItems.Add(dr["patient_id"].ToString());
                    ls.SubItems.Add(dr["comp_subject"].ToString());
                    ls.SubItems.Add(dr["comp_by"].ToString());
                    ls.SubItems.Add(dr["emp_name"].ToString());
                    ls.SubItems.Add(dr["compl_cont_no"].ToString());
                    ls.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy"));
                    if (dr["status_flag"].ToString().ToUpper() == "Y")
                        ls.ForeColor = Color.DarkGreen;
                    else
                        ls.ForeColor = Color.Red;
                    
                    ls.Group = lvComplaint.Groups[dr["branch"].ToString()];
                    lvComplaint.Items.Add(ls);
               }
            }
            else
            {
                MessageBox.Show("No Recor Found.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }

        private void lvComplaint_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FillRemark();
            }
        }
        public void FillList()
        {
            Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = ws.Quality_Querries(out _result,_complaint_id,GlobalUsage.gUnit_Id,dtAppFrom.Value.ToString("yyyy/MM/dd"), dtAppTo.Value.ToString("yyyy/MM/dd"), "-", "GetComplaint_Detail");
            lvDetail.Items.Clear();
            if (ds.Tables[0].Rows.Count > 0)
            {
                int count = 1;
                string temp = "";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string emp_name = dr["emp_name"].ToString();
                    if (temp != emp_name)
                    {
                        lvDetail.Groups.Add(emp_name, emp_name);
                        temp = emp_name;
                    }
                    ListViewItem ls = new ListViewItem(count.ToString());
                    ls.SubItems.Add(dr["remark"].ToString());
                    if (dr["doc_path"].ToString().Length > 10)
                        ls.SubItems.Add("Enter To Open");
                    else
                        ls.SubItems.Add("");
                    ls.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy"));
                    ls.SubItems.Add(dr["doc_path"].ToString());
                    ls.Group = lvDetail.Groups[emp_name];
                    lvDetail.Items.Add(ls);
                    count++;
                }
            }
            else
            {
                MessageBox.Show("No Recor Found.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor = Cursors.Default;
        }
        private void lvComplaint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillRemark();
        }
        private void FillRemark()
        {
           _complaint_id = lvComplaint.Items[lvComplaint.FocusedItem.Index].Text;
            txtPath1.Text = "";
            FillList();
        }
        private void lvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            Cursor.Current=Cursors.WaitCursor;
            if (e.KeyCode == Keys.Enter)
            {
                if (lvDetail.Items[lvDetail.FocusedItem.Index].SubItems[4].Text.Length > 10)
                {
                    FileDownload(lvDetail.Items[lvDetail.FocusedItem.Index].SubItems[4].Text);
                }
            }
            Cursor.Current = Cursors.Default;
         
        }
        private void FileDownload(string path)
        {
            Cursor.Current = Cursors.WaitCursor;
            //string path = "d:\\ajImage.JPG";
            if (path.Length > 0)
            {
                fiP = new System.IO.FileInfo(path);
                if (path != "N/A")
                {
                    data = ws.DownloadFile(path, out _result);
                    if (fiP.Extension == ".zip")
                    {
                        if (data != null)
                        {
                            string[] t = path.Split('\\');
                            FolderBrowserDialog fd = new FolderBrowserDialog();
                            fd.ShowDialog();
                            string stored_at = fd.SelectedPath + "\\" + t[t.Length - 1];
                            System.IO.File.WriteAllBytes(stored_at, data);
                        }
                    }
                    else
                    {
                        if (data != null)
                        {
                            System.IO.File.WriteAllBytes(Application.StartupPath + "\\Temp" + fiP.Extension, data);
                            System.Diagnostics.Process.Start(Application.StartupPath + "\\Temp" + fiP.Extension);
                        }
                    }
                }
            }
            else
            { fiP = null; }
            Cursor.Current = Cursors.Default;
        }
        private void lvDetail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtRemark.Text = e.Item.SubItems[1].Text;
        }
        private void btnReSend_Click(object sender, EventArgs e)
        {
            byte[] data = null;
            string extension=string.Empty;
            try
            {
                if (txtPath1.Text.Length > 2)
                {
                    data = System.IO.File.ReadAllBytes(txtPath1.Text);
                    System.IO.FileInfo fi = new System.IO.FileInfo(txtPath1.Text);
                    extension = fi.Extension;
                }
                Cursor.Current = Cursors.WaitCursor;
                if (txtRemark.Text.Trim().Length > 0 && _complaint_id.Length > 0)
                {
                    ws.SuscribeComplaintDetail(_complaint_id, extension,txtRemark.Text, data, GlobalUsage.gLogin_id, System.DateTime.Now.Millisecond.ToString(), out _result);
                    if (_result.Contains("Successfully"))
                    {
                        FillList();
                        txtPath1.Text = string.Empty; ;
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                { MessageBox.Show("Remark is mandatory"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            txtPath1.Text = "";
            OpenFileDialog fld = new OpenFileDialog();
            fld.ShowDialog();
            if (fld.FileName.Length > 5)
            {
                txtPath1.Text = fld.FileName;
            }
        }

        private void lvDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillRemark();
        }

    }
}
