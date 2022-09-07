using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; } 
     
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
            Console.WriteLine($"The {MainColor} Zero drives past.Zeroooo!");
        }
                public override void Turn()
        {
            Console.WriteLine($"The Zero gonna take a veer left!");
        }
                public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero stops abruptly!");
        }
    }
}