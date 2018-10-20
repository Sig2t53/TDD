using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class Form1ViewModel :INotifyPropertyChanged
    {
        //private System.Windows.Forms.Button CalculationButton;

        public string ATextBoxText { get; set; } = string.Empty;
        public string BTextBoxText { get; set; } = string.Empty;
        public string ResultLabelText { get; set; } = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }

        public void CalculationAction()
        {
            int a = Convert.ToInt16(ATextBoxText);
            int b = Convert.ToInt16(BTextBoxText);

            ResultLabelText = Calculation.Sum(a, b).ToString();

            OnPropertyChanged(string.Empty);
        }
    }
}
