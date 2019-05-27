using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoshConditionals
{
    class opg12
    {
        public static void Duplicate()
        {
            List<int> intList = new List<int>();
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Environment.Exit(1);
            }
            var split = input.Split('-');

            foreach (var str in split)
            {
                var str2 = Convert.ToInt32(str);
                intList.Add(str2);
            }

            if (intList.Count != intList.Distinct().Count())
            {
                Console.WriteLine("Duplicates");
            }

        }
    }
}
