using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;


namespace AZUK.MainframeAutomationRobot.Model
{
    public class KeyingResultModel
    {
        private string _outcome;
        private int _succesRecordsNos;
        private int _failureRecordsNos;

        public string Outcome
        {
            get
            {
                return _outcome;
            }
            set
            {
                this._outcome = value;
            }
        }

        public int SuccessRecordsNos
        {
            get
            {
                return _succesRecordsNos;
            }

            set
            {
                this._succesRecordsNos = value;
            }

        }
        public int FailureRecordsNos
        {
            get
            {
                return _failureRecordsNos;
            }

            set
            {
                this._failureRecordsNos = value;
            }

        }
    }
}
