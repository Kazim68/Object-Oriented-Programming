using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class ColorsDL
    {
        protected static List<string> colors = new List<string>();
        protected static int idx = 0;
        
        // add color
        public static void addColor(string color)
        {
            colors.Add(color);
        }

        // get color
        public static string getColor()
        {
            return colors[idx % 3];
        }

        // back color
        public static void backColor() { idx--;
            if (idx == -1) { idx = 2; }
        }

        // get next color
        public static void nextColor() { idx++; }
    }
}
