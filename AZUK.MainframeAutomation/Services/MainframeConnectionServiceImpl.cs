using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AZUK.MainframeAutomationRobot.Model;
using AZUK.MainframeAutomationRobot.ViewModel;
using AZUK.MainframeAutomationRobot.Helpers;
using AZUK.MainframeAutomationRobot.Exceptions;
using GalaSoft.MvvmLight.Ioc;
using AZUK.ServiceAdaptor.Services;


namespace AZUK.MainframeAutomationRobot.Services
{
    class MainframeConnectionServiceImpl : MainframeConnectionService
    {
        private List<ScreenModel> _screenModelObjects;
        private List<ScreenModel> _nonrepeatedScreens;
        private List<ScreenModel> _repeatedScreens;
        private DataTable excelData;
        private EhlApi KeyingObj ;
        private KeyingResultModel _result;
        

        public KeyingResultModel UploadToMainframe()
        {
            _screenModelObjects = new List<ScreenModel>();
            _result = new KeyingResultModel();
            _result.FailureRecordsNos = 0;
            _result.SuccessRecordsNos = 0;
            excelData = GetExcelValues();
            if (excelData != null)
            {
                GetScreensValues();
                if (_screenModelObjects.Count > 0)
                {
                   if(Mainframekeying().Contains(CommonServices.SUCCESS))
                    _result.Outcome=CommonServices.SUCCESS;
                   OpenExcelFile();
                   return _result;
                }
            }
           
          _result.Outcome= CommonServices.FAILURE;
          return _result;
                
           
        }

        private void OpenExcelFile()
        {
            string excelViewKey;
            try
            {

                if (CommonServices.Screens.TryGetValue(ScreenHandler.EXCEL_VIEW_NAME, out excelViewKey))
                {
                    string fileName = SimpleIoc.Default.GetInstance<ExcelUploadViewModel>(excelViewKey).SelectedFile.FileName;
                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                }
            }
            catch (Exception e)
            {
                throw new AutomationExceptions("Excel File opening failed");
            }
        }

        private DataTable GetExcelValues()
        {
            IOService ioService = SimpleIoc.Default.GetInstance<IOService>();
           
            return ioService.GetRecords();


        }

        private string Mainframekeying()
        {
            try
            {

                KeyingObj = new EhlApiImpl();

                int nonRepeatedCount = findLastNonRepeatedScreen();

                _nonrepeatedScreens = new List<ScreenModel>(_screenModelObjects.Take(nonRepeatedCount));

                _repeatedScreens = new List<ScreenModel>(_screenModelObjects.Skip(nonRepeatedCount).Take(_screenModelObjects.Count));

                populateNonRepeatedScreens();

                populateRepeatedScreens();

                updateBackExcel();

                //foreach (var screenObj in _screenModelObjects)
                //{
                //    populateMainframeScreen(screenObj);
                //}
                return CommonServices.SUCCESS;
            }
            catch (AutomationExceptions e)
            {
                return CommonServices.FAILURE;
            }
        }

        private void updateBackExcel()
        {
            try
            {
                IOService ioService = SimpleIoc.Default.GetInstance<IOService>();

                ioService.updateExcel(excelData);
            }

            catch (AutomationExceptions e)
            {
                throw new AutomationExceptions("Excel Update Failure. Exiting..");
            }
        }

        private void populateNonRepeatedScreens()
        {
            try{
                 foreach (var screenObj in _nonrepeatedScreens)
                  {
                  foreach (var mappingObj in screenObj.Mappings)
                 {
                    if (mappingObj.Identifier.Equals(ScreenHandler.COMMAND))
                    {    
                       // KeyingObj.ExecuteCommand(mappingObj.CommandOrExcelColumn, screenObj.ScreenName);
                        performCommand(mappingObj.IsMandatory, mappingObj.CommandOrExcelColumn, screenObj.ScreenName);
                    }
                    else
                    {
                        if(!string.IsNullOrWhiteSpace(excelData.Rows[0][mappingObj.CommandOrExcelColumn].ToString()))
                    //    KeyingObj.SearchFieldAndPopulate(mappingObj.ScreenField, excelData.Rows[0][mappingObj.CommandOrExcelColumn].ToString());
                            populateField(mappingObj.IsMandatory, mappingObj.ScreenField, excelData.Rows[0][mappingObj.CommandOrExcelColumn].ToString());
                    }

                  }
                }
             //    return CommonServices.SUCCESS; 

            }
            catch (AutomationExceptions e)
            {
                throw new AutomationExceptions("NonRepeatedScreenFailure Exiting..");
            }
        }

        private void populateRepeatedScreens()
        {
            try
            {

                foreach (DataRow currRow in excelData.Rows)
                {
                    currRow[CommonServices.RESULT_SHEET] = populateCurrentRow(currRow);

                }
                //return CommonServices.SUCCESS;
            }
            catch (AutomationExceptions e)
            {
                throw new AutomationExceptions();
            }
        }

        private string populateCurrentRow(DataRow currRow)
        {
            int currScreenLocation = 0;
            try
            {
               
                foreach (var screenObj in _repeatedScreens)
                {
                    currScreenLocation = _repeatedScreens.IndexOf(screenObj);
                    foreach (var mappingObj in screenObj.Mappings)
                    {
                        if (mappingObj.Identifier.Equals(ScreenHandler.COMMAND))
                        {
                            if (!mappingObj.ScreenField.Contains(ScreenHandler.OPTIONAL))
                                performCommand(mappingObj.IsMandatory,mappingObj.CommandOrExcelColumn, mappingObj.ScreenField);
                            else
                                performCommand(mappingObj.IsMandatory,mappingObj.CommandOrExcelColumn, screenObj.ScreenName);
                        }
                        else
                        {
                            if (!string.IsNullOrWhiteSpace(currRow[mappingObj.CommandOrExcelColumn].ToString()))
                              populateField(mappingObj.IsMandatory, mappingObj.ScreenField, currRow[mappingObj.CommandOrExcelColumn].ToString());

                        }
                    }
                }
                string status = KeyingObj.GetStatus();
                _result.SuccessRecordsNos = _result.SuccessRecordsNos+1;
                return CommonServices.SUCCESS + status;
            }
            catch (AutomationExceptions e)
            {
                _result.FailureRecordsNos = _result.FailureRecordsNos + 1;
                string status = KeyingObj.GetStatus();
                resetScreenForNextRow(currScreenLocation);
                return CommonServices.FAILURE+ "Reason: "+status+ " "+ e.Message;
            }
        }

        private void resetScreenForNextRow(int currScreenLocation)
        {
          //  System.Console.WriteLine(currScreenLocation);
           ScreenModel reverseScreen = _repeatedScreens.ElementAt(currScreenLocation);
           string exitCommands = reverseScreen.ExitCommand;
           List<string> commands = exitCommands.Split(',').ToList();
             foreach(string exitCommand in commands)
             {
                 performCommand(true,exitCommand, " ");
             }
        }

        private void populateField(bool mandatory,string fieldName, string fieldValue)
        {
            if (!KeyingObj.SearchFieldAndPopulate(fieldName, fieldValue))
            {
                if (mandatory)
                {
                   throw new AutomationExceptions("Mandatory Field " + fieldName + " Population Failed");
                }
            }
           
        }

        private void performCommand(bool mandatory,string command, string expectedScreen)
        {
            if (!KeyingObj.ExecuteCommand(command, expectedScreen))
                if (mandatory)
                {
                    throw new AutomationExceptions("Command: " + command + " Execution Failed");
                }
   
        }

        private int findLastNonRepeatedScreen()
        {
            int count = 0;
            foreach(var screenObj in _screenModelObjects)
            {
                if(!screenObj.IsRepeatable)
                    count++;
                else
                    break;
            }
            return count;
        }


        private void GetScreensValues()
        {
            foreach (KeyValuePair<string, string> screen in CommonServices.Screens)
            {
                if (!screen.Key.Contains(ScreenHandler.EXCEL_VIEW_NAME))
                    _screenModelObjects.Add(SimpleIoc.Default.GetInstance<ScreenViewModel>(screen.Value).ScreenMapping);
               
            }
             
        }
    }
}
