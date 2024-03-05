using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_6
{
    public class Garage
    {
        private List<Car> _cars = new List<Car>();
        private List<Bicycle> _bicycles = new List<Bicycle>();
        private List<Lorry> _lorries = new List<Lorry>();

        public void PrintCarInfo()
        {
            Console.WriteLine("Cars:");
            foreach (var car in _cars)
            {
                car.Print();
            }
        }

      
        public void PrintBicycleInfo()
        {
            Console.WriteLine("Bicycles:");
            foreach (var bicycle in _bicycles)
            {
                bicycle.Print();
            }
        }

       
        public void PrintLorryInfo()
        {
            Console.WriteLine("Lorries:");
            foreach (var lorry in _lorries)
            {
                lorry.Print();
            }
        }
        public static Lorry Input1()
        {
            Console.WriteLine("Введите название фирмы");
            string brand = Console.ReadLine();
            Console.WriteLine("Введите цену");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость");
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год выпуска");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную емкость");
            int capacity = int.Parse(Console.ReadLine());
            return new Lorry(brand, price, maxSpeed, year, capacity);
        }
        public static Bicycle Input2()
        {
            Console.WriteLine("Введите название фирмы");
            string brand = Console.ReadLine();
            Console.WriteLine("Введите цену");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость");
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год выпуска");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное колличество пассажиров");
            int numberOfPassengers = int.Parse(Console.ReadLine());
            return new Bicycle(brand, price, maxSpeed, year, numberOfPassengers);
        }
        public static Car Input3()
        {
            Console.WriteLine("Введите название фирмы");
            string brand = Console.ReadLine();
            Console.WriteLine("Введите цену");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость");
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год выпуска");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите мощность");
            int power = int.Parse(Console.ReadLine());
            return new Car(brand, price, maxSpeed, year, power);
        }
    }
}
