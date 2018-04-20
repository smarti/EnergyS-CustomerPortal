using System;

namespace Data.Entities
{
    public class Address
    {
        //Primary key
        public int AddressId { get; set; }

        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}