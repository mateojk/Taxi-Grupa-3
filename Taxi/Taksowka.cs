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
            Id = id;
            Samochod = samochod;
            this.aktualnaDzielnica = aktualnaDzielnica;
            czyWolny = true;
        }

        public int Id { get; private set; }

        public string Samochod { get; private set; }

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
