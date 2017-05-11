namespace EIAUI
{
    /// <summary>
    /// The design-time data for a <see cref="VisitationCardViewModel"/> 
    /// </summary>
    public class VisitationOverviewDesignModel : VisitationOverviewViewModel
    {
        #region Public Properties

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static VisitationOverviewDesignModel Instance => new VisitationOverviewDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public VisitationOverviewDesignModel()
        {
            Cpr = 0901644527;
            Diagnose = "DI 10 - Blodtryksforhøjelse af ukendt årsag. \n\nDE 659 - Fedme u spec.";
        }

        #endregion
    }
}
