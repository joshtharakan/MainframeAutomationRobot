using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AZUK.ServiceAdaptor.Log;

namespace AZUK.ServiceAdaptor.Exceptions
{
	class EhlApiExceptions : Exception
	{
        public EhlApiExceptions()
        {
        
        }

        public EhlApiExceptions(string message)
            : base(message)
        {
            System.Console.WriteLine(message);
            LogWriter.LogWrite(message);
        }

        public EhlApiExceptions(string message, Exception inner)
            : base(message, inner)
        {
        }
	}
}

