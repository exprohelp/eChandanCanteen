using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eIM.Inventory_WebServices;
namespace eIM
{
    public partial class DressStockMgt : Form
    {
        Inventory_WebServicesSoapClient ws = new Inventory_WebServicesSoapClient();
        public DressStockMgt()
        {
            InitializeComponent();
        }
        private void DressStockMgt_Load(object sender, EventArgs e)
        {
            cbxdresstype.SelectedIndex = 0;            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            try
            {
                ds = ws.GetQueryResult("select emp_name,emp_code from empdetail where emp_name like '" + txtsearchemp.Text + "%'  order by emp_name ", "ExHrd");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (ds.Tables.Count > 0)
            {
                cbxEmp.Items.Clear();
                cbxEmp.Items.AddRange(Config.FillCombo(ds.Tables[0]));
                cbxEmp.SelectedIndexChanged -= new EventHandler(this.cbxEmp_SelectedIndexChanged);
                cbxEmp.SelectedIndex = 0;
                cbxEmp.SelectedIndexChanged += new EventHandler(this.cbxEmp_SelectedIndexChanged);
         
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if((object)cbxEmp.SelectedItem != null)
            {
                string emp_code = ((ExproComboBox)cbxEmp.SelectedItem).Value;
                if (emp_code != "Select")
                {
                    try
                    {
                        if (cbxdressize.Text!="Select")
                        {
                            string MSG = ws.InsertDressInfo(emp_code,cbxdresstype.Text,cbxdressize.Text,0,"DRESSSIZE","result");
                            if (MSG == "Successfully saved") { fillDressSize(emp_code); } else { lblMessage.Text = MSG;}
                        }
                        else
                        {
                            MessageBox.Show("Not Valid Dress Size");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else
            {MessageBox.Show("Please Select employee");}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string emp_code = ((ExproComboBox)cbxEmp.SelectedItem).Value;
            if (emp_code != "Select")
            {
                try
                {
                    string MSG = ws.InsertDressInfo(emp_code, cbxdresstype.Text, cbxdressize.Text, Convert.ToInt32(txtNOS.Text), "DRESSINFO", "result");
                    lblMessage.Text = MSG;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void cbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp_code=((ExproComboBox)cbxEmp.SelectedItem).Value;
            fillDressSize(emp_code);
        }
        public void fillDressSize(string emp_code)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ws.GetQueryResult("select dr_size,dr_size sz from dressSize where emp_code='" + emp_code + "' ", "ExHrd");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (ds.Tables.Count > 0)
            {
                cbxdressize.Items.Clear();
                cbxdressize.Items.AddRange(Config.FillCombo(ds.Tables[0]));
                cbxdressize.SelectedIndex = 0;
            }
            
        }

    }
}
