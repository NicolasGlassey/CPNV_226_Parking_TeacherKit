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

        public void Park(Vehicle vehicle)
        {
            if (vacancy - vehicle.Size < 0)
            {
                throw new Exception("No more vacancy");
            }

            vacancy -= vehicle.Size;
        }
    }
}
