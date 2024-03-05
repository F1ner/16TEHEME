using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_6
{
    public class Car : Vehicle
    {
        public int Power { get; set; }

        public Car(string brand, double price, int maxSpeed, int year, int power)
            : base(brand, price, maxSpeed, year)
        {
            Power = power;
        }

        public override void Print()
        {
            Console.WriteLine($" {Brand} {Price} {MaxSpeed} {Year} {Power}");
        }
      
    }
}
