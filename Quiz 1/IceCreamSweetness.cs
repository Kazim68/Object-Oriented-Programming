using System;
using System.Collections.Generic;
using System.Linq;

namespace IceCreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IceCream> ices = GetIceCreamsFromInput();
            Console.WriteLine(SweetestIceCream(ices));
        }

        public static List<IceCream> GetIceCreamsFromInput()
        {
            List<IceCream> iceCreams = new List<IceCream>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                string[] _params = Console.ReadLine().Split(' ');
                IceCream _iceCream = new IceCream(_params[0], int.Parse(_params[1]));
                iceCreams.Add(_iceCream);
            }

            return iceCreams;
        }

        public static int SweetestIceCream(List<IceCream> icecream)
        {
            // Write your Code Here
            int sweet = -1;
            foreach (IceCream ice in icecream)
            {
                if (ice.sweetness + ice.sprinkles > sweet)
                {
                    sweet = ice.sweetness + ice.sprinkles;
                }
            }
        }
    }

    public class IceCream
    {
	// Write your Class Here
        public string name;
        public int sprinkles;
        public int sweetness;

        public IceCream(string name, int sprinkles)
        {
            this.name = name;
            this.sprinkles = sprinkles;
            if (name == "Plain")
            {
                this.sweetness = 0;
            }
            else if (name == "Vanilla")
            {
                this.sweetness = 5;
            }
            else if (name == "ChocolateChip")
            {
                this.sweetness = 5;
            }
            else if (name == "Strawberry")
            {
                this.sweetness = 10;
            }
            else if (name == "Chocolate")
            {
                this.sweetness = 10;
            }
        }


    }
}
