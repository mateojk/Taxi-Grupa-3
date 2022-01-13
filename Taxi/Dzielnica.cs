using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Dzielnica
    {
        public Dzielnica(int id, string nazwa, int odlegloscOdCentrum, Taksowka[] taksowki)
        {
            Id = id;
            Nazwa = nazwa;
            this.odlegloscOdCentrum = odlegloscOdCentrum;
            this.taksowki = taksowki;
        }

        public Taksowka[] taksowki;

        public int Id { get; private set; }

        public string Nazwa { get; private set; }

        private int odlegloscOdCentrum;
        public int OdlegloscOdCentrum {
            get { return odlegloscOdCentrum; }
        }

        private int iloscTaxi;
        public int IloscTaxi
        {
            get { return iloscTaxi; }
            set
            {
                iloscTaxi = 0;
                for (int i = 0; i < taksowki.Length; i++)
                {
                    if (Nazwa == taksowki[i].AktualnaDzielnica)
                        iloscTaxi++;
                }
            }
        }

    }
}
