using System;

namespace EncapsulationWithOnlineOrdering
{
    public class Address
    {
        private string street;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string street, string city, string stateProvince, string country)
        {
            this.street = street;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return country == "USA";
        }

        public string GetAddressString()
        {
            return $"{street}, {city}, {stateProvince}, {country}";
        }
    }
}
