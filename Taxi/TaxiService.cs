using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
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
        private void CreateDrivers()
        {
            
            Drivers.Add(new Driver(1, "Ford Mondeo", Districts, 1));
            Drivers.Add(new Driver(2, "Dacia Logan", Districts, 2));
            Drivers.Add(new Driver(3, "Toyota Avensis", Districts, 3)); 
            Drivers.Add(new Driver(4, "Mercedes E220", Districts, 4));
            Drivers.Add(new Driver(5, "Huindai Lantra", Districts, 5));
        }





        public static int StartMenu()
        {
            Display.DisplayMainMenu();
            string customersNumber = Console.ReadLine();
            bool isCustomersNumberValid = customersNumber == "1" || customersNumber == "2" || customersNumber == "3";
            while (!isCustomersNumberValid)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NIEPRAWIDŁOWY NUMER");
                Console.ForegroundColor = ConsoleColor.White;
                Display.DisplayMainMenu();
                customersNumber = Console.ReadLine();
                isCustomersNumberValid = customersNumber == "1" || customersNumber == "2" || customersNumber == "3";
            }

            return int.Parse(customersNumber);
        }




        public static int DistrictsDriversMenu(List<District> districts, List<Driver> drivers, int selectedDistrict)
        {
            Display.DisplayDistricts(districts, drivers);
            Display.DisplayDrivers(drivers, selectedDistrict);
            Display.DisplayMainMenu();
            string customersNumber = Console.ReadLine();
            bool isCustomersNumberValid = customersNumber == "1" || customersNumber == "2" || customersNumber == "3";
            while(!isCustomersNumberValid)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NIEPRAWIDŁOWY NUMER");
                Console.ForegroundColor = ConsoleColor.White;
                Display.DisplayDistricts(districts, drivers);
                Display.DisplayDrivers(drivers, selectedDistrict);
                Display.DisplayMainMenu();
                customersNumber = Console.ReadLine();
                isCustomersNumberValid = customersNumber == "1" || customersNumber == "2" || customersNumber == "3";
            }

            return int.Parse(customersNumber);
        }




        public static int SelectDistrict(int selectedDistrict)
        {
            bool firstDistrictSelection = selectedDistrict == 0;
            string newSelectedDistrict;

            if (firstDistrictSelection)
            {
                Console.WriteLine("PROSZĘ PODAĆ NUMER DZIELNICY DO KTÓREJ CHCESZ WEZWAĆ TAKSÓWKĘ:");
                newSelectedDistrict = Console.ReadLine();
                bool isSelectedDistrictValid = newSelectedDistrict == "1" || newSelectedDistrict == "2" || newSelectedDistrict == "3" || newSelectedDistrict == "4" || newSelectedDistrict == "5";
                while (!isSelectedDistrictValid)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NIEPRAWIDŁOWY NUMER DZIELNICY");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("PROSZĘ PODAĆ NUMER DZIELNICY DO KTÓREJ CHCESZ WEZWAĆ TAKSÓWKĘ:");
                    newSelectedDistrict = Console.ReadLine();
                    isSelectedDistrictValid = newSelectedDistrict == "1" || newSelectedDistrict == "2" || newSelectedDistrict == "3" || newSelectedDistrict == "4" || newSelectedDistrict == "5";
                }
            }
            else
            {

                // kto realizuje zlecenie
                //  districtdriversmenu
                Console.WriteLine("dupaduapadasdasd");
                newSelectedDistrict = Console.ReadLine();
            }


            return int.Parse(newSelectedDistrict);
        }




        public static int HowManyDriversInDistrict(List<Driver> drivers, District district)
        {
            int driversInDirstrict = 0;
            foreach (var driver in drivers)
            {
                if (driver.CurrentDistrictId == district.Id)
                    driversInDirstrict++;
            }

            return driversInDirstrict;
        }


    }
}



