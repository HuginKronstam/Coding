using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedArvning
{
    class Lærer : Ansat
    {
        public int Students;
        public override bool Overtid { get; set; }

        public Lærer(string navn, DateTime fødselsdag, int timeworked, decimal løn, int students) : base(navn, fødselsdag, timeworked, løn)
        {
            Students = students;
            Overtid = timeworked > 37;
            if (Overtid)
            {
                Console.WriteLine("{0} skal afspadsere {1} timer", Navn, timeworked - 37);
            }
        }
    }
}
