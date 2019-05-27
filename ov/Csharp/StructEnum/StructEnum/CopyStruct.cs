using System;

namespace StructEnum
{
    public enum CoffeeStrength { Mild, Medium, Strong, Extreme }
    public struct Coffee
    {
        public Coffee(CoffeeStrength strength, string coffeeName)
        {
            this._coffeeName = coffeeName;
            this.CStrength = strength;
        }
        public CoffeeStrength CStrength;


        private string _coffeeName;
        public string CoffeeName
        {
            get { return _coffeeName; }
            set { _coffeeName = value; }
        }

        public void PrintCoffee2()
        {
            Console.WriteLine("Coffee name {0} it has a {1} taste", this._coffeeName, this.CStrength);
        }
    //public string this[int index]
    //{
    //    get { return this.CoffeeStrength[index]; }
    //    set { this.CoffeeStrength[index] = value; }
    //}

    //public string Name;
    //public int Strength;
    //public void PrintCoffee()
    //{
    //    Console.WriteLine("Coffee Name: {0}\nCoffee Strength: {1}\n\n", this.Name, this.Strength);
    //}
}
}