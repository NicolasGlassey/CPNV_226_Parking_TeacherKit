using System;

namespace Parking
{
    public class ParkingLot
    {
        private double capacity;
        private double vacancy;

        public ParkingLot(double capacity)
        {
            this.capacity = capacity;
            vacancy = capacity;
        }

        public double Vacancy
        {
            get { return vacancy; }
        }

        public void Park(Car car)
        {
            if (vacancy - car.Size < 0)
            {
                throw new Exception("No more vacancy");
            }

            vacancy -= car.Size;
        }
    }
}
