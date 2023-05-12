using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode.BL
{
    internal class Ship
    {
        public string serialNumber;
        public Angle latitude;
        public Angle longitude;

        // parameterized constructor
        public Ship(string serialNumber, Angle latitude, Angle longitude)
        {
            this.serialNumber = serialNumber;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        // print position of the ship
        public string printPosition()
        {
            return "Ship at " + latitude.printAngle() + " and " + longitude.printAngle();
        }

        // return the serial number
        public string printSerialNumber()
        {
            return this.serialNumber;
        }
    }
}
