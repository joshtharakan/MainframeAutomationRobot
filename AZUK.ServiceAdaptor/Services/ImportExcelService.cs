using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using AZUK.ServiceAdaptor.Exceptions;
using ClosedXML.Excel;


namespace AZUK.ServiceAdaptor.Services
{
    public class ImportExcelService
    {
        System.Data.OleDb.OleDbConnection OledbConn;
        System.Data.OleDb.OleDbCommand oleExcelCommand;
        System.Data.OleDb.OleDbDataReader dataReader;
        DataTable ContentTable=null;
        private string _fileName;
        private string _sheetName;

        //public static string RESULT_SHEET = "Result"; 

        public ImportExcelService(string fileName)    
        {
            this._fileName = fileName;
        string connString = "";
        string extn = Path.GetExtension(_fileName);
        if (extn == ".xls")    
    //Connectionstring for excel v8.0    
    
         connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _fileName + ";Extended Properties=\"Excel 8.0;HdataReader=Yes;IMEX=1\"";    
        else
            //Connectionstring fo excel v12.0    
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _fileName + ";Extended Properties=\"Excel 12.0;HdataReader=Yes;IMEX=1\"";

            OledbConn = new System.Data.OleDb.OleDbConnection(connString);
            OledbConn.Close();
        }


        public DataTable GetColumnNames(string sheetName)
        {
            this._sheetName = sheetName;
            try
            {
                oleExcelCommand = new System.Data.OleDb.OleDbCommand();
                oleExcelCommand.Connection = OledbConn;
               

                if (!CheckForSheet(_sheetName))
                {
                    throw new EhlApiExceptions("Unable to find Sheet");
                }
                else
                {
                    OledbConn.Open();
                    
                    oleExcelCommand.CommandText = "SELECT TOP 1 * FROM [" + sheetName + "$]";
                    oleExcelCommand.CommandType = CommandType.Text;
                    dataReader = oleExcelCommand.ExecuteReader();

                    ContentTable = new DataTable();

                    ContentTable.Load(dataReader);

                }
                dataReader.Close();

                OledbConn.Close();
                return ContentTable;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Unable to connect Excel");
                Log.LogWriter.LogWrite("Unable to connect Excel");
                return null;

            }
        }   

        private bool CheckForSheet(string sheetName)
        {
            DataTable schemaTable = new DataTable();
            Boolean sheetFound = false;
            String readSheet = null;
            oleExcelCommand = new System.Data.OleDb.OleDbCommand();
            oleExcelCommand.Connection = OledbConn;
            OledbConn.Open();

            schemaTable = OledbConn.GetSchema("Tables");
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                readSheet = (string)schemaTable.Rows[i]["TABLE_NAME"];
                if (readSheet.Contains(sheetName))
                {
                    sheetFound = true;
                    break;
                }

             
            }
            OledbConn.Close();
            return sheetFound;
        }

        public  List<string> ReturnSheetNames()
        {
            DataTable schemaTable = new DataTable();
            List<string> sheetNames = new List<string>();
            String readSheet = null;
            oleExcelCommand = new System.Data.OleDb.OleDbCommand();
            oleExcelCommand.Connection = OledbConn;
            OledbConn.Open();

            schemaTable = OledbConn.GetSchema("Tables");
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                readSheet = (string)schemaTable.Rows[i]["TABLE_NAME"];
                sheetNames.Add(readSheet.Remove(readSheet.Length-1));

            }
            OledbConn.Close();
            return sheetNames;
        }

   public DataTable ReadFile(string sheetName, string resultSheet)    
    {
        this._sheetName = sheetName;
    try    
    {
    if (!CheckForSheet(sheetName))
        {
            throw new EhlApiExceptions("Unable to find Sheet");
        }
        else
        {
            oleExcelCommand = new System.Data.OleDb.OleDbCommand();
            oleExcelCommand.Connection = OledbConn;
            OledbConn.Open();
            oleExcelCommand.CommandText = "Select * from [" + sheetName + "$]";
            oleExcelCommand.CommandType = CommandType.Text;
            dataReader = oleExcelCommand.ExecuteReader();

            ContentTable = new DataTable();

            ContentTable.Load(dataReader);
            
        }
        dataReader.Close();
        InsertResultColumn(resultSheet);
        OledbConn.Close();
        return ContentTable;
    }    
    catch (Exception ex)    
    {
        System.Console.WriteLine("Unable to connect Excel");
        Log.LogWriter.LogWrite("Unable to connect Excel");
        return null;
  
    }    
}

   public void UpdateExcel(DataTable resultData, String resultSheet)
   {
       try
       {
         //  FileStream excelOutputStream = new FileStream(_fileName, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
           XLWorkbook WorkBook = new XLWorkbook(_fileName);
           if (CheckForSheet(resultSheet))
           {
               WorkBook.Worksheets.Delete(resultSheet);
           }
           WorkBook.Worksheets.Add(resultData, resultSheet);

           WorkBook.Save();
       }
       catch (Exception e)
       {
           throw new EhlApiExceptions("Unable to Update Sheet");
       }
   }

   public void InsertResultColumn(string resultSheet)
   {
       ContentTable.Columns.Add(resultSheet, typeof(string));
   }

    }

}
