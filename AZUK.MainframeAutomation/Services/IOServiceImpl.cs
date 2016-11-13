using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using Microsoft.Win32;
using System.Data;
using AZUK.ServiceAdaptor.Services;
using AZUK.MainframeAutomationRobot.Model;
namespace AZUK.MainframeAutomationRobot.Services
{
    class IOServiceImpl:IOService
    {


        private SpreadSheetModel SelectedExcelFile;

        public string OpenFileDialog(string defaultPath)
        {
            SelectedExcelFile = new SpreadSheetModel();
            var dialog = new OpenFileDialog { InitialDirectory = defaultPath };
            dialog.DefaultExt = ".xls|.xlsx";
            dialog.Filter = "Excel documents (*.xls, *.xlsx)|*.xls;*.xlsx";
            dialog.Multiselect = false;
            dialog.Title = "Find Excel File";
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            SelectedExcelFile.FileName = dialog.FileName;
            return SelectedExcelFile.FileName;
        }



        public List<string> GetColumnNames(string SheetName)
        {
            SelectedExcelFile.SelectedSheetName = SheetName;
            List<string> ColumnNames = new List<string>();
            ImportExcelService excelService = new ImportExcelService(SelectedExcelFile.FileName);
            DataTable excelColumns = excelService.GetColumnNames(SelectedExcelFile.SelectedSheetName);

            foreach (DataColumn column in excelColumns.Columns)
            {
                ColumnNames.Add(column.ToString());
            }
            SelectedExcelFile.ColumnNames = new System.Collections.ObjectModel.ObservableCollection<string>(ColumnNames);
            return ColumnNames;

        }

        public DataTable GetRecords()
        {
            try
            {

                ImportExcelService excelService = new ImportExcelService(SelectedExcelFile.FileName);
                return (excelService.ReadFile(SelectedExcelFile.SelectedSheetName,CommonServices.RESULT_SHEET)); ;
            }
            catch (NullReferenceException e)
            {
                return null;
            }
           
        }


        public List<string> GetSheetNames()
        {

            ImportExcelService excelService = new ImportExcelService(SelectedExcelFile.FileName);
            SelectedExcelFile.SheetNames = excelService.ReturnSheetNames();
            return (SelectedExcelFile.SheetNames);
        }

        public SpreadSheetModel getCurrentExcelFile()
        {
            if (this.SelectedExcelFile != null)
                return this.SelectedExcelFile;
            else
                return new SpreadSheetModel();
        }

        public string updateExcel(DataTable resultData)
        {
            try
            {
                ImportExcelService excelService = new ImportExcelService(SelectedExcelFile.FileName);
                excelService.UpdateExcel(resultData, CommonServices.RESULT_SHEET);
                return CommonServices.SUCCESS;
            }

            catch
            {
                return CommonServices.FAILURE;
            }
        }
    }
}
