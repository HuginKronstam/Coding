using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Array content =  File.ReadAllLines(@"C:\ov\site.css");
            foreach (var item in content)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey(true);
        }
    }
}
