using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4_classwork_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            bool flag = true;
            //Создание базы
            while (flag)
            {
               
                Console.WriteLine("Введите название");
                string s = Console.ReadLine();
                switch(s)
                {
                    case "Абитуриент": people.Add(Employee.Input());break;
                    case "Студент": people.Add(Student.Input());break;
                    case "Учитель": people.Add(Teacher.Input()); break;
                    default:flag = false;Console.Clear(); break;
                }
                
            };
            //Вывод базы
            foreach(var elem in people)
            {
                elem.Display();
            }

            Console.WriteLine("Введите нижнюю границу");
            int min=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу");
            int max = int.Parse(Console.ReadLine());
            for(int i=0;i<people.Count;i++)
            {
                if (people[i].Age() >= min && people[i].Age() <= max)
                {
                    people[i].Display();
                }
                 
            }

           




            //    // Создал список объектов класса Person
            //    List<Person> people = new List<Person>
            //{


            //    // Добавил 1 студента
            //    new Student("Петр", "Петров", new DateTime(1998, 2, 10), "Факультет", 2),

            //    // Добавил 1 преподавателя
            //    new Teacher("Алексей", "Алексеев", new DateTime(1965, 12, 25), "Факультет", "Преподаватель", 35),

            //      // Добавил 1 сотрудника
            //    new Employee("Сергей", "Сидоров", new DateTime(1970, 3, 20), "Факультет"),

            //     // Добавил 2 студента
            //    new Student("Евгений", "Иосиф", new DateTime(1999, 4, 11), "Факультет", 4),

            //    // Добавил 2 преподавателя
            //    new Teacher("Григорий", "Донцой", new DateTime(1978, 7, 26), "Факультет", "Преподаватель", 35),

            //      // Добавил 2 сотрудника
            //    new Employee("Илья", "Сидоров", new DateTime(1990, 1, 16), "Факультет"),
            //};

            //    // Вывел информацию о всех людях в списке
            //    foreach (var person in people)
            //    {
            //        person.Display();
            //    }

            //    Console.WriteLine();
            //    //// Установить минимальный и максимальный возраст для фильтрации
            //    //int minAge = 18, maxAge = 30;

            //    //// Отфильтровать людей в указанном диапазоне возрастов
            //    //var filteredPeople = people.Where(p => minAge <= p.Age && p.Age <= maxAge);

            //    //// Вывести людей в указанном диапазоне возрастов
            //    //Console.WriteLine("Люди с возрастом между " + minAge + " и " + maxAge + ":");
            //    //foreach (var person in filteredPeople)
            //    //{
            //    //    person.Display(); // Отобразить детали о человеке
            //    //}

            Console.ReadKey();
        }
    }
}
