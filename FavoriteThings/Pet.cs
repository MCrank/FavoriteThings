using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public PetType Type { get; set; }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public void Jump(int hight)
        {
            Console.WriteLine($"My pet jumped {hight} meters!");
        }
    }

    enum PetType
    {
        Cat,
        Dog,
        Fish,
        Lizard,
    }
}
