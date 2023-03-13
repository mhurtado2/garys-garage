using System;

namespace Garage
{
        public interface IGassy{
            public  void Drive();
             public int CurrentTankPercentage {get; set ;}
             public void RefuelTank();
        }
}