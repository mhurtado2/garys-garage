using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";

            Zero fxs2 = new Zero();
            fxs2.MainColor = "Black";
            
            Tesla modelS = new Tesla();
            modelS.MainColor = "Burgundy";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White";

            Ram trx = new Ram();
            trx.MainColor = "Silver";


            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine();
            fxs2.Drive();
            fxs2.Turn();
            fxs2.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine();
            trx.Drive();
            trx.Turn();
            trx.Stop();
        }
    }
}
