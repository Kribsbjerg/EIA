using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EIAUI
{
    /// <summary>
    /// A view model for each visitation card in the visitation card list
    /// </summary>
    public class VisitationOverviewViewModel : BaseViewModel
    {
        public VisitationOverviewViewModel()
        {
        }

        public ICommand OpenPopupCommand { get; set; }
        public ICommand ClosePopupCommand { get; set; }


        #region Public Properties

        /// <summary>
        /// The CPR number of the patient being referred
        /// </summary>
        public int Cpr { get; set; }

        /// <summary>
        /// The diagnosis of the patient
        /// </summary>
        public string Diagnose { get; set; }

        #endregion
    }
}
