using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AZUK.ServiceAdaptor.Log
{
   

    public static class LogWriter

    {

        //Set log file name . Get it from configuration file or hard code it :)

        //C:\Temp\LogFiles\encryptionLog.log

        public static string LogFileName = SettingsManager.Default.LogFileName;

        public static string getPath()
        {
            return Path.GetDirectoryName(LogFileName);
        }

        public static void LogWrite(string logMessage)

        {
            try
            {

                if (!Directory.Exists(getPath()))
                {
                    Directory.CreateDirectory(getPath());
                }

                if (!File.Exists(LogFileName))
                {

                    File.Create(LogFileName);
                }
                using (StreamWriter w = File.AppendText(LogFileName))
                {

                    Log(logMessage, w);
                    w.Close();

                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Exception while handling log file...");
            }

        }

 

        public static void ResetLogFile()

        {

                File.WriteAllText(LogFileName, String.Empty);

 

        }

 

        public static void Log(string logMessage, TextWriter txtWriter)

        {

                txtWriter.Write("\r\n");

                txtWriter.Write("{0} {1}", DateTime.Now.ToLongTimeString(),

                    DateTime.Now.ToLongDateString());

                txtWriter.Write(" : {0}", logMessage);

 

        }

    }

}

 

 
