using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Referral
    {
        #region Constructors
        /// <summary>
        /// Default constructors
        /// </summary>
        /// <param name="referralNumber"></param>
        /// <param name="currentPatient"></param>
        /// <param name="authority"></param>
        /// <param name="anamnesis"></param>
        /// <param name="pregnancy"></param>
        /// <param name="allergiesAndMedicine"></param>
        /// <param name="dato"></param>
        /// <param name="other"></param>
        public Referral(int referralNumber, Patient currentPatient, ReferringAuthority authority, string anamnesis, string pregnancy, string allergiesAndMedicine, DateTime dato, string other)
        {
            ReferralNumber = referralNumber;
            CurrentPatient = currentPatient;
            Authority = authority;
            Anamnesis = anamnesis;
            Pregnancy = pregnancy;
            AllergiesAndMedicine = allergiesAndMedicine;
            Dato = dato;
            Other = other;
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

        /// <summary>
        /// Holds the anamnesis 
        /// </summary>
        public string Anamnesis { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Pregnancy { get; private set; }

        /// <summary>
        /// Holds information about allergies / medicine that are relevant
        /// </summary>
        public string AllergiesAndMedicine { get; private set; }

        /// <summary>
        /// The date of the referral
        /// </summary>
        public DateTime Dato { get; private set; }

        /// <summary>
        /// Holds information about other considerations about the referal
        /// </summary>
        public string Other { get; private set; }

        #endregion
    }
}
