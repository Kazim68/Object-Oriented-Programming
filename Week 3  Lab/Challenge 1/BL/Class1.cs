using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1.BL
{
    internal class ClockType
    {
        public int hours;
        public int minutes;
        public int seconds;


        // default constructor
        public ClockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        // parameter contructor

        // only hours
        public ClockType(int h)
        {
            hours = h;
        }
        // hours and minutes
        public ClockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        // hours, minutes and seconds
        public ClockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        // increments

        //seconds
        public void incrementSecond()
        {
            seconds++;
        }
        // hours
        public void incrementHours()
        {
            hours++;
        }
        // minutes
        public void incrementMinutes()
        {
            minutes++;
        }

        // print time
        public void prinTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }

        // check if entered time is equal
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            return false;
        }

        // check if time of entered object is equal
        public bool isEqual(ClockType time)
        {
            if (hours == time.hours && minutes == time.minutes && seconds == time.seconds)
            {
                return true;
            }
            return false;
        }

        // elapsed time
        public int elapsedTime()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }

        // remaining time
        public int remainingTime()
        {
            return (24 * 3600) - elapsedTime();
        }

        // display time from seconds
        public void displayTime(int time)
        {
            int h = time / 3600;
            int m = (time % 3600) / 60;
            int s = time - (h * 3600) - (m * 60);
            Console.WriteLine(h + " " + m + " " + s);
        }
    }
}
