using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using AZUK.MainframeAutomationRobot.Model;
using AZUK.MainframeAutomationRobot.Services;
using System.Windows.Input;
using System.Collections.Generic;
using System.ComponentModel;
namespace AZUK.MainframeAutomationRobot.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class FinalisedViewModel : ModernViewModelBase
    {

        public ICommand BrowseCommand { get; private set; }
        private IOService _ioService;

        private SpreadSheetModel _selectedFile;
        private string _sheetName;

        /// <summary>
        /// Initializes a new instance of the <see cref="StepsViewModel"/> class. 
        /// </summary>
        public FinalisedViewModel(IOService ioService)
        {
            SelectedFile = new SpreadSheetModel();
            NavigatingFromCommand = new RelayCommand(NavigatingFrom);
            NavigatedFromCommand = new RelayCommand(NavigatedFrom);
            NavigatedToCommand = new RelayCommand(NavigatedTo);
            FragmentNavigationCommand = new RelayCommand(FragmentNavigation);
            LoadedCommand = new RelayCommand(LoadData);
            IsVisibleChangedCommand = new RelayCommand(VisibilityChanged);
            BrowseCommand = new RelayCommand(OpenFile);
            this._ioService = ioService;
   
        }
      
        

        public string SheetName
        {
            get
            {
                return _sheetName;
            }

            set
            {
                _sheetName = value;
                RaisePropertyChanged("SheetName");
                SelectedFile.SelectedSheetName = _sheetName;
                if(_sheetName != null)
                    CheckForSheetNameChange();
            }

        }

        public SpreadSheetModel SelectedFile
        {
            get
            {
                return _selectedFile;
            }

            set
            {
                _selectedFile = value;
                RaisePropertyChanged("SelectedFile");
               
            }
        }

        private void OpenFile()
        {
            SelectedFile.SheetNames = null;
            SelectedFile.FileName = _ioService.OpenFileDialog(@"C:\Executables");

            if (SelectedFile.FileName == "")
            {
                SelectedFile.FileName = string.Empty;
               

            }
            else
            {
                SelectedFile.SheetNames = _ioService.GetSheetNames();
                _sheetName = string.Empty;
            }
        }

        public void CheckForSheetNameChange()
        {
            
     //       SelectedFile.ColumnNames.Clear();
            SelectedFile.ColumnNames = new ObservableCollection<string>(_ioService.GetColumnNames(SelectedFile.SelectedSheetName));
        }

       
        /// <summary>
        /// Visibilities the changed.
        /// </summary>
        private void VisibilityChanged()
        {
            Debug.WriteLine("ResourcesViewModel - VisibilityChanged");
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            Debug.WriteLine("StepsViewModel - LoadData");
        }

        /// <summary>
        /// Navigateds from.
        /// </summary>
        private void NavigatedFrom()
        {
            // called when we navigated to another view
            Debug.WriteLine("StepsViewModel - NavigatedFrom");
        }

        /// <summary>
        /// Navigateds to.
        /// </summary>
        private void NavigatedTo()
        {
            // called when we navigate to the view related with this view model.
            Debug.WriteLine("StepsViewModel - NavigatedTo");
        }

        /// <summary>
        /// Fragments the navigation.
        /// </summary>
        private void FragmentNavigation()
        {
            Debug.WriteLine("StepsViewModel - FragmentNavigation");
        }

        /// <summary>
        /// Navigatings from.
        /// </summary>
        private void NavigatingFrom()
        {
            // Called when we will navigate to new view
            Debug.WriteLine("StepsViewModel - NavigatingFrom");
        }
    }
}