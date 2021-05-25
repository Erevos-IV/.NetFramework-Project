using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    public class View
    {
        // ERROR 
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OOPS, something went wrong! Please Select a visible Number.");
            Console.ResetColor();
        }

        // Every method goes here.

        public static void GetDoctors(List<Doctor> doctors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"DoctorID",-15}|{"First Name",-20}|{"Second name",-20}|{"Age",-20}|{"Salary",-20}");
            foreach (var doc in doctors)
            {
                doc.GetAllDoctors();
            }

        }

        public static void GetPatients(List<Patient> patients, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"PatientID",-15}|{"FirstName",-20}|{"LastName",-20}|{"Age",-20}|{"EntryDate",-30}|{"ExitDate",-30}");
            foreach (var pat in patients)
            {
                pat.GetAllPatients();
            }
        }

        public static void GetAddresses(List<Address> addreses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"AddressID",-15}|{"Name",-20}|{"Country",-20}|{"City",-20}|{"PostalCode",-30}");
            foreach (var add in addreses)
            {
                add.GetAddresses();
            }

        }

        public static void GetRooms(List<Room> rooms, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"RoomID",-15}|{"Title",5}");
            foreach (var room in rooms)
            {
                room.GetAllRooms();
            }

        }

        // Getting patients per Room
        public static void GetPatientPerRoom(List<Room> rooms, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"Room",-15}{"Full Name",20}");
            foreach (var room in rooms)
            {
                room.GetRoomTitle();
                foreach (var patient in room.Patients)
                {
                    Console.Write($"{"",-20}");
                    patient.GetPatientNames();
                }
            }
        }

        // Getting patients per Doctor
        public static void GetPatientPerDoctor(List<Doctor> doctors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"Doctor",-15}{"First Name",-30} {"Last Name",-40}");
            foreach (var doctor in doctors)
            {
                doctor.GetDoctorNames();
                foreach (var patient in doctor.Patients)
                {
                    Console.Write($"{"",-25}");
                    patient.GetPatientNames();
                }
            }
        }

        // Get patients per address
        public static void GetPatientPerAddress(List<Address> addresses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{"Address",-15}{"Full Name",20}");
            
            foreach (var address in addresses)
            {
                address.GetAddressNames();
                foreach (var patient in address.Patients)
                {
                    Console.Write($"{"",-25}");
                    patient.GetPatientNames();
                }
            }
        }


        // Does not working.
        //public static void GetAddressesPerPatient(List<Patient> patients, string message) 
        // {
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine(message);
        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
        //     Console.WriteLine($"{"Full name"}{"Addresses"}");
        //     foreach (var patient in patients)
        //     {
        //         patient.GetPatientNames();
        //        foreach (var address in patient.Address) 
        //         {
        //            address.GetAddressNames();
        //         }
        //     }
        // }

        

        // Filtering Doctors by their first name


        internal static void FilterDoctorsByFirstName(List<Doctor> doctors, string message)
        {
            Console.WriteLine("Give Doctor's First Name");
            string GivenName = Console.ReadLine();
            var FilteredDoctors = doctors.Where(x => x.FirstName.Contains(GivenName)).ToList();

            if (FilteredDoctors.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"There is no Doctor containing the {GivenName}");
                Console.ResetColor();
            }
            else
            {
                View.GetDoctors(FilteredDoctors, message);
            }

        }


        //  Filtering patients by thier age
        internal static void FilterPatientsByAge(List<Patient> patients, string message)
        {
            Console.WriteLine("Give Patient Age");
            string GivenAge = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("First Name | Second Name | Age");
            Console.ResetColor();

            foreach (var pat in patients)
            {
                int age2 = pat.Age;
                string age = Convert.ToString(age2);

                if (GivenAge == age)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{pat.FirstName,-13} {pat.LastName,-13} {pat.Age}");
                    Console.ResetColor();
                }
                
            }
        }

        // Filtering rooms by their tilte and "Numer of patients"
        internal static void FilterRoomsByTitleAndNumberOfPatients(List<Room> rooms, string message)
        {
            Console.WriteLine("Give Room Title");
            string GivenTitle = Console.ReadLine();
            var FilteredRoom = rooms.Where(x => x.Title.Contains(GivenTitle)).ToList();

            // Console.WriteLine("Give Number Of Patients");
            // string GivenNumber = Console.ReadLine();

            // Error with GivenNumber (Patients).
            // FilteredRoom = FilteredRoom.Where(x => x.Patients.Contains(GivenNumber)).Tolist();

            if (FilteredRoom.Count == 0)
            {
                Console.WriteLine($"Error, No Rooms Where Found Containing {GivenTitle}");
            }
            else
            {
                View.GetRooms(FilteredRoom, message);
            }
        }


        // STATS

        internal static void DoctorsCount(List<Doctor> doctors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"We have {doctors.Count()} Doctors in the hostipal.");
            Console.ResetColor();
        }

        internal static void PatientsCount(List<Patient> patients, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"sadly We are treating {patients.Count()} Patients in the hostipal.");
            Console.ResetColor();


        }

        internal static void NumberOfPatientsPerRoom(List<Room> rooms, string message)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Patients Per Room");
            foreach (var room in rooms)
            {
                Console.WriteLine($"At this moment {room.Title} has {room.Patients.Count()} ");
            }

        }

        // Inheritance.
        internal static void GetAllPeople(List<Person> persons, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{"First Name",-15}|{"Last Name",-20}");
            foreach (var per in persons)
            {
                per.GetPersonNames();
            }

        }
    }

}
    


