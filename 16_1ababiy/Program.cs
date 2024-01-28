using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1ababiy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 ЗАДАНИЕ

            //// Получаем текущую дату и время
            //DateTime currentDateTime = DateTime.Now;

            //// Выводим информацию в нужных форматах
            //Console.WriteLine($"Текущая дата:\n{currentDateTime:dd.MM.yyyy}\n{currentDateTime:dd MMM yyyy}\n{currentDateTime:dd MMMM yyyy 'г.'}");
            //// Форматируем и выводим дату в указанных форматах (по порядку): день.месяц.год, день месяца год, день месяца год с указанием месяца словами

            //Console.WriteLine($"\n{currentDateTime:ddd, dd MMM yyyy}\n{currentDateTime:dddd, dd MMMM yyyy}");
            //// Форматируем и выводим день недели, день месяца год, полную дату с указанием месяца словами

            //Console.WriteLine("\nТекущее время:\n{0:HH:mm:ss}\n{0:HH:mm}", currentDateTime);
            //// Форматируем и выводим текущее время в часы:минуты:секунды и часы:минуты

            //Console.WriteLine("\nТекущая дата и время:\n{0:dd.MM.yyyy HH:mm:ss}\n{0:dd MMMM yyyy 'г.' HH:mm}\n{0:dd MMMM yyyy 'г.' HH:mm:ss}", currentDateTime);
            //// Форматируем и выводим текущую дату и время в указанных форматах: день.месяц.год часы:минуты:секунды, день месяца год часы:минуты, день месяца год часы:минуты:секунды

            //Console.WriteLine("{0:ddd, dd MMM yyyy HH:mm:ss 'GMT'}", currentDateTime);
            //// Форматируем и выводим день недели, день месяца год часы:минуты:секунды с указанием времени по Гринвичу (GMT)

            //Console.WriteLine("{0:yyyy-MM-ddTHH:mm:ss}", currentDateTime);
            //// Форматируем и выводим текущую дату и время в формате ISO 8601 (год-месяц-деньTчасы:минуты:секунды)


            //2 ЗАДАНИЕ

            //// Получаем текущую дату и время
            //DateTime today = DateTime.Now;

            //// Выводим приглашение для ввода возраста человека
            //Console.WriteLine("Введите возраст человека:");

            //// Считываем возраст из ввода пользователя
            //int age = int.Parse(Console.ReadLine());

            //// Вычисляем год рождения, вычитая возраст из текущего года
            //int birthYear = today.Year - age;

            //// Выводим год рождения
            //Console.WriteLine($"Ты родился в {birthYear} году");


            //3 ЗАДАНИЕ

            //// Получаем текущую дату и время
            //DateTime today = DateTime.Now;

            //// Выводим приглашение для ввода года рождения человека
            //Console.WriteLine("Введите год рождения человека:");

            //// Объявляем переменную для хранения введенной даты
            //DateTime date;

            //// Считываем введенную дату и записываем ее в переменную date
            //DateTime.TryParse(Console.ReadLine(), out date);

            //// Вычисляем возраст, вычитая год рождения из текущего года
            //int age = today.Year - date.Year;

            //// Выводим возраст
            //Console.WriteLine($"Этому человеку {age} лет");


            
            Console.ReadLine();
        }
    }
}
