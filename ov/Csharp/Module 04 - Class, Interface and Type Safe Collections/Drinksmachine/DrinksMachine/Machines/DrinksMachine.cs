using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine.Machines
{
    public class DrinksMachine
    {
        private int _age;
        public int Age
            {
            get
                {
                return _age;
                }
            set
                {
                    if (value > 0) { _age = value; }
                }
            }
        
        // More properties
        public string Make;
        public string Model;

        public void MakeEspresso()
        {
            //Make Espresso
        }
        DrinksMachine dm = new DrinksMachine();
        
    }
}
