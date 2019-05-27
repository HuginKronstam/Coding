using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine.Drinks
{
    public class Coffee : IBeverage
    {
        public bool IsFairTrade { get; set; }

        public event EventHandler OnSoldOut;

        public int GetServingTemperature(bool includesMilk)
        {
            return includesMilk ? 80 : 100;
            //throw new NotImplementedException();
        }
    }
}
