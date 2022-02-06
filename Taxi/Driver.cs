using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Driver
    {
        public Driver(int id, string car, string currentDistrict)
        {
            Id = id;
            Car = car;
            this.currentDistrict = currentDistrict;
            available = true;
        }

        public int Id { get; private set; }

        public string Car { get; private set; }

        private bool available;
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        private string currentDistrict;
        public string CurrentDistrict
        {
            get { return currentDistrict; }
            set { currentDistrict = value; }
        }
    }
}
