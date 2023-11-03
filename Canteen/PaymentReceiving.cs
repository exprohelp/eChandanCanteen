using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eChandanCanteen.Canteen
{
    public partial class PaymentReceiving : Telerik.WinControls.UI.RadForm
    {
        string _ledgerCode = string.Empty;
        public PaymentReceiving()
        {
            InitializeComponent();
        }
        private void PaymentReceiving_Load(object sender, EventArgs e)
        {
            rdp_from.Value = System.DateTime.Now;
            rdp_to.Value = System.DateTime.Now;
            FillParty();
        }

        private void FillParty()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + rdp_from.Value.ToString("yyyy/MM/dd") + "','" + rdp_to.Value.ToString("yyyy/MM/dd") + "','','CreditorList' ";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgDOCTOR.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
     
                string _paymode="Cash";
                if(rbSwapCard.Checked)
               _paymode="Swipe Card";

                if (_ledgerCode.Length<3)
                {
                    MessageBox.Show("Please select employee/doctor name");
                    return;
                }

                if (txtAmt.Text.Trim()=="")
                {
                    MessageBox.Show("Please fill amount");
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                _result=GlobalUsage.canteenProxy.Receive_Payment(GlobalUsage.gUnit_Id, _ledgerCode,lbl_empname.Text, Convert.ToDecimal(txtAmt.Text), txtPayRemark.Text, _paymode, txttranId.Text, GlobalUsage.gLogin_id, "", "AdvancePayment");
                MessageBox.Show(_result);
                if(_result.Contains("Success"))
                {
                  _ledgerCode = string.Empty;
                   PaymentList();
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void PaymentList()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteenReport_Queries '" + GlobalUsage.gUnit_Id + "','" + rdp_from.Value.ToString("yyyy/MM/dd") + "','" + rdp_to.Value.ToString("yyyy/MM/dd") + "','','PaymentList' ";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgpayList.DataSource=ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PaymentList();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportCredit_Doctor obj = new ImportCredit_Doctor();
            obj.SearchUpdated += new SearchUpdateEventHandler(RefreshEmployee);
            obj.Owner = this;
            obj.Show();
        }
        private void RefreshEmployee(object sender, SearchUpdatedEventArgs e)
        {
            FillParty();
        }

        private void dgDOCTOR_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           _ledgerCode = dgDOCTOR.CurrentRow.Cells["emp_code"].Value.ToString();
            lbl_empname.Text = dgDOCTOR.CurrentRow.Cells["emp_name"].Value.ToString();
        }
    }
}
