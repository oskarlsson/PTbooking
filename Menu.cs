using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Menu : Person
    {       

        //On startup of site/program
        public void MainMenu()
        {
            bool run = true;
            //First screen that appears
            Console.WriteLine("---Welcome to your Training Center!---");
            while(run == true)
            {
                Console.WriteLine("Enter name: ");
                Name = Console.ReadLine();
                //If user is already worker or member
                if (MemberList.ContainsKey(Name) || WorkerList.ContainsKey(Name))
                {
                    //Method if you are already a worker/member
                    //Activities.MenuMethod();
                    
                    
                }
                else
                {
                    //Register user
                    RegisterUser(Name);
                }
            }            
        }

        public void RegisterUser(string Name)
        {
            
            Console.WriteLine("Enter phone: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Are you a member(1) or worker(2)?: ");
            Member = Console.ReadLine();
            //Split user into member or worker - list
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
        //Activity menu Worker/Member
        public void ActivityMenu()
        {

        }
    }     
}
