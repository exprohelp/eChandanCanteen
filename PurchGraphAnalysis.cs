using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZedGraph;
using eChandanCanteen.Inventory_WebServices;
using ExPro.Client;
using ExPro.Server;
namespace eChandanCanteen
{
    public partial class PurchGraphAnalysis : Form
    {
        Inventory_WebServicesSoapClient lws = new Inventory_WebServicesSoapClient();
        DataSet ds = new DataSet();
        public PurchGraphAnalysis()
        {
            InitializeComponent();
        }
        private void PurchGraphAnalysis_Load(object sender, EventArgs e)
        {
            ds = lws.GetQueryResult("exec pTotalPurchaseInFinYear ", "eIM_Data");
            PointPairList list = new PointPairList();
            list.Add(0, Convert.ToDouble(ds.Tables[0].Rows[0]["APR"]));
            list.Add(1, Convert.ToDouble(ds.Tables[0].Rows[0]["MAY"]));
            list.Add(2, Convert.ToDouble(ds.Tables[0].Rows[0]["JUN"]));
            list.Add(3, Convert.ToDouble(ds.Tables[0].Rows[0]["JUL"]));
            list.Add(4, Convert.ToDouble(ds.Tables[0].Rows[0]["AUG"]));
            list.Add(5, Convert.ToDouble(ds.Tables[0].Rows[0]["SEP"]));
            list.Add(6, Convert.ToDouble(ds.Tables[0].Rows[0]["OCT"]));
            list.Add(7, Convert.ToDouble(ds.Tables[0].Rows[0]["NOV"]));
            list.Add(8, Convert.ToDouble(ds.Tables[0].Rows[0]["DEC"]));
            list.Add(9, Convert.ToDouble(ds.Tables[0].Rows[0]["JAN"]));
            list.Add(10, Convert.ToDouble(ds.Tables[0].Rows[0]["FEB"]));
            list.Add(11, Convert.ToDouble(ds.Tables[0].Rows[0]["MAR"]));
            string[] MONTH = new string[12];
            MONTH[0] = "APR";
            MONTH[1] = "MAY";
            MONTH[2] = "JUN";
            MONTH[3] = "JUL";
            MONTH[4] = "AUG";
            MONTH[5] = "SEP";
            MONTH[6] = "OCT";
            MONTH[7] = "NOV";
            MONTH[8] = "DEC";
            MONTH[9] = "JAN";
            MONTH[10] = "FEB";
            MONTH[11] = "MAR";
            CreateGraph(zedGraphControl1, list, "", MONTH);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void CreateGraph(ZedGraphControl zgc, PointPairList list, string Volume, string[] month)
        {
           // GraphPane myPane = zgc.GraphPane;
           // myPane.Title.Text = "Graph Of Given Volume=" + Volume;
           // myPane.XAxis.Title.Text = "Date";
           // myPane.YAxis.Title.Text = "Actual Volume";
           // //BarItem  myCurve1 = myPane.AddBar("4", list, Color.DeepSkyBlue);
           // LineItem myCurve = myPane.AddCurve("", list, Color.Black, SymbolType.Circle);
           // myCurve.Line.Fill = new Fill(Color.White, Color.Black, 45F);
           //// Make the symbols opaque by filling them with white
           // myCurve.Symbol.Fill = new Fill(Color.White);
           // myPane.XAxis.Scale.TextLabels = month;
           // myPane.XAxis.Type = AxisType.Text;
           // // Fill the axis background with a color gradient
           // myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
           // // Fill the pane background with a color gradient
           // myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);
           // zgc.AxisChange();
           // zgc.Refresh();

            GraphPane myPane = zgc.GraphPane;
            myPane.Title.Text = "Purchase Graph";
            myPane.XAxis.Title.Text = "Month";
            myPane.YAxis.Title.Text = "Stock Rs";

            //  BarItem  myCurve1 = myPane.AddBar("4", list, Color.DeepSkyBlue);
            BarItem bar = myPane.AddBar("", list, Color.Maroon);
            bar.Bar.Fill = new Fill(Color.White, Color.Maroon, 45F);
            //int i = 0;
            //double[] yar = new double[12]; 
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //     yar[i]=Convert.ToDouble(dr["APR"]);
            //     i++;
            //}
            //var m= yar.Max();
            //var mi=yar.Min();
            //double z = 2 *  m;
            ////Make the symbols opaque by filling them with white

            // myPane.YAxis.Scale.Max = m;
            //// myPane.YAxis.Scale.TextLabels=yar;
            // myPane.YAxis.Type = AxisType.Text;
            
            myPane.XAxis.Scale.TextLabels = month;
            myPane.XAxis.Type = AxisType.Text;
            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);
            zgc.AxisChange();
            zgc.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    
    }
}
