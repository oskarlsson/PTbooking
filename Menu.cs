using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Menu : Person
    {
        public Activities AM;
        //On startup of site/program
        public void MainMenu()
        {
            AM = new Activities();
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
                    ActivityMenu(Name);
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
            Console.WriteLine("You need to register");
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
                Console.WriteLine("Member list");
                foreach(object i in MemberList)
                {
                    Console.WriteLine(i);
                }
            }
            else if (Member == "2")
            {
                Member = "Worker";
                WorkerList.Add(Name, new Tuple<string, string, string>(Phone, Email, Member));
            }
        }
        //public List<string> selfTrainingList = new List<string>();
        //Activity menu Worker/Member
        public void ActivityMenu(string Name)
        {
            //Activities AM = new Activities();
            string userInput;
            if (Member == "Member")
            {
                Console.WriteLine("1. Self training\n2. Group training\n3. PT training\n4. PT consultation");
                userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    AM.addToSelfTraining(Name);
                }
                else if(userInput == "2")
                {
                    AM.addToGroupTraining(Name);
                }
                else if (userInput == "3")
                {
                    AM.addToPtTraining(Name);
                }
                else if (userInput == "4")
                {
                    AM.addToPtConsultation(Name);
                }
            }
            else if (Member == "Worker")
            {
                Console.WriteLine();
            }
            

        }
    }     
}
