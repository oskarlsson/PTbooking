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
        public Person(string name, string phone, string email, string member, string worker)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Member = member;
        }

        //Method to register new person
        public void Registration()
        {

            

            //First screen that appears
            Console.WriteLine("---Welcome to your Training Center!---");
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            if (MemberList.ContainsKey(Name) || WorkerList.ContainsKey(Name))
            {
                //Method if you are already a user
                //Activities.MenuMethod();
                Console.WriteLine("Activity menu");
            }
            else
            {
                //Register user
                Console.WriteLine("Enter phone: ");
                Phone = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                Email = Console.ReadLine();
                Console.WriteLine("Are you a member(1) or worker(2)?: ");
                Member = Console.ReadLine();
                if (Member == "1")
                {
                    Member = "Member";
                    MemberList.Add(Name, new Tuple<string, string, string>(Phone, Email, Member));
                }
                else if (Member == "2")
                {
                    Member = "Worker";
                    WorkerList.Add(Name, new Tuple<string, string, string>(Phone, Email, Member));
                }
            }
                                  
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
