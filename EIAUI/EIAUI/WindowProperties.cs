using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EIAUI
{
    class WindowProperties : BaseViewModel
    {
        public WindowProperties()
        {
            BorderThickness = new Thickness(10);
        }

        public Thickness BorderThickness { get; set; }
    }
}
