namespace ClassesForProjectEIA
{
    class TreatmentFacility
    {
        #region Constructors

        public TreatmentFacility(string facilityName, AddressInformation facilityAddress, ContactInformation facilityContactInformation, ContactHours facilityHours)
        {
            FacilityName = facilityName;
            FacilityAddress = facilityAddress;
            FacilityContactInformation = facilityContactInformation;
            FacilityHours = facilityHours;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Holds the name of the facility
        /// </summary>
        public string FacilityName { get; set; }

        /// <summary>
        /// Holds the address of the facility
        /// </summary>
        public AddressInformation FacilityAddress { get; set; }

        /// <summary>
        /// Holds the contact information of the facility
        /// </summary>
        public ContactInformation FacilityContactInformation { get; set; }

        /// <summary>
        /// Holds the contact hours of the facility
        /// </summary>
        public ContactHours FacilityHours { get; set; }

        #endregion
    }
}
