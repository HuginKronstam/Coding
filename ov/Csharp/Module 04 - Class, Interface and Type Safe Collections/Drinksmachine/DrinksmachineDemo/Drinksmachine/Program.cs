using Drinksmachine.Beverages;
using Drinksmachine.Beverages.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drinksmachine
{
    class Program
    {
        private static readonly List<Ingredient> ingredients = new List<Ingredient>();
        private static readonly List<Beverage> beverages = new List<Beverage>();
        private static readonly Menu menu = new Menu();

        static void Main(string[] args)
        {
            ingredients.Add(new Ingredient("Coffee"));  // 0
            ingredients.Add(new Ingredient("Cacao"));   // 1
            ingredients.Add(new Ingredient("Milk"));    // 2
            ingredients.Add(new Ingredient("Sucker"));  // 3
            ingredients.Add(new Ingredient("Water"));   // 4

            var beverage = new Beverage("American Coffe");
            beverage.AddIngredient(ingredients[0], 2);
            beverage.AddIngredient(ingredients[4], 10);
            beverages.Add(beverage);

            beverage = new Beverage("Cafe Latte");
            beverage.AddIngredient(ingredients[0], 2);
            beverage.AddIngredient(ingredients[2], 4);
            beverage.AddIngredient(ingredients[4], 10);
            beverages.Add(beverage);

            beverage = new Beverage("Cafe Choko");
            beverage.AddIngredient(ingredients[0], 1);
            beverage.AddIngredient(ingredients[2], 2);
            beverage.AddIngredient(ingredients[1], 1);
            beverage.AddIngredient(ingredients[4], 10);
            beverages.Add(beverage);

            beverage = new Beverage("Choko Latte");
            beverage.AddIngredient(ingredients[1], 2);
            beverage.AddIngredient(ingredients[2], 4);
            beverage.AddIngredient(ingredients[4], 10);
            beverages.Add(beverage);

            foreach (var beverage1 in beverages)
            {
                menu.AddBeverage(beverage1);
            }

            menu.ShowMenu();
        }
    }
}
