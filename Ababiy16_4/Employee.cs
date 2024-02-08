using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy16_4
{
    internal class Employee
    {
        // Поля класса
        public int EmployeeId { get; set; } // табельный номер
        public string FullName { get; set; } // ФИО сотрудника
        public DateTime DateOfBirth { get; set; } // дата рождения
        public string Position { get; set; } // должность
        public double Salary { get; set; } // оклад

        // Конструктор класса
        public Employee(int employeeId, string fullName, DateTime dateOfBirth, string position, double salary)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Position = position;
            Salary = salary;
        }

        // Метод для вычисления возраста сотрудника
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (DateOfBirth > today.AddYears(-age)) age--;
            return age;
        }
    }
}
