using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesAndReferences
{
    struct MyStruct
    {
        public int Contents;
    }
    class MyClass
    {
        public int Contents = 0;
    }
    static class Conversions
    {
        public static double PoundsToKilogram(double pounds)
            {
            double kilos = pounds * 0.4536;
            return kilos;
            }
        public static double KilogramToPounds(double Kilograms)
        {
            double pounds = Kilograms * 2.205;
            return pounds;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct struct1 = new MyStruct();
            MyStruct struct2 = struct1;
            struct2.Contents = 100;

            //Reference Type
            MyClass class1 = new MyClass();
            MyClass class2 = class1;
            class2.Contents = 100;

            Console.WriteLine("Value tpes: {0} {1}",struct1.Contents, struct2.Contents);
            Console.WriteLine("Reference tpes: {0} {1}", class1.Contents, class2.Contents);
            Console.ReadKey();

            //Statuc class
            Console.WriteLine("Pounds: {0}, Kilos {1}", Conversions.KilogramToPounds(35), Conversions.PoundsToKilogram(Conversions.KilogramToPounds(35)));
            Console.ReadKey();
            //foreach (var beverage1 in beverages)
            //{
            //    menu.AddBeverage(beverage1);
            //}

            //menu.ShowMenu();
        }
    }
}
