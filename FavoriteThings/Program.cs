using System;

namespace FavoriteThings
{
    class Program
    {
        public static object Name { get; private set; }

        // 1. 
        static void Main(string[] args)
        {
            var muffin = new Pet { Name = "Muffin", Age = 8, Color = "Tabby", Type = PetType.Cat };
            muffin.Jump(3);

            var myBike = new Bicycle { Size = 26, Type = BicycleType.Trike, NumberOfWheels = 3 };
            myBike.Forward(45);

            var myCookie = new Cookie { Name = "Tasty Cookie", Type = CookieType.Macadamia, GlutenFree = false };
            myCookie.SetName("Tastes like shit");

            var myPizza = new Pizza { Name = "Gooey", Type = PizzaType.allmeatallthetime, ExtraCheese = true };
            myPizza.AddExtraCheese(true);

            Console.WriteLine("Hello World!");
            Console.ReadLine();


        }
    }
}
