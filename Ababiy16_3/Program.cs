using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy16_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Задание 1:");

            // Создаем объект класса DateClass с использованием конструктора с параметрами, введенными с клавиатуры.
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            DateClass dateObj = new DateClass(year, month, day);

            // Выводим информацию о дате и ее свойствах.
            Console.WriteLine($"Year: {dateObj.Data.Year}");
            Console.WriteLine($"Month: {dateObj.Data.Month}");
            Console.WriteLine($"Day: {dateObj.Data.Day}");
            Console.WriteLine($"День через точки: {dateObj.Data.ToShortDateString()}");
            Console.WriteLine($"Предыдущий день: {dateObj.PreviousDay().ToShortDateString()}");
            Console.WriteLine($"Последующий день: {dateObj.NextDay().ToShortDateString()}");
            Console.WriteLine($"Количество дней до конца месяца: {dateObj.DaysLeftInMonth()}");

            // Задание 2
            Console.WriteLine("\nЗадание 2: Введите две даты (гггг-мм-дд):");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            TimeSpan daysBetween = date2 - date1;
            Console.WriteLine($"Между датами прошло {daysBetween.Days} дней.");

            // Задание 3
            Console.WriteLine("\nЗадание 3: Рассчитать время проведения медицинских процедур.");

            Console.Write("Введите время начала первой процедуры (HH:mm): ");
            DateTime startTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите время начала следующей процедуры (HH:mm): ");
            DateTime nextProcedureTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите общее количество назначенных процедур: ");
            int totalProcedures = int.Parse(Console.ReadLine());

            // Рассчитываем время для каждой процедуры и выводим результат.
            Console.WriteLine("\nСписок времени для выполнения назначенных процедур:");
            for (int i = 0; i < totalProcedures; i++)
            {
                DateTime procedureTime = startTime.AddMinutes(i * (nextProcedureTime - startTime).TotalMinutes);
                Console.WriteLine($"Процедура {i + 1}: {procedureTime.ToString("HH:mm")}");
            }

            Console.ReadKey();
        }
    }
}
