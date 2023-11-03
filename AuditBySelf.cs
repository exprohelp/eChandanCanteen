using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace eChandanCanteen
{
    public partial class AuditBySelf : Form
    {
        private System.Windows.Forms.Button m_btnPrintPreview;
        private System.Windows.Forms.Button m_btnPrint;
        Inventory_WebServices.Inventory_WebServicesSoapClient cws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        DataSet ds = new DataSet();
        public AuditBySelf()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.m_btnPrintPreview = new System.Windows.Forms.Button();
            this.m_btnPrint = new System.Windows.Forms.Button();
            this.m_list = new eChandanCanteen.PrintableListView();
            this.item_id = new System.Windows.Forms.ColumnHeader();
            this.ietm_name = new System.Windows.Forms.ColumnHeader();
            this.ptype = new System.Windows.Forms.ColumnHeader();
            this.pQty = new System.Windows.Forms.ColumnHeader();
            this.op_stock = new System.Windows.Forms.ColumnHeader();
            this.RetQty = new System.Windows.Forms.ColumnHeader();
            this.PurchQty = new System.Windows.Forms.ColumnHeader();
            this.dispqty = new System.Windows.Forms.ColumnHeader();
            this.clQty = new System.Windows.Forms.ColumnHeader();
            this.curStock = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // m_btnPrintPreview
            // 
            this.m_btnPrintPreview.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnPrintPreview.Location = new System.Drawing.Point(2, 3);
            this.m_btnPrintPreview.Name = "m_btnPrintPreview";
            this.m_btnPrintPreview.Size = new System.Drawing.Size(74, 29);
            this.m_btnPrintPreview.TabIndex = 1;
            this.m_btnPrintPreview.Text = "RETRIVE";
            this.m_btnPrintPreview.Click += new System.EventHandler(this.ButtonPrintPreview_OnClick);
            // 
            // m_btnPrint
            // 
            this.m_btnPrint.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnPrint.Image = global::eChandanCanteen.Properties.Resources.print;
            this.m_btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnPrint.Location = new System.Drawing.Point(684, 3);
            this.m_btnPrint.Name = "m_btnPrint";
            this.m_btnPrint.Size = new System.Drawing.Size(73, 28);
            this.m_btnPrint.TabIndex = 2;
            this.m_btnPrint.Text = "PRINT";
            this.m_btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnPrint.Click += new System.EventHandler(this.ButtonPrint_OnClick);
            // 
            // m_list
            // 
            this.m_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.ietm_name,
            this.ptype,
            this.pQty,
            this.op_stock,
            this.RetQty,
            this.PurchQty,
            this.dispqty,
            this.clQty,
            this.curStock});
            this.m_list.FitToPage = false;
            this.m_list.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_list.FullRowSelect = true;
            this.m_list.GridLines = true;
            this.m_list.Location = new System.Drawing.Point(2, 36);
            this.m_list.Name = "m_list";
            this.m_list.Size = new System.Drawing.Size(761, 320);
            this.m_list.TabIndex = 3;
            this.m_list.Title = "";
            this.m_list.UseCompatibleStateImageBehavior = false;
            this.m_list.View = System.Windows.Forms.View.Details;
            // 
            // item_id
            // 
            this.item_id.Text = "item_id";
            this.item_id.Width = 0;
            // 
            // ietm_name
            // 
            this.ietm_name.Text = "Name of Item";
            this.ietm_name.Width = 300;
            // 
            // ptype
            // 
            this.ptype.Text = "P.Type";
            // 
            // pQty
            // 
            this.pQty.Text = "P.Qty";
            this.pQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // op_stock
            // 
            this.op_stock.Text = "Op.Stk";
            this.op_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RetQty
            // 
            this.RetQty.Text = "Ret.Qty";
            this.RetQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PurchQty
            // 
            this.PurchQty.Text = "Pr.Qty";
            this.PurchQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dispqty
            // 
            this.dispqty.Text = "DispQty";
            this.dispqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clQty
            // 
            this.clQty.Text = "CL.Qty";
            this.clQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // curStock
            // 
            this.curStock.Text = "CurStock";
            this.curStock.Width = 0;
            // 
            // AuditBySelf
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(764, 359);
            this.Controls.Add(this.m_list);
            this.Controls.Add(this.m_btnPrintPreview);
            this.Controls.Add(this.m_btnPrint);
            this.MaximizeBox = false;
            this.Name = "AuditBySelf";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Audit Today\'s Transacted Items";
            this.Load += new System.EventHandler(this.TestPrintListView_Load_1);
            this.ResumeLayout(false);

        }
        private void TestPrintListView_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void FillList()
        {
            DataSet ds = new DataSet();
            try
            {
                string qry = "exec pAuditBySelf";
                ds = cws.GetQueryResult(qry, "eIM_Data");
                FillList(this.m_list, ds.Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void FillList(ListView list, DataTable table)
        {
            m_list.SuspendLayout();
            // Clear list
            m_list.Items.Clear();
            // Rows
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row[0].ToString();

                for (int i = 1; i < table.Columns.Count; i++)
                {
                    if (i == 4 || i == 6 || i == 5)
                        item.SubItems.Add(Convert.ToDecimal(row[i].ToString()).ToString("###.##"));
                    else
                        item.SubItems.Add(row[i].ToString());
                    if (Convert.ToDecimal(row[8].ToString()) != Convert.ToDecimal(row[9].ToString()))
                        item.BackColor = Color.Red;
                }
                m_list.Items.Add(item);
            }
            m_list.ResumeLayout();
        }        
        private bool IsNumeric(Type dataType)
        {
            switch (Type.GetTypeCode(dataType))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
                default:
                    return false;
            }
        }
        private void ButtonPrintPreview_OnClick(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FillList();
            Cursor.Current = Cursors.Default;
        }
        private void ButtonPrint_OnClick(object sender, System.EventArgs e)
        {
            m_list.Title = "Test Printable List View";
            m_list.Print();
        }

        private void TestPrintListView_Load_1(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 120);
        }  
    }
}
