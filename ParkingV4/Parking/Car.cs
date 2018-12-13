using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car : Vehicle
    {
        private string color;

        public Car(string color) : base(1.0)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
        }

        public override string ToString()
        {
            return $"Car {color} {Size}";
        }
    }
}
