using System.Collections.Generic;

namespace Assessment
{
    public class Doctor :Person
    {
        // Creating the properties of a Doctor.

        public int DoctorID { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();


        // Methods.
        public void GetAllDoctors()
        {
            System.Console.WriteLine($"{DoctorID,-15}|{FirstName,-20}|{LastName,-20}|{Age,-20}|{Salary,-20}");
        }

        public void GetDoctorNames()
        {
            System.Console.WriteLine($"{FirstName} {LastName}");
        }


    }




}
    


