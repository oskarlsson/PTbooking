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
        public Machine Machine;
        public StaffActivities SAM;
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
            else if (Member == "Worker")
            {

                Console.WriteLine("1. Change schedule\n2. Reserve rooms\n3. Add activity\n" +
                "4. Create booking schedule\n5. Register machine\n6. Report broken machine ");
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    SAM.ChangeSchedule();
                }
                else if (userInput == "2")
                {
                    SAM.ReserveRoom();
                }
                else if (userInput == "3")
                {
                    SAM.CreateBookingSchedule();
                }
                else if (userInput == "4")
                {
                    //Add activity method
                }
                else if (userInput == "5")
                {
                    Machine.RegisterMachines();
                }
                else if (userInput == "6")
                {
                    Machine.ChangeMachineStatus();
                }
            }
            

        }
    }     
}
