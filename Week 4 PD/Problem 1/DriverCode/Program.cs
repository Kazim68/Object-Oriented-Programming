using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DriverCode.BL;

namespace DriverCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            string option = "";
            while (option != "5")
            {
                printMenu();
                option = takeOption();
                Console.Clear();
                if (option == "1")
                {
                    ships.Add(addShip());
                }
                else if (option == "2")
                {
                    viewPosition(ships);
                }
                else if (option == "3")
                {
                    viewSerialNumber(ships);
                }
                else if (option == "4")
                {
                    changeShipPosition(ships);
                }
                transition();
                Console.Clear();
            }
        }

        // print menu
        static void printMenu()
        {
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
        }

        // take option input
        static string takeOption()
        {
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        // add a ship. Returns the object ship
        static Ship addShip()
        {
            // serial number
            Console.Write("Enter Ship Serial Number: ");
            string serialNo = Console.ReadLine();

            // latitude
            Angle latitude = takeLatitudeLongitude("Latitude");

            // longitude
            Angle longitude = takeLatitudeLongitude("Longitude");

            // make the Ship object and return it
            Ship ship = new Ship(serialNo, latitude, longitude);
            return ship;
        }

        // makes the object of latitude and longitude
        static Angle takeLatitudeLongitude(string text)
        {
            Console.WriteLine("Enter Ship " + text + " :");
            Console.Write("Enter " + text + "'s Degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.Write("Enter " + text + "'s Minute: ");
            float minute = float.Parse(Console.ReadLine());
            Console.Write("Enter " + text + "'s direction: ");
            char direction = char.Parse(Console.ReadLine());
            Angle latitude = new Angle(degree, minute, direction);
            return latitude;
        }

        // view position
        static void viewPosition(List<Ship> ships)
        {
            Console.Write("Enter Ship Serial Number to find position: ");
            string serialNo = Console.ReadLine();

            Ship ship = checkShipBySN(serialNo, ships);
            if (ship != null)
            {
                Console.WriteLine(ship.printPosition()); 
            }
            else
            {
                Console.WriteLine("No record Found!");
            }
        }

        // check ship list by serial number
        static Ship checkShipBySN(string serialNo, List<Ship> ships)
        {
            // traverse the list for the serial number match
            foreach (Ship ship in ships)
            {
                if (ship.serialNumber == serialNo)
                {
                    return ship;
                }
            }
            return null;
        }

        // view serial number
        static void viewSerialNumber(List<Ship> ships)
        {
            // taking latitude and longitude
            Console.WriteLine("Enter Ship Latitude: ");
            string latitude = Console.ReadLine();
            Console.WriteLine("Enter Ship Longitude: ");
            string longitude = Console.ReadLine();

            // checking and printing
            Ship ship = checkByLL(latitude, longitude, ships);
            if (ship != null)
            {
                Console.WriteLine(ship.serialNumber);
            }
            else
            {
                Console.WriteLine("No Records Found!");
            }
        }

        // check ship list by latitude and longitude
        static Ship checkByLL(string latitude, string longitude, List<Ship> ships)
        {
            // traverse the list for a match
            foreach (Ship ship in ships)
            {
                if (ship.latitude.printAngle() == latitude && ship.longitude.printAngle() == longitude)
                {
                    return ship;
                }
            }
            return null;
        }

        // change position
        static void changeShipPosition(List<Ship> ships)
        {
            Console.Write("Enter Ship Serial Number to find position: ");
            string serialNo = Console.ReadLine();

            Ship ship = checkShipBySN(serialNo, ships);
            if (ship != null)
            {
                ship.latitude = takeLatitudeLongitude("Latitude");
                ship.longitude = takeLatitudeLongitude("Longitude");
            }
            else
            {
                Console.WriteLine("No Records Found!");
            }
        }

        // transition of screen
        static void transition()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
