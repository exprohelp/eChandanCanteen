using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace eChandanCanteen
{
    public static class GlobalUsage
    {
        public static string DocId="";
        public static string gLogin_id = "";
        public static string gUnit_Id = "";
        public static string gUnitName = "";
        public static string gCmpCode="";
        public static string gRights = "";
        public static string gFileName = "";
        public static string gMessage = "Waiting For Action\n ";
        public static bool NetConnected = false;
        public static string mainFormCaption = "";
        public static string Old_Sale_Inv_No = "";
        public static string Purchase_Id="";
        public static string gAddress = "";
        public static string gPharmacistNo = "";
        public static string gDL_No = ""; 
        public static string gVAT_No = "";
        public static CanteenProxy.ChandanCanteenServiceClient canteenProxy;
        public static void checkNumbers(Form frm, TextBox txt)
        {
            string str1 = "";
            Int32 count;

            for (count = 0; count <= txt.Text.Length - 1; count++)
            {
                if (char.IsNumber(txt.Text, count))
                {
                    str1 = "OK";
                }
                else
                {
                    MessageBox.Show("Only Numbers Are Allowed");
                    txt.Focus(); txt.Clear(); txt.Select();
                }
            }
        }
        public static string ErrorHistory(Exception ex)
        {
            string[] errorarray = ex.StackTrace.Split('\\');
            string[] line = errorarray[errorarray.Length - 1].Split(':');
            string error = ex.Source + "|" + ex.TargetSite.Name + "|" + ex.TargetSite.ReflectedType.FullName + "|" + line[1] + "|" + ex.Message;
            return error;
        }
    }
   
}
