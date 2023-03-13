using System;

namespace Garage
{
    public class Zero : IElectric
    {
        public double BatteryKWh { get; set; }

       public int CurrentChargePercentage {get; set ; } 
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
            // method definition omitted
    //     }
    //    public override void Drive()
    //     {
    //         Console.WriteLine($"The {MainColor} Zero rips by you. Yeeeowwww!");
    //     }

           public void ElectricDrive()
        {
            Console.WriteLine("I am driving electrily");
        }
    }
}