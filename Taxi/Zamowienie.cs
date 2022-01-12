using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Zamowienie
    {
        public string CzyTaxiWolne(Taksowka taxi)
        {
            if (taxi.CzyWolny)
                return "wolny";
            else
                return "zajęty";
        }







	
        public int CzyTaxiWDzielnicy(Dzielnica dzielnica, Taksowka taksowka)
        {
            if (dzielnica.Nazwa == taksowka.AktualnaDzielnica)
                return 1;
            else
                return 0;
        }


        //public string PokazInfoDzielnica(Dzielnica dzielnica)
        //{
        //    return dzielnica.Id + " | " + dzielnica.Nazwa + " | ";  //+ ile taxi
        //}



    }
}
