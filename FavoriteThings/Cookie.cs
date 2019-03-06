using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Cookie
    {
        public string Name { get; set; }
        public CookieType Type { get; set; }
        public bool GlutenFree { get; set; }

        public void SetName(string name)
        {
            Name = name;
            Console.WriteLine($"You set the name of the cookie to {name}");
        }

        public void IsGlutenFree(bool glutenFree)
        {
            GlutenFree = glutenFree;
            Console.WriteLine($"You set the value of GlutenFree to {glutenFree}");
        }

    }

    enum CookieType
    {
        ChocolateChip,
        Sugar,
        Oatmeal,
        Macadamia
    }
}
