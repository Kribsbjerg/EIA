using System.Collections.Generic;

namespace EIAUI
{
    /// <summary>
    /// The design-time data for a <see cref="VisitationCardListDesignModel"/> 
    /// </summary>
    public class VisitationCardListDesignModel : VisitationCardListViewModel
    {

        #region Public Properties

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static VisitationCardListDesignModel Instance => new VisitationCardListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public VisitationCardListDesignModel()
        {
            VisitationCards = new List<VisitationCardViewModel>
            {
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
                new VisitationCardViewModel
                {
                    Cpr = 0901644527,
                    Diagnose = "Ondt i hovedet",
                    TreatmentType = "Kaffe",
                },
            };

        }

        #endregion
    }
}
