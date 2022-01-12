using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Dzielnica
    {
        public Dzielnica(int id, string nazwa, int odlegloscOdCentrum)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.odlegloscOdCentrum = odlegloscOdCentrum;
        }


        private int id;
        public int Id { 
            get { return id; }
        }

        private string nazwa;
        public string Nazwa { 
            get { return nazwa; }
        }

        private int odlegloscOdCentrum;
        public int OdlegloscOdCentrum {
            get { return odlegloscOdCentrum; }
        }

        private int iloscTaxi;
        public int IloscTaxi {
            get { return iloscTaxi; }
            set { iloscTaxi = value; }
        }

        //public int CzyTaksowkaWDzielnicy(Taksowka taksowka)
        //{
        //    if (Nazwa == taksowka.AktualnaDzielnica)
        //        return 1;
        //    else
        //        return 0;
        //}

    }
}
