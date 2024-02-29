using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    // Базовый класс фигуры
    abstract class Figure
    {
        // Внутреннее поле имя фигуры
        protected string name;

        // Конструктор с параметром инициализирующий поле name
        public Figure(string name)
        {
            this.name = name;
        }

        // Свойство для доступа к полю name
        public string Name
        {
            get { return name; }
        }

        // Абстрактный метод для вычисления площади фигуры
        public abstract double Area();

        public abstract double Perimeter();

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
