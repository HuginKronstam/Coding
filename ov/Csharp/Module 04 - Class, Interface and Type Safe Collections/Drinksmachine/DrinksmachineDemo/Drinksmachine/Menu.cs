using Drinksmachine.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinksmachine
{
    public class Menu
    {
        private readonly List<Beverage> beverages = new List<Beverage>();

        public void AddBeverage( Beverage beverage )
        {
            beverages.Add(beverage);
        }

        public void ShowMenu()
        {
            char sel;
            do
            {
                short inx = 1;
                foreach (Beverage bev in beverages)
                {
                    Console.WriteLine(inx + ")\t" + bev.Name);
                    inx++;
                }

                Console.WriteLine("0)\tAfslut");
                sel = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                if( sel > 48 && sel < 49 + beverages.Count ) {
                    beverages[sel-49].Make();
                }

            } while (sel != 48);
        }
    }
}
