using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coffee coffee1 = new Coffee(); // new Coffee(coffeeStrenght.medium, "arbica")
            //coffee1.Name = "Java Enthusiast\'s Dream";
            //coffee1.Strength = 5;

            //Coffee coffee2 = new Coffee();
            //coffee2.Name = "Arabica Lover";
            //coffee2.Strength = 4;

            //coffee1.PrintCoffee();
            //coffee2.PrintCoffee();

            Coffee coffee1 = new Coffee(CoffeeStrength.Medium,"Java Dream");
            //coffee1.PrintCoffee2();
            Coffee coffee2 = new Coffee(CoffeeStrength.Extreme, "Johan's Wet Dream");
            //coffee2.PrintCoffee2();
            Coffee coffee3 = new Coffee(CoffeeStrength.Strong, "Gurmis Gustne Glimmer Gummer Glanser Glimrende");
            //coffee3.PrintCoffee2();
            Coffee coffee4 = new Coffee(CoffeeStrength.Mild, "Kaspers Kummerlige Kapsel Kaffe");
            //coffee4.PrintCoffee2();

            ArrayList coffees = new ArrayList();
            coffees.Add(coffee1);
            coffees.Add(coffee2);
            coffees.Add(coffee3);
            coffees.Add(coffee4);

            var queryResult = from Coffee c in coffees where c.CStrength == CoffeeStrength.Extreme select c;
            foreach (Coffee element in queryResult)
            {
                element.PrintCoffee2();
            }

            var queryResult2 = from Coffee c in coffees where c.CStrength == CoffeeStrength.Strong select c;
            foreach (Coffee element in queryResult2)
            {
                element.PrintCoffee2();
            }
            Console.ReadKey();
        }
    }
}
