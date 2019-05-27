using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    public class opg4
    {
        public static void checkSpeed(int speed)
        {
            int speedLimit = 100;
            if (speedLimit >= speed)
                Console.WriteLine("Ok");
            else
            {
                int demerit = speed - speedLimit;
                int points = demerit / 5;
                if (points >= 12)
                {
                    Console.WriteLine("Your licence has been suspended");
                }
                else
                    Console.WriteLine("Yo have been demeritet {0} points", points);
            }
            Console.ReadKey();
        }
    }
}
