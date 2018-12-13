using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Valet
    {
        private string name;
        private bool available;

        public Valet(string name)
        {
            this.name = name;
            available = true;
        }

        public bool Available
        {
            get { return available; }
        }

        public void Drive(Vehicle vehicle)
        {
            if (!available)
            {
                throw new BusyValetException();
            }

            available = false;
            vehicle.TurnOn();

            // The content of this anonymous function is run asynchronously.
            // Thus the normal control flows directly after this block
            Task.Run(async () =>
            {
                // Wait 2 seconds per vehicle size
                await Task.Delay((int)(vehicle.Size*2000));

                // After this delay, continue with the housekeeping stuff
                vehicle.TurnOff();
                available = true;
            });
        }
    }
}
