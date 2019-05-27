using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    public static class opg11
    {
        public static void Consecutive()
        {
            List<int> intList = new List<int>();
            var input = Console.ReadLine();
            var split = input.Split('-');
            var message = "";
            
            foreach(var str in split)
            {
                var str2 = Convert.ToInt32(str);
                intList.Add(str2);
            }

            var start = intList[0];
            foreach (var number in intList)
            {
                if (number == start)
                    Console.WriteLine("The starting number is {0}", number);
                else
                {
                    if (number == start + 1 || number == start - 1)
                    {
                        start = number;
                        message = "Consecutive";
                    }
                    else
                    {
                        start = 435265462;
                        message = "Non Consecutive";
                    }
                }
            }
            Console.WriteLine(message);
        }
    }
}
