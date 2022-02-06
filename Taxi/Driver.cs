using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Driver
    {
        public Driver(int id, string car, List<District> districts, int currentDistrictId)
        {
            Id = id;
            Car = car;
            Districts = districts;
            this.currentDistrictId = currentDistrictId;
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


        private int currentDistrictId;
        public int CurrentDistrictId
        {
            get { return currentDistrictId; }
            set { currentDistrictId = value; }
        }




    }
}
