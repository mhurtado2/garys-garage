using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
    
            //put current charged amount in instances
            Zero fxs = new Zero()
            {
                CurrentChargePercentage = 11
            };
            Zero fx = new Zero()
            {
                CurrentChargePercentage = 34
            };
            Tesla modelS = new Tesla()
            {
                CurrentChargePercentage = 50
            };

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery(); //shouldn't have parameter of charged battery
            }

            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ()
            {
                CurrentTankPercentage = 75
            };
            Cessna cessna150 = new Cessna ()
            {
                CurrentTankPercentage = 40
            };

            List<IGassy> gasVehicles = new List<IGassy>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGassy gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGassy gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGassy gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
      
        }
    }
}


//   Zero fxs = new Zero();
//             fxs.MainColor = "Midnight Blue";

//             Zero fxs2 = new Zero();
//             fxs2.MainColor = "Black";
            
//             Tesla modelS = new Tesla();
//             modelS.MainColor = "Burgundy";

//             Cessna mx410 = new Cessna();
//             mx410.MainColor = "White";

//             Ram trx = new Ram();
//             trx.MainColor = "Silver";


//             fxs.Drive();
//             fxs.Turn();
//             fxs.Stop();
//             Console.WriteLine();
//             fxs2.Drive();
//             fxs2.Turn();
//             fxs2.Stop();
//             Console.WriteLine();
//             modelS.Drive();
//             modelS.Turn();
//             modelS.Stop();
//             Console.WriteLine();
//             mx410.Drive();
//             mx410.Turn();
//             mx410.Stop();
//             Console.WriteLine();
//             trx.Drive();
//             trx.Turn();
//             trx.Stop();