using System;
using TaxiLogic;

namespace TaxiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiService taxi = new TaxiService();
            bool firstOrder = true;

            Display.MainMenu();
            District selectedDistrict = TaxiService.FirstOrderSelection(taxi.Drivers, taxi.Districts, int.Parse(Console.ReadLine()));
            int orderedDriversIndex = TaxiService.SelectFastestDriversIndex(taxi.Drivers, selectedDistrict);
            taxi.Drivers[orderedDriversIndex].CurrentDistric = selectedDistrict;
            taxi.Drivers[orderedDriversIndex].StatusAvaible = false;
            firstOrder = false;

            while (true)
            {
                selectedDistrict = TaxiService.NextSelection(taxi.Drivers, taxi.Districts, selectedDistrict, orderedDriversIndex, firstOrder);
                orderedDriversIndex = TaxiService.SelectFastestDriversIndex(taxi.Drivers, selectedDistrict);
                taxi.Drivers[orderedDriversIndex].CurrentDistric = selectedDistrict;
                taxi.Drivers[orderedDriversIndex].StatusAvaible = false;
            }
        }
    }
}
