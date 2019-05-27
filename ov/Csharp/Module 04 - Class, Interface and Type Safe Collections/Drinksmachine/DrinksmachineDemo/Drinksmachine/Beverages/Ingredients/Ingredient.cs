using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinksmachine.Beverages.Ingredients
{
    public class Ingredient
    {
        public string Name { get; }

        public Ingredient(string name)
        {
            Name = name;
        }

        public void Get(int amount)
        {
            Console.WriteLine(Name + " Processing request for " + amount);
        }
    }
}
