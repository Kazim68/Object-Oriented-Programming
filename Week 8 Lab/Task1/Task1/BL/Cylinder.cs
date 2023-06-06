using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Cylinder : Circle
    {
        protected double height;

        // default constructor
        public Cylinder() { }

        // parameterized constructor
        public Cylinder(double radius) : base(radius) { }

        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = height;
        }

        // return height
        public double getHeight() { return this.height; }

        // set new height
        public void setHeight(double height) { this.height = height; }

        // return volume
        public double getVolume() { return base.getArea() * this.height; }
    }
}
