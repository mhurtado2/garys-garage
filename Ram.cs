using System;

namespace Garage
{
    public class Ram : IGassy  // Gas powered truck
    {
        // public double FuelCapacity { get; set; }

          public int CurrentTankPercentage {get; set; } 

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
         public void Drive()
        {
            // Console.WriteLine($"The {MainColor} Ram growls by you. RRRrrruummmble!");
        }
    }
}