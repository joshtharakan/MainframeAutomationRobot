using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AZUK.ServiceAdaptor.Log;

namespace AZUK.MainframeAutomationRobot.Exceptions
{
	class AutomationExceptions : Exception
	{
        public AutomationExceptions()
        {
        
        }

        public AutomationExceptions(string message)
            : base(message)
        {
            System.Console.WriteLine(message);
            LogWriter.LogWrite(message);
        }

        public AutomationExceptions(string message, Exception inner)
            : base(message, inner)
        {
        }
	}
}