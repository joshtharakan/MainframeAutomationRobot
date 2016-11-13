// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModelLocator.cs" company="saramgsilva">
//   Copyright (c) 2014 saramgsilva. All rights reserved.
// </copyright>
// <summary>
//   This class contains static references to all the view models in the
//   application and provides an entry point for the bindings.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using AZUK.MainframeAutomationRobot.Helpers;
using AZUK.MainframeAutomationRobot.Services;


namespace AZUK.MainframeAutomationRobot.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        //public ModernViewModelBase CurrentViewModel;

        public Dictionary<string, Uri> CreateScreens()
        {
            int CurrScreenCount = CommonServices.Historic.Count;
            CurrScreenCount++;
            string NewScreenName = String.Format("Screen{0}", CurrScreenCount.ToString());
            CommonServices.Historic.Add(NewScreenName);
            Dictionary<string, Uri> newScreen = new Dictionary<string, Uri>();
            newScreen.Add(NewScreenName, ScreenHandler.returnScreenUri(NewScreenName));
            return newScreen;
        }

        



        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
         

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ExcelUploadViewModel>();
             SimpleIoc.Default.Register<ScreenViewModel>();
        }

        public ModernViewModelBase GetCurrentViewModel(string UserControlName)
        {

            if (UserControlName == ScreenHandler.EXCEL_VIEW_NAME)
            {
                return SimpleIoc.Default.GetInstance<ExcelUploadViewModel>(CommonServices.ConfigureOrRetrieve(UserControlName));
            }
            else
            {
                return SimpleIoc.Default.GetInstance<ScreenViewModel>(CommonServices.ConfigureOrRetrieve(UserControlName));
            }
       
        }

 




       
        /// <summary>
        /// Cleanups this instance.
        /// </summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}