using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    class Vehicle:Mucerredklas
    {
        string _color, _brand;
        double _km;


        public Vehicle(string color,string brand,double km)
        {
            this._color = color;
            this._brand = brand;
            this._km = km;
        }
        
        public override double Drive()
        {
            return 280;
        }
        

        public virtual void ShowInfo()
        {
            Console.WriteLine($"The car's color is{this._color}, The car's brand is {this._brand}, The car's miller is{this._km}");

        }
    }
    public abstract class Mucerredklas
    {
        public abstract double Drive();
    }

}
