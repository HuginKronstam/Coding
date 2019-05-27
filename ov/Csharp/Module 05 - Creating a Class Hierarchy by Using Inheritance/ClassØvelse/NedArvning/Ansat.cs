using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedArvning
{
    class Ansat : Person
    {
        public int TimeWorked;
        public decimal Løn;
        public virtual bool Overtid { get; set; }

        public Ansat(string navn, DateTime fødselsdag, int timeWorked, decimal løn) : base(navn, fødselsdag)
        {
            TimeWorked = timeWorked;
            Løn = løn;
            Overtid = false;
        }
    }
}
