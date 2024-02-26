using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class American : Human
    {
        // Конструктор класса  American с одним параметром name для установки имени экземпляра класса  American.
        public American(string name) : base(name, "American")
        {
        }

        /// <summary>
        /// метод вывода приветсвия с использованием переменной  name
        /// </summary>
        /// <returns></returns>
        public override string Greet()
        {
            return $"Hello, {name}!";
        }
    }
}
