namespace ClassesForProjectEIA
{
    class Patient : Person
    {
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// Calls <see cref="GetAgeOfPatient"/> that returns the age for the patient
        /// Calls <see cref="GetGenderOfPatient"/> that returns an enum with the gender of a patient 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contact"></param>
        /// <param name="address"></param>
        /// <param name="anamnesis"></param>
        /// <param name="diagnosis"></param>
        /// <param name="cpr"></param>
        /// <param name="translationInformation"></param>
        /// <param name="referralAuthority"></param>
        /// <param name="hoursToContact"></param>
        public Patient(string name, ContactInformation contact, AddressInformation address, 
                       string anamnesis, string diagnosis, int cpr, Translator translationInformation,
                       ReferringAuthority referralAuthority, ContactHours hoursToContact)
            :base(name, contact, address)
        {
            Anamnesis = anamnesis;
            Diagnosis = diagnosis;
            Cpr = cpr;
            Age = GetAgeOfPatient();
            PatientGender = GetGenderOfPatient();
            TranslationInformation = translationInformation;
            ReferralAuthority = referralAuthority;
            HoursToContact = hoursToContact;
        }

        #endregion

        #region Enums

        /// <summary>
        /// Enumerator for the gender of a patient
        /// </summary>
        public enum Gender { Male, Female };

        #endregion

        #region Public Properties

        /// <summary>
        /// Property holding the medical history of a patient (Anamnesis)
        /// </summary>
        public string Anamnesis { get; private set; }
        /// <summary>
        /// Property holding the diagnosis of a patient
        /// </summary>
        public string Diagnosis { get; set; }
        /// <summary>
        /// The social security number of the  patient
        /// </summary>
        public int Cpr { get; private set; }
        /// <summary>
        /// The age of the patient
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Property holding the gender of the patient
        /// </summary>
        public Gender PatientGender { get; set; }

        /// <summary>
        /// Property holding translator information about the patient
        /// </summary>
        public Translator TranslationInformation { get; set; }
        /// <summary>
        /// Property holding information about referral authority
        /// </summary>
        public ReferringAuthority ReferralAuthority { get; set; }
        /// <summary>
        /// Property holding the hours the patient is possible to contact
        /// </summary>
        public ContactHours HoursToContact { get; set; }

        #endregion

        #region Private methods

        /// <summary>
        /// Returns the age of the patient
        /// </summary>
        /// <returns></returns>
        private int GetAgeOfPatient() => 20;

        /// <summary>
        /// Returns the gender of the patient based on the social security number
        /// Female is even numbered in the last digit, male uneven. 
        /// </summary>
        /// <returns></returns>
        private Gender GetGenderOfPatient() => (Cpr % 10) % 2 == 0 ? Gender.Female : Gender.Male;

        #endregion
    }
}
