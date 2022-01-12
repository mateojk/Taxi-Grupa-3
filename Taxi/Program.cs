using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Zamowienie zamowienie = new Zamowienie();
            Dzielnica[] dzielnice = new Dzielnica[5];
            Taksowka[] taksowki = new Taksowka[5];
            dzielnice[0] = new Dzielnica(1, "Retkinia", -2);
            dzielnice[1] = new Dzielnica(2, "Łódź Kaliska", -1);
            dzielnice[2] = new Dzielnica(3, "Śródmieście", 0);
            dzielnice[3] = new Dzielnica(4, "Widzew", 1);
            dzielnice[4] = new Dzielnica(5, "Janów", 3);
            taksowki[0] = new Taksowka(1, "Ford Mondeo", dzielnice[0].Nazwa);
            taksowki[1] = new Taksowka(2, "Dacia Logan", dzielnice[1].Nazwa);
            taksowki[2] = new Taksowka(3, "Toyota Avensis", dzielnice[2].Nazwa);
            taksowki[3] = new Taksowka(4, "Mercedes E220", dzielnice[3].Nazwa);
            taksowki[4] = new Taksowka(5, "Huindai Lantra", dzielnice[4].Nazwa);

            PokazMenu(); 



        }







        static void PokazListeDzielnic(Dzielnica dzielnica)
        {           
            Console.WriteLine("LISTA DZIELNIC");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("NUMER | NAZWA | ILOŚĆ TAKSÓWEK");

        }

        //static void PokazListeTaxówek

        static string PokazMenu()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK");
            Console.WriteLine("2 => ZAMÓW TAKSÓWKĘ");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3: ");
            return Console.ReadLine();
        }
    }
}
