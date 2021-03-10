using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Menu
    {       
        Person p1 = new Person();        
        //On startup of site/program
        public void Registration()
        {
            string aName = p1.Name;
            string aPhone = p1.Phone;
            string aEmail = p1.Email;
            string aMember = p1.Member;
            bool run = true;
            //First screen that appears
            Console.WriteLine("---Welcome to your Training Center!---");
            while(run == true)
            {
                Console.WriteLine("Enter name: ");
                aName = Console.ReadLine();
                //If user is already worker or member
                if (p1.MemberList.ContainsKey(aName) || p1.WorkerList.ContainsKey(aName))
                {
                    //Method if you are already a worker/member
                    //Activities.MenuMethod();
                    Console.WriteLine("Activity menu");
                }
                else
                {
                    //Register user
                    Console.WriteLine("Enter phone: ");
                    aPhone = Console.ReadLine();
                    Console.WriteLine("Enter email: ");
                    aEmail = Console.ReadLine();
                    Console.WriteLine("Are you a member(1) or worker(2)?: ");
                    aMember = Console.ReadLine();
                    //Split user into member or worker - list
                    if (aMember == "1")
                    {
                        aMember = "Member";
                        p1.MemberList.Add(aName, new Tuple<string, string, string>(aPhone, aEmail, aMember));
                    }
                    else if (aMember == "2")
                    {
                        aMember = "Worker";
                        p1.WorkerList.Add(aName, new Tuple<string, string, string>(aPhone, aEmail, aMember));
                    }
                }
                Console.WriteLine("Workers");
                p1.PrintWorkers();
                Console.WriteLine("Members");
                p1.PrintMembers();
            }            
        }
    }
     
}
