using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    class opg1
    {
        public static void ValidNumber(int number)
        {
            if (number < 1 || number < 11)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
