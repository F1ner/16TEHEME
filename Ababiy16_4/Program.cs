using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy16_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество сотрудников: ");
            int N = int.Parse(Console.ReadLine()); // Количество сотрудников

            // Создание массива сотрудников
            Employee[] employees = new Employee[N];

            // Заполнение массива данными с клавиатуры
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\nВведите информацию о {i + 1}-м сотруднике:");
                Console.Write("Табельный номер: ");
                int employeeId = int.Parse(Console.ReadLine());
                Console.Write("ФИО: ");
                string fullName = Console.ReadLine();
                Console.Write("Дата рождения (гггг-мм-дд): ");
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.Write("Должность: ");
                string position = Console.ReadLine();
                Console.Write("Оклад: ");
                double salary = double.Parse(Console.ReadLine());

                employees[i] = new Employee(employeeId, fullName, dateOfBirth, position, salary);
            }

            // Вывод информации о сотрудниках в табличном виде
            Console.WriteLine("\nИнформация о сотрудниках:");
            Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-20} {4,-10}", "Табельный номер", "ФИО", "Дата рождения", "Должность", "Оклад");
            foreach (var employee in employees)
            {
                Console.WriteLine("{0,-15} {1,-25} {2,-15:dd.MM.yyyy} {3,-20} {4,-10}", employee.EmployeeId, employee.FullName, employee.DateOfBirth, employee.Position, employee.Salary);
            }

            // Вывод информации о возрасте каждого сотрудника
            Console.WriteLine("\nИнформация о возрасте каждого сотрудника:");
            foreach (var employee in employees)
            {
                Console.WriteLine("{0}: {1} лет", employee.FullName, employee.CalculateAge());
            }

            Console.ReadKey();
        }
    }
}
