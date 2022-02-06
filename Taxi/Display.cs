using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Display
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK");
            Console.WriteLine("2 => ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3: ");
        }



        public static void DisplayDrivers(List<Driver> drivers, int selectedDistrict)
        {
            bool firstDistrictSelection = selectedDistrict != 1 || selectedDistrict != 2 || selectedDistrict != 3 || selectedDistrict != 4 || selectedDistrict != 5;
            string commutingTime = "";
            string timeToSelectedDistrict = "";

            if (!firstDistrictSelection)
            {
                commutingTime = " | CZAS DOJAZDU";
                // tu ten czas ustawie
            }

            Console.WriteLine("LISTA TAKSÓWEK");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA" + commutingTime);
            foreach (var driver in drivers)
            {
                string driverStatus;
                if (driver.Status)
                    driverStatus = "wolny";
                else
                    driverStatus = "zajęty";



                    

                // if district chosen
                // jezeli wybierzemy dzielnice, to pokaze nam czas do niej
                Console.WriteLine($"{driver.Car} | {driverStatus} | {driver.Districts[driver.CurrentDistrictId - 1].Name}{timeToSelectedDistrict}");
            }
        }


        public static void DisplayDistricts(List<District> districts, List<Driver> drivers)
        {
            Console.WriteLine("LISTA DZIELNIC");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
            foreach (var district in districts)
            {
                Console.WriteLine($"{district.Id} | {district.Name} | {TaxiService.HowManyDriversInDistrict(drivers, district)}");
            }
        }


    }
}
