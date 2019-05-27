using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedArvning
{
    abstract class Person
    {
        public string Navn;
        public DateTime Fødselsdag;

        public Person(string navn, DateTime fødselsdag)
        {
            Navn = navn;
            Fødselsdag = fødselsdag;
        }

    }
}
