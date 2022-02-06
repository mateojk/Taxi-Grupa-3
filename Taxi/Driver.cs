using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Driver
    {
        public Driver(int id, string car, List<District> districts)
        {
            Id = id;
            Car = car;
            Districts = districts;
            status = true;
        }

        public List<District> Districts;
        public int Id { get; private set; }
        public string Car { get; private set; }
        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }


    }
}
