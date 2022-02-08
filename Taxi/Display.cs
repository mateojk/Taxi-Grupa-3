using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Display
    {

        public static void MainMenu()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK");
            Console.WriteLine("2 => ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3: ");
        }

        public static void DistrictsList(List<District> districts, List<Driver> drivers)
        {
            Console.WriteLine("LISTA DZIELNIC");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
            foreach (var district in districts)
            {
                Console.WriteLine($"{district.Id} | {district.Name} | {TaxiService.HowManyDriversInDistrict(drivers, district)}");
            }
        }

        public static void DriversTitle()
        {
            Console.WriteLine("LISTA TAKSÓWEK");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA");
        }

        public static string DriverInfo(Driver driver)
        {
            
            string driverStatus;
            if (driver.StatusAvaible)
                driverStatus = "wolny";
            else
                driverStatus = "zajęty";
            string driverInfo = driver.Car + " | " + driverStatus + " | " + driver.CurrentDistric.Name;

            return driverInfo;
        }


        public static int DistricrSelection()
        {
            Console.WriteLine("PROSZĘ PODAĆ NUMER DZIELNICY DO KTÓREJ CHCESZ WEZWAĆ TAKSÓWKĘ: ");
            string usersSelection = Console.ReadLine();
            bool isSelecionVaiid = usersSelection == "1" || usersSelection == "2" || usersSelection == "3" || usersSelection == "4" || usersSelection == "5";
            if(isSelecionVaiid)
                return int.Parse(usersSelection);
            else
                return 0;
        }

    }
}
