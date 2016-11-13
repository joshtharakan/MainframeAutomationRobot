// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Allianz">
//   Copyright (c) 2016 Joseph Tharakan. All rights reserved.
// </copyright>
// <summary>
//   Interaction logic for App.xaml.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Text;
using System.Windows;
using System.Runtime.ExceptionServices;
namespace AZUK.MainframeAutomationRobot
{
    /// <summary>
    /// Interaction logic for App.xaml.
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            //AppDomain.CurrentDomain.FirstChanceException += OnFirstChanceException;
        }

        //private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    var ex = e.ExceptionObject as Exception;

        //    if (ex == null)
        //    {
        //        MessageBox.Show(string.Format("Null Exception: {0}", e));
        //        return;
        //    }

        //    var sb = new StringBuilder();
        //    sb.AppendLine("An unhandled exception was encountered. Terminating now.");
        //    sb.AppendLine();
        //    sb.AppendLine("Exception:");
        //    sb.AppendLine(ex.Message);

        //    MessageBox.Show(sb.ToString(), "Whoops...", MessageBoxButton.OK, MessageBoxImage.Error);

        //    Environment.Exit(1);
        //}
        //private void OnFirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        //{
        //    var ex = e.Exception as Exception;

        //    if (ex == null)
        //    {
        //        MessageBox.Show(string.Format("Null Exception: {0}", e));
        //        return;
        //    }

        //    var sb = new StringBuilder();
        //    sb.AppendLine("An unhandled exception was encountered. Terminating now.");
        //    sb.AppendLine();
        //    sb.AppendLine("Exception:");
        //    sb.AppendLine(ex.Message);

        //    MessageBox.Show(sb.ToString(), "Whoops...", MessageBoxButton.OK, MessageBoxImage.Error);

        //    Environment.Exit(1);
        //}

    }
}
