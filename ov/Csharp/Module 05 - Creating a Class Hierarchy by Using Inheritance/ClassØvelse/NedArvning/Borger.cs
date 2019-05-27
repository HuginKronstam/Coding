using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedArvning
{
    class Borger : Person
    {
        public DateTime PasUdløbsdato;
        public bool pasudløbet;

        public Borger(string navn, DateTime pasUdløbsdato, DateTime fødselsdag) : base(navn, fødselsdag)
        {
            PasUdløbsdato = pasUdløbsdato;
            pasudløbet = (DateTime.Today > PasUdløbsdato);
        }
    }
}
