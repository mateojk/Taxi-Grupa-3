using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiService taxi = new TaxiService();   // w tym konstruktorze tworzą się obiekty District i Driver

            PokazMenu();


            Console.ReadKey();
        }







        static void PokazListeDzielnic(TaxiService taxi) // to do klasy "Ekran"
        {           
            Console.WriteLine("LISTA DZIELNIC");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
            // zarzad.PokazInformacjeDzielnic();
        }

        static void PokazListeTaxowek(TaxiService taxi) // to do klasy "Ekran"
        {
            Console.WriteLine("LISTA TAKSÓWEK");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA");
            // zarzad.PokazInfromacjeTaksowek();
        }

        static void PokazMenu() // to do klasy "Ekran"
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK");
            Console.WriteLine("2 => ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3: ");
            //return Console.ReadLine();
        }

        static bool CzyDobryKlawisz(string klawisz) // to w klase service?
        {
            if (klawisz == "1" || klawisz == "2" || klawisz == "3")
                return true;
            else 
                return false;
        }
    }
}







// MARGINES
//
//string WyborGracza = Console.ReadLine();
//while (!CzyDobryKlawisz(WyborGracza))
//{
//    Console.Clear();
//    PokazMenu();
//    WyborGracza = Console.ReadLine();
//}

//Console.WriteLine();




//foreach (var driv in taxi.Drivers)
//{
//    Console.WriteLine(driv.Car);
//}