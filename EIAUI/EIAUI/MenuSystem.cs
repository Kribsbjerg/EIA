using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EIAUI
{
    class MenuSystem : BaseViewModel
    {
        private Window _window;
        private string _numberString;

        public MenuSystem(Window window)
        {
            _window = window;
            MyWindow = new WindowProperties();

            CountUp = new RelayCommand(() => TestText = TestText + 1);
        }

        public WindowProperties MyWindow { get; set; }

        public string TestText
        {
            get { return _numberString; }
            set
            {
                _numberString = value.ToString();
            }
        }
        public ICommand CountUp { get; set; }
    }
}