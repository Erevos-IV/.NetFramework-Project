using System;
using System.Collections.Generic;

namespace Assessment
{
    public class Address
    {
        // Creating the properties of an Address.

        public int AddressID { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        // methods
        public void GetAddresses()
        {
            System.Console.WriteLine($"{AddressID,-15}|{Name,-20}|{Country,-20}|{City,-20}|{PostalCode,-30}");
        }
        public void GetAddressNames()
        {
            Console.WriteLine($"{Name,-15}");
        }
    }


}
    


