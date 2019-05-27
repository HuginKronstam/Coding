using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine.Machine
{
    class DrinksMachines
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
                if (Age > 0)
                {
                    _age = value;
                }
            }
        }
        //More Properties
        public string Make { get; set; }
        public string Model;

        public void MakeEspresso()
        {
            throw new NotImplementedException("This functionality is not implemented... Yet.");
        }
    }
}
