using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LaaseTest
{
    class Check
    {
        object locker = new object();
        private int inventory = 200;
        public void CheckInventory(int request)
        {
            
            if (inventory < 0)
            {
                throw new Exception("Inventory is less than zero");
            }
            lock (locker)
                {
                    if (request < inventory)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Subtracting {0} fra {1}, all is good", request, inventory);
                    inventory -= request;
                    Console.WriteLine(inventory);
                }
                else
                {
                    Console.WriteLine("Inventory is less than request");
                    Console.WriteLine(inventory);
                }
            }
        }
    }
}
