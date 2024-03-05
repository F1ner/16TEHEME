using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> veh = new List<Vehicle>();
            bool flag = true;
            //Создание базы
            while (flag)
            {

                Console.WriteLine("Выберите дейтвие:");
                Console.WriteLine("1.Добавить в список велосипед");
                Console.WriteLine("2.Добавить в список машину");
                Console.WriteLine("3.Добавить в список грузовик");
                Console.WriteLine("4.Вывести все велосипеды из списка");
                Console.WriteLine("5.Вывести все машины из списка");
                Console.WriteLine("6.Вывести все грузовики из списка");
                Console.WriteLine("7.Выход");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1": veh.Add(Garage.Input2()); break;
                    case "2": veh.Add(Garage.Input3()); break;
                    case "3": veh.Add(Garage.Input1()); break;
                    case "4": veh.PrintBicycleInfo(); break;
                    case "5":; break;
                    case "6":; break;
                    case "7": flag = false; Console.Clear(); break;

                    default: flag = false; Console.Clear(); break;
                }

            };

            Console.ReadKey();
        }
    }
}
