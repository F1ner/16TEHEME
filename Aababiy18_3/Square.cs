using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    class Square : Rectangle
    {
        // Конструктор для класса Квадрат
        // Принимает имя (строка) и сторону (дробь) в качестве параметров
        // Вызывает конструктор базового класса с именем, side и side (сторона квадрата устанавливается равной сторонам прямоугольника)
        public Square(string name, double side) : base(name, side, side)
        {
        }

        // Переопределенное свойство для доступа к стороне квадрата
        // Возвращает и устанавливает значение стороны квадрата
        public new double Side
        {
            get { return base.Side1; } // Возвращает значение стороны квадрата
            set { base.Side1 = base.Side2 = value; } // Устанавливает значение стороны квадрата равным значению для обеих сторон прямоугольника
        }

        // Переопределенный метод Print()
        // Вызывает метод Print() базового класса, затем выводит значение стороны квадрата
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона: {Side}");
        }
    }

}
