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
            SelectCard = new RelayCommand(() => IsSelected = true);
        }

        #region Commands

        public ICommand SelectCard { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The CPR number of the patient being referred
        /// </summary>
        public int Cpr { get; set; }

        /// <summary>
        /// The diagnosis of the patient
        /// </summary>
        public string Diagnose { get; set; }

        /// <summary>
        /// Is true if the card is selected
        /// </summary>
        public bool IsSelected { get; set; }

        #endregion
    }
}
