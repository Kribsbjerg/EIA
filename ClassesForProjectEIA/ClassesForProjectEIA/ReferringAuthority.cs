using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesForProjectEIA
{
    class ReferringAuthority : Person
    {
        #region Constructors

        public ContactHours HoursToContact { get; set; }

        public ReferringAuthority(string name, ContactInformation contact, AddressInformation address,
                                  ContactHours hoursToContact) 
            : base(name, contact, address)
        {
            HoursToContact = hoursToContact;
        }
        #endregion
    }
}
