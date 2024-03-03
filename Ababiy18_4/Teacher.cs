using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4
{
    /// <summary>
    /// Представляет преподавателя
    /// </summary>
    public class Teacher : Person
    {
        /// <summary>
        /// Возвращает или задает должность преподавателя
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Возвращает или задает стаж работы преподавателя
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Teacher с указанными именем, фамилией, датой рождения, факультетом, должностью и стажем работы
        /// </summary>
        /// <param name="firstName">Имя преподавателя</param>
        /// <param name="lastName">Фамилия преподавателя</param>
        /// <param name="birthDate">Дата рождения преподавателя</param>
        /// <param name="faculty">Факультет преподавателя</param>
        /// <param name="position">Должность преподавателя</param>
        /// <param name="experience">Стаж работы преподавателя</param>
        public Teacher(string firstName, string lastName, DateTime birthDate, string faculty, string position, int experience) : base(firstName, lastName, birthDate, faculty)
        {
            Faculty = faculty;

            Position = position;

            Experience = experience;
        }

        /// <summary>
        /// Отображает детали преподавателя
        /// </summary>
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"{Position} ({Experience} лет стажа)");
        }
    }
}
