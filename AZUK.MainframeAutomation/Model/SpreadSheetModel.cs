using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace AZUK.MainframeAutomationRobot.Model
{
    public class SpreadSheetModel : ObservableObject
    {

        private string _fileName;

        private string _selectedsheetName;

        private ObservableCollection<string> _columnNames;

        private List<string> _sheetNames;



        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                Set<string>(()=>this.FileName, ref _fileName,value);
            }
        }

        public string SelectedSheetName
        {
            get
            {
                return _selectedsheetName;
            }
            set
            {
                Set<string>(() => this.SelectedSheetName, ref _selectedsheetName, value);
               

            }
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

        public List<string> SheetNames
        {
            get
            {
                return _sheetNames;
            }
            set
            {
                Set<List<string>>(() => this.SheetNames, ref _sheetNames, value);


            }
        }
    }
}
