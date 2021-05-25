using System;
using System.Collections.Generic;

namespace Assessment
{
    public class Patient :Person
    {
        // Creating the properties of a patient.

        public int PatientID { get; set; }

        public int Age { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime? ExitDate { get; set; }

        public Address Address { get; set; }

        public Room Room { get; set; }

        public Doctor Doctor { get; set; }

        // Methods.
        public void GetAllPatients()
        {
            System.Console.WriteLine($"{PatientID,-15}|{FirstName,-20}|{LastName,-20}|{Age,-20}|{EntryDate,-30}|{ExitDate,-30}");
        }

        public void GetPatientNames()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }

}
    


