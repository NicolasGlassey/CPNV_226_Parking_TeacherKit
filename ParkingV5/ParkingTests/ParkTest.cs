using System;
using System.Threading;
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
            flon.Hire(new Valet("James"));
            Vehicle christine = new Vehicle(1.0);

            flon.Park(christine);

            Assert.AreEqual(9.0, flon.Vacancy);
        }

        [TestMethod]
        public void TestParkAVehicleWithJustEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(1.0);
            flon.Hire(new Valet("James"));
            Vehicle christine = new Vehicle(1.0);

            flon.Park(christine);

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [TestMethod]
        [ExpectedException(typeof(NoVacancyException))]
        public void TestParkAVehicleWithoutEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(0.5);
            flon.Hire(new Valet("James"));
            Vehicle christine = new Vehicle(1.0);

            flon.Park(christine);
        }

        [TestMethod]
        public void TestParkSeveralVehicleUptoCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);
            flon.Hire(new Valet("James"));
            flon.Hire(new Valet("Edgar"));

            for (int i=0; i<10; i++)
            {
                flon.Park(new Vehicle(1.0));
                Thread.Sleep(2000);
            }

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [TestMethod]
        [ExpectedException(typeof(NoVacancyException))]
        public void TestParkSeveralVehicleExceedingCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);
            flon.Hire(new Valet("James"));
            flon.Hire(new Valet("Edgar"));

            for (int i = 0; i < 10; i++)
            {
                flon.Park(new Vehicle(1.0));
                Thread.Sleep(2000);
            }

            Assert.AreEqual(0.0, flon.Vacancy);

            flon.Park(new Vehicle(1.0));
        }
    }
}
