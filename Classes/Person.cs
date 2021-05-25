using System;
using System.Collections.Generic;

namespace Assessment
{



    public class Person
    {
        // Properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Methods.
        public void GetPersonNames()
        {
            Console.WriteLine($"{FirstName,-15} {LastName,-20}");
        }


    }
 

}

