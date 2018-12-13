using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        private double size;

        public Car(double size)
        {
            this.size = size;
        }

        public double Size
        {
            get { return size; }
        }
    }
}
