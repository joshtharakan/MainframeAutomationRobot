using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AZUK.MainframeAutomationRobot.Model;

namespace AZUK.MainframeAutomationRobot.Services
{
    public interface IOService
    {
       
        string OpenFileDialog(string defaultPath);
        List<string> GetColumnNames(string SheetName);
        List<string> GetSheetNames();
        SpreadSheetModel getCurrentExcelFile();
        DataTable GetRecords();
        string updateExcel(DataTable resultData);
    }
}
