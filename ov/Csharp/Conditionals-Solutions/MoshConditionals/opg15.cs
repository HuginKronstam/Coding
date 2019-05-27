using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    public static class opg15
    {
        public static void Vowels()
        {
            int result = 0;
            Console.WriteLine("Please enter a word from the English language");
            var input = Console.ReadLine();

            foreach (char x in input)
            {
                if (x == 'a' || x == 'e' || x == 'o' || x == 'u' || x == 'i')
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
