using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Parking;

namespace ParkingTests
{
    [TestClass]
    public class ParkAllTypeTest
    {
        private ParkingLot flon;

        [TestInitialize]
        public void Initialize()
        {
            flon = new ParkingLot(10.0);
            flon.Hire(new Valet("James"));
        }

        [TestMethod]
        public void TestParkACar()
        {
            Vehicle vehicle = new Car("white");

            flon.Park(vehicle);

            Assert.AreEqual(9.0, flon.Vacancy);
        }

        [TestMethod]
        public void TestParkAMotorcylce()
        {
            Vehicle vehicle = new Motorcycle("suzuki");

            flon.Park(vehicle);

            Assert.AreEqual(9.5, flon.Vacancy);
        }

        [TestMethod]
        public void TestParkATruck()
        {
            Vehicle vehicle = new Truck();

            flon.Park(vehicle);

            Assert.AreEqual(7.0, flon.Vacancy);
        }
    }
}
