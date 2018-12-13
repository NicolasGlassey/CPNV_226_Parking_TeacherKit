using System;
using System.Collections.Generic;

namespace Parking
{
    public class ParkingLot
    {
        private double capacity;
        private double vacancy;
        private List<Valet> valets;
        private List<Vehicle> parkedVehicles;

        public ParkingLot(double capacity)
        {
            this.capacity = capacity;
            vacancy = capacity;
            valets = new List<Valet>();
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

            ChooseValet().Drive(vehicle);

            vacancy -= vehicle.Size;
            parkedVehicles.Add(vehicle);
        }

        public void Vacate(Vehicle vehicle)
        {
            if (!parkedVehicles.Contains(vehicle))
            {
                throw new VehicleNotParkedException();
            }

            ChooseValet().Drive(vehicle);

            vacancy += vehicle.Size;
            parkedVehicles.Remove(vehicle);
        }

        public void Hire(Valet valet)
        {
            if (valets.Contains(valet))
            {
                throw new ValetAlreadyHiredException();
            }

            valets.Add(valet);
        }

        public void Fire(Valet valet)
        {
            if (!valets.Contains(valet))
            {
                throw new ValetNotHiredException();
            }

            valets.Remove(valet);
        }

        private Valet ChooseValet()
        {
            foreach (Valet valet in valets)
            {
                if (valet.Available)
                {
                    return valet;
                }
            }

            throw new NoValetsAvailableException();
        }
    }
}
