using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4_classwork_
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
            //base.Display();
            //Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"{FirstName} {LastName} дата рождения-{BirthDate} факультет-{Faculty}  курс-{Course} возраст-{Age()}");

        }
        public static Student Input()
        {
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите факультет ");
            string fac = Console.ReadLine();
            Console.Write("Введите курс ");
            int cour = int.Parse(Console.ReadLine());
            return new Student(name, surname, dob, fac, cour);
        }
    }
}
