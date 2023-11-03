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
    public partial class ProductIssue : Telerik.WinControls.UI.RadForm
    {
        public ProductIssue()
        {
            InitializeComponent();
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            ProductList("ProductList", "ALL");
        }
        private void ProductList(string logic,string prm1)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','" + logic + "','" + prm1 + "','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgProduct.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void rbtnRawRetail_CheckedChanged(object sender, EventArgs e)
        {
            ProductList("RawAndRetailList", "ALL");
        }

        private void rbtnCooked_CheckedChanged(object sender, EventArgs e)
        {
            ProductList("ProductList", "CookedProduct");
        }

        private void ProductIssue_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 60); 
        }

        private void MasterTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','StocksInfo','"+dgProduct.CurrentRow.Cells["item_id"].Value.ToString()+"','N/A','N/A'";
                    DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                    dgProductDetail.DataSource = ds.Tables[0];
                    dgProductDetail.Focus();
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
       
    }
}
