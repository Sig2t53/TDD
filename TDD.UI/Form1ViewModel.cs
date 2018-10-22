using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class Form1ViewModel :ViewModelBase
    {
        private IDB _db;

        public Form1ViewModel(IDB db)
        {
            _db = db;
        }

        private string _aTextBoxText = string.Empty;
        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set { SetProperty(ref _aTextBoxText, value); }
        }

        private string _bTextBoxText = string.Empty;
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set { SetProperty(ref _bTextBoxText, value); }
        }

        private string _resultLabelText = string.Empty;
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set { SetProperty(ref _resultLabelText, value); }
        }

        public void CalculationAction()
        {
            int a = Convert.ToInt16(ATextBoxText);
            int b = Convert.ToInt16(BTextBoxText);

            int dbValue = _db.getDBValue();
            ResultLabelText = (Calculation.Sum(a, b) + dbValue).ToString();
        }
    }
}
