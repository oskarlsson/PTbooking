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
        public bool Broken;
        //Use readonly to instantiate the lists once
        public readonly List<Machine> Machines = new List<Machine>();
        public readonly List<Machine> BrokenMachines = new List<Machine>();
        public Machine()
        {
        }
        public Machine(string Name, int MachineID, bool Status)
        {
            this.Name = Name;
            this.MachineID = MachineID;
            this.Broken = Status;
        }


        public void RegisterMachines()
        {
            int counter = 0;
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
                        counter = counter + 1;
                        Machines.Add(new Machine(machinetype, counter, status));
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
        public void PrintAvailMachines()
        {
            Console.WriteLine("Avalible");
            foreach (var machine in Machines)
            {
                if (machine.Broken == false)
                    Console.WriteLine("ID: {0} Machine: {1} Broken: {2}", machine.MachineID, machine.Name, machine.Broken);
            }
        }

        public void PrintBrokenMachines()
        {
            Console.WriteLine("Unavalible");
            foreach (var machine in BrokenMachines)
            {
                if (machine.Broken == true)
                {

                    Console.WriteLine("ID: {0} Machine: {1} Broken: {2}", machine.MachineID, machine.Name, machine.Broken);
                }

                else
                {
                    Console.WriteLine("här var det tomt");
                }
            }
        }

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
