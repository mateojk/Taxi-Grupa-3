using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiService taxi = new TaxiService();   // w tym konstruktorze tworzą się obiekty District i Driver

            bool firstOrder = true;

            //1
            Display.MainMenu();
            int usersNumber = int.Parse(Console.ReadLine());
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
                Display.DistrictsList(taxi.Districts, taxi.Drivers);
                Display.DriversTitle();
                foreach (var driver in taxi.Drivers)
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
                    Display.DistrictsList(taxi.Districts, taxi.Drivers);
                    Display.DriversTitle();
                    foreach (var driver in taxi.Drivers)
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
                District selectedDistrict = taxi.Districts[usersNumber - 1];
                firstOrder = false;



                while (true)
                {
                    //  dzielnia wybrana
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Kto i ile jedzie");
                    Console.ForegroundColor = ConsoleColor.White;
                    Display.DistrictsList(taxi.Districts, taxi.Drivers);
                    Display.DriversTitle();
                    foreach (var driver in taxi.Drivers)
                    {
                        if (!firstOrder)
                            Console.WriteLine(Display.DriverInfo(driver) + " | " + TaxiService.CommuteTime(driver, selectedDistrict));
                        else
                            Console.WriteLine(Display.DriverInfo(driver));
                    }
                    usersNumber = Display.DistricrSelection();
                    isUsersNumberValid = usersNumber == 1 || usersNumber == 2 || usersNumber == 3 || usersNumber == 4 || usersNumber == 5;
                    while (!isUsersNumberValid)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Kto i ile jedzie");
                        Console.ForegroundColor = ConsoleColor.White;
                        Display.DistrictsList(taxi.Districts, taxi.Drivers);
                        Display.DriversTitle();
                        foreach (var driver in taxi.Drivers)
                        {
                            if (!firstOrder)
                                Console.WriteLine(Display.DriverInfo(driver) + " | " + TaxiService.CommuteTime(driver, selectedDistrict));
                            else
                                Console.WriteLine(Display.DriverInfo(driver));
                        }
                        usersNumber = Display.DistricrSelection();
                        isUsersNumberValid = usersNumber == 1 || usersNumber == 2 || usersNumber == 3 || usersNumber == 4 || usersNumber == 5;
                    }

                    selectedDistrict = taxi.Districts[usersNumber - 1];

                }
            }

        }

        //Environment.Exit(0);


    }
}





