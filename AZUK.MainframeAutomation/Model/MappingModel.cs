using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;

namespace AZUK.MainframeAutomationRobot.Model
{
    public class MappingModel : ObservableObject
    {
        private string _identifier;

        private bool _isMandatory;

        private string _commandOrExcelColumn;

        private string _screenField;

        public MappingModel()
        {
            _isMandatory = true;
        }
        public bool IsMandatory
        {
            get
            {
                return _isMandatory;
            }

            set
            {
                Set<bool>(() => this.IsMandatory, ref _isMandatory, value);
            }
        }

        public string Identifier
        {
            get
            {
                return _identifier;
            }
            set
            {
                Set<string>(() => this.Identifier, ref _identifier, value);
            }
        }


        public string CommandOrExcelColumn
        {
            get
            {
                return _commandOrExcelColumn;
            }
            set
            {
                Set<string>(() => this.CommandOrExcelColumn, ref _commandOrExcelColumn, value);
            }
        }



        public string ScreenField
        {
            get
            {
                return _screenField;
            }
            set
            {
                Set<string>(() => this.ScreenField, ref _screenField, value);
            }
        }

    }
}
