using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_6
{
    public class Bicycle : Vehicle
    {
        public int NumberOfPassengers { get; set; }

        public Bicycle(string brand, double price, int maxSpeed, int year, int numberOfPassengers)
            : base(brand, price, maxSpeed, year)
        {
            NumberOfPassengers = numberOfPassengers;
        }

        public override void Print()
        {
            Console.WriteLine($"{Brand} {Price} {MaxSpeed} {Year} {NumberOfPassengers}");
        }
        
    }
}
