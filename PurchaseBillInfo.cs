using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;

namespace eChandanCanteen
{
    public partial class PurchaseBillInfo : Form
    {
        int PX = 0, IX = 0, PW = 0, IW = 0, PH = 0, IH = 0;
        int counter = 2;
        System.IO.FileInfo fiP;
        byte[] data = null; DataSet _ds = new DataSet();
        System.IO.MemoryStream ms = null;
        Bitmap bmpPrint;
        string _Result = string.Empty;
        DataSet pDS = new DataSet();
        string Logic = "ALL";
        string _purch_id = string.Empty;
        public PurchaseBillInfo()
        {
            InitializeComponent();
        }
        private void FillData()
        {
            lv_Detail.Items.Clear();
            if(pDS.Tables.Count > 0)
            {
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    string temp = "Temp";
                    lv_Detail.ItemChecked -= new ItemCheckedEventHandler(lv_Detail_ItemChecked);
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        if (temp != dr["vend_name"].ToString())
                        {
                            lv_Detail.Groups.Add(dr["vend_name"].ToString(), dr["vend_name"].ToString());
                            temp = dr["vend_name"].ToString();
                        }
                        ListViewItem lvi = new ListViewItem(dr["purch_Id"].ToString());
                        lvi.SubItems.Add(dr["inv_no"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MMM-yyyy"));
                        lvi.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MMM-yyyy"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["inv_total"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["inv_tax"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["inv_discount"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["netamount"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["roundoff"]).ToString("####.00"));
                        lvi.SubItems.Add(dr["conf_flag"].ToString());
                        lvi.Group = lv_Detail.Groups[dr["vend_name"].ToString()];
                        lv_Detail.Items.Add(lvi); 
                    }
                    lv_Detail.ItemChecked += new ItemCheckedEventHandler(lv_Detail_ItemChecked);
                }
            }
        }
        private void PurchaseBillInfo_Load(object sender, EventArgs e)
        {
            if (GlobalUsage.gLogin_id == "CHCL-00002")
               lv_Detail.CheckBoxes = true;
            else
               lv_Detail.CheckBoxes = false;
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd/MM/yyyy";
            panel1.Visible = true;
            panel1.Controls.Clear();
            ucUploadScanedDoc obj = new ucUploadScanedDoc();
            obj.DocId = "Select";
            obj.DocType = "PurchaseBill";
            panel1.Controls.Add(obj);
    
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            if (chkVerify.Checked)
                Logic = "Verified";
            else
                Logic = "ALL";
            pbPurchageFillInfo.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }
        public string DateToSql(DateTime dtp)
        {
            string temp;
            temp = dtp.ToString("yyyy/MM/dd");
            return temp;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string str;
            string str1;
            str = DateToSql(dtTo.Value);
            str1 = DateToSql(dtFrom.Value);
            string qry = @"pGetPurchaseInfo '" + str1.Trim() + "','" + str.Trim() + "','" + GlobalUsage.gCmpCode + "','" + Logic + "','-' ";
            try
            {
                 pDS =GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
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
            FillData();
            pbPurchageFillInfo.Visible = false;
            btnPrint.Visible = true; 
        }
        private void pbPurchageFillInfo_Click(object sender, EventArgs e)
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            string str;
            string str1;
            str = DateToSql(dtTo.Value);
            str1 = DateToSql(dtFrom.Value);
            string qry = @"pGetPurchaseInfo '" + str1.Trim() + "','" + str.Trim() + "','" + GlobalUsage.gCmpCode + "','" + Logic + "','NotCancel' ";
            try
            {
                ds =GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorRport obj = new ErrorRport();
                obj.SendError(ex);
            }
            eChandanCanteen.PurchageBill crt = new eChandanCanteen.PurchageBill();
            crt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            frmCommonRpt frm = new frmCommonRpt();
            frm.crystalReportViewer1.ReportSource = crt;
            Cursor.Current = Cursors.Default;
            frm.Show();
        }
        private void lv_Detail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if((object)lv_Detail.FocusedItem!=null)
                {
                  purchDetail obj = new purchDetail(lv_Detail.Items[lv_Detail.FocusedItem.Index].Text);
                  obj.Owner = this;
                  obj.Show();
                }
            }
            if (e.KeyCode == Keys.P)
            {
                if ((object)lv_Detail.FocusedItem != null)
                {

                    Cursor.Current = Cursors.WaitCursor;
                    DataSet purchds = GlobalUsage.canteenProxy.GetQueryResult("pGetPurchBillPrint '" + lv_Detail.Items[lv_Detail.FocusedItem.Index].Text + "' ", "ChandanCanteen");
                    eChandanCanteen.CrPrintPurch crt = new eChandanCanteen.CrPrintPurch();
                    crt.Database.Tables[0].SetDataSource(purchds.Tables[0]);
                    crt.Database.Tables[1].SetDataSource(purchds.Tables[1]);
                    crt.Database.Tables[2].SetDataSource(purchds.Tables[2]);
                    crt.SetParameterValue("Checkedby", purchds.Tables[2].Rows[0]["app_by"].ToString());
                    frmCommonRpt frm = new frmCommonRpt();
                    frm.crystalReportViewer1.ReportSource = crt;
                    Cursor.Current = Cursors.Default;
                    frm.Show();
                }
            }
            if (e.KeyCode == Keys.B)
            {
                if ((object)lv_Detail.FocusedItem != null)
                {
                  
                    Cursor.Current = Cursors.WaitCursor;
                    data = null; pictureBox1.Image = null; pictureBox1.Invalidate(); btnPrint.Enabled = false; bmpPrint = null;
                    fillDocumentIds(lv_Detail.Items[lv_Detail.FocusedItem.Index].Text);
                    if (ddlDocuments.Items.Count > 1)
                    {
                        FileDownload(((ExproComboBox)ddlDocuments.Items[1]).Value);
                        ddlDocuments.SelectedIndex = 1;
                    }
                    else
                    { data = null; pictureBox1.Image = null; pictureBox1.Invalidate(); btnPrint.Enabled = false; }
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        private void lv_Detail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _purch_id = e.Item.Text;
            panel1.Visible = true;
           
            panel1.Controls.Clear();
            ucUploadScanedDoc obj = new ucUploadScanedDoc();
            obj.DocId = e.Item.Text;
            obj.DocType = "PurchaseBill";
            panel1.Controls.Add(obj);
            btnDelete.Enabled = false;
            if (e.Item.SubItems[9].Text =="N")
                btnDelete.Enabled = true;
            //panel1.Visible = true;
            //panel1.Controls.Clear();
            //string fin_Year =lv_Detail.Items[e.ItemIndex].Text.Substring(lv_Detail.Items[e.ItemIndex].Text.Length - 5,5);
            //panel1.Controls.Add(Config.AddDocUploadControl("PURCHASE\\" + fin_Year, lv_Detail.Items[e.ItemIndex].Text,720));
        }
        private void lv_Detail_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                try
                {
                    string qry = "update purch_master set conf_flag='Y',conf_by='" + GlobalUsage.gLogin_id + "' where purch_id='" + e.Item.Text + "'  ";
                    if (GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen") == "Success")
                    e.Item.SubItems[9].Text="Y";
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void FileDownload(string path)
        {
            //Cursor.Current = Cursors.WaitCursor;
            ////string path = "d:\\ajImage.JPG";
            //if (path.Length > 0)
            //{
            //    fiP = new System.IO.FileInfo(path);
            //    if (path != "N/A")
            //        data = lws.DownloadFile(path, out _Result);
            //    else
            //        if (pictureBox1.Image != null) { data = null; pictureBox1.Image = null; pictureBox1.Invalidate(); }
            //    if (fiP.Extension == "pdf" || fiP.Extension == "doc" || fiP.Extension == "docx" || fiP.Extension == "doc" || fiP.Extension == "xlsx" || fiP.Extension == "txt")
            //    {
            //        if (data != null)
            //        {
            //            string[] t = path.Split('\\');
            //            FolderBrowserDialog fd = new FolderBrowserDialog();
            //            fd.ShowDialog();
            //            string stored_at = fd.SelectedPath + "\\" + t[t.Length - 1];
            //            System.IO.File.WriteAllBytes(stored_at, data);
            //            btnPrint.Visible = false;
            //        }
            //    }
            //    else
            //    {
            //        if (data != null)
            //        {
            //            ms = new System.IO.MemoryStream(data);
            //            Bitmap bmp = new Bitmap(System.Drawing.Image.FromStream(ms), new System.Drawing.Size(270, 542));
            //            bmpPrint = new Bitmap(System.Drawing.Image.FromStream(ms));
            //            pictureBox1.Image = bmp;
            //            btnPrint.Visible = true;
            //            System.IO.File.WriteAllBytes(Application.StartupPath + "\\Temp" + fiP.Extension, data);
            //        }
            //        else
            //            if (pictureBox1.Image != null) { data = null; pictureBox1.Image = null; pictureBox1.Invalidate(); btnPrint.Enabled = false; }
            //    }
            //}
            //else
            //{ fiP = null; }
            //Cursor.Current = Cursors.Default;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //zoomImg obj = new zoomImg(data);
            //obj.Show();
            ImgPanel.BringToFront();
            pictureBox1.BringToFront();
            if (ms != null)
            {
                if (counter % 2 == 0)
                {
                    btnPrint.Visible = false;
                    PX = 754; ; PW = 271; IW = 270; PH = 542; IH = 542;
                    timer1.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    PX = 754; PW = 271; PH = 542; IW = 270; IH = 541;
                    btnPrint.BringToFront();
                    timer1.Enabled = false;
                    timer1.Stop();
                    ImgPanel.Width = PW;
                    ImgPanel.Height = PH;
                    pictureBox1.Width = IW;
                    pictureBox1.Height = IH;
                    Bitmap bmp = new Bitmap(System.Drawing.Image.FromStream(ms), new System.Drawing.Size(IW, IH));
                    ImgPanel.Location = new Point(PX,57);
                    pictureBox1.Location = new Point(IX, 0);
                    pictureBox1.Image = bmp;
                    btnPrint.Visible = true;
                }
                counter++;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ImgPanel.BringToFront();
            pictureBox1.BringToFront();
            if (ms != null)
            {
                if (PX > 15)
                {
                    PX = PX - 20;
                    PW = PW + 20;
                    IW = IW + 20;
                    IH = IH + 10;
                    ImgPanel.Width= PW;
                    ImgPanel.Height= PH;
                    pictureBox1.Width= IW;
                    pictureBox1.Height = IH;
                    Bitmap bmp = new Bitmap(System.Drawing.Image.FromStream(ms), new System.Drawing.Size(IW, IH));
                    ImgPanel.Location = new Point(PX,57);
                    pictureBox1.Location = new Point(IX, 0);
                    pictureBox1.Image = bmp;
                }
                else
                {
                    timer1.Enabled = false;
                    timer1.Stop();

                }
            }            
        }
        private void fillDocumentIds(string purchId)
        {
            string qry = @"pGetPurchaseInfo '1900/01/01','1900/01/01','" + GlobalUsage.gCmpCode + "','GetAllDocument','" + purchId + "' ";
            DataSet ds =GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
            ddlDocuments.SelectedIndexChanged -= new EventHandler(ddlDocuments_SelectedIndexChanged);
            ddlDocuments.Items.Clear();
            ddlDocuments.Items.AddRange(Config.FillCombo(ds.Tables[0]));
            ddlDocuments.SelectedIndex = 0;
            ddlDocuments.SelectedIndexChanged += new EventHandler(ddlDocuments_SelectedIndexChanged);
        }
        private void ddlDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            FileDownload(((ExproComboBox)ddlDocuments.SelectedItem).Value);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Temp" + fiP.Extension);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "execute pDelete_ScanDocument '" + _purch_id + "','" + ((ExproComboBox)ddlDocuments.SelectedItem).NewDescription + "','PurchaseDoc_Delete','-' ";
                if (GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen").ToString().Contains("Success"))
                    MessageBox.Show("Successfully Deleted");
                else
                    MessageBox.Show("It can not be Deleted");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
   
       
    }
}
