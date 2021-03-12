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
        Machine machines = new Machine();
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
            Console.WriteLine("Are you a member(1) or staff(2)?: ");
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
                Member = "Staff";
                WorkerList.Add(Name, new Tuple<string, string, string>(Phone, Email, Member));
            }
        }
        //Activity menu Worker/Member
        public void ActivityMenu(string Name)
        {
            string userInput;
            if (Member == "Member")
            {
                Console.WriteLine("1. Self training\n2. Group training\n3. PT training\n4. PT consultation");
                userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    AM.AddToSelfTraining(Name);
                }
                else if(userInput == "2")
                {
                    AM.AddToGroupTraining(Name);
                }
                else if (userInput == "3")
                {
                    AM.AddToPtTraining(Name);
                }
                else if (userInput == "4")
                {
                    AM.AddToPtConsultation(Name);
                }
            }
            else if (Member == "Staff")
            {
               
                Console.WriteLine("1. Register machines\n2. Report broken machines\n3. Show avalible machines\n4. Show broken machines");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        machines.RegisterMachines();
                        break;
                    case "2":
                        machines.PrintAvailMachines();
                        machines.ChangeMachineStatus();
                        break;
                    case "3":
                        machines.PrintAvailMachines();
                        break;
                    case "4":
                        machines.PrintBrokenMachines();
                        break;
                }             
            }           
        }
    }     
}
