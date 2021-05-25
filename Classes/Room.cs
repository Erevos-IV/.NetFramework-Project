using System.Collections.Generic;

namespace Assessment
{
    public class Room
    {
        // Creating the properties.
        public int RoomID { get; set; }

        public string Title  { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        // Methods.
        // Methods.
        public void GetAllRooms()
        {
            System.Console.WriteLine($"{RoomID,-15}|{Title,-20}");
        }

        public void GetRoomTitle() 
        {
            System.Console.WriteLine($"{Title}");
        }
    }


}
    


