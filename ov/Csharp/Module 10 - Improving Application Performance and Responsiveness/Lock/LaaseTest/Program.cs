using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace LaaseTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random r = new Random();
            Check check = new Check();

            Parallel.For(0, 100, i =>
            {
                //lock(check)
                //{
                   check.CheckInventory(r.Next(1, 50));
                //}
            });
            Console.ReadKey(true);
        }
    }
}
