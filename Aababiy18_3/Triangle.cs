using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    class Triangle : Figure
    {
        // Объявляем три private поля для хранения длин сторон треугольника
        private double side1;
        private double side2;
        private double side3;

        // Конструктор для класса Треугольник
        // Принимает имя (строка) и три стороны (дробь) в качестве параметров
        // Присваивает значения полей side1, side2 и side3
        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // Свойства для доступа к сторонам треугольника
        // Возвращают и устанавливают значения соответствующих сторон треугольника
        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }

        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

        // Переопределенный метод Area()
        // Вычисляет площадь треугольника по формуле Герона
        public override double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        // Переопределенный метод Perimeter()
        // Вычисляет периметр треугольника как сумму длин сторон
        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        // Переопределенный метод Print()
        // Вызывает метод Print() базового класса, затем выводит значения сторон треугольника
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона 1: {Side1}");
            Console.WriteLine($"Сторона 2: {Side2}");
            Console.WriteLine($"Сторона 3: {Side3}");
        }
    }

}
