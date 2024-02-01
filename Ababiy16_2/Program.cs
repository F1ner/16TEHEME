using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                // Задача 1: Введите две даты и определите количество дней между ними.
                Console.WriteLine("Задача 1: Введите две даты (гггг-мм-дд):");
                DateTime date1 = DateTime.Parse(Console.ReadLine());
                DateTime date2 = DateTime.Parse(Console.ReadLine());

                // Вычисляем разницу в днях между введенными датами.
                TimeSpan daysBetween = date2 - date1;

                // Выводим результат.
                Console.WriteLine($"Между датами прошло {daysBetween.Days} дней.");

                // Задача 2: Определить, сколько дней осталось до конца месяца.
                Console.WriteLine("\nЗадача 2: Определить, сколько дней осталось до конца месяца.");

                // Получаем текущую дату.
                DateTime currentDate = DateTime.Now;

                // Вычисляем количество оставшихся дней в текущем месяце.
                int daysLeftInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month) - currentDate.Day;

                // Выводим результат.
                Console.WriteLine($"До конца месяца осталось {daysLeftInMonth} дней.");

                // Задача 3: Введите свою дату рождения и выполните несколько действий.
                Console.WriteLine("\nЗадача 3: Введите свою дату рождения (гггг-мм-дд):");
                DateTime birthday = DateTime.Parse(Console.ReadLine());

                // a) день недели, в котором вы родились;
                string dayOfWeek = birthday.ToString("dddd");

                // b) порядковый номер дня в году;
                int dayOfYear = birthday.DayOfYear;

                // c) является ли ваш год рождения високосным;
                bool isLeapYear = DateTime.IsLeapYear(birthday.Year);

                // d) дата ближайшего дня рождения;
                DateTime nextBirthday = new DateTime(currentDate.Year, birthday.Month, birthday.Day);
                if (nextBirthday < currentDate)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
                string nextBirthdayString = nextBirthday.ToString("dddd, d MMMM yyyy");

                // e) количество полных лет;
                int age = currentDate.Year - birthday.Year;
                if (currentDate < birthday.AddYears(age))
                {
                    age--;
                }

                // f) сколько дней осталось от сегодняшней даты до вашего ближайшего дня рождения.
                int daysUntilNextBirthday = (nextBirthday - currentDate).Days;

                // Вывод результатов.
                Console.WriteLine($"a) Вы родились в {dayOfWeek}.");
                Console.WriteLine($"b) Порядковый номер дня в году: {dayOfYear}.");
                Console.WriteLine($"c) Ваш год рождения {(isLeapYear ? "високосный." : "не високосный.")}");
                Console.WriteLine($"d) Ближайший день рождения: {nextBirthdayString}");
                Console.WriteLine($"e) Вам {age} {(age == 1 ? "год" : "лет")}.");
                Console.WriteLine($"f) Дней до ближайшего дня рождения: {daysUntilNextBirthday} {(daysUntilNextBirthday == 0 ? "(С днем рождения!)" : "")}");
            
        

    }
}
}
