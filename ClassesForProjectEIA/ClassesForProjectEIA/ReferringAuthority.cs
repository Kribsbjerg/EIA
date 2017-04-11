﻿namespace ClassesForProjectEIA
{
    class ReferringAuthority : Person
    {
        public ContactHours HoursToContact { get; set; }

        public ReferringAuthority(string name, ContactInformation contact, AddressInformation address,
                                  ContactHours hoursToContact) 
            : base(name, contact, address)
        {
            HoursToContact = hoursToContact;
        }
    }
}
