using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshConditionals
{
    class opg3
    {
        public static void imageDimensions(int width, int height)
        {
            if (width > height)
                Console.WriteLine("Landscape");
            else if (width == height)
                Console.WriteLine("The Picture is an rectangular shape");
            else
                Console.WriteLine("Portrait");
                Console.ReadKey(true);
        }
    }
}
