using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class Address
    {
        public Address(string cityName, string streetName, int houseNumber, int apartmentNubmer)
        {
            CityName = cityName;
            StreetName = streetName;
            HouseNumber = houseNumber;
            ApartmentNumber = apartmentNubmer;
        }

        public Address()
        {

        }
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
