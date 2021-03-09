using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTbooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Activities Action = new Activities();

            Console.WriteLine(Action.selfTraining);

            Console.ReadKey();
        }
    }
}
