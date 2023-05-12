using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode.BL
{
    internal class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;

        // parameterized constructor
        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        // change angle
        public void changeAngle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        // print angle
        public string printAngle()
        {
            return this.degrees + "\u00b0" + this.minutes + "'" + this.direction;
        }
    }
}
