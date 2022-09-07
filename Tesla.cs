using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; } = 25;

           public void initialCharge(int charge)
        {
            BatteryKWh = charge;
        } 
        public void ChargeBattery()
        {
            BatteryKWh = 100;// method definition omitted
        }
       public void CurrentChargePercentage()
        {
            Console.WriteLine($"{BatteryKWh}");
        }

                public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past.-----psh!");
        }
         public override void Turn()
        {
            Console.WriteLine("The vehicle takes a left");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla rolls to a stop after rolling a mile down the runway.");
        }
    }
}