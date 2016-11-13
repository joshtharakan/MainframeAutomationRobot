using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AZUK.MainframeAutomationRobot.Services
{
    static class CommonServices
    {
        public static readonly Dictionary<string, string> Screens;
        public static readonly List<string> Historic;

        public static string SUCCESS = "Success";
        public static string FAILURE = "Failure";
        public static string RESULT_SHEET = "Result"; 

       //public const string COMMAND = "Command";
       //public const string EXCEL_SCREEN_NAME = "Excel";

        static CommonServices()
        {
            Screens = new Dictionary<string, string>();
            Historic = new List<string>();
        }
        /// <summary>
        /// Configures the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        public static string ConfigureOrRetrieve(string UserControlName)
        {
            lock (Screens)
            {
                if (!CommonServices.Screens.ContainsKey(UserControlName))
                {
                    var uniqueKey = Guid.NewGuid().ToString();
                    Screens.Add(UserControlName, uniqueKey);

                }
                return (Screens[UserControlName]);
            }
        }

      


    }
}
