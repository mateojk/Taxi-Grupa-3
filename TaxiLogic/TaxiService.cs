using System;
using System.Collections.Generic;

namespace TaxiLogic
{
    public class TaxiService
    {
        public TaxiService()
        {
            CreateDistricts();
            CreateDrivers();
        }

        public List<District> Districts { get; set; } = new List<District>();
        private void CreateDistricts()
        {
            Districts.Add(new District(1, "Retkinia", -2));
            Districts.Add(new District(2, "Łódź Kaliska", -1));
            Districts.Add(new District(3, "Śródmieście", 0));
            Districts.Add(new District(4, "Widzew", 1));
            Districts.Add(new District(5, "Janów", 3));
        }


        public List<Driver> Drivers { get; set; } = new List<Driver>();
        public static object Display { get; private set; }

        private void CreateDrivers()
        {           
            Drivers.Add(new Driver(1, "Ford Mondeo", Districts[0]));
            Drivers.Add(new Driver(2, "Dacia Logan", Districts[1]));
            Drivers.Add(new Driver(3, "Toyota Avensis", Districts[2])); 
            Drivers.Add(new Driver(4, "Mercedes E220", Districts[3]));
            Drivers.Add(new Driver(5, "Huindai Lantra", Districts[4]));
        }


        public static int HowManyDriversInDistrict(List<Driver> drivers, District district)
        {
            int driversInDirstrict = 0;
            foreach (var driver in drivers)
            {
                if (driver.CurrentDistric == district)
                    driversInDirstrict++;
            }

            return driversInDirstrict;
        }


        public static int CommuteTime(Driver driver, District district)
        {
            int commuteTime;
            if (driver.CurrentDistric == district)
                commuteTime = 4;
            else
                commuteTime = Math.Abs(driver.CurrentDistric.DistanceFromTheCenter - district.DistanceFromTheCenter) * 5;
            if (!driver.StatusAvaible)
                commuteTime += 12;

            return commuteTime;
        }


        public static int SelectFastestDriversIndex(List<Driver> drivers, District district)
        {
            int fastestDriverIndex = 0;
            int fastestCommuteTime = CommuteTime(drivers[0], district);
            drivers[0].TimeToOrderedDistrict = CommuteTime(drivers[0], district);

            for (int i = 1; i < drivers.Count; i++)
            {
                drivers[i].TimeToOrderedDistrict = CommuteTime(drivers[i], district);
                if (fastestCommuteTime > CommuteTime(drivers[i], district))
                {
                    fastestCommuteTime = CommuteTime(drivers[i], district);
                    fastestDriverIndex = i;
                }
            } 

            return fastestDriverIndex;
        }


        public static District FirstOrderSelection(List<Driver> drivers, List<District> districts, int usersNumber)
        {
            bool isUsersNumberValid = usersNumber == 1 || usersNumber == 2;
            while (!isUsersNumberValid)
            {
                Console.Clear();
                Display.MainMenu();
                usersNumber = int.Parse(Console.ReadLine());
                isUsersNumberValid = usersNumber == 2;
                if (usersNumber == 3)
                    Environment.Exit(0);
            }

            if (usersNumber == 1)
            {
                Console.Clear();
                Display.DistrictsList(districts, drivers);
                Display.DriversTitle();
                foreach (var driver in drivers)
                {
                    Console.WriteLine(Display.DriverInfo(driver));
                }
                Display.MainMenu();
                usersNumber = int.Parse(Console.ReadLine());
                isUsersNumberValid = usersNumber == 2;
                while (!isUsersNumberValid)
                {
                    Console.Clear();
                    if (usersNumber == 3)
                        Environment.Exit(0);
                    Display.DistrictsList(districts, drivers);
                    Display.DriversTitle();
                    foreach (var driver in drivers)
                    {
                        Console.WriteLine(Display.DriverInfo(driver));
                    }
                    Display.MainMenu();
                    usersNumber = int.Parse(Console.ReadLine());
                    isUsersNumberValid = usersNumber == 2;
                }
            }

            if (usersNumber == 2)
            {
                Console.Clear();
                usersNumber = Display.DistricrSelection();
                isUsersNumberValid = usersNumber == 1 || usersNumber == 2 || usersNumber == 3 || usersNumber == 4 || usersNumber == 5;
                while (!isUsersNumberValid)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NIEPRAWIDŁOWY NUMER DZIELNICY");
                    Console.ForegroundColor = ConsoleColor.White;
                    usersNumber = Display.DistricrSelection();
                    isUsersNumberValid = usersNumber == 1 || usersNumber == 2 || usersNumber == 3 || usersNumber == 4 || usersNumber == 5;
                }
            }


            return districts[usersNumber - 1];
        }


        public static District NextSelection(List<Driver> drivers, List<District> districts, District selectedDistrict,int orderedDriversIndex, bool firstOrder)
        {
            {
                Console.Clear();
                Display.OrderedDriversInfo(drivers[orderedDriversIndex], selectedDistrict);
                Display.DistrictsList(districts, drivers);
                Display.DriversTitle();
                foreach (var driver in drivers)
                {
                    if (!firstOrder)
                        Console.WriteLine($"{Display.DriverInfo(driver)} | ({driver.TimeToOrderedDistrict} min.)");
                    else
                        Console.WriteLine(Display.DriverInfo(driver));
                }
                int usersNumber = Display.DistricrSelection();
                bool isUsersNumberValid = usersNumber == 1 || usersNumber == 2 || usersNumber == 3 || usersNumber == 4 || usersNumber == 5;
                while (!isUsersNumberValid)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NIEPRAWIDŁOWY NUMER DZIELNICY");
                    Console.ForegroundColor = ConsoleColor.White;
                    usersNumber = Display.DistricrSelection();
                    isUsersNumberValid = usersNumber == 1 || usersNumber == 2 || usersNumber == 3 || usersNumber == 4 || usersNumber == 5;
                }

                return districts[usersNumber - 1];
            }
        }

    }
}

