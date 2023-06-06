using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    internal class Circle
    {
        protected double radius;
        protected string color;

        // default constructor
        public Circle() { }

        // parameterized constructed

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        // return radius
        public double getRadius() { return this.radius; }

        // set new radius
        public void setRadius(double radius) { this.radius = radius; }

        // get color
        public string getColor() { return this.color; }

        // set new color
        public void setColor(string color) { this.color = color; }

        // return area
        public double getArea()
        {
            return 3.142F * this.radius * this.radius;
        }

        // return a string with circle information
        public string toString()
        {
            return "Circle[radius=" + this.radius + ", color=" + this.color + "]";
        }
    }
}
