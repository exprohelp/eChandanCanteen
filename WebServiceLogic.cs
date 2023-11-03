using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eChandanCanteen
{
    class WebServiceLogic
    {
        public  WebServiceLogic()
        { }
        public object getServiceReffrence()
        {
            eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient objService = new eChandanCanteen.Inventory_WebServices.Inventory_WebServicesSoapClient();
            return objService;
        }
        
    }
}
