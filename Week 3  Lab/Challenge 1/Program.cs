using Challenge_1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // default constructor
            ClockType emptyTime = new ClockType();
            Console.Write("Empty time: ");
            emptyTime.prinTime();

            // parameterized constructor -> hours
            ClockType hourTime = new ClockType(8);
            Console.Write("Hour time: ");
            hourTime.prinTime();

            // parameterized constructor -> hours + minutes
            ClockType minuteTime = new ClockType(8, 10);
            Console.Write("Minutes time: ");
            minuteTime.prinTime();

            // parameterized constructor -> hours + minutes + seconds 
            ClockType secondTime = new ClockType(8, 10, 10);
            Console.Write("Seconds time: ");
            secondTime.prinTime();

            // increments

            // seconds
            secondTime.incrementSecond();
            Console.Write("Seconds increments: ");
            secondTime.prinTime();

            // hours
            secondTime.incrementHours();
            Console.Write("Hours increments: ");
            secondTime.prinTime();

            // mintes
            secondTime.incrementMinutes();
            Console.Write("Minutes increments: ");
            secondTime.prinTime();

            // checks

            // by value
            bool check = secondTime.isEqual(9, 11, 11);
            Console.WriteLine("Check: " + check);

            // by obj
            ClockType temp = new ClockType(10, 12, 1);
            check = secondTime.isEqual(temp);
            Console.WriteLine("Obj Check: " + check);

            // check elapsed time
            secondTime.displayTime(secondTime.elapsedTime());

            // check remaining time
            secondTime.displayTime(secondTime.remainingTime());

            // screen stop
            Console.ReadKey();
        }
    }
}
