using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using System.Windows.Forms;
using System.Security.Cryptography;
using Telerik.WinControls.UI;
using System.Drawing;

namespace eChandanCanteen
{
    public class Config
    {
        public static string NewVoucherNo(string unit_id){

            SqlConnection con = DBConnection.GetConnection(true, "eMediCentral");
            SqlCommand cmd = new SqlCommand("pNewVoucherNo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("unit_id", SqlDbType.VarChar, 10).Value = unit_id;
            cmd.Parameters.Add("Voucher_No", SqlDbType.VarChar, 15).Value = "N/A";
            cmd.Parameters["Voucher_No"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string result = (string)cmd.Parameters["Voucher_No"].Value;
            return result; 
       }
        public static string LeftAlign(string Info, Int32 Space)
        {
            Int32 len = Info.Length;
            string sp = new String(' ', (Space - len));
            return sp;
        }
        public static string RightAlign(string First_Info, Int32 Space_1, string Second_Info, Int32 Space_2)
        {
            Int32 len = (Space_1 - First_Info.Length) + (Space_2 - Second_Info.Trim().Length);
            string sp = new String(' ', len);
            return sp;
        }

        public static List<RadListDataItem> FillTelrikCombo(DataTable dt)
        {
            List<RadListDataItem> list = new List<RadListDataItem>();
            RadListDataItem li = new Telerik.WinControls.UI.RadListDataItem();
            System.Windows.Forms.ComboBox cb = new System.Windows.Forms.ComboBox();
            li.Value = "Select";
            li.Text = "Select";
            list.Add(li);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Telerik.WinControls.UI.RadListDataItem(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
            }
            return list;
        }
        public static object[] FillCombo(DataTable dt)
        {
            ComboBox cb = new ComboBox();
            cb.Items.Add(new ExproComboBox("Select", "Select"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(new ExproComboBox(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
            }
            cb.SelectedIndex = 0;
            object[] obj = new object[cb.Items.Count];
            cb.Items.CopyTo(obj, 0);

            return obj;
        }
        public static string Encryption(string strPwd)
        {
            string strHex = string.Empty;

            byte[] HashValue, MessageBytes = UnicodeEncoding.Default.GetBytes(strPwd);

            SHA512 sha512 = new SHA512Managed();

            HashValue = sha512.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
                strHex += string.Format("{0:x2}", b);
            return strHex;
        }
        public static UCSaveDoc AddDocUploadControl(string DocType, string DocId, int cwidth)
        {
            UCSaveDoc rpc = new UCSaveDoc();
            rpc.DocType = DocType;
            rpc.DocId = DocId;
            rpc.Location = new System.Drawing.Point(8, 5);
            rpc.Width = cwidth;
            return rpc;
        }

    }
    public static class FormExtensions
    {
        public static bool? SetScreenToFirstNonPrimary(this Form self)
        {
            try
            {
                // Retrieves the collection of available screens (monitors)
                var aScreens = Screen.AllScreens;
                // If count is not greater than 1 then exit
                if (aScreens.Length <= 1)
                    return false; // screen kept original

                // Saves current screen reference
                var screenOld = Screen.FromControl(self);
                foreach (var screen in aScreens)
                {
                    // Skips primary and current screen
                    if (screen.Primary || screen.Equals(screenOld))
                        continue;

                    var boundsScreen = screen.Bounds;

                    var oldState = self.WindowState;
                    // If form is currently maximized ...
                    if (oldState == FormWindowState.Maximized)
                    {
                        self.WindowState = FormWindowState.Normal;
                        self.StartPosition = FormStartPosition.Manual;
                        self.Location = boundsScreen.Location;
                        self.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        self.StartPosition = FormStartPosition.Manual;
                        // Center into new screen
                        var sizeGaps = boundsScreen.Size - self.Size;
                        var x = boundsScreen.Left + (sizeGaps.Width / 2);
                        var y = boundsScreen.Top + (sizeGaps.Height / 2);
                        self.Location = new Point(x, y);
                    }

                    return true; // screen has been changed
                }

                return false; // screen kept original
            }
            catch (Exception ex)
            {
                // process exception ex
                // ...

                return null; // error occurred
            }
        }
    }
}
