using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Referral
    {
        /// <summary>
        /// Dumme Jacob
        /// </summary>
        int i;

        #region Constructors
        /// <summary>
        /// Default constructors
        /// </summary>
        /// <param name="referralNumber"></param>
        /// <param name="currentPatient"></param>
        /// <param name="contact"></param>
        /// <param name="address"></param>
        /// <param name="hours"></param>
        /// <param name="authority"></param>
        public Referral(int referralNumber, Patient currentPatient, ReferringAuthority authority)
        {
            ReferralNumber = referralNumber;
            CurrentPatient = currentPatient;
            Authority = authority;
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Holds the referral number of the patient
        /// </summary>
        public int ReferralNumber { get; private set; }

        /// <summary>
        /// Holds the patient of the current referral
        /// </summary>
        public Patient CurrentPatient { get; private set; }

        /// <summary>
        /// Holds the referring authority
        /// </summary>
        public ReferringAuthority Authority { get; private set; }

        #endregion
    }
}
