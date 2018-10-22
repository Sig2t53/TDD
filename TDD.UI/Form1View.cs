using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.UI
{
    public partial class Form1View : Form
    {
        private Form1ViewModel _viewModel = new Form1ViewModel(new DB());
        public Form1View()
        {
            InitializeComponent();
            ATextBox.DataBindings.Add("Text", _viewModel, "ATextBoxText");
            BTextBox.DataBindings.Add("Text", _viewModel, "BTextBoxText");
            ResultLabel.DataBindings.Add("Text", _viewModel, "ResultLabelText");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.CalculationAction();
        }
    }
}
