using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    class Circle : Figure
    {
        // Поле для хранения радиуса круга
        private double radius;

        // Конструктор для класса Circle
        // Принимает имя (строка) и радиус (дробь) в качестве параметров
        // Присваивает радиусу переданное значение
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        // Свойство для получения и установки радиуса круга
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Переопределенный метод Area()
        // Возвращает площадь круга по формуле: S = π \* r^2
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        // Переопределенный метод Perimeter()
        // Возвращает длину окружности по формуле: L = 2 \* π \* r
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        // Переопределенный метод Print()
        // Вызывает метод Print() базового класса
        // Затем выводит значение радиуса круга
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {Radius}");
        }
    }
}
