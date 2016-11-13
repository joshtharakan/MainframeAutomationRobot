
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Allianz">
//   Copyright (c) 2016 JosephTharakan. All rights reserved.
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Windows.Media;
using System.Windows.Controls;
using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System.Windows;
using AZUK.MainframeAutomationRobot.Model;
using AZUK.MainframeAutomationRobot.ViewModel;
using AZUK.MainframeAutomationRobot.Services;
using AZUK.MainframeAutomationRobot.Helpers;


namespace AZUK.MainframeAutomationRobot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
     
        public MainWindow()
        {
            InitializeComponent();
            AppearanceManager.Current.AccentColor = Colors.Lavender;
           
            ContentSource = MenuLinkGroups.First().Links.First().Source;
            
            CommandBinding NewScreendBinding = new CommandBinding(ApplicationCommands.New, NewScreenExecuted, NewScreenCanExecute);
            CommandBinding FinishProcessBinding = new CommandBinding(ApplicationCommands.Save,FinishProcessExecuted,FinishProcessCanExecute);
            this.CommandBindings.Add(NewScreendBinding);
            this.CommandBindings.Add(FinishProcessBinding);
            SetUpServices();
        }

        void FinishProcessExecuted(object target, ExecutedRoutedEventArgs e)
        {
            MainframeConnectionService connImpl = Application.Current.FindResource("MainframeConnection") as MainframeConnectionService;
            KeyingResultModel result = connImpl.UploadToMainframe();
            if(result.Outcome.Contains(CommonServices.SUCCESS))
            {
                string content = "Successfully Submitted to Mainframe and Updated Excel. Please Verify.";
                content+="\n" + "Success: " + result.SuccessRecordsNos;
                content += "\n" + "Failure: " + result.FailureRecordsNos;
               // MessageBox.Show("Successfully Submitted to Mainframe and Updated Excel. Please Verify. ");
                var dlg = new ModernDialog
                {
                    Title = "Output",
                    Content = content
                };
                dlg.Buttons = new Button[] {
                    dlg.OkButton};
              //  dlg.Background = Brushes.Beige;
                dlg.ShowDialog();

            }
            else
            {
                //MessageBox.Show("Error while submitting to Mainframe. Please check. ");// MessageBox.Show("Successfully Submitted to Mainframe and Updated Excel. Please Verify. ");
                var dlg = new ModernDialog
                {
                    Title = "Output",
                    Content = "Error while submitting to Mainframe. Please check."
                };
                dlg.Buttons = new Button[] {
                    dlg.OkButton};
             //   dlg.Background = Brushes.Beige;
                dlg.ShowDialog();

            }
        }

        void FinishProcessCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
            //ViewModelLocator vmLocator = Application.Current.FindResource("Locator") as ViewModelLocator;
            //foreach (KeyValuePair<string, string> screen in CommonServices.Screens)
            //{
            //    if (screen.Key.Contains())
            //        string excelName = .SelectedFile.FileName.ToString();


            string excelViewKey;
            if (CommonServices.Screens.TryGetValue(ScreenHandler.EXCEL_VIEW_NAME, out excelViewKey))
            {
                string fileName = SimpleIoc.Default.GetInstance<ExcelUploadViewModel>(excelViewKey).SelectedFile.SelectedSheetName;
                if (!string.IsNullOrWhiteSpace(fileName))
                    e.CanExecute = true;
            }
        }

        void NewScreenExecuted(object target, ExecutedRoutedEventArgs e)
        {
            ViewModelLocator vmLocator = Application.Current.FindResource("Locator") as ViewModelLocator;
            Link newScreenLink = new Link();
            Dictionary<string, Uri> newScreen = vmLocator.CreateScreens();
            newScreenLink.DisplayName = newScreen.Keys.First();
            newScreenLink.Source = newScreen[newScreen.Keys.First()];
            MenuLinkGroups.First().Links.Add(newScreenLink);
            
        }

        void NewScreenCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void SetUpServices()
        {
            var ioService = new IOServiceImpl();
            SimpleIoc.Default.Register<IOService>(() => ioService);
            var mainframeConnectionService = new MainframeConnectionServiceImpl();
            SimpleIoc.Default.Register<MainframeConnectionService>(() => mainframeConnectionService);

        }
    }
}
