using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy17_2
{
    class Engineer : Employee
    {
        // Дополнительное поле потомка
        public int ProjectsCount { get; set; }

        // Конструктор с параметрами
        public Engineer(string lastName, string firstName, double baseSalary, double bonusCoefficient, int projectsCount)
            : base(lastName, firstName, baseSalary, bonusCoefficient)
        {
            ProjectsCount = projectsCount;
        }

        // Переопределенный метод вывода информации о потомке
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Вызов метода базового класса для вывода основной информации
            Console.WriteLine($"Количество проектов: {ProjectsCount}");
        }

        // Переопределенный метод расчета дохода
        public override double CalculateIncome()
        {
            double baseIncome = base.CalculateIncome(); // Расчет базового дохода
            if (ProjectsCount > 10)
            {
                // Увеличение дохода в зависимости от количества проектов
                return baseIncome * (1 + ProjectsCount / 10.0);
            }
            else
            {
                return baseIncome;
            }
        }
    }
}
