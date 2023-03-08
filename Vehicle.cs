using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
          public virtual void Turn()
        {
            Console.WriteLine("The vehical carefully turns right");
        }
          public virtual void Stop()
        {
            Console.WriteLine("The vehical gently rolls to a stop!");
        }
    }
}