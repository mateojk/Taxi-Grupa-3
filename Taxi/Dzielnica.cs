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
            this.id = id;
            this.nazwa = nazwa;
            this.odlegloscOdCentrum = odlegloscOdCentrum;
            this.taksowki = taksowki;
        }

        public Taksowka[] taksowki;

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
