using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_6
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public double Price { get; set; }
        public int MaxSpeed { get; set; }
        public int Year { get; set; }

        public Vehicle() { }
        public Vehicle(string brand, double price, int maxSpeed, int year)
        {
            Brand = brand;
            Price = price;
            MaxSpeed = maxSpeed;
            Year = year;
        }

        public abstract void Print();
    }
}
