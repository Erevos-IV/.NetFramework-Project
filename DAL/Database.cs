using System;
using System.Collections.Generic;

namespace Assessment
{
    class Database
    {
        // Creating the Lists.
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public List<Address> Addresses { get; set; } = new List<Address>();

        public List<Room> Rooms { get; set; } = new List<Room>();

        public List<Person> Persons { get; set; } = new List<Person>();

        public Database()
        {
            // Synthetic Data.
            #region Doctors
            // Creating doctors (12 Doctors).
            Doctor d1 = new Doctor() { DoctorID = 1, FirstName = "Vasileios", LastName = "Papandreou", Age = 44, Salary = 42500 };
            Doctor d2 = new Doctor() { DoctorID = 2, FirstName = "Natasa", LastName = "Makrigiannh", Age = 57, Salary = 60000 };
            Doctor d3 = new Doctor() { DoctorID = 3, FirstName = "Takis", LastName = "Tsoukalas", Age = 37, Salary = 21400 };
            Doctor d4 = new Doctor() { DoctorID = 4, FirstName = "Maria", LastName = "Georgiou", Age = 19, Salary = 3000 };
            Doctor d5 = new Doctor() { DoctorID = 5, FirstName = "Stella", LastName = "Papadioti", Age = 39, Salary = 25000 };
            Doctor d6 = new Doctor() { DoctorID = 6, FirstName = "Georgios", LastName = "Printezhs", Age = 35, Salary = 19000 };
            Doctor d7 = new Doctor() { DoctorID = 7, FirstName = "Vasileios", LastName = "Gerapetriths", Age = 49, Salary = 50000 };
            Doctor d8 = new Doctor() { DoctorID = 8, FirstName = "Giannhs", LastName = "Kefyridhs", Age = 44, Salary = 76677 };
            Doctor d9 = new Doctor() { DoctorID = 9, FirstName = "Alejandros", LastName = "Katsanos", Age = 55, Salary = 43000 };
            Doctor d10 = new Doctor() { DoctorID = 10, FirstName = "Katerina", LastName = "Karapappa", Age = 74, Salary = 42500 };
            Doctor d11 = new Doctor() { DoctorID = 11, FirstName = "Christina", LastName = "Vasilikoy", Age = 68, Salary = 60000 };
            Doctor d12 = new Doctor() { DoctorID = 12, FirstName = "Petros", LastName = "Gaitanos", Age = 66, Salary = 65000 };
            #endregion

            #region Patients
            Patient p1 = new Patient() { PatientID = 1, FirstName = "Sofia", LastName = "Oikologou", Age = 19, EntryDate = new DateTime(2021, 03, 19), ExitDate = new DateTime(2021, 03, 25)};
            Patient p2 = new Patient() { PatientID = 2, FirstName = "Dionysios", LastName = "Atzarakhs", Age = 99, EntryDate = new DateTime(2020, 12, 25), ExitDate = new DateTime(2021, 05, 13)};
            Patient p3 = new Patient() { PatientID = 3, FirstName = "Manwlhs", LastName = "Xristodoulopoylos", Age = 37, EntryDate = new DateTime(2021, 01, 27), ExitDate = new DateTime(2021, 01, 29)};
            Patient p4 = new Patient() { PatientID = 4, FirstName = "Ektoras", LastName = "Botreni", Age = 57, EntryDate = new DateTime(2021, 05, 22), ExitDate = null};
            Patient p5 = new Patient() { PatientID = 5, FirstName = "Xristos", LastName = "Papatheodorou", Age = 43, EntryDate = new DateTime(2021, 02, 28), ExitDate = new DateTime(2021, 03, 02)};
            Patient p6 = new Patient() { PatientID = 6, FirstName = "Christiana", LastName = "Karavity", Age = 19, EntryDate = new DateTime(2021, 04, 02), ExitDate = null,};
            Patient p7 = new Patient() { PatientID = 7, FirstName = "Georgios", LastName = "Orfanidhs", Age = 77, EntryDate = new DateTime(2021, 05, 10), ExitDate = null};
            Patient p8 = new Patient() { PatientID = 8, FirstName = "Hlias", LastName = "Vathrakokylhs", Age = 12, EntryDate = new DateTime(2021, 04, 19), ExitDate = new DateTime(2021, 04, 22)};
            Patient p9 = new Patient() { PatientID = 9, FirstName = "Maria", LastName = "Pelekanou", Age = 2, EntryDate = new DateTime(2021, 05, 22), ExitDate = new DateTime(2021, 05, 23)};
            Patient p10 = new Patient() { PatientID = 10, FirstName = "Kyriakh", LastName = "Nikoloulh", Age = 66, EntryDate = new DateTime(2020, 12, 02), ExitDate = new DateTime(2021, 01, 05)};
            Patient p11 = new Patient() { PatientID = 11, FirstName = "Sofianna", LastName = "Spinoula", Age = 22, EntryDate = new DateTime(2021, 01, 13), ExitDate = null };
            Patient p12 = new Patient() { PatientID = 12, FirstName = "Athanasios", LastName = "Katsoulhs", Age = 19, EntryDate = new DateTime(2021, 03, 19), ExitDate = new DateTime(2021, 03, 30)};
            Patient p13 = new Patient() { PatientID = 13, FirstName = "Petroula", LastName = "Kairou", Age = 26, EntryDate = new DateTime(2020, 01, 26), ExitDate = new DateTime(2021, 02, 18)};
            Patient p14 = new Patient() { PatientID = 14, FirstName = "Kyriakos", LastName = "Avramidhs", Age = 82, EntryDate = new DateTime(2021, 05, 19), ExitDate = null};
            Patient p15 = new Patient() { PatientID = 15, FirstName = "Vasileios", LastName = "Giasemhs", Age = 1, EntryDate = new DateTime(2021, 05, 25), ExitDate = null};
            Patient p16 = new Patient() { PatientID = 16, FirstName = "Atzoun", LastName = "Mehmet", Age = 19, EntryDate = new DateTime(2020, 12, 02), ExitDate = new DateTime(2020, 12, 25)};
            Patient p17 = new Patient() { PatientID = 17, FirstName = "Maria", LastName = "Papadakh", Age = 4, EntryDate = new DateTime(2021, 03, 19), ExitDate = new DateTime(2021, 03, 25)};
            Patient p18 = new Patient() { PatientID = 18, FirstName = "Christiana", LastName = "Pappa", Age = 42, EntryDate = new DateTime(2021, 03, 05), ExitDate = new DateTime(2021, 03, 15)};
            Patient p19 = new Patient() { PatientID = 19, FirstName = "Vasileios", LastName = "Kappas", Age = 9, EntryDate = new DateTime(2021, 01, 05), ExitDate = new DateTime(2021, 01, 09)};
            Patient p20 = new Patient() { PatientID = 20, FirstName = "Sofia", LastName = "Karagiorgh", Age = 32, EntryDate = new DateTime(2021, 05, 01), ExitDate = new DateTime(2021, 05, 12)};
            #endregion

            #region Adresses
            Address a1 = new Address() { AddressID = 1, Name = "Tepelenhs", Country = "Greece", City = "Athens", PostalCode = "12435", };
            Address a2 = new Address() { AddressID = 2, Name = "Samou", Country = "Greece", City = "Athens", PostalCode = "18121", };
            Address a3 = new Address() { AddressID = 3, Name = "Athinas", Country = "Greece", City = "Athens", PostalCode = "52928", };
            Address a4 = new Address() { AddressID = 4, Name = "Petrou Ralli", Country = "Greece", City = "Athens", PostalCode = "12122", };
            Address a5 = new Address() { AddressID = 5, Name = "Wthonos", Country = "Greece", City = "Athens", PostalCode = "19362", };
            Address a6 = new Address() { AddressID = 6, Name = "Karaiskakh", Country = "Greece", City = "Athens", PostalCode = "19211", };
            Address a7 = new Address() { AddressID = 7, Name = "Peloponnhsou", Country = "Greece", City = "Athens", PostalCode = "11111", };
            Address a8 = new Address() { AddressID = 8, Name = "Leontaras", Country = "Greece", City = "Athens", PostalCode = "14729", };
            Address a9 = new Address() { AddressID = 9, Name = "Apsou", Country = "Greece", City = "Athens", PostalCode = "12381", };
            Address a10 = new Address() { AddressID = 10, Name = "papias", Country = "Greece", City = "Athens", PostalCode = "91743", };
            Address a11 = new Address() { AddressID = 11, Name = "Kyriths", Country = "Greece", City = "Athens", PostalCode = "37193", };
            Address a12 = new Address() { AddressID = 12, Name = "Katapelth", Country = "Greece", City = "Athens", PostalCode = "58445", };
            Address a13 = new Address() { AddressID = 13, Name = "Agia napa", Country = "Greece", City = "Athens", PostalCode = "83575", };
            #endregion

            #region Rooms
            // Creating the rooms (10 ROOMS).
            Room r1 = new Room() { RoomID = 1, Title = "RoomA" };
            Room r2 = new Room() { RoomID = 2, Title = "RoomB" };
            Room r3 = new Room() { RoomID = 3, Title = "RoomC" };
            Room r4 = new Room() { RoomID = 4, Title = "RoomD" };
            Room r5 = new Room() { RoomID = 5, Title = "RoomE" };
            Room r6 = new Room() { RoomID = 6, Title = "RoomF" };
            Room r7 = new Room() { RoomID = 7, Title = "RoomG" };
            Room r8 = new Room() { RoomID = 8, Title = "RoomH" };
            Room r9 = new Room() { RoomID = 9, Title = "RoomI" };
            Room r10 = new Room() { RoomID = 10, Title = "RoomJ" };
            #endregion


            // Relations.
            #region Doc and pat
            // Relations between doctors and patients.
            d1.Patients.Add(p2);
            d2.Patients.Add(p1);
            d2.Patients.Add(p4);
            d2.Patients.Add(p8);
            d2.Patients.Add(p18);
            d3.Patients.Add(p6);
            d3.Patients.Add(p17);
            d4.Patients.Add(p3);
            d4.Patients.Add(p7);
            d4.Patients.Add(p15);
            d5.Patients.Add(p16);
            d6.Patients.Add(p13);
            d7.Patients.Add(p11);
            d8.Patients.Add(p12);
            d9.Patients.Add(p19);
            d10.Patients.Add(p10);
            d11.Patients.Add(p9);
            d11.Patients.Add(p14);
            d12.Patients.Add(p20);
            d12.Patients.Add(p5);

            p1.Doctor = d2;
            p2.Doctor = d1;
            p3.Doctor = d4;
            p4.Doctor = d2;
            p5.Doctor = d12;
            p6.Doctor = d3;
            p7.Doctor = d4;
            p8.Doctor = d2;
            p9.Doctor = d11;
            p10.Doctor = d10;
            p11.Doctor = d7;
            p12.Doctor = d8;
            p13.Doctor = d6;
            p14.Doctor = d11;
            p15.Doctor = d4;
            p16.Doctor = d5;
            p17.Doctor = d3;
            p18.Doctor = d2;
            p19.Doctor = d9;
            p20.Doctor = d12;
            #endregion

            #region  Rooms and Patients
            // Creating relations  
            r1.Patients.Add(p12);
            r2.Patients.Add(p19);
            r3.Patients.Add(p20);
            r3.Patients.Add(p3);
            r4.Patients.Add(p1);
            r4.Patients.Add(p4);
            r4.Patients.Add(p8);
            r4.Patients.Add(p9);
            r4.Patients.Add(p13);
            r5.Patients.Add(p10);
            r5.Patients.Add(p2);
            r6.Patients.Add(p18);
            r7.Patients.Add(p5);
            r7.Patients.Add(p17);
            r8.Patients.Add(p14);
            r8.Patients.Add(p15);
            r9.Patients.Add(p11);
            r9.Patients.Add(p16);
            r10.Patients.Add(p6);
            r10.Patients.Add(p7);

            p1.Room = r4;
            p2.Room = r5;
            p3.Room = r3;
            p4.Room = r4;
            p5.Room = r7;
            p6.Room = r10;
            p7.Room = r10;
            p8.Room = r4;
            p9.Room = r4;
            p10.Room = r5;
            p11.Room = r9;
            p12.Room = r1;
            p13.Room = r4;
            p14.Room = r8;
            p15.Room = r8;
            p16.Room = r9;
            p17.Room = r7;
            p18.Room = r6;
            p19.Room = r2;
            p20.Room = r3;
            #endregion

            #region Addresses and Patients
            a1.Patients.Add(p1);
            a1.Patients.Add(p3);
            a1.Patients.Add(p14);
            a2.Patients.Add(p2);
            a2.Patients.Add(p9);
            a2.Patients.Add(p19);
            a3.Patients.Add(p4);
            a3.Patients.Add(p13);
            a4.Patients.Add(p5);
            a4.Patients.Add(p20);
            a5.Patients.Add(p6);
            a6.Patients.Add(p7);
            a7.Patients.Add(p8);
            a8.Patients.Add(p10);
            a9.Patients.Add(p11);
            a10.Patients.Add(p12);
            a11.Patients.Add(p15);
            a11.Patients.Add(p18);
            a12.Patients.Add(p16);
            a13.Patients.Add(p17);

            p1.Address = a1;
            p2.Address = a2;
            p3.Address = a1;
            p4.Address = a3;
            p5.Address = a4;
            p6.Address = a5;
            p7.Address = a6;
            p8.Address = a7;
            p9.Address = a2;
            p10.Address = a8;
            p11.Address = a9;
            p12.Address = a10;
            p13.Address = a3; 
            p14.Address = a1;
            p15.Address = a11;
            p16.Address = a12;
            p17.Address = a13;
            p18.Address = a11;
            p19.Address = a2;
            p20.Address = a4;

            #endregion


            

            // Creating the lists between fpr rooms doctors addresses and patients.
            List<Doctor> doctors = new List<Doctor>() { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12 };
            Doctors.AddRange(doctors);

            List<Patient> patient = new List<Patient>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20 };
            Patients.AddRange(patient);

            List<Address> address = new List<Address>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13 };
            Addresses.AddRange(address);

            List<Room> rooms = new List<Room>() { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
            Rooms.AddRange(rooms);

            List<Person> persons = new List<Person>() { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20 };
            Persons.AddRange(persons);
        }
    }

}
    


