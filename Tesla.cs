using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : IElectric
    {
        // public double BatteryKWh { get; set; }
         public int CurrentChargePercentage {get; set;} 

        // public void ChargeBattery()
        // {
        // }
        public void ChargeBattery()
        {
           if(CurrentChargePercentage != 100){
            CurrentChargePercentage = 100;
           }
           else {
            Console.WriteLine("Already at 100% chief");
           }
        }
        public void ElectricDrive()
        {
            Console.WriteLine("I am driving electrily");
        }

        // public override void Turn()
        // {
        //     Console.WriteLine($"The {MainColor} Tesla squeals around a right turn");
        // }
        // public override void Stop()
        // {
        //     Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved");
        // }
    }
}