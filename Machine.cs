﻿using System;
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
            int antal = int.Parse(Console.ReadLine());
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Name the type of machine: ");
                string ord = Console.ReadLine();
                bool status = false;
                counter = counter + 1;
                Machines.Add(new Machine(ord, counter, status));
            }


        }


        public void PrintAvailMachines()
        {
            Console.WriteLine("Avalible");
            foreach (var mask in Machines)
            {
                if (mask.Broken == false)
                    Console.WriteLine("ID: {0} Machine: {1} Broken: {2}", mask.MachineID, mask.Name, mask.Broken);
            }
        }

        public void PrintBrokenMachines()
        {
            Console.WriteLine("Unavalible");
            foreach (var mask in BrokenMachines)
            {
                if (mask.Broken == true)
                {

                    Console.WriteLine("ID: {0} Machine: {1} Broken: {2}", mask.MachineID, mask.Name, mask.Broken);
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
                Console.WriteLine("Här var det tomt");
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
