using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.BL
{
    internal class Cell
    {
        public char value;
        public int x;
        public int y;

        // parameterized constructor
        public Cell(char value, int x, int y)
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }

        // returns the value stored in cell
        public char getValue() { return this.value; }

        // returns the x value of cell
        public int getX() { return this.x;}

        // returns the y value of cell
        public int getY() { return this.y;}

        // checks if pacman is present and returns a bool
        public bool isPacmanPresent()
        {
            if (this.value == 'P') { return true; }
            return false;
        }

        // checks if ghost is present and returns a bool
        public bool isGhostPresent(char ghost)
        {
            if (this.value == ghost) { return true; }
            return false;
        }
    }
}
