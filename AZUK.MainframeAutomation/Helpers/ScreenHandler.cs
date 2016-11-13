using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AZUK.MainframeAutomationRobot.Helpers
{
    class ScreenHandler
    {
         public static  string EXCEL_VIEW_NAME = "ExcelUpload";

         public static string COMMAND = "COMMAND";
         public static string COLUMN = "COLUMN";
         public static string OPTIONAL = "<OPTIONAL>";
         public static string screenControlUri = "/Views/ScreenControl.xaml";
         
         public static Uri returnScreenUri(string screenName)
         {   
             string identifier = "?name={0}";
             return new Uri(screenControlUri + string.Format(identifier, screenName), UriKind.Relative);

         }

         public static string returnScreenName(Uri screenUri)
         {
             string identifier = "?name=";
             //Just check if the string is avaialble in the URI
             int ix = screenUri.OriginalString.IndexOf(identifier);

             if (ix != -1)
             {
                 return screenUri.OriginalString.Substring(screenUri.OriginalString.IndexOf(identifier) + identifier.Length);
             }
             else
             {
               
                 return "";
             }

         }
    }
}
