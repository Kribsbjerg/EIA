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

        #region Constructors

        public VisitationOverviewViewModel()
        {
            OpenNoteField = new RelayCommand(() => ChangeNoteFieldState());
        }

        #endregion


        public ICommand OpenNoteField { get; set; }


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

        public string ReferralCause { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string Doctor { get; set; }

        public bool NeedsTranslator { get; set; }

        public string TranslatorLanguage { get; set; }

        public bool IsPinned { get; set; }

        public bool IsNoteOpen { get; set; }

        public bool NoteReceived { get; set; }

        public string SecretaryNote { get; set; }
        
        public string Category { get; set; }

        public bool IsActive { get; set; } = true;

        public string TextToDisplay { get; set; }
        
        #endregion

        #region Private Methods

        public void ChangeNoteFieldState()
        {
            IsNoteOpen = !IsNoteOpen;
        }

        #endregion
    }
}
