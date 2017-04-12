using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class TreatmentPlan
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
        public TreatmentPlan(TreatmentFacility facility, Referral patientReferral)
        {
            Facility = facility;
            PatientReferral = patientReferral;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Holds information of where the treatment takes place
        /// </summary>
        public TreatmentFacility Facility { get; private set; }

        /// <summary>
        /// Holds the referral of the patient
        /// </summary>
        public Referral PatientReferral { get; private set; }

        //public DateTime TreatmentDay
        //{
        //    get { return _treatmentDay; }
        //    set { if (value.Date < PatientReferral)}
        //}

        #endregion
    }
}
