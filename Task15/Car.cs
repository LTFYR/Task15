using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
     class Car:Vehicle
    {
        public float Fuelcapacity, CurrentFuel, FuelFor1KM;

        public Car(string color, string brand, double km) : base(color, brand, km)
        {
            brand = "Mercedes S-Class";
            color = "Black";
            km = 260;

            brand = "Prado";
            color = "WHite";
            km = 180;
        }
        
       
        
    }
}
