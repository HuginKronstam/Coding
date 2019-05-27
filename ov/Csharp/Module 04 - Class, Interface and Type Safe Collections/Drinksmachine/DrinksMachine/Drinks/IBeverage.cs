using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine.Drinks
{
    public interface IBeverage
    {
        bool IsFairTrade { get; set; }

        int GetServingTemperature(bool includesMilk);

        event EventHandler OnSoldOut;
    }
}
