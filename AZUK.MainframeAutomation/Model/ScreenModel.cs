using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
namespace AZUK.MainframeAutomationRobot.Model
{
    public class ScreenModel : ObservableObject
    {
        private string _screenName;

        private string _exitCommand;

        private bool _isRepeatable;

        private List<string> _entries;


        public ObservableCollection<MappingModel> Mappings { get; set; }



        public ScreenModel()
        {
            Mappings = new ObservableCollection<MappingModel>();
            _isRepeatable = false;
        }


        public bool IsRepeatable
        {
            get
            {
                return _isRepeatable;
            }

            set
            {
                Set<bool>(() => this.IsRepeatable, ref _isRepeatable, value);
            }
        }

        public string ScreenName
        {
            get
            {
                return _screenName;
            }
            set
            {
                Set<string>(() => this.ScreenName, ref _screenName, value);
            }
        }

        public string ExitCommand
        {
            get
            {
                return _exitCommand;
            }
            set
            {
                Set<string>(() => this.ExitCommand, ref _exitCommand, value);
            }
        }

        public List<string> Entries
        {
            get
            {
                return _entries;
            }
            set
            {
                Set<List<string>>(() => this.Entries, ref _entries, value);


            }
        }


        
    }
}
