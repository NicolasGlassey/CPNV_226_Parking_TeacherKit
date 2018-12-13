using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Motorcycle : Vehicle
    {
        private string brand;

        public Motorcycle(string brand) : base(0.5)
        {
            this.brand = brand;
        }

        public string Brand
        {
            get { return brand; }
        }

        public override string ToString()
        {
            return $"Motorcycle {brand} {Size}";
        }
    }
}
