using System;

namespace Garage
{
        public interface IElectric{
            public  void ElectricDrive();
             public int CurrentChargePercentage {get; set;} 
             public void ChargeBattery(); //shouldn't have parameter of charged battery
        }
}

