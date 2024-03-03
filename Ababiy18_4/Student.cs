using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4
{
    public class Student : Person
    {

        /// <summary>
        /// Возвращает или задает курс студента
        /// </summary>
        public int Course { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Student с указанными именем, фамилией, датой рождения и факультетом
        /// </summary>
        /// <param name="firstName">Имя студента</param>
        /// <param name="lastName">Фамилия студента</param>
        /// <param name="birthDate">Дата рождения студента</param>
        /// <param name="faculty">Факультет студента</param>
        /// <param name="course">Курс студента</param>
        public Student(string firstName, string lastName, DateTime birthDate, string faculty, int course) : base(firstName, lastName, birthDate, faculty)
        {
            Faculty = faculty;

            Course = course;
        }

        /// <summary>
        /// Отображает детали студента
        /// </summary>
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Курс: {Course}");
        }
    }
}
