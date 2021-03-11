using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class StaffActivities : Menu
    {
        public StaffActivities()
        {

        }
        public void ChangeSchedule()
        {
            string[] schedule = { "08 - 09", "10 - 11", "12 - 13", "14 - 15"};
            Console.WriteLine(schedule[0]);
            //for (int i = 0; i < schedule.Length; i++)
            //{
            //    Console.WriteLine(schedule[i]);
            //}
        }
        public void ReserveRoom()
        {

        }
        public void CreateBookingSchedule()
        {

        }

    }
}
