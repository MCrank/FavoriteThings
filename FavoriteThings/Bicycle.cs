using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Bicycle
    {
        public BicycleType Type { get; set; }
        public int NumberOfWheels { get; set; }
        public int Size { get; set; }

        public void InflateTire(int psi)
        {
            Console.WriteLine($"You infalted the tire to {psi}");
        }

        public void Forward(int distanceFeet)
        {
            Console.WriteLine($"You moved forward {distanceFeet} feet!");
        }

    }

    enum BicycleType
    {
        Street,
        BMX,
        Dirt,
        Cruiser,
        Trike,
        Unicycle
    }
}

