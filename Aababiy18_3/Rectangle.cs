using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    class Rectangle : Figure
    {
        // Объявляем две private переменные для хранения длин сторон прямоугольника
        private double side1;
        private double side2;

        // Конструктор для класса Прямоугольник
        // Принимает имя (строка), side1 (дробь), и side2 (дробь) в качестве параметров
        // Вызывает конструктор базового класса с именем в качестве параметра
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            // Присваиваем side1 и side2 параметрам private полей
            this.side1 = side1;
            this.side2 = side2;
        }

        // Свойство для получения и установки значения side1
        public double Side1
        {
            get { return side1; } // Геттер возвращает значение side1
            set { side1 = value; } // Сеттер присваивает значение свойства side1
        }

        // Свойство для получения и установки значения side2
        public double Side2
        {
            get { return side2; } // Геттер возвращает значение side2
            set { side2 = value; } // Сеттер присваивает значение свойства side2
        }

        // Переопределенный метод Area()
        // Возвращает произведение side1 и side2
        public override double Area()
        {
            return side1 * side2;
        }

        // Переопределенный метод Perimeter()
        // Возвращает периметр прямоугольника
        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }

        // Переопределенный метод Print()
        // Вызывает метод Print() базового класса, затем выводит значения side1 и side2
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона 1: {Side1}");
            Console.WriteLine($"Сторона 2: {Side2}");
        }
    }
}
