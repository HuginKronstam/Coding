using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksMachine.Drinks;
using DrinksMachine.Machine;

namespace DrinksMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachines dm = new DrinksMachines()
            {
                Age = 2,
                Make ="Siemens",
                Model = "the best"
            };
            Coffee coffee1 = new Coffee();
            Coffee coffee2 = coffee1;
        }
    }
}
