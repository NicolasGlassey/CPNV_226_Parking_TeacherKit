using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Parking;

namespace ParkingTests
{
    [TestClass]
    public class ParkTest
    {
        [TestMethod]
        public void TestParkAVehicleWithEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Vehicle christine = new Vehicle(1.0, "voiture");

            flon.Park(christine);

            Assert.AreEqual(9.0, flon.Vacancy);
        }

        [TestMethod]
        public void TestParkAVehicleWithJustEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(1.0);
            Vehicle christine = new Vehicle(1.0, "voiture");

            flon.Park(christine);

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestParkAVehicleWithoutEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(0.5);
            Vehicle christine = new Vehicle(1.0, "voiture");

            flon.Park(christine);
        }

        [TestMethod]
        public void TestParkSeveralVehicleUpToCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);

            for (int i=0; i<10; i++)
            {
                flon.Park(new Vehicle(1.0, "voiture"));
            }

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestParkSeveralVehicleExceedingCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);

            for (int i = 0; i < 10; i++)
            {
                flon.Park(new Vehicle(1.0, "voiture"));
            }

            Assert.AreEqual(0.0, flon.Vacancy);

            flon.Park(new Vehicle(1.0, "voiture"));
        }
    }
}
