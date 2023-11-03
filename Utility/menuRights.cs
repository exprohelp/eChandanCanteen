using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eChandanCanteen.utility
{
    public partial class menuRights : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _productName = string.Empty;
        public menuRights(string productName)
        {
            _productName = productName;
            this.Text = "Assign Menu Rights For " + _productName;
            InitializeComponent();
        }

        private void menuRights_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
               _ds = GlobalUsage.canteenProxy.GetQueryResult("execute pMenu_RightsQueries '" + _productName + "','n/a','EN','N/A','N/A',0,'" + _productName + ":LoginList'", "ChandanCanteen");
                rgv_employee.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void btn_FillMenu_Click(object sender, EventArgs e)
        {


        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pMenu_RightsQueries '" + _productName + "','" + e.Row.Cells[0].Value.ToString() + "','EN','N/A','N/A',0,'WithAssignMenu'";
               _ds = GlobalUsage.canteenProxy.GetQueryResult(qry,"ChandanCanteen");
                rgv_info.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Allow"].Value != null && e.RowElement.RowInfo.Cells["Allow"].Value.ToString() == "Y")
            {
                e.RowElement.ForeColor = Color.Green;
            }
            else
            {
                e.RowElement.ForeColor = Color.Black;
            }
        }

        private void rgv_info_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "A")
                {
                    // ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    if (e.CellElement.RowInfo.Cells["allow"].Value.ToString() == "Y")
                    {
                        //((GridCommandCellElement)e.CellElement).CommandButton.Image = Resources.attachment;
                        //((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                        ((GridCommandCellElement)e.CellElement).CommandButton.Text = "Disable";
                    }
                    else
                    {
                        ((GridCommandCellElement)e.CellElement).CommandButton.Text = "Enable";
                    }

                }
            }
        }

        private void rgv_info_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GridCommandCellElement gCommand = (sender as GridCommandCellElement);
                string logic = gCommand.CommandButton.Text;
                if (logic == "Enable")
                {
                    string qry = "Insert_Modify_Menu_Rights '"+ _productName + "','"+ rgv_info.CurrentRow.Cells["element_name"].Value.ToString() + "','"+ rgv_employee.CurrentRow.Cells[0].Value.ToString() + "','Y','"+ GlobalUsage.gLogin_id + "','' ";
                   _result = GlobalUsage.canteenProxy.QueryExecute(qry,"ChandanCanteen");
                    rgv_info.CurrentRow.Cells["allow"].Value = "Y";
                }
                else
                {
                    string qry = "Insert_Modify_Menu_Rights '" + _productName + "','" + rgv_info.CurrentRow.Cells["element_name"].Value.ToString() + "','" + rgv_employee.CurrentRow.Cells[0].Value.ToString() + "','N','" + GlobalUsage.gLogin_id + "','' ";
                    _result = GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen");
                    rgv_info.CurrentRow.Cells["allow"].Value = "N";

                }
                rgv_info.Refresh();
            }

            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_mark_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCreateAppLogin '" + _productName + "','-','" + rgv_employee.CurrentRow.Cells[0].Value.ToString() + "','Admin','" + GlobalUsage.gLogin_id + "','N/A'";
                GlobalUsage.canteenProxy.QueryExecute(qry, "exhrd");
                string opt = cmb_options.Text.Substring(0, 1);
                GlobalUsage.canteenProxy.QueryExecute("delete from AppMenu_rights where app_name='" + _productName + "' and emp_code='" + rgv_employee.CurrentRow.Cells[0].Value.ToString() + "'", "ChandanCanteen");
                foreach(GridViewRowInfo g in rgv_info.Rows)
                {
                    if(g.Cells["options"].Value.ToString().Contains(opt))
                    {
                        qry = "Insert_Modify_Menu_Rights '" + _productName + "','" + g.Cells["element_name"].Value.ToString() + "','" + rgv_employee.CurrentRow.Cells[0].Value.ToString() + "','Y','" + GlobalUsage.gLogin_id + "','' ";
                       _result = GlobalUsage.canteenProxy.QueryExecute(qry, "ChandanCanteen");
                    }
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult("execute pMenu_RightsQueries '" + _productName + "','empcode','EN','" + txtLookFor.Text + "','N/A',0,'SearchStaff'", "ChandanCanteen");
                rgv_employee.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void txtLookFor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
