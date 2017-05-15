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
        #region Public Properties

        /// <summary>
        /// The CPR number of the patient being referred
        /// </summary>
        public string Cpr { get; set; }

        /// <summary>
        /// The diagnosis of the patient
        /// </summary>
        public string Diagnose { get; set; }

        /// <summary>
        /// Is true if the card is selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// The suggested treatment type of the system
        /// </summary>
        public string TreatmentType { get; set; }

        #endregion
    }
}
