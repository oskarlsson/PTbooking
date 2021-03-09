using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Person
    {
        //Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Defaultconstructor
        public Person()
        {

        }

        //Method to register new person
        public void Registration()
        {
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            Email = Console.ReadLine();
        }
    }
}
