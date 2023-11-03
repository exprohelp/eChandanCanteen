using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eChandanCanteen.Inventory_WebServices;
namespace eChandanCanteen
{
    public partial class AuditDispatch : Form
    {
        Inventory_WebServicesSoapClient ws = new Inventory_WebServicesSoapClient();
        public AuditDispatch()
        {
            InitializeComponent();
        }
        private void AuditDispatch_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = ws.fillUnit();
                cbxUnit.DisplayMember = "unit_name";
                cbxUnit.ValueMember = "unit_code";
                cbxUnit.DataSource = ds.Tables[0];
                cbxUnit.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                string qry=@"exec pGetDispatchInfO '"+cbxUnit.SelectedValue.ToString()+ "'";
                try {ds=ws.GetQueryResult(qry, "eIM_Data");
                FillData(ds);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void FillData(DataSet _ds)
        {
            if(_ds.Tables.Count > 0)
            {
                int dipatch_qty = 0;
                int intran_qty = 0;
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    m_list.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                         m_list.Items.Add(dr["item_name"].ToString());
                         m_list.Items[m_list.Items.Count - 1].SubItems.Add(Convert.ToInt32(dr["t_qty"]).ToString());
                         m_list.Items[m_list.Items.Count - 1].SubItems.Add(Convert.ToInt32(dr["INTR_QTY"]).ToString());
                         dipatch_qty +=Convert.ToInt32(dr["t_qty"]);
                         intran_qty  += Convert.ToInt32(dr["INTR_QTY"]);
                    }
                    m_list.Items.Add("Total").ForeColor = Color.Red;
                    m_list.Items[m_list.Items.Count - 1].SubItems.Add(dipatch_qty.ToString());
                    m_list.Items[m_list.Items.Count - 1].SubItems.Add(intran_qty.ToString());
                }
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            m_list.Title = "Product Name : " + cbxUnit.Text + "";
            m_list.FitToPage = true;
            m_list.Print();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
