using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eChandanCanteen
{
    class ErrorRport
    {
        eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient lws = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
        public ErrorRport()
        { }
        public  string ErrorHistory(Exception ex)
        {
            string[] errorarray = ex.StackTrace.Split('\\');
            string[] line = errorarray[errorarray.Length - 1].Split(':');
            string error = errorarray[errorarray.Length - 2] + "|" + ex.TargetSite.ReflectedType.FullName + "|" + line[0] + "|" + line[1] + "|" + ex.Message;
            return error;
        }
        public void SendError(Exception ex)
        {
            try { lws.SaveErrorLog(GlobalUsage.gUnit_Id,ErrorHistory(ex)); }
            catch (Exception ex1) { }
        }

    }
}
