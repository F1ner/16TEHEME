using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования классов

            // Создание объекта класса Сотрудник
            Employee employee = new Employee("Иванов", "Петр", 1000, 1.2);
            employee.DisplayInfo(); // Вывод информации о сотруднике

            Console.WriteLine();

            // Создание объекта класса Инженер
            Engineer engineer = new Engineer("Петров", "Иван", 1500, 1.5, 15);
            engineer.DisplayInfo(); // Вывод информации об инженере

            Console.WriteLine();

            // Создание объекта класса Автобус
            Bus bus = new Bus("Mercedes", 40, 10);
            Console.WriteLine($"Общая стоимость всех мест: {bus.CalculateTotalCost()}"); // Вывод общей стоимости мест в автобусе

            Console.WriteLine();

            // Создание объекта класса Туристический автобус
            TouristBus touristBus = new TouristBus("Volvo", 30, 15, 5);
            Console.WriteLine($"Общая стоимость всех мест с учетом экскурсии: {touristBus.CalculateTotalCost()}"); // Вывод общей стоимости мест с учетом экскурсии

            Console.ReadKey();
        }
    }
}
