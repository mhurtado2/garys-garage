using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. MMmmmmmm!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a right turn");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved");
        }
    }
}