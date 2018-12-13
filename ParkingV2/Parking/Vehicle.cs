using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Vehicle
    {
        private double size;
        private string type;

        public Vehicle(double size, string type)
        {
            this.size = size;
            this.type = type;
        }

        public Vehicle(string type)
        {
            this.type = type;
            switch (type)
            {
                case "voiture": size = 1.0; break;
                case "moto":    size = 0.5; break;
                case "camion":  size = 3.0; break;
            }
        }

        public double Size
        {
            get { return size; }
        }
    }
}
