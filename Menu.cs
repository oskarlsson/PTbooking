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
            Activities AM = new Activities();
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
                    ActivityMenu();



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
            Console.WriteLine("Are you a member(1) or staff(2)?: ");
            Member = Console.ReadLine();
            //Split user into member or worker - list
            if (Member == "1")
            {
                Member = "Member";
                MemberList.Add(Name, new Tuple<string, string, string>(Phone, Email, Member));
            }
            else if (Member == "2")
            {
                Member = "Staff";
                WorkerList.Add(Name, new Tuple<string, string, string>(Phone, Email, Member));
            }
        }
        //Activity menu Worker/Member
        public void ActivityMenu()
        {
            Activities AM = new Activities();
            string userInput;
            if (Member == "Member")
            {
                Console.WriteLine("1. Self training\n2. Group training\n3. PT training\n4. PT consultation");
                userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    AM.addToSelfTraining(Name);
                }
            }
            else if (Member == "Staff")
            {

            }
            

        }
    }     
}
