using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AZUK.ServiceAdaptor.Log;

namespace AZUK.ServiceAdaptor.Exceptions
{
    class EhlApiError : Exception
    {
        public EhlApiError()
        {

        }

        public EhlApiError(string message)
            : base(message)
        {
            System.Console.WriteLine(message);
            LogWriter.LogWrite(message);
        }

        public EhlApiError(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
