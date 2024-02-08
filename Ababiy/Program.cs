using Ababiy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //111


            //// 1. Создание объекта базового класса и обращение к методу вывода состояния объекта базового класса
            //Person person = new Person { Name = "Иван", Surname = "Иванов", Age = 30 };
            //Console.WriteLine("Информация о человеке:");
            //person.DisplayInfo();
            //Console.WriteLine();

            //// 2. Создание объекта производного класса и обращение к методу вывода информации о сотруднике производного класса
            //Employee employee = new Employee { Name = "Петр", Surname = "Петров", Age = 25, Company = "ООО Рога и Копыта", Job = "Программист" };
            //Console.WriteLine("Информация о сотруднике:");
            //employee.DisplayInfo();
            //Console.WriteLine();

            //// 3. Создание ссылки типа базового класса на объект производного класса 
            //// и обращение к методу вывода состояния объекта базового класса
            //Person employeeAsPerson = new Employee { Name = "Алексей", Surname = "Алексеев", Age = 35, Company = "ООО Шестеренка", Job = "Инженер" };
            //Console.WriteLine("Информация о сотруднике, рассматриваемая как человек:");
            //employeeAsPerson.DisplayInfo();


            //222


            //// 1. Создание объекта базового класса и обращение к методу вывода состояния объекта базового класса
            //Press press = new Press(copies: 1000, name: "Газета", price: 1.5);
            //Console.WriteLine("Информация о печатной продукции:");
            //press.Output();
            //Console.WriteLine($"Стоимость тиража: {press.Cost()} руб.");
            //Console.WriteLine();

            //// 2. Создание объекта производного класса и обращение к методу вывода информации о сотруднике производного класса
            //Magazine magazine = new Magazine(copies: 500, name: "Журнал", price: 3.0, quality: "высокое");
            //Console.WriteLine("Информация о журнале:");
            //magazine.Output();
            //Console.WriteLine($"Стоимость тиража: {magazine.Cost()} руб.");
            //Console.WriteLine();

            //// 3. Создание ссылки типа базового класса на объект производного класса 
            //// и обращение к методу вывода состояния объекта базового класса
            //Press magazineAsPress = new Magazine(copies: 800, name: "Журнал", price: 2.0, quality: "низкое");
            //Console.WriteLine("Информация о журнале, рассматриваемая как печатная продукция:");
            //magazineAsPress.Output();
            //Console.WriteLine($"Стоимость тиража: {magazineAsPress.Cost()} руб.");


            //333


            //// Создание объекта базового класса и проверка методов
            //Notebook notebook = new Notebook("Simp", 48);
            //notebook.DisplayInfo();

            //// Создание объекта производного класса и проверка методов
            //ExerciseBook exerciseBook = new ExerciseBook("Hard", 96, "Plast");
            //exerciseBook.DisplayInfo();



            Console.ReadKey();
        }
    }
}
