using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Zarzad
    {
        public Zarzad(Dzielnica[] dzielnice, Taksowka[] taksowki)
        {
            this.dzielnice = dzielnice;
            this.taksowki = taksowki;
        }

        private Dzielnica[] dzielnice;
        private Taksowka[] taksowki;

        public string CzyTaxiWolne(Taksowka taxi)
        {
            if (taxi.CzyWolny)
                return "wolny";
            else
                return "zajęty";
        }

        public void PokazInformacjeDzielnic()
        {
            for (int i = 0; i < dzielnice.Length; i++)
            {
                Console.WriteLine($"{dzielnice[i].Id} | {dzielnice[i].Nazwa} | {dzielnice[i].IloscTaxi}");
            }
        }
        
        public void PokazInfromacjeTaksowek()
        {
            for (int i = 0; i < taksowki.Length; i++)
            {
                Console.WriteLine($"{taksowki[i].Samochod} | {CzyTaxiWolne(taksowki[i])} | " +
                    $"{taksowki[i].AktualnaDzielnica}");
            }
        }
    }
}
