using System;

namespace ClassesForProjectEIA
{
    public class AddressInformation
    {
        #region Private Members

        /// <summary>
        /// Backingfield for Zipcode
        /// </summary>
        int _zipcode;

        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="streetName"></param>
        /// <param name="streetNumber"></param>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>
        public AddressInformation(string streetName, string streetNumber, string city, int zipCode, string country)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            ZipCode = zipCode;
            Country = country;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Property holding the street name for the house, facility or hospital
        /// </summary>
        public string StreetName { get; private set; }

        /// <summary>
        /// Property holding the street number including floor and letter
        /// </summary>
        public string StreetNumber { get; private set; }

        /// <summary>
        /// Property holding the city where the house, facility or hospital
        /// </summary>
        public string City { get; private set; }

        /// <summary>
        /// Property holding the zip code for the city
        /// </summary>
        public int ZipCode
        {
            get { return _zipcode; }
            private set
            {
                if (value <= 1000 && value >= 9990)
                   _zipcode = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Property holding the country of the house, facility or hospital
        /// </summary>
        public string Country { get; set; }
        
        #endregion
    }
}
