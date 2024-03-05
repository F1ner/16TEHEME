using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_6
{
    public class Lorry : Vehicle
    {
        public int Capacity { get; set; }

        public Lorry(string brand, double price, int maxSpeed, int year, int capacity)
            : base(brand, price, maxSpeed, year)
        {
            Capacity = capacity;
        }

        public override void Print()
        {
            Console.WriteLine($" {Brand} {Price} {MaxSpeed} {Year} {Capacity}");
        }

    }
}
