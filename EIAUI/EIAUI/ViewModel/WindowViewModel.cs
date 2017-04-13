using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EIAUI
{
    class WindowViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The window this viewmodel controls
        /// </summary>
        private Window _window;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            _window = window;
        }

        #endregion


        #region Public Properties

        public int MyProperty { get; set; }

        #endregion

    }
}