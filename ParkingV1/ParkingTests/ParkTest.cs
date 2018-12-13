using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parking;

namespace ParkingTests
{
    [TestClass]
    public class ParkTest
    {
        [TestMethod]
        public void TestParkACarWithEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Car christine = new Car(1.0);

            flon.Park(christine);

            Assert.AreEqual(9.0, flon.Vacancy);
        }

        [TestMethod]
        public void TestParkACarWithJustEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(1.0);
            Car christine = new Car(1.0);

            flon.Park(christine);

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestParkACarWithoutEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(0.5);
            Car christine = new Car(1.0);

            flon.Park(christine);
        }

        [TestMethod]
        public void TestParkSeveralCarsUptoCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);

            for (int i=0; i<10; i++)
            {
                flon.Park(new Car(1.0));
            }

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestParkSeveralCarsExceedingCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);

            for (int i = 0; i < 10; i++)
            {
                flon.Park(new Car(1.0));
            }

            Assert.AreEqual(0.0, flon.Vacancy);

            flon.Park(new Car(1.0));
        }
    }
}
