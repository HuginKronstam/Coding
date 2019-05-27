using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    public static class opg13
    {
        public static void ValidTime()
        {
            bool valid = false;
            Console.WriteLine("Please Enter a time, the valid format is hh:mm");
            var input = Console.ReadLine();
            var inputArr = input.Split(':');
            List<int> intList = new List<int>();
            foreach (var str in inputArr)
            {
                var str2 = Convert.ToInt32(str);
                intList.Add(str2);
            }
            if ((inputArr[0].Length == 2 && (intList[0] < 25 && intList[0] > -1)) && (inputArr[1].Length == 2 && (intList[1] < 61 && intList[1] > -1)))
                valid = true;
            else
                Console.WriteLine("Not valid");

            Console.WriteLine(valid);

        }
    }
}
