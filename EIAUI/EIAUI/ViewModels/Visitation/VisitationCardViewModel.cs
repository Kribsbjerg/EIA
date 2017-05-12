using System;
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
        Button _button;

        public VisitationCardViewModel()
        {
            OpenPopupCommand = new RelayParameterCommand((parameter) => runButton((Button)parameter));
            ClosePopupCommand = new RelayCommand(() => PopupOpen = false);
        }

        public ICommand OpenPopupCommand { get; set; }
        public ICommand ClosePopupCommand { get; set; }

        public bool PopupOpen { get; set; }

        public double PopUpX { get; set; }
        public double PopUpY { get; set; }
        public string PopUpText { get; set; }

        public void runButton(Button button)
        {
            _button = button;
            Point location = _button.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0));
            PopUpX = -40 - (Application.Current.MainWindow.Width - 700) / 2;
            PopUpY = location.Y > 180 ? -140 : 0;
            PopUpText = $"X: {location.X}   Y: {location.Y}";
            PopupOpen = true;
            //System.Windows.Forms.MessageBox.Show(Application.Current.MainWindow.Width.ToString());
        }

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
