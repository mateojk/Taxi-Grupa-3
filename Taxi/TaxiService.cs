using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class TaxiService
    {
        public TaxiService()
        {
            CreateDrivers();
            CreateDistricts();
        }

        public List<Driver> Drivers { get; set; } = new List<Driver>();
        private void CreateDrivers()
        {
            Drivers.Add(new Driver(1, "Ford Mondeo", "Retkinia"));
            Drivers.Add(new Driver(2, "Dacia Logan", "Łódź Kaliska"));
            Drivers.Add(new Driver(3, "Toyota Avensis", "Śródmieście"));
            Drivers.Add(new Driver(4, "Mercedes E220", "Widzew"));
            Drivers.Add(new Driver(5, "Huindai Lantra", "Janów"));
        }

        public List<District> Districts { get; set; } = new List<District>();
        private void CreateDistricts()
        {
            Districts.Add(new District(1, "Retkinia", -2, Drivers));
            Districts.Add(new District(2, "Łódź Kaliska", -1, Drivers));
            Districts.Add(new District(3, "Śródmieście", 0, Drivers));
            Districts.Add(new District(4, "Widzew", 1, Drivers));
            Districts.Add(new District(5, "Janów", 3, Drivers));
        }


        //public string CzyTaxiWolne(Taksowka taxi)
        //{
        //    if (taxi.CzyWolny)
        //        return "wolny";
        //    else
        //        return "zajęty";
        //}

        //public void PokazInformacjeDzielnic()
        //{
        //    for (int i = 0; i < dzielnice.Length; i++)
        //    {
        //        Console.WriteLine($"{dzielnice[i].Id} | {dzielnice[i].Nazwa} | {dzielnice[i].IloscTaxi}");
        //    }
        //}

        //public void PokazInfromacjeTaksowek()
        //{
        //    for (int i = 0; i < taksowki.Length; i++)
        //    {
        //        Console.WriteLine($"{taksowki[i].Samochod} | {CzyTaxiWolne(taksowki[i])} | " +
        //            $"{taksowki[i].AktualnaDzielnica}");
        //    }
        //}



    }
}



