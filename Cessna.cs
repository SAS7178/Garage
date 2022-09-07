using System;
namespace Garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; } 

                public void initialCapacity(int fuel)
        {
            FuelCapacity = fuel;
        } 
            public void RefuelTank()
        {
            FuelCapacity = 100; // method definition omitted
        }
              public void CurrentTankPercentage()
        {
            Console.WriteLine($"{FuelCapacity}");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past.yeeeeennn!");
        }
               public override void Turn()
        {
            Console.WriteLine("The vehicle takes a right");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}