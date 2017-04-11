namespace ClassesForProjectEIA
{
    public class AddressInformation
    {
        public string StreetName { get; private set; }
        public string StreetNumber { get; private set; }
        public string City { get; private set; }
        public int ZipCode { get; private set; }
        public string Country { get; set; }

        public AddressInformation(string streetName, string streetNumber, string city, int zipCode, string country)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            ZipCode = zipCode;
            Country = country;
        }
    }
}
