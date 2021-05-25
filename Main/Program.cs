using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();

            const int first = -40;
            const int second = -40;
            const int third = -50;
            const int fourth = -40;
            const int fifth = -50;
            string input;
            do
            {
                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Choose an option");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine($"{"STATS",first} {"Advanced Stats",second} {"Filterings", third} { "12- Number Of Doctors",fourth} {"15- Doctors Ordered by Name Ascending", fifth}");
                Console.WriteLine($"{"1- Doctors", first} {"5- Patients Per Room",second} {"9- Filter Doctors By First Name", third} {"13- Number Of Patients", fourth} {"16- Addresses Ordered By Name Descending", fifth}");
                Console.WriteLine($"{"2- Patients",first} {"6- Patients per Doctor",second} {"10-Filter Patients By Age", third } {"14- Number of Patients Per Room", fourth} {"17- Patients Ordered By Age Ascending", fifth}");
                Console.WriteLine($"{"3- Addresses",first} {"7- Patients Per Address", second} {"11- Filter Rooms By Name And Number of patients",third} {"", fourth} {"18- Rooms Ordered By Title Ascending", fifth}");
                Console.WriteLine($"{"4- Rooms",first} {"8- Address Per Patient", second} ");
                Console.WriteLine($"{"19- All People By Inheritance", second}");
              

                input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1": View.GetDoctors(db.Doctors,"All Doctors"); break;
                    case "2": View.GetPatients(db.Patients, "All Patients"); break;
                    case "3": View.GetAddresses(db.Addresses, "All Addresses"); break;
                    case "4": View.GetRooms(db.Rooms, "All Rooms"); break;
                    case "5": View.GetPatientPerRoom(db.Rooms, "Patients Per Room"); break;
                    case "6": View.GetPatientPerDoctor(db.Doctors, "Patient Per Doctor");  break;
                    case "7": View.GetPatientPerAddress(db.Addresses, "Patient Per Address"); break;
                    //case "8": View.GetAddressesPerPatient(db.Patients, "Addresses Per Patient"); break;
                    case "9": View.FilterDoctorsByFirstName(db.Doctors, "Doctors Filtered By First Name"); break;
                    case "10": View.FilterPatientsByAge(db.Patients, "Patients Filtered By Age"); break; 
                    case "11": View.FilterRoomsByTitleAndNumberOfPatients(db.Rooms, "Filtered Rooms"); break;
                    case "12": View.DoctorsCount(db.Doctors, "Number Of Doctors"); break;
                    case "13": View.PatientsCount(db.Patients, "Number Of Patients"); break;
                    case "14": View.NumberOfPatientsPerRoom(db.Rooms, "Patients Per Room"); break;
                    case "15": View.GetDoctors(db.Doctors.OrderBy(x => x.FirstName).ToList(), "Doctors Ordered By Name"); break;
                    case "16": View.GetAddresses(db.Addresses.OrderByDescending(x => x.Country).ToList(),"Addresses Ordered By Country Descending" ); break;
                    case "17": View.GetPatients(db.Patients.OrderBy(x => x.Age).ToList(),"Patients Ordered By Age Ascending"); break;
                    case "18": View.GetRooms(db.Rooms.OrderBy(x => x.Title).ToList(), "Rooms Ordered By Title Ascending"); break;
                    case "19": View.GetAllPeople(db.Persons.OrderBy(x => x.FirstName).ToList(),"All People withn hospital"); break;
                    default: View.Error(); break;
                }

            } while (input != "E");

        }
    }
}

