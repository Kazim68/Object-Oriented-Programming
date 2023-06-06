using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireDepartment.UI;

namespace FireDepartment.BL
{
    internal class FireTruck
    {
        protected Ladder ladder;
        protected HosePipe hosePipe;
        protected FireFighter fireFighter;
        protected FireChief fireChief;

        // parameterized constructor
        public FireTruck(HosePipe hosePipe, FireFighter fireFighter, FireChief fireChief)
        {
            this. hosePipe = hosePipe;
            this.fireFighter = fireFighter;
            this.fireChief = fireChief;
            this.ladder = Inputs.ladder();
        }
    }
}
