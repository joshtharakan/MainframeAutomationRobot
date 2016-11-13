using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using AZUK.MainframeAutomationRobot.Services;
using AZUK.MainframeAutomationRobot.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AZUK.MainframeAutomationRobot.Services;
using AZUK.MainframeAutomationRobot.Helpers;
namespace AZUK.MainframeAutomationRobot.ViewModel
{
    /// <summary>
    /// The resources view model.
    /// </summary>
    public class ScreenViewModel : ModernViewModelBase
    {
       // private readonly IDataService _dataService;
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesViewModel"/> class. 
        /// </summary>

        private IOService _ioService;
        private SpreadSheetModel _selectedFile;
        private ScreenModel _screenMapping;
        private MappingModel _selectedMapping;
        private string _selectedColumnName;
        private ObservableCollection<string> _columnNames;
        public ICommand AddCommand { get; private set; }
        public ICommand AddColumnCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }

        private void AddNewCommandEntry()
        {
            MappingModel newCommandMapping = new MappingModel();
            newCommandMapping.Identifier = ScreenHandler.COMMAND;
            newCommandMapping.CommandOrExcelColumn = "";
            newCommandMapping.ScreenField = ScreenHandler.OPTIONAL;
            ScreenMapping.Mappings.Add(newCommandMapping);

        }

        private void RemovSelectedEntry()
        {
            if (SelectedMapping != null)
            {
                ScreenMapping.Mappings.Remove(SelectedMapping);
            }

        }

        private void AddColumnEntry()
        {

            MappingModel newColumnMapping = new MappingModel();
            newColumnMapping.Identifier = ScreenHandler.COLUMN;
            newColumnMapping.CommandOrExcelColumn = SelectedColumnName;
            newColumnMapping.ScreenField = SelectedColumnName;
            ScreenMapping.Mappings.Add(newColumnMapping);

        }


        public ObservableCollection<string> ColumnNames
        {
            get
            {
                return _columnNames;      
            }
            set
            {
                _columnNames = value;
                RaisePropertyChanged("ColumnNames");
            }
        }


        public string SelectedColumnName
        {
            get
            {
                return _selectedColumnName;
            }

            set
            {
                _selectedColumnName = value;
                RaisePropertyChanged("SelectedColumnName");
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

    
        public ScreenModel ScreenMapping
        {
            get
            {
                return _screenMapping;
            }

            set
            {
                _screenMapping = value;
                RaisePropertyChanged("ScreenMapping");

            }
        }

        public MappingModel SelectedMapping
        {
            get
            {
                return _selectedMapping;
            }

            set
            {
                _selectedMapping = value;
                RaisePropertyChanged("SelectedMapping");

            }
        }

        public ScreenViewModel(IOService ioService)
        {
            this._ioService = ioService;
            _selectedFile = _ioService.getCurrentExcelFile();
            _screenMapping = new ScreenModel();
            _selectedMapping = new MappingModel();
            _columnNames = new ObservableCollection<string>();
            if(SelectedFile.ColumnNames != null)
                _columnNames = SelectedFile.ColumnNames;
            
            NavigatingFromCommand = new RelayCommand(NavigatingFrom);
            NavigatedFromCommand = new RelayCommand(NavigatedFrom);
            NavigatedToCommand = new RelayCommand(NavigatedTo);
            FragmentNavigationCommand = new RelayCommand(FragmentNavigation);
            LoadedCommand = new RelayCommand(LoadData);
            IsVisibleChangedCommand = new RelayCommand(VisibilityChanged);
            AddCommand = new RelayCommand(AddNewCommandEntry);
            RemoveCommand = new RelayCommand(RemovSelectedEntry);
            AddColumnCommand = new RelayCommand(AddColumnEntry);
        }

        /// <summary>
        /// Visibilities the changed.
        /// </summary>
        private void VisibilityChanged()
        {
            Debug.WriteLine("ScreenViewModel - VisibilityChanged");
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
         
            Debug.WriteLine("ScreenViewModel - LoadData");
           
        }

        /// <summary>
        /// Navigateds from.
        /// </summary>
        private void NavigatedFrom()
        {
            // called when we navigated to another view
            Debug.WriteLine("ScreenViewModel - NavigatedFrom");
        }

        /// <summary>
        /// Navigateds to.
        /// </summary>
        private void NavigatedTo()
        {
            _selectedFile = _ioService.getCurrentExcelFile();
            ColumnNames = SelectedFile.ColumnNames;
            // called when we navigate to the view related with this view model.
            Debug.WriteLine("ScreenViewModel - NavigatedTo");
        }

        /// <summary>
        /// Fragments the navigation.
        /// </summary>
        private void FragmentNavigation()
        {
            Debug.WriteLine("ScreenViewModel - FragmentNavigation");
        }

        /// <summary>
        /// Navigatings from.
        /// </summary>
        private void NavigatingFrom()
        {
            // Called when we will navigate to new view
            Debug.WriteLine("ScreenViewModel - NavigatingFrom");
        }
    }
}
