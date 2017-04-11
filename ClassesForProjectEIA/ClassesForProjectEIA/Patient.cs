using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Patient : Person
    {
        public string Anamnesis { get; private set; }
        public string Diagnosis { get; set; }
        public int Cpr { get; private set; }
        public int Age { get; private set; }

        public Gender PatientGender { get; set; }
        
        public Translator TranslationInformation { get; set; }
        public ReferringAuthority ReferralAuthority { get; set; }
        public ContactHours HoursToContact { get; set; }

        public enum Gender { Male, Female };

        /// <summary>
        /// Hej diller
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

        private int GetAgeOfPatient()
        {
            return int.Parse(Cpr.ToString().Substring(0, 6));
            

        }

        private Gender GetGenderOfPatient() => (Cpr % 10) % 2 == 0 ? Gender.Female : Gender.Male;
    }
}
