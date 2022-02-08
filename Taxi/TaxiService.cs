using System;
using System.Collections.Generic;

namespace Taxi
{
    public class TaxiService
    {
        public TaxiService()
        {
            CreateDistricts();
            CreateDrivers();
        }

        public List<District> Districts { get; set; } = new List<District>();
        private void CreateDistricts()
        {
            Districts.Add(new District(1, "Retkinia", -2));
            Districts.Add(new District(2, "Łódź Kaliska", -1));
            Districts.Add(new District(3, "Śródmieście", 0));
            Districts.Add(new District(4, "Widzew", 1));
            Districts.Add(new District(5, "Janów", 3));
        }


        public List<Driver> Drivers { get; set; } = new List<Driver>();
        private void CreateDrivers()
        {           
            Drivers.Add(new Driver(1, "Ford Mondeo", Districts[0]));
            Drivers.Add(new Driver(2, "Dacia Logan", Districts[1]));
            Drivers.Add(new Driver(3, "Toyota Avensis", Districts[2])); 
            Drivers.Add(new Driver(4, "Mercedes E220", Districts[3]));
            Drivers.Add(new Driver(5, "Huindai Lantra", Districts[4]));
        }


        public static int HowManyDriversInDistrict(List<Driver> drivers, District district)
        {
            int driversInDirstrict = 0;
            foreach (var driver in drivers)
            {
                if (driver.CurrentDistric == district)
                    driversInDirstrict++;
            }

            return driversInDirstrict;
        }


        public static int CommuteTime(Driver driver, District district)
        {
            int commuteTime;
            if (driver.CurrentDistric == district)
                commuteTime = 4;
            else
                commuteTime = Math.Abs(driver.CurrentDistric.DistanceFromTheCenter - district.DistanceFromTheCenter) * 5;
            if (!driver.StatusAvaible)
                commuteTime += 12;

            return commuteTime;
        }






    }
}

