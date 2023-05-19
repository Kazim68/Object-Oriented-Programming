using Game.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { {'@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] opTriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundary b = new Boundary();
            GameObject g1 = new GameObject(triangle, new Point(5,5), "LeftToRight", b);
            GameObject g2 = new GameObject(opTriangle, new Point(30, 60), "RightToLeft", b);
            List<GameObject> lst = new List<GameObject>();
            lst.Add(g1);
            lst.Add(g2);
            while (true)
            {
                Thread.Sleep(2000);
                foreach (GameObject g in lst)
                {
                    g.erase();
                    g.move();
                    g.draw();
                }
            }
        }
    }
}
