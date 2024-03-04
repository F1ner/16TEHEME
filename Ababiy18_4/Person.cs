using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4_classwork_
{
    public abstract class Person // Объявил абстрактный класс Person.
    {

        public string FirstName { get; set; }//Свойство описывающее имя
        public string LastName { get; set; } // Свойство для фамилии.
        public DateTime BirthDate { get; set; } // Свойство для даты рождения.
                                                // Добавил свойство Факультет
        public string Faculty { get; set; }//Свойство описывающее факультет

        public Person() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName">имя студента</param>
        /// <param name="lastName">фамилия студента</param>
        /// <param name="birthDate">дата рождения</param>
        /// <param name="faculty">факультет</param>
        /// 
        public Person(string firstName, string lastName, DateTime birthDate, string faculty) // Конструктор с тремя параметрами.
        {
            FirstName = firstName; // Инициализировал свойство FirstName.
            LastName = lastName; // Инициализировал свойство LastName.
            BirthDate = birthDate; // Инициализировал свойство BirthDate.
            Faculty = faculty;// Инициализировал свойство BirthDate.
        }
        /// <summary>
        /// Отображает детали студента
        /// </summary>
        /// <returns></returns>
        public abstract void Display();
        
            //Console.WriteLine($"Имя: {FirstName} {LastName} Возраст: {Age}  Факультет: {Faculty}");
        

        public int Age ()// Свойство для возраста.
        {


            return DateTime.Now.Year - BirthDate.Year;
                //var today = DateTime.Today; // Получил текущую дату.
                //var age = today.Year - BirthDate.Year; // Вычислил количество лет, прожитых с момента рождения.

                //if (today.Month < BirthDate.Month || (today.Month == BirthDate.Month && today.Day < BirthDate.Day)) // Если сегодняшняя дата еще не достигла дня рождения.
                //{
                //    age--; // Уменьшил количество лет на 1.
                //}

                //return age; // Вернул количество лет.
            
        }
    }
}
