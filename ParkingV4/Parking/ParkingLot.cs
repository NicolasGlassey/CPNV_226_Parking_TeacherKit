using System;
using System.Collections.Generic;

namespace Parking
{
    public class ParkingLot
    {
        private double capacity;
        private double vacancy;
        private List<Vehicle> parkedVehicles;

        public ParkingLot(double capacity)
        {
            this.capacity = capacity;
            vacancy = capacity;
            parkedVehicles = new List<Vehicle>();
        }

        public double Vacancy
        {
            get { return vacancy; }
        }

        public void Park(Vehicle vehicle)
        {
            if (vacancy - vehicle.Size < 0)
            {
                throw new NoVacancyException();
            }

            if (parkedVehicles.Contains(vehicle))
            {
                throw new VehicleAlreadyParkedException();
            }

            vehicle.TurnOn();
            vehicle.TurnOff();

            vacancy -= vehicle.Size;
            parkedVehicles.Add(vehicle);
        }

        public void Vacate(Vehicle vehicle)
        {
            if (!parkedVehicles.Contains(vehicle))
            {
                throw new VehicleNotParkedException();
            }

            vehicle.TurnOn();
            vehicle.TurnOff();

            vacancy += vehicle.Size;
            parkedVehicles.Remove(vehicle);
        }

    }
}
