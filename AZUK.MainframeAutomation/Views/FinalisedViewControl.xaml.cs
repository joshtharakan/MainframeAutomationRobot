using System.Diagnostics;
using System.Windows.Navigation;
using AZUK.MainframeAutomationRobot.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
namespace AZUK.MainframeAutomationRobot.Views
{
    /// <summary>
    /// Interaction logic for ResourcesControl.xaml.
    /// </summary>
    public partial class FinalisedViewControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesControl"/> class.
        /// </summary>
        public FinalisedViewControl()
        {
            InitializeComponent();
           

        }


        // Code


        //void listView_TargetUpdated(object sender, DataTransferEventArgs e)
        //{
        //    var view = LVScreenMapping.View as GridView;
        //    AutoResizeGridViewColumns(view);
        //}

        //static void AutoResizeGridViewColumns(GridView view)
        //{
        //    if (view == null || view.Columns.Count < 1) return;
        //    // Simulates column auto sizing
        //    foreach (var column in view.Columns)
        //    {
        //        // Forcing change
        //        if (double.IsNaN(column.Width))
        //            column.Width = 1;
        //        column.Width = double.NaN;
        //    }
        //}


    }
}
