using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eChandanCanteen
{
    public partial class AuditStock : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        public AuditStock()
        {
            InitializeComponent();
        }

        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds =GlobalUsage.canteenProxy.ReconcileProduct2(out _result, GlobalUsage.gUnit_Id, "AllByItem","","");
                dgProduct.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void AuditStock_Load(object sender, EventArgs e)
        {
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
            GlobalUsage.gUnit_Id = "CHCANT";
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.canteenProxy.ReconcileProduct2(out _result, GlobalUsage.gUnit_Id, "GET_OPEN_AUDIT", "", "");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtAuditNo.Text = ds.Tables[0].Rows[0]["audit_no"].ToString();
                    btnAudit.Enabled = true;
                }
                else
                {
                    btnAudit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dgProduct_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (Convert.ToDecimal(e.RowElement.RowInfo.Cells["SysBal"].Value) != Convert.ToDecimal(e.RowElement.RowInfo.Cells["InStock"].Value))
            {
                e.RowElement.ForeColor = Color.Red;
                e.RowElement.RowInfo.Cells["flag"].Value="N";
            }
            else
            {
                e.RowElement.ForeColor = Color.Green;
                e.RowElement.RowInfo.Cells["flag"].Value="Y";
            }
        }

        private void dgProduct_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.canteenProxy.ReconcileProduct2(out _result, GlobalUsage.gUnit_Id, "AllKeyofItem", dgProduct.CurrentRow.Cells["item_id"].Value.ToString(),txtAuditNo.Text);
                dgKeyInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (Convert.ToDecimal(e.RowElement.RowInfo.Cells["SysBal"].Value) != Convert.ToDecimal(e.RowElement.RowInfo.Cells["InStock"].Value))
            {
                e.RowElement.ForeColor = Color.Red;
            }
            else
            {
                e.RowElement.ForeColor = Color.Green;
            }
        }
        private void btnAudit_Click(object sender, EventArgs e)
        {
            try
            {
                string _audit_no = string.Empty;
                Cursor.Current = Cursors.WaitCursor;
                if (rbExtra.Checked)
                    _result = GlobalUsage.canteenProxy.Insert_Modify_Audit_master(GlobalUsage.gUnit_Id,"Extra", txtAuditNo.Text,txtMasterKey.Text,Convert.ToInt32(txtQty.Text),GlobalUsage.gLogin_id, "InsertUpdate");
                else
                    _result = GlobalUsage.canteenProxy.Insert_Modify_Audit_master(GlobalUsage.gUnit_Id,"Damage",txtAuditNo.Text,txtMasterKey.Text,Convert.ToInt32(txtQty.Text), GlobalUsage.gLogin_id, "InsertUpdate");
                MessageBox.Show(_result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void dgKeyInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            txtMasterKey.Text=dgKeyInfo.CurrentRow.Cells["master_key_id"].Value.ToString();
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if(radPageView1.SelectedPage.Text == "Current Audit Detail")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataSet ds = GlobalUsage.canteenProxy.ReconcileProduct2(out _result, GlobalUsage.gUnit_Id, "AuditedProduct",txtAuditNo.Text, "");
                    dgAuditedList.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnDispatchDamage_Click(object sender, EventArgs e)
        {
            
                try
                {
                   Cursor.Current = Cursors.WaitCursor;
                   _result = GlobalUsage.canteenProxy.Auto_DispatchForDamageOrExtra(txtAuditNo.Text, GlobalUsage.gLogin_id, GlobalUsage.gUnit_Id, "Damage", "Damage");
                   MessageBox.Show(_result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Cursor.Current = Cursors.Default;
           
        }

        private void btnDispatchExtra_Click(object sender, EventArgs e)
        {
              try
                {
                    Cursor.Current = Cursors.WaitCursor;
                   _result = GlobalUsage.canteenProxy.Auto_DispatchForDamageOrExtra(txtAuditNo.Text, GlobalUsage.gLogin_id, GlobalUsage.gUnit_Id,"Extra","Extra");
                    MessageBox.Show(_result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Cursor.Current = Cursors.Default;
          
        }

    }
}
