using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class District
    {
        public District(int id, string name, int distanceFromTheCenter, List<Driver> drivers)
        {
            Id = id;
            Name = name;
            this.distanceFromTheCenter = distanceFromTheCenter;
            this.Drivers = drivers;
        }

        public List<Driver> Drivers;

        public int Id { get; private set; }

        public string Name { get; private set; }

        private int distanceFromTheCenter;
        public int DistanceFromTheCenter
        {
            get { return distanceFromTheCenter; }
        }

        //private int iloscTaxi;
        public int NumberOfDrivers
        {
            get { return Drivers.Count; }
            //set
            //{
            //    iloscTaxi = 0;
            //    for (int i = 0; i < taksowki.Length; i++)
            //    {
            //        if (Nazwa == taksowki[i].AktualnaDzielnica)
            //            iloscTaxi++;
            //    }
            //}
        }

    }
}
