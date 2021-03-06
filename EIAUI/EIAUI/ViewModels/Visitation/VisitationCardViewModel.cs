﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EIAUI
{
    /// <summary>
    /// A view model for each visitation card in the visitation card list
    /// </summary>
    public class VisitationCardViewModel : BaseViewModel
    {
        public VisitationCardViewModel()
        {
            
        }

        public ICommand OpenPopupCommand { get; set; }
        public ICommand ClosePopupCommand { get; set; }
        public ICommand SaveNote { get; set; }

        public bool PopupOpen { get; set; }

        public double PopUpX { get; set; }
        public double PopUpY { get; set; }
        public string PopUpText { get; set; }

        

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
        /// The suggested type of treatment for the patient
        /// </summary>
        public string TreatmentType { get; set; }

        /// <summary>
        /// The cause of the referral
        /// </summary>
        public string ReferralCause { get; set; }

        /// <summary>
        /// The suggested date and time for the treatment
        /// </summary>
        public DateTime TreatmentTime { get; set; }

        /// <summary>
        /// Property is true if EIA is certain of the suggestion within a given threshold
        /// </summary>
        public bool IsCertain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SpecialConditions { get; set; }

        /// <summary>
        /// The color of the suggestion in string format
        /// </summary>
        public string SuggestionColor => IsCertain ? "#43da86" : "#ffb721"; 

        #endregion
    }
}
