using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Truck : Vehicle
    {
        public Truck() : base(3.0)
        {
        }

        public override string ToString()
        {
            return $"Truck {Size}";
        }
    }
}
