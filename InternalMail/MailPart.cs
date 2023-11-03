using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Net;
using CustomUIControls;
using eInventory.InternalMail;
using eInventory.WorkStation_WebServices;
namespace eInventory
{
    public partial class MailPart : Form
    {
        eInventory.WorkStation_WebServices.WorkStation_WebServices ws = new WorkStation_WebServices.WorkStation_WebServices();
        Microsoft.Win32.OpenFileDialog ofdg = new Microsoft.Win32.OpenFileDialog();
        InternalMail_WebServiceSoapClient fws = new InternalMail_WebServiceSoapClient();
        DateTime pFromDate = new DateTime();
        DateTime pToDate = new DateTime();
        Size sz = new Size();
        int flag = 1;
        private int flags;
        string[] CheckedSubjectId;
        string PersonToSent = "";
        string Conversation = "";
        DataSet pDS = new DataSet();
        string filename = "";
        string pJobId = "";
        string pAction = "";
        string _LoginId = "";
        string _Password = "";
        string _Attachment = "";
        string _RecId = "";
        byte[] data;
        int animate_time = 0;
        int clintsize = 0;
        public MailPart(int flag_prm, int time, int clint_size)
        {
            animate_time = time;
            flag = flag_prm;
            clintsize = clint_size;
            InitializeComponent();
        }
        private void btnCloseOldMail_Click(object sender, EventArgs e)
        {
            CheckedSubjectId = new string[lv_old_view.CheckedItems.Count];
            for (int i = 0; i < lv_old_view.CheckedItems.Count; i++)
            {
                CheckedSubjectId[i]=lv_old_view.CheckedItems[i].SubItems[5].Text;
            }
            if (!backgroundWorker1.IsBusy)
            {
                pAction = "CloseMail";
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Visible = true;
                btnClose.Visible = true;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pAction == "LoadNewMails")
            {
                try { pDS = ws.GetQueryResult("exec Get_New_Mail '" + GlobalUsage.gLogin_id + "' ", "eManagement"); }
                catch (Exception ex) { }
            }
            if (pAction == "LoadoldMails")
            {
                try { pDS = ws.GetEmails(GlobalUsage.gLogin_id); }
                catch (Exception ex) { }
            }
            if (pAction == "SearchMail")
            {
                string qry = "exec pWS_Search_Mail '" + GlobalUsage.gLogin_id + "','" + pFromDate.ToString("yyyy/MM/dd") + "','" + pToDate.ToString("yyyy/MM/dd") + "' ";
                try { pDS = ws.GetQueryResult(qry, "eManagement"); }
                catch (Exception ex) { }
            }
            if (pAction == "FindEmployee")
            {
                try
                {
                    string query = "select emp_code,(emp_name+' - '+ltrim(comp_code) ) as emp_name from empdetail where res_date is null and  emp_name like '" + txtLookFor.Text + "%' order by emp_name";
                    pDS = ws.GetQueryResult(query, "exhrd");
                }
                catch (Exception ex) { }
            }
            if (pAction == "UploadFile")
            {
                if (filename != "")
                    data = File.ReadAllBytes(ofdg.FileName.ToString());
                try { MessageBox.Show(fws.NewMail(GlobalUsage.gLogin_id, PersonToSent, txtSubject.Text, Conversation, filename, data)); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (pAction == "CloseMail")
            {
                try { ws.CloseMail(CheckedSubjectId, GlobalUsage.gLogin_id); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (pAction == "DownLoadFile")
            {
                if (_Attachment != "N/A")
                {
                    try { data = ws.DownLoadFile(_Attachment.Trim(), _RecId, "Job_"); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            if (pAction == "LoginNow")
            {
                try { pDS = ws.GetQueryResult("select emp_code,emp_name from empdetail where emp_code='" + _LoginId + "' and NetPassword='" + _Password + "' and InJob='YES' ", "ExHrd"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (pAction == "FillReminder")
            {
                try { pDS = ws.GetQueryResult("select * from myReminders  where emp_code='" + _LoginId + "' and active='Y' and rem_date<=getDate() order by rem_date ", "eManagement"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pAction == "LoadNewMails") { fillIncomingNewMails(pDS.Tables[0]); }
            if (pAction == "LoadoldMails") { fillIncomingoldMails(); }
            if (pAction == "FindEmployee") { FillEmployeeList(); }
            if (pAction == "SearchMail") { fillSearchedMails(); }
            if (pAction == "DownLoadFile") { DownloadFile(); }
            progressBar1.Visible = false;
            pDS.Clear();
            pDS.Dispose();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            CheckedSubjectId = new string[lv_new_mails.CheckedItems.Count];
            for (int i = 0; i < lv_new_mails.CheckedItems.Count; i++)
            {
                CheckedSubjectId[i] = lv_new_mails.CheckedItems[i].SubItems[5].Text;
            }
            if (!backgroundWorker1.IsBusy)
            {
                pAction = "CloseMail";
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Visible = true;
                btnClose.Visible = true;
            }

        }
        #region Fill Arrieved Mails,Jobs,Reminders in Listview
        public void fillIncomingNewMails(DataTable dtNewMail)
        {
            if (dtNewMail.Rows.Count > 0)
            {
                lv_new_mails.Items.Clear();
                lv_new_mails.BeginUpdate();
                btnClose.Visible = true;
                foreach (DataRow dr in dtNewMail.Rows)
                {
                    lv_new_mails.Items.Add(dr["msgFrom"].ToString());
                    lv_new_mails.Items[lv_new_mails.Items.Count - 1].SubItems.Add(dr["msgto"].ToString());
                    lv_new_mails.Items[lv_new_mails.Items.Count - 1].SubItems.Add(dr["subject"].ToString());
                    lv_new_mails.Items[lv_new_mails.Items.Count - 1].SubItems.Add(dr["status"].ToString());
                    lv_new_mails.Items[lv_new_mails.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MMM-yyyy"));
                    lv_new_mails.Items[lv_new_mails.Items.Count - 1].SubItems.Add(dr["Autoid"].ToString());
                    lv_new_mails.Items[lv_new_mails.Items.Count - 1].SubItems.Add(dr["Conv_id"].ToString());
                    if (dr["status"].ToString() == "New")
                        lv_new_mails.Items[lv_new_mails.Items.Count - 1].ForeColor = Color.Red;
                    else if (dr["status"].ToString() == "Reply")
                        lv_new_mails.Items[lv_new_mails.Items.Count - 1].ForeColor = Color.Green;
                    else if (dr["status"].ToString() == "Acknowledged")
                        lv_new_mails.Items[lv_new_mails.Items.Count - 1].ForeColor = Color.Purple;
                    else
                        lv_new_mails.Items[lv_new_mails.Items.Count - 1].ForeColor = Color.Black;
                }
                lv_new_mails.Focus();
                lv_new_mails.Items[0].Selected = true;
                lv_new_mails.EndUpdate();
            }
        }
        public void fillIncomingoldMails()
        {
            if (pDS.Tables.Count > 0)
            {
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    lv_old_view.Items.Clear();
                    lv_old_view.BeginUpdate();
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        lv_old_view.Items.Add(dr["msgFrom"].ToString());
                        lv_old_view.Items[lv_old_view.Items.Count - 1].SubItems.Add(dr["msgto"].ToString());
                        lv_old_view.Items[lv_old_view.Items.Count - 1].SubItems.Add(dr["subject"].ToString());
                        lv_old_view.Items[lv_old_view.Items.Count - 1].SubItems.Add(dr["status"].ToString());
                        lv_old_view.Items[lv_old_view.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MMM-yyyy"));
                        lv_old_view.Items[lv_old_view.Items.Count - 1].SubItems.Add(dr["Autoid"].ToString());
                        lv_old_view.Items[lv_old_view.Items.Count - 1].SubItems.Add(dr["Conv_id"].ToString());
                        if (dr["status"].ToString() == "New")
                            lv_old_view.Items[lv_old_view.Items.Count - 1].ForeColor = Color.Red;
                        else if (dr["status"].ToString() == "Reply")
                            lv_old_view.Items[lv_old_view.Items.Count - 1].ForeColor = Color.Green;
                        else if (dr["status"].ToString() == "Acknowledged")
                            lv_old_view.Items[lv_old_view.Items.Count - 1].ForeColor = Color.Purple;
                        else
                            lv_old_view.Items[lv_old_view.Items.Count - 1].ForeColor = Color.Black;
                    }
                    lv_old_view.Focus();
                    lv_old_view.Items[0].Selected = true;
                    lv_old_view.EndUpdate();

                }
            }

        }
        public void fillSearchedMails()
        {
            if (pDS.Tables.Count > 0)
            {
                if (pDS.Tables[0].Rows.Count > 0)
                {
                    lv_SearchMail.Items.Clear();
                    lv_SearchMail.BeginUpdate();
                    foreach (DataRow dr in pDS.Tables[0].Rows)
                    {
                        lv_SearchMail.Items.Add(dr["msgFrom"].ToString());
                        lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].SubItems.Add(dr["msgto"].ToString());
                        lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].SubItems.Add(dr["subject"].ToString());
                        lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].SubItems.Add(dr["status"].ToString());
                        if (dr["cr_date"].ToString() != "")
                            lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MMM-yyyy"));
                        else
                            lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].SubItems.Add("");
                        lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].SubItems.Add(dr["Autoid"].ToString());
                        lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].SubItems.Add(dr["Conv_id"].ToString());
                        if (dr["status"].ToString() == "New")
                            lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].ForeColor = Color.Red;
                        else if (dr["status"].ToString() == "Reply")
                            lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].ForeColor = Color.Green;
                        else if (dr["status"].ToString() == "Acknowledged")
                            lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].ForeColor = Color.Purple;
                        else
                            lv_SearchMail.Items[lv_SearchMail.Items.Count - 1].ForeColor = Color.Black;
                    }
                    lv_SearchMail.EndUpdate();
                    lv_SearchMail.Focus();
                    lv_SearchMail.Items[0].Selected = true;


                }
            }

        }
        public void DownloadFile()
        {
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
        #endregion
        private void lv_old_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string msgfrom = lv_old_view.Items[lv_old_view.FocusedItem.Index].SubItems[0].Text;
                string msgto = lv_old_view.Items[lv_old_view.FocusedItem.Index].SubItems[1].Text;
                string Subject = lv_old_view.Items[lv_old_view.FocusedItem.Index].SubItems[2].Text;
                string subId = lv_old_view.Items[lv_old_view.FocusedItem.Index].SubItems[5].Text;
                string Conv_id = lv_old_view.Items[lv_old_view.FocusedItem.Index].SubItems[6].Text;
                ConvDetail obj = new ConvDetail(subId, Conv_id, msgfrom, msgto, Subject);
                obj.Owner = this;
                obj.Show();
            }
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 0)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                    progressBar1.Visible = true;
                    btnCloseOldMail.Visible = false;
                    btnClose.Visible = true;
                }
            }
            else if (tabControl2.SelectedIndex == 1)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    pAction = "LoadoldMails";
                    backgroundWorker1.RunWorkerAsync();
                    progressBar1.Visible = true;
                    btnClose.Visible = false;
                    btnCloseOldMail.Visible = true;
                }
            }
            else
            {
                btnClose.Visible = false; btnCloseOldMail.Visible = false;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                pAction = "FindEmployee";
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Visible = true;
            }

        }
        private void FillEmployeeList()
        {
            if (pDS.Tables[0].Rows.Count > 0)
            {
                ddlPerson.Items.Clear();
                ddlPerson.Items.Add(new GlobalUsage.AddValue("Select", "Select"));
                foreach (DataRow dr in pDS.Tables[0].Rows)
                {
                    ddlPerson.Items.Add(new GlobalUsage.AddValue(dr["emp_code"].ToString(), dr["emp_name"].ToString()));
                }
            }
            ddlPerson.SelectedIndex = 0;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            filename = "";
            PersonToSent = "Select";
            if (!backgroundWorker1.IsBusy)
            {
                PersonToSent = ((GlobalUsage.AddValue)ddlPerson.SelectedItem).NewValue;
                Conversation = txtConversation.Text;
                if (PersonToSent == "Select")
                {
                    MessageBox.Show("Please Select Person To Send Mail");
                    return;
                }
                if (txtSubject.Text.Length <= 0)
                {
                    MessageBox.Show("Please Write Subject ");
                    return;
                }
                pAction = "UploadFile";
                filename = ofdg.SafeFileName;
                progressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdg.ShowDialog();
            txtbrowse.Text = ofdg.FileName;

        }
        private void lv_new_mails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string msgfrom = lv_new_mails.Items[lv_new_mails.FocusedItem.Index].SubItems[0].Text;
                string msgto = lv_new_mails.Items[lv_new_mails.FocusedItem.Index].SubItems[1].Text;
                string Subject = lv_new_mails.Items[lv_new_mails.FocusedItem.Index].SubItems[2].Text;
                string subId = lv_new_mails.Items[lv_new_mails.FocusedItem.Index].SubItems[5].Text;
                string Conv_id = lv_new_mails.Items[lv_new_mails.FocusedItem.Index].SubItems[6].Text;
                ConvDetail obj = new ConvDetail(subId, Conv_id, msgfrom, msgto, Subject);
                obj.Owner = this;
                obj.Show();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                pAction = "SearchMail";
                pFromDate = dtFrom.Value;
                pToDate = dtTo.Value;
                progressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync();

            }

        }
        private void lv_SearchMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string msgfrom = lv_SearchMail.Items[lv_SearchMail.FocusedItem.Index].SubItems[0].Text;
                string msgto = lv_SearchMail.Items[lv_SearchMail.FocusedItem.Index].SubItems[1].Text;
                string Subject = lv_SearchMail.Items[lv_SearchMail.FocusedItem.Index].SubItems[2].Text;
                string subId = lv_SearchMail.Items[lv_SearchMail.FocusedItem.Index].SubItems[5].Text;
                string Conv_id = lv_SearchMail.Items[lv_SearchMail.FocusedItem.Index].SubItems[6].Text;
                ConvDetail obj = new ConvDetail(subId, Conv_id, msgfrom, msgto, Subject);
                obj.Owner = this;
                obj.Show();
            }
        }
        private void MailPart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] t = ((Control)sender).Text.Split('|');
            _Attachment = t[1];
            _RecId = t[0];
            if (_Attachment != "N/A")
            {
                pAction = "DownLoadFile";
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }

        }
        private void linkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string qry = "update job_Assignment set JobInProcess='N', finishdate=getDate() where Job_Id='" + pJobId + "'";
            if (MessageBox.Show("Do you want to close this Job (Y/N) ?", "Job Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ws.QueeryExecute(qry, "eManagement");
                MessageBox.Show("Job is Closed ");
                if (!backgroundWorker1.IsBusy)
                {
                    pAction = "WorkListOfEmployee";
                    backgroundWorker1.RunWorkerAsync();
                    progressBar1.Visible = true;
                }
            }
        }
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void MailPart_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 125);
            if (!backgroundWorker1.IsBusy)
            {
                pAction = "LoadNewMails";
                progressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
      
        }
        public void JobDetail(object sender, EventArgs e)
        {

        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }

    }
}
