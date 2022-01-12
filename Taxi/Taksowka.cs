using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taksowka
    {
        public Taksowka(int id, string samochod, string aktualnaDzielnica)
        {
            this.id = id;
            this.samochod = samochod;
            this.aktualnaDzielnica = aktualnaDzielnica;
            czyWolny = true;
        }


        private int id;
        public int Id {
            get { return id; } 
        }

        private string samochod;
        public string Samochod { 
            get { return samochod; }
        }

        private bool czyWolny;
        public bool CzyWolny { 
            get { return czyWolny; } 
            set { czyWolny = value; }
        }

        private string aktualnaDzielnica;
        public string AktualnaDzielnica { 
            get { return aktualnaDzielnica; }
            set { aktualnaDzielnica = value; } 
        }
    }
}
