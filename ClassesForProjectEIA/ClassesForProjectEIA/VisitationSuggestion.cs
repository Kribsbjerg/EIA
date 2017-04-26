using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class VisitationSuggestion
    {
        
        #region Default Constructor

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
        
        #endregion

    }
}
