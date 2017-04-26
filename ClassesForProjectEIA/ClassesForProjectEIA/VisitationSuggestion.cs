using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class VisitationSuggestion
    {
        #region Private Members

        /// <summary>
        /// List of visitation considerations
        /// </summary>
        private List<VisitationConsiderations> _considerationList = new List<VisitationConsiderations>();

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="suggestionReferral"></param>
        /// <param name="suggestionPractitioner"></param>
        /// <param name="suggestionTreatmentFacility"></param>
        /// <param name="suggestionVisitationConsiderations"></param>
        public VisitationSuggestion(Referral suggestionReferral, Practitioner suggestionPractitioner, TreatmentFacility suggestionTreatmentFacility,
                                    VisitationConsiderations suggestionVisitationConsiderations)
        {
            SuggestionReferral = suggestionReferral;
            SuggestionPractitioner = suggestionPractitioner;
            SuggestionTreatmentFacility = suggestionTreatmentFacility;
            SuggestionVisitationConsiderations = suggestionVisitationConsiderations;
        }

        #endregion
        
        #region Public Properties

        public Referral SuggestionReferral { get; set; }
        public Practitioner SuggestionPractitioner { get; set; }
        public TreatmentFacility SuggestionTreatmentFacility { get; set; }
        public VisitationConsiderations SuggestionVisitationConsiderations { get; set; }
        public List<VisitationConsiderations> ConsiderationList { get; }

        #endregion

    }
}
