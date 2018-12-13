using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Parking;

namespace ParkingTests
{
    [TestClass]
    public class Scenarios
    {
        [TestMethod]
        public void TestFixedScenario()
        {
            ParkingLot flon = new ParkingLot(20.0);

            // Engage quelques voituriers
            flon.Hire(new Valet("James"));
            flon.Hire(new Valet("Edgar"));
            flon.Hire(new Valet("Barbara"));
            flon.Hire(new Valet("Elise"));

            // Achete quelques vehicules
            Car v1 = new Car("red");
            Car v2 = new Car("blue");
            Motorcycle m1 = new Motorcycle("Yamaha");
            Truck c1 = new Truck();

            // Effectue quelques mouvements, en attendant un peu de temps en temps
            flon.Park(v1);
            flon.Park(v2);
            flon.Park(c1);

            Thread.Sleep(3000);

            flon.Vacate(v1);
            flon.Vacate(v2);

            Thread.Sleep(3000);

            flon.Park(m1);
            flon.Vacate(c1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void TestRandomScenario()
        {
            ParkingLot flon = new ParkingLot(20.0);

            // Engage quelques voituriers
            flon.Hire(new Valet("James"));
            flon.Hire(new Valet("Edgar"));
            flon.Hire(new Valet("Barbara"));

            // Achete quelques vehicules
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("red"));
            vehicles.Add(new Car("blue"));
            vehicles.Add(new Motorcycle("Yamaha"));
            vehicles.Add(new Truck());

            // Effectue 8 mouvements au hasard, ce qui DOIT a un moment donné provoquer une exception
            Random random = new Random();
            for (int m = 0; m < 8; m++)
            {
                // Tire un vehicule au hasard
                Vehicle v = vehicles[random.Next(vehicles.Count)];

                // Tire l'opération au hasard
                if (random.Next() % 2 == 0)
                {
                    flon.Park(v);
                }
                else
                {
                    flon.Vacate(v);
                }
            }
        }
    }
}