using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class Referral
    {
        public Referral(Patient currentPatient, ContactInformation contact, AddressInformation address, ContactHours hours, ReferringAuthority authority)
            :base (currentPatient, contact, address, hours, authority)
    }
}
