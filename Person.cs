using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Person //: Activities
    {
        //Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Member { get; set; }
        //Lists for all users on the program
        public Dictionary<string, Tuple<string, string, string>> MemberList = new Dictionary<string, Tuple<string, string, string>>();
        public Dictionary<string, Tuple<string, string, string>> WorkerList = new Dictionary<string, Tuple<string, string, string>>();


        //Defaultconstructor
        public Person()
        {

        }
        public Person(string name, string phone, string email, string member)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Member = member;
        }
        //Access all members in List
        public void PrintMembers()
        {
            foreach (object i in MemberList)
            {
                Console.WriteLine(i);
            }
        }
        //Access all workers in List
        public void PrintWorkers()
        {
            foreach(object i in WorkerList)
            {
                Console.WriteLine(i);
            }
        }
        

    }
}
