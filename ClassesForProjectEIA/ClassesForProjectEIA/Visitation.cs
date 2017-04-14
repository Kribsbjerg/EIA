using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Visitation
    {
        #region Private Members

        private DateTime _treatmentDay;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="facility"></param>
        /// <param name="patientReferral"></param>
        /// <param name="patientPractitioner"></param>
        public Visitation(TreatmentFacility facility, Referral patientReferral, Practitioner treatingPractitioner)
        {
            Facility = facility;
            PatientReferral = patientReferral;
            TreatingPractitioner = treatingPractitioner;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Holds information of where the treatment takes place
        /// </summary>
        public TreatmentFacility Facility { get; private set; }

        public Practitioner TreatingPractitioner { get; private set; }

        public Referral PatientReferral { get; set; }

        //public DateTime TreatmentDay
        //{
        //    get { return _treatmentDay; }
        //    set { if (value.Date < PatientReferral.)}
        //}

        #endregion
    }
}
