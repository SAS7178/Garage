using System;

namespace Garage
{
    public class Ram : Vehicle, IGas
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
            Console.WriteLine($"The {MainColor} Ram drives past.Dang Bo!");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle takes a left");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rolls to a stop after rolling a mile down the runway.");
        }
    }
}