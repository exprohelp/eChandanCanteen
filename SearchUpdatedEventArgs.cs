using System;
using System.Collections.Generic;
using System.Text;

namespace eChandanCanteen
{
    public delegate void SearchUpdateEventHandler(object sender, SearchUpdatedEventArgs e); 
     public   class SearchUpdatedEventArgs : System.EventArgs 
    {
        private string productID;
        public SearchUpdatedEventArgs(string productID)
        {
            this.productID = productID;
           
        }
        public string ProductID
        { 
            get 
            { return this.productID;
            }
        }
    }
}
