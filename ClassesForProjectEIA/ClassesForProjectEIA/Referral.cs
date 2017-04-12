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
        /// <param name="contact"></param>
        /// <param name="address"></param>
        /// <param name="hours"></param>
        /// <param name="authority"></param>
        public Referral(int referralNumber, Patient currentPatient, ContactInformation contact, AddressInformation address, ContactHours hours, ReferringAuthority authority)
            :base (currentPatient, contact, address, hours, authority)
        #endregion
    }
}
