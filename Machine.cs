using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Machine
    {
        public string Name;
        public int MachineID;
        public readonly List<Machine> Machines = new List<Machine>();

        public Machine()
        {
        }
        public Machine(string Name, int MachineID)
        {
            this.Name = Name;
            this.MachineID = MachineID;
        }


        public void RegisterMachines()
        {
            int counter = 0;
            Console.WriteLine("How Many machines is there in your gym?: ");
            int antal = int.Parse(Console.ReadLine());
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Name the type of machine: ");
                string ord = Console.ReadLine();
                
                counter = counter + 1;
                Machines.Add(new Machine(ord, counter));
            }

            foreach (var mask in Machines)
            {
                Console.WriteLine("Maskin: {0} ID: {1}", mask.Name, mask.MachineID);
            }
        }
        
    }
}
