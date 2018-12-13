using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Parking;

namespace ParkingTests
{
    [TestClass]
    public class ParkAllTypeTest
    {
        [TestMethod]
        public void TestParkACar()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Vehicle vehicle = new Vehicle("voiture");

            flon.Park(vehicle);

            Assert.AreEqual(9.0, flon.Vacancy);
        }

        public void TestParkAMotorcylce()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Vehicle vehicle = new Vehicle("moto");

            flon.Park(vehicle);

            Assert.AreEqual(9.5, flon.Vacancy);
        }

        public void TestParkATruck()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Vehicle vehicle = new Vehicle("camion");

            flon.Park(vehicle);

            Assert.AreEqual(7.0, flon.Vacancy);
        }
    }
}
