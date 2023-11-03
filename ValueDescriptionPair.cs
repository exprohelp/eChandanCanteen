using System;
using System.Collections.Generic;
using System.Text;

namespace eChandanCanteen
{
 public  class ExproComboBox
    {
     private object objValue;
     private String strDescription;

     public ExproComboBox(object NewValue, String NewDescription)
     {
         objValue = NewValue;
         strDescription=NewDescription;
     }

     public string Value{
         get { return objValue.ToString();}
     }
      public string NewDescription{
     get{return strDescription;}
     }
      public override string ToString()
      {
           return strDescription;
      }
    }
}
