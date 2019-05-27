using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedArvning
{
    class Program
    {
        static void Main(string[] args)
        {
            HK Anders = new HK("Anders Johansen", DateTime.Now, 42, 150);
            HK Per = new HK("Per Flæsk", DateTime.Now, 39, 150);
            HK Gert = new HK("Gert Ikkejohansen", DateTime.Now, 56, 150);
            HK Dennis = new HK("Dennis og Mini", DateTime.Now, 77, 150);

            Lærer Thomas = new Lærer("Thomas Test", DateTime.Now, 42, 230, 40);
            Lærer Jørgen = new Lærer("Jørgen Prøve", DateTime.Now, 36, 270, 30);
            Lærer Hans = new Lærer("Hans AdHoc", DateTime.Now, 36, 270, 30);
            Lærer Flemming = new Lærer("Flemming Midlertidig", DateTime.Now, 36, 270, 30);



            Console.ReadKey(true);
        }
    }
}
