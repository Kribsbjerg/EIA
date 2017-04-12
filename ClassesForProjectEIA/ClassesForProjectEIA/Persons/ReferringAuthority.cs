namespace ClassesForProjectEIA
{
    class ReferringAuthority : Person
    {
        #region Constructors

        public ReferringAuthority(string name, ContactInformation contact, AddressInformation address,
                                  ContactHours hoursToContact) 
            : base(name, contact, address)
        {
            HoursToContact = hoursToContact;
        }
        #endregion

        #region Public Properties

        public ContactHours HoursToContact { get; set; }

        #endregion
    }
}
