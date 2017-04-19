﻿namespace EIAUI
{
    /// <summary>
    /// The design-time data for a <see cref="VisitationCardViewModel"/> 
    /// </summary>
    public class VisitationCardDesignModel : VisitationCardViewModel
    {
        #region Public Properties

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static VisitationCardDesignModel Instance => new VisitationCardDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public VisitationCardDesignModel()
        {
            Cpr = 0901644527;
            Diagnose = "Ondt i hovedet";
            TreatmentType = "Kaffe";
        }

        #endregion
    }
}
