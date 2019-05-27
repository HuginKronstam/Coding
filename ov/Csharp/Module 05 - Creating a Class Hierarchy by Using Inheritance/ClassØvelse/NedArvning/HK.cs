using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedArvning
{
    class HK : Ansat
    {
        public override bool Overtid { get; set; }

        public HK(string navn, DateTime fødselsdag, int timeworked, decimal løn) : base(navn, fødselsdag, timeworked, løn)
        {
                Overtid = timeworked > 37;
            if(Overtid)
            {
                Console.WriteLine("{0} skal have udbetalt overarbejde for {1} timer, svarende til {2} kr", Navn, timeworked - 37, (timeworked - 37) * løn);    
            }
        }   
    }
}
