using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzielnica[] dzielnice = new Dzielnica[5];
            Taksowka[] taksowki = new Taksowka[5];
            taksowki[0] = new Taksowka(1, "Ford Mondeo", "Retkinia");
            taksowki[1] = new Taksowka(2, "Dacia Logan", "Łódź Kaliska");
            taksowki[2] = new Taksowka(3, "Toyota Avensis", "Śródmieście");
            taksowki[3] = new Taksowka(4, "Mercedes E220", "Widzew");
            taksowki[4] = new Taksowka(5, "Huindai Lantra", "Janów");
            dzielnice[0] = new Dzielnica(1, "Retkinia", -2, taksowki);
            dzielnice[1] = new Dzielnica(2, "Łódź Kaliska", -1, taksowki);
            dzielnice[2] = new Dzielnica(3, "Śródmieście", 0, taksowki);
            dzielnice[3] = new Dzielnica(4, "Widzew", 1, taksowki);
            dzielnice[4] = new Dzielnica(5, "Janów", 3, taksowki);
            Zarzad zarzad = new Zarzad(dzielnice, taksowki);


            PokazMenu();
            string WyborGracza = Console.ReadLine();
            while (!CzyDobryKlawisz(WyborGracza))
            {
                Console.Clear();
                PokazMenu();
                WyborGracza = Console.ReadLine();
            }

            //Console.WriteLine();

            Console.ReadKey();
        }







        static void PokazListeDzielnic(Zarzad zarzad)
        {           
            Console.WriteLine("LISTA DZIELNIC");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");
            zarzad.PokazInformacjeDzielnic();
        }

        static void PokazListeTaxowek(Zarzad zarzad)
        {
            Console.WriteLine("LISTA TAKSÓWEK");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SAMOCHÓD | STATUS | AKTUALNA LOKALIZACJA");
            zarzad.PokazInfromacjeTaksowek();
        }

        static void PokazMenu()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK");
            Console.WriteLine("2 => ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3: ");
            //return Console.ReadLine();
        }

        static bool CzyDobryKlawisz(string klawisz)
        {
            if (klawisz == "1" || klawisz == "2" || klawisz == "3")
                return true;
            else 
                return false;
        }
    }
}
