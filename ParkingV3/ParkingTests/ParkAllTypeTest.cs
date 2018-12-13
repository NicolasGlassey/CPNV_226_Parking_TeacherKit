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
            Vehicle vehicle = new Car("white");

            flon.Park(vehicle);

            Assert.AreEqual(9.0, flon.Vacancy);
        }

        [TestMethod]
        public void TestParkAMotorcylce()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Vehicle vehicle = new Motorcycle("suzuki");

            flon.Park(vehicle);

            Assert.AreEqual(9.5, flon.Vacancy);
        }

        [TestMethod]
        public void TestParkATruck()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Vehicle vehicle = new Truck();

            flon.Park(vehicle);

            Assert.AreEqual(7.0, flon.Vacancy);
        }
    }
}
