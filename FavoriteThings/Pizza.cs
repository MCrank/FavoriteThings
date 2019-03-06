using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Pizza
    {
        public string Name { get; set; }
        public PizzaType Type { get; set; }
        public bool ExtraCheese { get; set; }

        public void AddExtraCheese(bool extraCheese)
        {
            ExtraCheese = extraCheese;
            Console.WriteLine("You added extra cheese!");
        }

        public void SetName(string name)
        {
            Name = name;
            Console.WriteLine($"You set the name to {name}");
        }
    }

    enum PizzaType
    {
        cheese,
        pepperoni,
        allmeatallthetime,
        veggie
    }
}
