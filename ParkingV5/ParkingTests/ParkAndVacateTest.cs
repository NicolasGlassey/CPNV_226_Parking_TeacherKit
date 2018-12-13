using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Parking;

namespace ParkingTests
{
    [TestClass]
    public class ParkAndVacateTest
    {
        private ParkingLot flon;
        private Car christine;

        [TestInitialize]
        public void Initialize()
        {
            flon = new ParkingLot(10.0);
            flon.Hire(new Valet("James"));
            flon.Hire(new Valet("Edgar"));
            christine = new Car("red");
        }

        [TestMethod]
        public void TestParkAndVacateSameVehicle()
        {
            flon.Park(christine);
            flon.Vacate(christine);
        }

        [TestMethod]
        public void TestParkAndVacateSameVehicleMultipleTimes()
        {
            for (int i=0; i<4; i++)
            {
                flon.Park(christine);
                flon.Vacate(christine);
                Thread.Sleep(4000);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleAlreadyParkedException))]
        public void TestParkSameVehicleTwice()
        {
            flon.Park(christine);
            flon.Park(christine);
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleNotParkedException))]
        public void TestVacateNotParkedVehicle()
        {
            flon.Vacate(christine);
        }
    }
}
