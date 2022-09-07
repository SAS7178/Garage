using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.initialCharge(10);
            Zero fx = new Zero();
            fx.initialCharge(20);
            Tesla modelS = new Tesla();
            modelS.initialCharge(40);
            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                    ev.CurrentChargePercentage();
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {

                ev.CurrentChargePercentage();
            }

            /***********************************************/

            Ram ram = new Ram();
            ram.initialCapacity(10);
            Cessna cessna150 = new Cessna();
             cessna150.initialCapacity(20);
            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                gv.CurrentTankPercentage();
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                gv.CurrentTankPercentage();
            }
        }
    }
}