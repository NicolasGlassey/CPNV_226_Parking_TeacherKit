using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Vehicle
    {
        private double size;

        public Vehicle(double size)
        {
            this.size = size;
        }

        public double Size
        {
            get { return size; }
        }
    }
}
