using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartment.BL
{
    internal class HosePipe
    {
        protected string material;
        protected string shape;
        protected int diameter;
        protected int waterFlowRate;

        // parameterized constructor
        public HosePipe(string material, string shape, int diameter, int waterFlowRate)
        {
            this.material = material;
            this.shape = shape;
            this.diameter = diameter;
            this.waterFlowRate = waterFlowRate;
        }
    }
}
