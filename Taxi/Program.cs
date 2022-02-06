using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiService taxi = new TaxiService();   // w tym konstruktorze tworzą się obiekty District i Driver
            int SelectedDistrict = 0;


            int CustomersNumber = TaxiService.StartMenu();

            while (CustomersNumber != 3)
            {
                Console.Clear();
                switch (CustomersNumber)
                {
                    case 1:
                        CustomersNumber = TaxiService.DistrictsDriversMenu(taxi.Districts, taxi.Drivers, SelectedDistrict);
                        break;
                    case 2:
                        // jezeli taksowka zostala juz wybrana
                        int newSelectedDistrict = TaxiService.SelectDistrict(SelectedDistrict);
                        SelectedDistrict = newSelectedDistrict;
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:           // każdy inny przypadek  
                        Console.WriteLine("LALALA");
                        break;
                }
            }

            





            //w tym momencie customersnumber to 1 lub 2 lub 3

            //Environment.Exit(0);








        }

    }

    


}





