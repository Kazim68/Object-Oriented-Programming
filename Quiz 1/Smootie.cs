using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;

namespace Ques2
{
	internal class Program
	{
        static List<ingredients> items = new List<ingredients>();
        static void Main(string[] args)
        {
            ingredients ingredient1 = new ingredients("Strawberries", 1.50);
            items.Add(ingredient1);
            ingredients ingredient2 = new ingredients("Banana", 0.50);
            items.Add(ingredient2);
            ingredients ingredient3 = new ingredients("Mango", 2.50);
            items.Add(ingredient3);
            ingredients ingredient4 = new ingredients("Blueberries", 1.00);
            items.Add(ingredient4);
            ingredients ingredient5 = new ingredients("Raspberries", 1.00);
            items.Add(ingredient5);
            ingredients ingredient6 = new ingredients("Apple", 1.75);
            items.Add(ingredient6);
            ingredients ingredient7 = new ingredients("Pineapple", 3.50);
            items.Add(ingredient7);

            List<string> smoothies = GetSmoothieFromInput();
            Smoothie s = new Smoothie(smoothies);
            outputResult(s);
        }

        public static void outputResult(Smoothie s)
        {

            Console.WriteLine(Math.Round(s.GetCost(), 2));
            Console.WriteLine(Math.Round(s.GetPrice(), 2));
            Console.WriteLine(s.GetName());
            Console.ReadKey();
        }
        public static List<string> GetSmoothieFromInput()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ingredients = new List<string>();
            for (int i = 0; i < n; ++i)
            {
                string _params = Console.ReadLine();
                ingredients.Add(_params);
            }
            return ingredients;
        }

        public class Smoothie
        {
            public List<string> Ingredients = new List<string>();
            public Smoothie(List<string> Ingredients)
            {
                // Write Code Here
                this.Ingredients = Ingredients;
            }

            public double GetCost()
            {
                // Write Code Here
                double cost = 0.0D;
                foreach (string ingredient in this.Ingredients)
                {
                    foreach (ingredients i in items)
                    {
                        if (i.name == ingredient)
                        {
                            cost += i.price;
                            break;
                        }
                    }
                }
                return cost;
            }
            public double GetPrice()
            {
                // Write Code Here
                return GetCost() + (GetCost() * 1.50F);
            }
            public string GetName()
            {

                // Write Code Here
                if (Ingredients.Count == 0)
                {
                    return smoothieName(Ingredients[0]) + "Smoothie";
                }
                List<string> ing = Ingredients;
                ing.Sort();
                string name = "";
                foreach (string i in ing)
                {
                    name += smoothieName(i) + " ";
                }
                return name + "Fusion";
            }

            public string smoothieName(string name)
            {
                if (name == items[0].name)
                {
                    return "Strawberry";
                }
                else if (name == items[3].name)
                {
                    return "Blueberry";
                }
                else if (name == items[4].name)
                {
                    return "Raspberry";
                }
                return name;
            }

        }
        public class ingredients
        {
            public string name;
            public double price;

            public ingredients(string name, double price)
            {
                // Write Code Here
                this.name = name;
                this.price = price;
            }
        }


    }
}
