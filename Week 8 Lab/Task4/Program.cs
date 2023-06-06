using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BL;
using Task4.DL;
using Task4.UI;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = CircleUI.takeInput();
            Rectangle r = RectangleUI.takeInput();
            Square s=SquareUI.takeInput();

            ShapeDL.addIntoList(c);
            ShapeDL.addIntoList(r);
            ShapeDL.addIntoList(s);

            foreach (Shape shape in ShapeDL.getShapes())
            {
                Console.WriteLine(shape.printInfo());
            }

            Console.ReadKey();
        }
    }
}
