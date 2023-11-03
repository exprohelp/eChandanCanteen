using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Linq;
using Microsoft.Reporting.WinForms;

namespace eChandanCanteen.Canteen
{
    public partial class ProductSale : Telerik.WinControls.UI.RadForm
    {
        HubConnection connection;
        static IHubProxy _hub;
        Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
        Microsoft.Reporting.WinForms.LocalReport report_KOT = new Microsoft.Reporting.WinForms.LocalReport();
        string _RoomServiceLogic = "No";
        string _custname = string.Empty;
        string _sale_no = string.Empty;
        string _partyid = string.Empty;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Label lblPack;
        private new System.Windows.Forms.Label lblRate;
        DataSet dsProductList = new DataSet();
        string _CreditAllowed = "N";
        string _empcode = string.Empty;
        string FreeToStaffProduct = "N";
        public ProductSale()
        {
            InitializeComponent();
        }
        private void ProductList(string logic,string prm1)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','" + logic + "','" + prm1 + "','N/A','N/A'";
                dsProductList = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                dgProduct.DataSource = dsProductList.Tables[0];
                ProductListByTemplate();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void ProductListByTemplate()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int xloc = 7; int yloc = 7;
                int count = 0;
                var prodlist = dsProductList.Tables[0].AsEnumerable().Where(s => s.Field<string>("fevroite_flag") == "N").OrderBy(y=>y.Field<string>("item_name"));
                MasterPanel.Controls.Clear();
                foreach (var dr in prodlist)
                {
                    lblProduct = new System.Windows.Forms.Label();
                    lblRate = new System.Windows.Forms.Label();
                    pnlItem = new System.Windows.Forms.Panel();
                    lblPack = new System.Windows.Forms.Label();
                    // 
                    // pnlItem
                    // 
                    this.pnlItem.BackColor = System.Drawing.Color.Silver;
                    this.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.pnlItem.Controls.Add(this.lblPack);
                    this.pnlItem.Controls.Add(this.lblRate);
                    this.pnlItem.Controls.Add(this.lblProduct);
                    this.pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                    this.pnlItem.Name = "pnlItem";
                    pnlItem.Tag = dr.Field<string>("item_id").ToString();
                    this.pnlItem.Size = new System.Drawing.Size(185, 80);
                    this.pnlItem.TabIndex = 5;
                    pnlItem.Click += new EventHandler(PanelClick);
                    pnlItem.MouseEnter += new EventHandler(Panel_MouseEnter);
                    pnlItem.MouseLeave += new EventHandler(Panel_MouseLeave);
                    // 
                    // lblProduct
                    // 
                    this.lblProduct.AutoSize = true;
                    this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                    this.lblProduct.Location = new System.Drawing.Point(9, 5);
                    this.lblProduct.Name = "lblprod" + dr.Field<string>("item_id").ToString();
                    this.lblProduct.Tag = dr.Field<string>("item_id").ToString();
                    this.lblProduct.Size = new System.Drawing.Size(67, 15);
                    this.lblProduct.TabIndex = 0;
                    this.lblProduct.Text = dr.Field<string>("item_name").ToString();
                    pnlItem.Controls.Add(lblProduct);

                    // 
                    // lblRate
                    // 
                    this.lblRate.AutoSize = true;
                    this.lblRate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                    this.lblRate.Location = new System.Drawing.Point(97, 47);
                    this.lblRate.Name = "lblrate" + dr.Field<decimal>("rate").ToString();
                    this.lblRate.Size = new System.Drawing.Size(75, 25);
                    this.lblRate.TabIndex = 1;
                    this.lblRate.Text = Convert.ToInt32(dr.Field<decimal>("rate")).ToString("##") + " Rs.";
                    pnlItem.Controls.Add(this.lblRate);
                 
                    // 
                    // lblPack
                    // 
                    this.lblPack.AutoSize = true;
                    this.lblPack.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
                    this.lblPack.Location = new System.Drawing.Point(9, 28);
                    this.lblPack.Name = "lblPack";
                    this.lblPack.Size = new System.Drawing.Size(44, 12);
                    this.lblPack.TabIndex = 2;
                    this.lblPack.Text = dr.Field<string>("pack_type").ToString();
                    pnlItem.Controls.Add(this.lblPack);
                    xloc = xloc + 193;
                    count++;
                    if (count % 3 == 0)
                    { yloc = yloc + 90; xloc = 7; }

                    MasterPanel.Controls.Add(pnlItem);

                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btnTokenList_Click(object sender, EventArgs e)
        {
            TokenListPanel();
        }
        private void TokenListPanel()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','TokenList','-','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                int xloc = 7; int yloc = 7;
                int count = 0;
                pnlToken.Controls.Clear();
                int tokenno = 1;
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    tokenno =Convert.ToInt16(dr["tokenNo"]);
                    lblProduct = new System.Windows.Forms.Label();
                    pnlItem = new System.Windows.Forms.Panel();
                    // 
                    // pnlItem
                    // 
                    if(dr["TokenStatus"].ToString()=="Free")
                    pnlItem.BackColor = System.Drawing.Color.Silver;

                    if (dr["TokenStatus"].ToString() == "Booked")
                    {
                        pnlItem.Enabled = false;
                        pnlItem.BackColor = System.Drawing.Color.CornflowerBlue;
                    }
                    if (dr["TokenStatus"].ToString() == "Cooking")
                    {
                        pnlItem.Enabled = false;
                        pnlItem.BackColor = System.Drawing.Color.Coral;
                    }
                    if (dr["TokenStatus"].ToString() == "Ready")
                    {
                        pnlItem.Enabled = false;
                        pnlItem.BackColor = System.Drawing.Color.LightGreen;
                    }
                    pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pnlItem.Controls.Add(this.lblProduct);
                    pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                    pnlItem.Name = "pnlItem";
                    pnlItem.Tag = tokenno.ToString();
                    pnlItem.Size = new System.Drawing.Size(58, 55);
                    pnlItem.TabIndex = 5;
                    pnlItem.Click += new EventHandler(TokenClick);
                    pnlItem.MouseEnter += new EventHandler(Panel_MouseEnter);
                    pnlItem.MouseLeave += new EventHandler(Panel_MouseLeave);
                    // 
                    // lblProduct
                    // 
                    lblProduct.AutoSize = true;
                    lblProduct.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
                    lblProduct.Location = new System.Drawing.Point(8,12);
                    lblProduct.Name = "lblprod" + tokenno.ToString();
                    lblProduct.Tag = tokenno.ToString();
                    lblProduct.Size = new System.Drawing.Size(45, 30);
                    lblProduct.TabIndex = 0;
                    lblProduct.Click += new EventHandler(TokenClick);
                    lblProduct.Text = tokenno.ToString();
                    pnlItem.Controls.Add(lblProduct);
             
                    xloc = xloc + 65;
                    count++;
                    if (count % 3 == 0)
                    { yloc = yloc + 63; xloc = 7; }

                   pnlToken.Controls.Add(pnlItem);

                }
             
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void TokenClick(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Panel p = sender as System.Windows.Forms.Panel;
                txtToken.Text = p.Tag.ToString();
            }
            catch { }
            try
            {
                System.Windows.Forms.Label p = sender as System.Windows.Forms.Label;
                txtToken.Text = p.Parent.Tag.ToString();
            }
            catch { }
        }
        private void PanelClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel p = sender as System.Windows.Forms.Panel;
           _itemid= p.Tag.ToString();
           p.BackColor = Color.SandyBrown;

           foreach (var ctrl in MasterPanel.Controls)
           {
               if(((System.Windows.Forms.Panel)ctrl).Tag.ToString()!=p.Tag.ToString())
               ((System.Windows.Forms.Panel)ctrl).BackColor = System.Drawing.Color.Silver;
           }
           ProductSelection(_itemid);
        }
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel p = sender as System.Windows.Forms.Panel;
            p.BackColor = Color.LightPink;
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel p = sender as System.Windows.Forms.Panel;
            p.BackColor = System.Drawing.Color.Silver; ;
        }
        private void ProductListByTemplateSearch(string searchkey)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int xloc = 7; int yloc = 7;
                int count = 0;
                var prodlist = dsProductList.Tables[0].AsEnumerable().Where(s => s.Field<string>("item_name").Contains(searchkey)).OrderBy(y=>y.Field<string>("item_name"));
                MasterPanel.Controls.Clear();
                foreach (var dr in prodlist)
                {
                    lblProduct = new System.Windows.Forms.Label();
                    lblRate = new System.Windows.Forms.Label();
                    pnlItem = new System.Windows.Forms.Panel();
                    lblPack = new System.Windows.Forms.Label();
                    // 
                    // pnlItem
                    // 
                    this.pnlItem.BackColor = System.Drawing.Color.Silver;
                    this.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.pnlItem.Controls.Add(this.lblPack);
                    this.pnlItem.Controls.Add(this.lblRate);
                    this.pnlItem.Controls.Add(this.lblProduct);
                    this.pnlItem.Location = new System.Drawing.Point(xloc, yloc);
                    this.pnlItem.Name = "pnlItem";
                    pnlItem.Tag = dr.Field<string>("item_id").ToString();
                    this.pnlItem.Size = new System.Drawing.Size(185, 80);
                    this.pnlItem.TabIndex = 5;
                    pnlItem.Click += new EventHandler(PanelClick);
                    pnlItem.MouseEnter += new EventHandler(Panel_MouseEnter);
                    pnlItem.MouseLeave += new EventHandler(Panel_MouseLeave);
                    // 
                    // lblProduct
                    // 
                    this.lblProduct.AutoSize = true;
                    this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                    this.lblProduct.Location = new System.Drawing.Point(9, 5);
                    this.lblProduct.Name = "lblprod" + dr.Field<string>("item_id").ToString();
                    this.lblProduct.Tag = dr.Field<string>("item_id").ToString();
                    this.lblProduct.Size = new System.Drawing.Size(67, 15);
                    this.lblProduct.TabIndex = 0;
                    this.lblProduct.Text = dr.Field<string>("item_name").ToString();
                    pnlItem.Controls.Add(lblProduct);

                    // 
                    // lblRate
                    // 
                    this.lblRate.AutoSize = true;
                    this.lblRate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                    this.lblRate.Location = new System.Drawing.Point(97, 47);
                    this.lblRate.Name = "lblrate" + dr.Field<decimal>("rate").ToString();
                    this.lblRate.Size = new System.Drawing.Size(75, 25);
                    this.lblRate.TabIndex = 1;
                    this.lblRate.Text = Convert.ToInt32(dr.Field<decimal>("rate")).ToString("##") + " Rs.";
                    pnlItem.Controls.Add(this.lblRate);

                    // 
                    // lblPack
                    // 
                    this.lblPack.AutoSize = true;
                    this.lblPack.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
                    this.lblPack.Location = new System.Drawing.Point(9, 28);
                    this.lblPack.Name = "lblPack";
                    this.lblPack.Size = new System.Drawing.Size(44, 12);
                    this.lblPack.TabIndex = 2;
                    this.lblPack.Text = dr.Field<string>("pack_type").ToString();
                    pnlItem.Controls.Add(this.lblPack);
                    xloc = xloc + 193;
                    count++;
                    if (count % 3 == 0)
                    { yloc = yloc + 90; xloc = 7; }

                    MasterPanel.Controls.Add(pnlItem);

                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void ProductIssue_Load(object sender, EventArgs e)
        {
            GlobalUsage.canteenProxy = new CanteenProxy.ChandanCanteenServiceClient();
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 60);
            GlobalUsage.gUnit_Id = "CHCANT";
            ProductList("ProductList", "ALL");
            TokenListPanel();
            ConnectToSignalRServer();
        }
        decimal _disc_perc = 0;
        string  _prodType = string.Empty;
        string  _masterkey = string.Empty;
        string  _item_name = string.Empty;
        string  _itemid = string.Empty;
        string _IsDiscountable = "1";
        private void MasterTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductSelection(dgProduct.CurrentRow.Cells["item_id"].Value.ToString());
            }
        }
        private void ProductSelection(string item_id)
        {
            try
            {
                FreeToStaffProduct = "N";
                Cursor.Current = Cursors.WaitCursor;
                 string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','StocksInfo','" + item_id + "','N/A','N/A'";
                 DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                 dgProductDetail.DataSource = ds.Tables[0];
                 if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count==0)
                 {
                     txtRate.Text = "0";
                     _masterkey ="";
                      txtNet.Text = "0";
                     txtQty.Select();
                     txtQty.Text = "1";
                     txtQty.SelectionStart = 0;
                     txtQty.SelectionLength = txtQty.Text.Length;  
                     MessageBox.Show("Retail product can not sale without stocks");
                 }

                _itemid = ds.Tables[1].Rows[0]["item_id"].ToString();
                _prodType = ds.Tables[1].Rows[0]["prodType"].ToString();
                _item_name = ds.Tables[1].Rows[0]["item_name"].ToString();
                _IsDiscountable = ds.Tables[1].Rows[0]["IsDiscountable"].ToString();
                txtProdDisplay.Text = _item_name;
                 FreeToStaffProduct = ds.Tables[1].Rows[0]["freeToStaff"].ToString();
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
                {
                     txtQty.Focus();
                     txtRate.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["mrp"]).ToString("##.0");
                    _masterkey = ds.Tables[0].Rows[0]["master_key_id"].ToString();
                   
                     txtQty.Select();
                     txtQty.Text = "1";
                     txtQty.SelectionStart = 0;
                     txtQty.SelectionLength = txtQty.Text.Length;  

                }
                else if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 1)
                {
                    txtRate.Text = "0";
                    _masterkey = "";
                    txtNet.Text = "0";
                    dgProductDetail.Focus();
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void MasterTemplate_Click_1(object sender, EventArgs e)
        {
            SelectionByProductDetail();

        }
        private void SelectionByProductDetail()
        {
            try
            {
                txtQty.Focus();
                txtRate.Text = dgProductDetail.CurrentRow.Cells["mrp"].Value.ToString();
                _masterkey = dgProductDetail.CurrentRow.Cells["master_key_id"].Value.ToString();
                txtQty.Select();
                txtQty.Text = "1";
                txtQty.SelectionStart = 0;
                txtQty.SelectionLength = txtQty.Text.Length;
            }
            catch (Exception ex) {}
        }
        private void Calculation()
        {
        //    try
        //    {
        //        if(_prodType=="CookedProduct" && chkStaff.Checked)
        //        {
        //            txtDisc.Text = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text) * _disc_perc /100 ).ToString("##.0");
        //        }
        //        else if (_prodType == "CookedProduct" && chkFreeStaff.Checked)
        //        {
        //            txtDisc.Text = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text) * 50 / 100).ToString("##.0");
        //        }
        //        else
        //        {
        //            txtDisc.Text = "0";
        //        }
        //        txtNet.Text = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text) - Convert.ToDecimal(txtDisc.Text)).ToString("##.0");
        //    }
        //    catch (Exception ex) {  }
       }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
             ProductListByTemplateSearch(txtSearch.Text);
        }
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
           Calculation();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Free Product management
            decimal qty =Convert.ToDecimal(txtQty.Text);
            decimal rate = Convert.ToDecimal(txtRate.Text);
            if (qty > 0)
            {
                if (FreeToStaffProduct == "Y" && Convert.ToInt32(txtFreeTea.Text) > 0)
                {
                    if (qty <= Convert.ToDecimal(txtFreeTea.Text))
                    {
                        AddProductInCart(qty, 100, rate, "N");
                        txtFreeTea.Text = (Convert.ToDecimal(txtFreeTea.Text) - qty).ToString();
                    }
                    else
                    {
                        // Two entry paid and free amount calculation if he put qty more than free
                        decimal paid_qty = qty - Convert.ToDecimal(txtFreeTea.Text);
                        AddProductInCart(paid_qty, _disc_perc, rate, "Y");

                        if (Convert.ToDecimal(txtFreeTea.Text) > 0)
                        {
                            AddProductInCart(Convert.ToDecimal(txtFreeTea.Text), 100, rate, "N");
                            txtFreeTea.Text = "0";
                        }
                    }
                }
                else
                {
                    AddProductInCart(qty, _disc_perc, rate, "N");
                }
                txtSearch.Focus();
                txtSearch.SelectAll();
            }
            else { MessageBox.Show("Quantity must be positive"); }
            //dgProductDetail.Rows.Add(gr);
        }
        private void AddProductInCart(decimal qty, decimal disc_perc, decimal rate, string extraRec)
        {
            if (rate > 0 && qty != 0)
            {
                decimal amount = rate * qty;
                GridViewRowInfo gr = dgProdDet.Rows.AddNew();
                gr.Cells["master_key_id"].Value = _masterkey;
                gr.Cells["item_name"].Value = _item_name;
                gr.Cells["item_id"].Value = _itemid;
                gr.Cells["prodType"].Value = _prodType;
                gr.Cells["qty"].Value = qty;
                gr.Cells["rate"].Value = rate;
                gr.Cells["FreeToStaff"].Value = FreeToStaffProduct;
                gr.Cells["amount"].Value = amount.ToString();
                //gr.Cells["extraRec"].Value = extraRec;
                if(disc_perc == 100)
                    gr.Cells["FreeGiven"].Value ="Y";
                else
                    gr.Cells["FreeGiven"].Value ="N";
                gr.Cells["amount"].Value = amount.ToString();
                decimal discount = 0;
                if (_prodType == "CookedProduct" && _IsDiscountable == "1")
                {
                    discount = (amount * disc_perc / 100);
                    gr.Cells["discount"].Value = discount;
                    gr.Cells["disc_perc"].Value = disc_perc;
                }
                else
                {
                    discount = 0;
                    gr.Cells["discount"].Value = "0";
                    gr.Cells["disc_perc"].Value = "0";
                }
                gr.Cells["Net"].Value = (amount - discount).ToString();// - Convert.ToDecimal(txtDisc.Text)).ToString();
                dgProduct.Focus();
                RebindSum();
            }
            else
            { MessageBox.Show("Invalid rate"); }
        }
        private void RebindSum()
        {
            decimal Total = 0;
            decimal discount = 0;
            decimal Net = 0;
            AddRemoveRoomServiceCharges();
            foreach (GridViewRowInfo r in dgProdDet.Rows)
            {
                Total = Total + Convert.ToDecimal(r.Cells["amount"].Value);
                discount = discount + Convert.ToDecimal(r.Cells["discount"].Value);
                Net = Net + Convert.ToDecimal(r.Cells["Net"].Value);
            }
            var x = Net - Math.Truncate(Net);
            txtTotal.Text = Total.ToString();
            txtTotalDisc.Text =(discount+x).ToString();
            txtTotNet.Text = (Net-x).ToString();
           
            txtQty.Text = "";
            txtRate.Text = "0";
            txtNet.Text = "0";
            if(dgProdDet.Rows.Count>0)
            { btnSave.Enabled=true;}
            else
            {btnSave.Enabled=false; }
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            btnAdd.Focus();
        }
        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if(e.Row.Cells["FreeToStaff"].Value.ToString() == "Y" && e.Row.Cells["FreeGiven"].Value.ToString() == "Y")
            {
                txtFreeTea.Text = (Convert.ToInt32(txtFreeTea.Text) + Convert.ToInt32(e.Row.Cells["qty"].Value)).ToString();
            }
            e.Row.Delete();
            dgProduct.Focus();
            RebindSum();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false; 
            DataTable dt = new DataTable();
            dt.Columns.Add("item_id", typeof(string));
            dt.Columns.Add("master_key_id", typeof(string));
            dt.Columns.Add("sold_qty", typeof(string));
            dt.Columns.Add("dis_per", typeof(string));
            dt.Columns.Add("net", typeof(string));
            dt.Columns.Add("FreeGiven", typeof(string));

            string _saleType = string.Empty;
         
            foreach (GridViewRowInfo r in dgProdDet.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["item_id"] = r.Cells["item_id"].Value.ToString();
                dr["master_key_id"] = r.Cells["master_key_id"].Value.ToString();
                dr["sold_qty"] = r.Cells["qty"].Value.ToString();
                dr["dis_per"] = r.Cells["disc_perc"].Value.ToString();
                dr["net"] = r.Cells["net"].Value.ToString();
                dr["FreeGiven"] = r.Cells["FreeGiven"].Value.ToString();
                dt.Rows.Add(dr);
            }
            string  _result=string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                //var strjson=JsonConvert.SerializeObject(dt);
                if (chkStaff.Checked)
                    _saleType = "Staff";
                if (chkFreeStaff.Checked)
                    _saleType = "Doctor";
                if (chkOther.Checked)
                    _saleType = "Other";
                string _custname = string.Empty;

                if (txtempdetail.Text.Contains(":"))
                {
                    _custname = txtempdetail.Text.Split(':')[0];

                }
                else
                    _custname = txtempdetail.Text;

                string paymode = "CA";
                if(chkSwipeCard.Checked)
                paymode = "SC";

                _sale_no = GlobalUsage.canteenProxy.Retail_InsertSale(out _result, ds, GlobalUsage.gUnit_Id, "N/A", _saleType, "N/A", paymode, txtpayremark.Text, _custname, _empcode, _custname, "N/A", GlobalUsage.gLogin_id, _partyid,"N/A","-",Convert.ToInt32(txtToken.Text));
                if (_sale_no.Contains("S"))
                {
                    PrintBill(_sale_no,"Original");
                    ClearAll();
                }
                else
                { MessageBox.Show(_result); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void ClearAll()
        {
            dgProdDet.Rows.Clear();
            txtTotal.Text = "0";
            txtTotalDisc.Text = "0";
            txtTotNet.Text = "0";
            _disc_perc = 0;
            txtFreeTea.Text = "0";
            _partyid = string.Empty;
            _empcode = string.Empty;
            chkCash.Checked = true;
            chkOther.Checked = true;
            btnSave.Enabled = false;
            chkOther.Checked = true; _CreditAllowed = "N";
            txtempdetail.Text = string.Empty;
            txtToken.Text = "0";
            this.chkRoomService.CheckedChanged -= new System.EventHandler(this.chkRoomService_CheckedChanged);
            chkRoomService.Checked = false;
            this.chkRoomService.CheckedChanged += new System.EventHandler(this.chkRoomService_CheckedChanged);
        }
        private void PrintBill(string sale_inv_no,string BillType)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','PrintBill','" + sale_inv_no + "','-','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                if (Convert.ToDecimal(txtTotNet.Text) > 0)
                {
                    report.Refresh();
                    report.DataSources.Clear();
                    report.ReportPath = @"msReport\receit.rdlc";
                    ReportParameter rp = new ReportParameter("ReportType", BillType);
                    report.SetParameters(new ReportParameter[] { rp });
                    report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
                    report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
                    report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
                    report.PrintToPrinter(3.2f, 8.3f, 0.1f, 0.1f, 0.1f, 0.1f); //parameter in Inches 
                }
                //KOT Printing
                report_KOT.Refresh();
                report_KOT.DataSources.Clear();
                report_KOT.ReportPath = @"msReport\KOT.rdlc";
                ReportParameter rpK = new ReportParameter("ReportType", BillType);
                report_KOT.SetParameters(new ReportParameter[] { rpK });
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
                report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
                report_KOT.PrintToPrinter(3.2f,8.3f,0.1f, 0.1f, 0.1f, 0.1f);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void btnPrintIS_Click(object sender, EventArgs e)
        {
            PrintBill(_sale_no,"Duplicate");
        }
        private void RebindGrid()
        {
            string over_from_free = string.Empty;
            foreach (GridViewRowInfo gr in dgProdDet.Rows)
            {
                decimal amount = (Convert.ToDecimal(gr.Cells["rate"].Value) * Convert.ToDecimal(gr.Cells["qty"].Value));
                gr.Cells["amount"].Value = amount.ToString();
                decimal discount = 0;

                //if(gr.Cells["FreeToStaff"].Value.ToString() == "Y")
                //{
                //    if(Convert.ToInt32(gr.Cells["qty"].Value) <= Convert.ToDecimal(txtFreeTea.Text))
                //    {
                //        discount = (amount * 100 / 100);
                //        gr.Cells["disc_perc"].Value = 100;
                //        txtFreeTea.Text = (Convert.ToInt32(txtFreeTea.Text) - Convert.ToInt32(gr.Cells["qty"].Value)).ToString();
                //    }
                //    else
                //    {
                //        decimal paid_qty = Convert.ToInt32(gr.Cells["qty"].Value) - Convert.ToDecimal(txtFreeTea.Text);
                //        amount = (Convert.ToDecimal(gr.Cells["rate"].Value) * paid_qty);
                //        discount = (amount * _disc_perc / 100);
                //        gr.Cells["disc_perc"].Value = _disc_perc;
                //        gr.Cells["qty"].Value = paid_qty;
                //        gr.Cells["amount"].Value = amount.ToString();
                //        over_row_rate = Convert.ToDecimal(gr.Cells["rate"].Value);
                //        // adding next entry
                //        over_from_free = "Y";
                //     }
                //}
                if (gr.Cells["prodType"].Value.ToString() == "CookedProduct")
                {
                    discount = (amount * _disc_perc / 100);
                    gr.Cells["disc_perc"].Value = _disc_perc;
                }
                else
                {
                    discount = 0;
                    gr.Cells["disc_perc"].Value = 0;
                }
                gr.Cells["discount"].Value = discount.ToString("##.0");
                gr.Cells["Net"].Value = (amount - discount).ToString("##.0");
            }
            //if (Convert.ToDecimal(txtFreeTea.Text) > 0 && over_from_free=="Y")
            //{
            //    AddProductInCart(Convert.ToDecimal(txtFreeTea.Text), 100,over_row_rate);
            //    txtFreeTea.Text = "0";
            //}
            //dgProdDet.Refresh();

        }
        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOther.Checked)
            { _disc_perc = 0; txtEmployee.Text = string.Empty; txtempdetail.Text = string.Empty; }
            RebindGrid();
            RebindSum();
        }
        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCash.Checked)
            { txtpayremark.Enabled = false; chkSwipeCard.Checked = false; }
        }
        private void chkSwipeCard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCash.Checked)
            { txtpayremark.Enabled = true;chkCash.Checked = false; }
        }
        private void txtEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','ValidateStaff','" + txtEmployee.Text + "','N/A','N/A'";
                    DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                         txtempdetail.Text = ds.Tables[0].Rows[0]["emp_name"].ToString();
                        _empcode = txtEmployee.Text;
                        _partyid = _empcode;
                        _disc_perc = Convert.ToDecimal(ds.Tables[0].Rows[0]["discount_perc"]);
                         txtFreeTea.Text = ds.Tables[0].Rows[0]["free_tea"].ToString();
                         if(dgProdDet.Rows.Count > 0)
                         {
                             MessageBox.Show("Please delete all records from cart and always select employee/doctor first in case of discount");
                             return;
                         }
                         txtSearch.Focus();
                        chkStaff.Checked = true;
                    }
                    else
                    { 
                        txtempdetail.Text = ""; chkOther.Checked = true; _empcode = string.Empty; txtFreeTea.Text = "0";
                        
                        RebindGrid();
                        RebindSum();
                    
                    }
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
        private void MasterTemplate_KeyDown_1(object sender, KeyEventArgs e)
        {
            SelectionByProductDetail();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtFreeTea.Text = "0";
            HIS_Doctor obj = new HIS_Doctor();
            obj.SearchUpdated += new SearchUpdateEventHandler(selectDoctor);
            obj.Owner = this;
            obj.Show();
        }
        private void selectDoctor(object sender, SearchUpdatedEventArgs e)
        {
            if (e.ProductID.Length > 5)
            {
                 string[] t = e.ProductID.Split(':');
                 _empcode = string.Empty;
                 txtempdetail.Text = t[0]+":"+t[1];
                _partyid = t[1];
                _disc_perc = 0;
                txtFreeTea.Text = t[2];
                txtSearch.Focus();
                txtEmployee.Text = string.Empty;
                RebindGrid();
                RebindSum();
                chkFreeStaff.Checked = true;
            }
            else
            { txtempdetail.Text = string.Empty; chkFreeStaff.Checked = false; }

        }
        private void chkRoomService_CheckedChanged(object sender, EventArgs e)
        {
            RebindSum();
        }
        private void AddRemoveRoomServiceCharges()
        {
            dgProdDet.SelectionMode = GridViewSelectionMode.FullRowSelect;
            foreach (GridViewRowInfo row in dgProdDet.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains("C001154"))
                {
                    row.Delete();
                    break;
                }
            }
            decimal Net = 0;
            foreach (GridViewRowInfo r in dgProdDet.Rows)
            {
                if(r.Cells[0].Value.ToString()!= "C001154")
                Net = Net + Convert.ToDecimal(r.Cells["Net"].Value);
            }
            if(chkRoomService.Checked)
            {
                #region Adding Service Charges
                decimal RoomServiceCharges = 0;
                RoomServiceCharges = Net * 20 / 100;
                GridViewRowInfo gr = dgProdDet.Rows.AddNew();
                gr.Cells["master_key_id"].Value = "C001154";
                gr.Cells["item_name"].Value = "ROOM SERVICE CHARGES";
                gr.Cells["item_id"].Value = "C001154";
                gr.Cells["prodType"].Value = "ServiceTax";
                gr.Cells["qty"].Value = 1;
                gr.Cells["rate"].Value = RoomServiceCharges;
                decimal amount = RoomServiceCharges;
                gr.Cells["amount"].Value = RoomServiceCharges;
                gr.Cells["discount"].Value = "0";
                gr.Cells["disc_perc"].Value = "0";
                gr.Cells["Net"].Value = amount.ToString();
                gr.Cells["FreeToStaff"].Value = "N";
                gr.Cells["FreeGiven"].Value = "N";
                
                dgProduct.Focus();
                #endregion
            }
            else
            {
                dgProdDet.SelectionMode = GridViewSelectionMode.FullRowSelect;
                foreach (GridViewRowInfo row in dgProdDet.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains("C001154"))
                    {
                        row.Delete();
                        break;
                    }
                }
            }
        }
        private void radButton4_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ConnectToSignalRServer()
        {

            try
            {
                string url = System.Configuration.ConfigurationManager.AppSettings["URL"].ToString();
                connection = new HubConnection(url, "username="+GlobalUsage.gLogin_id+"");
               _hub = connection.CreateHubProxy("canteenHub");
                connection.Start().Wait();
                if(connection.State == Microsoft.AspNet.SignalR.Client.ConnectionState.Connected)
                {
                    connection.Closed += Connection_Closed;
                }
                //ConnectToSignalRServer().Start();
                _hub.On<string, string>("addMessage", (name, message) =>this.Invoke((Action)(() => StartFillingSync()))
                );
            }
            catch (Exception ex) { }

        }
        private void UpdateTokenStatus()
        {
            try
            {
                string qry = "execute pCanteen_TokenQueries '" + GlobalUsage.gUnit_Id + "','TokenList','-','N/A','N/A'";
                DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");
                foreach (Control ctr in pnlToken.Controls)
                {
                    System.Windows.Forms.Panel p = ctr as System.Windows.Forms.Panel;
                    var t = ds.Tables[0].AsEnumerable().Where(x => x.Field<int>("TokenNo").ToString() == p.Tag.ToString()).Select(y=>new { tokenStatus=y.Field<string>("tokenStatus") }).ToList();
                    if(t.Any())
                    {
                        if(t.First().tokenStatus == "Free")
                        {
                            p.BackColor = Color.Silver;
                            p.Enabled = true;
                        }
                        if (t.First().tokenStatus == "Booked")
                        {
                            p.BackColor = Color.CornflowerBlue;
                            p.Enabled = false;
                        }

                        if (t.First().tokenStatus == "Cooking")
                        {
                            p.BackColor = Color.Coral;
                            p.Enabled = true;
                        }
                        if (t.First().tokenStatus == "Ready")
                        {
                            p.BackColor = Color.LightGreen;
                            p.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        private async void Connection_Closed()
        {
        }
        private void StartFillingSync()
        {
            if (!backgroundWorker1.IsBusy) { backgroundWorker1.RunWorkerAsync(); }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateTokenStatus();
        }
    }
    }
