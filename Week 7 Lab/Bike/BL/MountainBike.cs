using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike.BL
{
    internal class MountainBike : Bicycle
    {
        protected int seatHeigtht;

        public MountainBike(int seatHeigtht, int cadence, int speed, int gear) : base(cadence, speed, gear)
        {
            this.seatHeigtht = seatHeigtht;
        }

        // setter
        public void setSeatHeigtht(int seatHeigtht) { this.seatHeigtht=seatHeigtht; }
    }
}
