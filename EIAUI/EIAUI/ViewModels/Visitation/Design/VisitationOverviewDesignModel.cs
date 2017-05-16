using System.Windows.Input;

namespace EIAUI
{
    /// <summary>
    /// The design-time data for a <see cref="VisitationCardViewModel"/> 
    /// </summary>
    public class VisitationOverviewDesignModel : VisitationOverviewViewModel
    {
        public static VisitationOverviewDesignModel Instance => new VisitationOverviewDesignModel();

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public VisitationOverviewDesignModel()
        {
            Cpr = "01";
            Diagnose = "DI 10 - Blodtryksforhøjelse af ukendt årsag. \n\nDE 659 - Fedme u spec.";
        }
        
        #endregion

    }
}
