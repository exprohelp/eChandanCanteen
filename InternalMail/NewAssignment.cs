using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using ExPro.Server;
using eInventory.WorkStation_WebServices;
using eInventory.InternalMail;
namespace eInventory.InternalMail

{
    public partial class NewAssignment : Form
    {
        eInventory.WorkStation_WebServices.WorkStation_WebServices cws = new WorkStation_WebServices.WorkStation_WebServices();
        int pItemIndex = 0;
        private int animationTime;
        private int flags;
        string pAction = "";
        string pEmpCode = "CHCL-00009";
        OpenFileDialog ofdg = new OpenFileDialog();
        DataSet pds = new DataSet();
        DataSet _ds = new DataSet();
        string pJobId = "";
        byte[] data; 
        string Coment = "";
        string pAssignedJob = "";
        string priority = "";
        string pSubject="";
        string Description="";
        DateTime finish_date=new DateTime();
        public NewAssignment(int AnimationTime, int Flags)
        {
            animationTime = AnimationTime;
            flags = Flags;
		    InitializeComponent();
        }
        private void NewAssignment_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 125); 
            pAction = "WorkListOfEmployee";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            progressBar1.Visible =true;
            WinAPI.AnimateWindow(this.Handle, animationTime, flags);
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pAction == "WorkListOfEmployee")
            {
                getWorkofSelectedEmployee();
            }
            if (pAction == "FillJobDetail")
            {
                FillJobDetail();
            }
            if (pAction == "CreateNewJob")
            {
                pAction = "WorkListOfEmployee";
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
                progressBar1.Visible = true;
            }
            progressBar1.Visible = false;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pAction=="FillJobDetail")
            {
                try { _ds =cws.GetQueryResult("select Subject,Description from Job_Assignment where Job_id='" + pAssignedJob + "'   select cr_date,Development from Job_Process_Info where Job_id='" + pAssignedJob + "' order by auto_id desc ", "eManagement"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (pAction=="WorkListOfEmployee")
            {
                string qry=@" select * from Job_Assignment where assignedby='" + GlobalUsage.gLogin_id + "' and assignedto='" + pEmpCode + "' order by auto_id desc ";
                try { pds =cws.GetQueryResult(qry, "eManagement"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            if (pAction == "CreateNewJob")
            {
                if (pSubject.Length > 5)
                {
                    DataSet dsdate = DbManager.GetQueryResult("select convert(varchar(10),(getDate()+2),111) target_date", "eDiagnostic");
                    finish_date = Convert.ToDateTime(dsdate.Tables[0].Rows[0][0]);
                    if (ofdg.SafeFileName.Length > 0)
                        data = File.ReadAllBytes(ofdg.FileName.ToString());
                    try
                    {
                       MessageBox.Show(cws.createNewJob(pSubject, Description, GlobalUsage.gLogin_id, pEmpCode, finish_date, priority, "No Coment", "Document", ofdg.SafeFileName, ofdg.SafeFileName, data), "ExProHelp Passing Query ...");
                       cws.SendSMS(GlobalUsage.gUnit_Id + ", " + txtSubject.Text.Trim() + ".", "9839690999");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help Passing Query ..."); }
                }
            }
        }
        #region Function Area All the user Defined Function Should be written here or exists here 
        #region fill  Employee In Left Listview 
        #endregion
        #region Get Work Of Selected Employee
        public void getWorkofSelectedEmployee()
        {
            lv_WorkersWork.Items.Clear();
            lv_AssignedWork.Items.Clear();
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                       lv_WorkersWork.Items.Add(dr["job_id"].ToString());
                       lv_WorkersWork.Items[lv_WorkersWork.Items.Count - 1].SubItems.Add(dr["subject"].ToString());
                       lv_WorkersWork.Items[lv_WorkersWork.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["job_date"]).ToString("dd-MMM-yyyy"));
                       lv_WorkersWork.Items[lv_WorkersWork.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["target_date"]).ToString("dd-MMM-yyyy"));
                       if(dr["finishdate"].ToString()!="")
                       lv_WorkersWork.Items[lv_WorkersWork.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["finishdate"]).ToString("dd-MMM-yyyy"));
                       else
                       lv_WorkersWork.Items[lv_WorkersWork.Items.Count - 1].SubItems.Add("not finished");
                      //TWO GRID FILLING ALONG WITH
                       lv_AssignedWork.Items.Add(dr["job_id"].ToString());
                       lv_AssignedWork.Items[lv_AssignedWork.Items.Count - 1].SubItems.Add(dr["subject"].ToString());
                       lv_AssignedWork.Items[lv_AssignedWork.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["job_date"]).ToString("dd-MMM-yyyy"));
                       lv_AssignedWork.Items[lv_AssignedWork.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["target_date"]).ToString("dd-MMM-yyyy"));
                       if (dr["finishdate"].ToString() != "")
                           lv_AssignedWork.Items[lv_AssignedWork.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["finishdate"]).ToString("dd-MMM-yyyy"));
                       else
                           lv_AssignedWork.Items[lv_AssignedWork.Items.Count - 1].SubItems.Add("not finished");
                    }
                    lv_WorkersWork.Focus();
                    lv_WorkersWork.Items[0].Selected = true;
                    lv_WorkersWork.Items[0].BackColor=Color.Red;
                    lv_WorkersWork.Items[0].ForeColor=Color.White;
               
                    pJobId = lv_WorkersWork.Items[0].Text;
                }
            }
        }
        #endregion
        #endregion
        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            if (chkUrgent.Checked)
                priority = "High";
            else
                priority = "Low";
                pAction= "CreateNewJob";
                pSubject = txtSubject.Text;
                Description = txtDescription.Text;
                if (!backgroundWorker1.IsBusy)
                {
                    progressBar1.Visible = true;  
                    backgroundWorker1.RunWorkerAsync();
                }
                btnSaveJob.Enabled = false;
        }
        private void lv_WorkersWork_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            lv_WorkersWork.Items[pItemIndex].BackColor = Color.LightBlue;
            lv_WorkersWork.Items[e.ItemIndex].ForeColor = Color.White;
            pItemIndex = e.ItemIndex;
            pJobId = lv_WorkersWork.Items[e.ItemIndex].Text;
            DataRow[] dr = pds.Tables[0].Select("job_id='" + pJobId + "'");
            txtSubject.Text = dr[0]["subject"].ToString();
            txtDescription.Text= dr[0]["Description"].ToString();

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (lv_AssignedWork.Items.Count > 0)
                {
                    lv_AssignedWork.Focus();
                    lv_AssignedWork.Items[0].Selected = true;
                    pItemIndex =0;
                }
            }
        }
        private void lv_AssignedWork_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pAssignedJob = lv_AssignedWork.Items[e.ItemIndex].Text;
            lv_AssignedWork.Items[pItemIndex].BackColor = Color.LightBlue;
            lv_AssignedWork.Items[pItemIndex].ForeColor = Color.Maroon;
            lv_AssignedWork.Items[e.ItemIndex].BackColor = Color.Red;
            lv_AssignedWork.Items[e.ItemIndex].ForeColor = Color.White;
            pItemIndex = e.ItemIndex;
       }
        private void btnOpenDoc_Click(object sender, EventArgs e)
        {
            ofdg.ShowDialog();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (ofdg.SafeFileName.Length > 0)
            {
                if(!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                    pAction = "UploadFile";
                    progressBar1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please Select File To Upload ");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           cws.QueeryExecute("update job_process_info set Development='" + txtDescription.Text + "' where job_id='" + jobId + "'", "eManagement");
        }
        private void lv_AssignedWork_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
           cws.QueeryExecute("update job_process_info set Development='" + txtDescription.Text + "' where job_id='" + jobId + "'", "eManagement");
        }
        private void btnupoadmod_Click(object sender, EventArgs e)
        {
            if (ofdg.SafeFileName.Length > 0)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    Coment=txtDescription.Text;
                    backgroundWorker1.RunWorkerAsync();
                    pAction = "UploadFile";
                    progressBar1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please Select File To Upload ");
            }
        }
        private void btnimport_Click(object sender, EventArgs e)
        {
            ofdg.ShowDialog();
        }
        private void Tab_Old_Click(object sender, EventArgs e)
        {

        }
        private void NewAssignment_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                txtDescription.Text = "";
                txtSubject.Text = "";
                txtSubject.Focus();
                btnSaveJob.Enabled = true;
             }
        }
        private void lv_WorkersWork_KeyDown(object sender, KeyEventArgs e)
        {
            string qry = " delete from  Job_Process_Info where Job_Id='" + pJobId + "' ; delete from  job_Assignment where Job_Id='" + pJobId + "' ";
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you want to delete  this Job (Y/N) ?", "Job Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   cws.QueeryExecute(qry, "eManagement");
                    MessageBox.Show("Job is deleted ");
                    pAction = "WorkListOfEmployee";
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                        progressBar1.Visible = true;
                    }
                }
            }
         
        }
        private void lv_AssignedWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
                pAction = "FillJobDetail";
                progressBar1.Visible = true;
            }
        }
        void FillJobDetail()
        {
            if (_ds.Tables.Count > 0)
            {
                txtDetail.Text = _ds.Tables[0].Rows[0][1].ToString();
                if (_ds.Tables[1].Rows.Count > 0)
                {
                    int y = 3;
                    panel1.Controls.Clear();
                    foreach (DataRow dr in _ds.Tables[1].Rows)
                    {
                        RepeatingJob rpc = new RepeatingJob();
                        rpc.Development=dr["Development"].ToString();
                        rpc.UpdDate = dr["cr_date"].ToString();
                        rpc.Location = new System.Drawing.Point(8, y);
                        panel1.Controls.Add(rpc);
                        y = y + 110;
                    }
                }
            }
        }
       
    }
}
