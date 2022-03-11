using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    class Bycle : Vehicle
    {
        public Bycle(string color, string brand, double km) : base(color, brand, km)
        {
            brand = "Desna";
            color = "Red";
            km = 40;

            brand = "Setra";
            color = "White";
            km = 45;
        }
        
    }
}
