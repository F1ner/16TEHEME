using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy18_4_classwork_
{
    /// <summary>
    /// Представляет сотрудника
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса Employee с указанными именем, фамилией, датой рождения и факультетом
        /// </summary>
        /// <param name="firstName">Имя сотрудника</param>
        /// <param name="lastName">Фамилия сотрудника</param>
        /// <param name="birthDate">Дата рождения сотрудника</param>
        /// <param name="faculty">Факультет сотрудника</param>
        public Employee(string firstName, string lastName, DateTime birthDate, string faculty) : base(firstName, lastName, birthDate, faculty)
        {
            Faculty = faculty;
        }
        /// <summary>
        /// Отображает детали сотрудника
        /// </summary>
        public override void Display()
        {
            //base.Display();
            Console.WriteLine($"{FirstName} {LastName} дата рождения-{BirthDate} факультет-{Faculty} возраст-{Age()}");
        }

        public static Employee Input()
        {
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите факультет ");
            string fac = Console.ReadLine();
            return new Employee(name, surname, dob, fac);
        }
    }
}
