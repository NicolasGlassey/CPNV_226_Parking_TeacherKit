using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Vehicle
    {
        private double size;
        private bool isTurnedOn;

        public Vehicle(double size)
        {
            this.size = size;
            isTurnedOn = false;
        }

        public double Size
        {
            get { return size; }
        }

        public void TurnOn()
        {
            isTurnedOn = true;
            Console.WriteLine($"Turning {ToString()} on");
        }

        public void TurnOff()
        {
            isTurnedOn = false;
            Console.WriteLine($"Turning {ToString()} off");
        }
    }
}
