using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    public static class opg14
    {
        public static void UpperLower()
        {
            Console.WriteLine("Please Write a normal sentence, and i will do magic to it");
            var input = Console.ReadLine();
            var newInput =input.ToLower();
            Console.WriteLine(newInput);
            var split = newInput.Split(' ');
            foreach (var word in split)
            {
                var finalWord =char.ToUpper(word[0]) +word.Substring(1);
                Console.Write(finalWord);
            }
        }
    }
}
