using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class StaffActivities
    {

        public bool ChangeSchedule(string title)
        {
            Console.Write("Do you want to change your schedule? ");
            ConsoleKey response;
            do
            {
                //next feature if there's time
                //send an sms to the member who wants to change the schedule
                Console.Write($"Do you want to change your schedule? { title } [y/n] ");
                response = Console.ReadKey(false).Key;  // true is intercept key (dont show), false is show
                if (response != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }
            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            return (response == ConsoleKey.Y);

        }

        public char ReserveRoom(char c)
        {
            char ch;
            do
            {
                Console.Write("Do you want to reserve a room? Enter (Y/N) :-");
                ch = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            while(ch.Equals(char.Parse("N")));
            //next feature if there's time
            // ask which room as well in case the rooms were numbered
            Console.WriteLine("Thanks ....The room is reserved");
            Console.ReadLine();
            return ch;
        }

        public void AddActivity()
        {
             try
             {
                //ask which activite the staff wants to add
                //ask if the staff is sure from what they wrote
                //the activity added will go to the members activities menu to be selected from the members
             }
            catch (Exception e)
             {
                //msg in case something went wrong
             }
        }

        public void CreateBookingSchedule()
        {

            //adding columns (datatable)
            //set the member in a certen day and time 
            //can be shown in the table when the member is booked
            //in case of ChangeSchedule >>> shows in the datatable aswell
        }
    }  
}
