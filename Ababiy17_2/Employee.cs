using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy17_2
{
    class Employee
    {
        // Поля/свойства базового класса
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double BaseSalary { get; set; }
        public double BonusCoefficient { get; set; }

        // Конструктор с параметрами
        public Employee(string lastName, string firstName, double baseSalary, double bonusCoefficient)
        {
            LastName = lastName;
            FirstName = firstName;
            BaseSalary = baseSalary;
            BonusCoefficient = bonusCoefficient;
        }

        // Виртуальный метод вывода информации об объекте
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Доход: {CalculateIncome()}"); // Вызов метода для расчета дохода
        }

        // Виртуальный метод расчета дохода
        public virtual double CalculateIncome()
        {
            return BaseSalary * BonusCoefficient; // Расчет дохода
        }
    }
}
