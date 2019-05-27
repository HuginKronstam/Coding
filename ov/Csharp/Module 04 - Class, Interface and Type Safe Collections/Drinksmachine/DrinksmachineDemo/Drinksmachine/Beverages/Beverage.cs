using Drinksmachine.Beverages.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinksmachine.Beverages
{
    public class Beverage
    {
        private struct Item
        {
            public Ingredient Ingredient { get; }
            public int Amount { get; }

            public Item(Ingredient ingredient, int amount )
            {
                Ingredient = ingredient;
                Amount = amount;
            }
        }

        public string Name { get; set; }

        private readonly List<Item> _ingredients = new List<Item>();

        public Beverage(string name)
        {
            Name = name;
        }

        public void AddIngredient( Ingredient ingredient, int amount )
        {
            _ingredients.Add(new Item(ingredient, amount));
        }

        public void Make()
        {
            foreach( Item item in _ingredients )
            {
                item.Ingredient.Get(item.Amount);
                Console.WriteLine("Got: " + item.Amount + " of " + item.Ingredient.Name);
            }
        }
    }
}
