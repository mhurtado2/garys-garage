using System;

namespace Garage
{
    public class Cessna : IElectric, IGassy
    {
        // public double FuelCapacity { get; set; }
          public int CurrentChargePercentage {get; set;} 

            public int CurrentTankPercentage {get; set;} 

        public void ChargeBattery()
          {
           if(CurrentChargePercentage != 100){
            CurrentChargePercentage = 100;
           }
           else {
            Console.WriteLine("Already at 100% chief");
           }
        }

        // public override void Drive()
        // {
        //     Console.WriteLine($"The {MainColor} Cessna Flashes by you like a hurricane.Zoooooom!");
        // }
           public void ElectricDrive()
        {
            Console.WriteLine("I am driving electrily");
        }

         public void Drive()
        {
            // Console.WriteLine($"The {MainColor} Ram growls by you. RRRrrruummmble!");
        }
        //   public void RefuelTank()
        // {
        //     // method definition omitted
        // }

        public void RefuelTank()
          {
           if(CurrentTankPercentage != 100)
           {
            CurrentTankPercentage = 100;
           }
           else 
           {
            Console.WriteLine("Already at 100% bud");
           }
        }
        // public override void Stop()
        // {
        //     Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        // }
    }
}