using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCollections;

namespace MyCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.Add("Kage1");
            ll.Add("Kage2");
            ll.Add("Kage3");
            ll.Add("Kage4");
            ll.PrintList();
            Console.ReadKey(true);
        }
    }
}
