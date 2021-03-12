using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Machine
    {
        private string Name;
        private int MachineID;
        private bool Broken;
        //Use readonly to init the lists only once.
        private readonly List<Machine> Machines = new List<Machine>();
        private readonly List<Machine> BrokenMachines = new List<Machine>();
        public Machine()
        {
        }
        public Machine(string Name, int MachineID, bool Status)
        {
            this.Name = Name;
            this.MachineID = MachineID;
            this.Broken = Status;
        }
        //Register new machines and add to list.
        public void RegisterMachines()
        {
            int id = 0;
            Console.WriteLine("How Many machines is there in your gym?: ");
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    int num = int.Parse(input);
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("Name the type of machine: ");
                        string machinetype = Console.ReadLine();
                        bool status = false;
                        id = id + 1;
                        Machines.Add(new Machine(machinetype, id, status));
                    }
                }
                catch
                {
                    Console.WriteLine("Enter valid number");
                    continue;
                }               
                break;
            }
        }
        //Prints out list of machines that are not broken.
        public void PrintAvailMachines()
        {
            Console.WriteLine("Avalible");
            foreach (var machine in Machines)
            {
                    Console.WriteLine("ID: {0}, Machine: {1}, Broken: {2}", machine.MachineID, machine.Name, machine.Broken);
            }
        }
        //Prints out list of broken machines.
        public void PrintBrokenMachines()
        {
            Console.WriteLine("Unavalible");
            foreach (var machine in BrokenMachines)
            {
                    Console.WriteLine("ID: {0}, Machine: {1}, Broken: {2}", machine.MachineID, machine.Name, machine.Broken);
            }
        }
        //Move machines from avalible machines list to broken machines list.
        public void ChangeMachineStatus()
        {
            if (Machines == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine("What Machine is broken? ");
                int toremove = int.Parse(Console.ReadLine());
                var toAdd = Machines.ElementAt(toremove - 1);
                BrokenMachines.Add(toAdd);
                Machines.RemoveAt(toremove - 1);
                foreach (var i in BrokenMachines)
                {
                    i.Broken = true;
                }
            }
        }
    }
}
