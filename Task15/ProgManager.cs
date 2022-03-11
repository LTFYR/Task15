using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    class ProgManager
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public List<Vehicle> Vehicle => vehicles;

      

        public string DriveForProg(string color,string brand,double km)
        {
            Vehicle vehicless = new Vehicle(color,brand,km);
            return color+ brand + km;
        }
    }
}
