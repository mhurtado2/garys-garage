using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna Flashes by you like a hurricane.Zoooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}