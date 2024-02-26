using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Russian : Human
    {
        // Конструктор класса Russian с одним параметром name для установки имени экземпляра класса Russian.
        public Russian(string name) : base(name, "Russian")
        {
        }

        /// <summary>
        /// метод вывода приветсвия с использованием переменной  name
        /// </summary>
        /// <returns></returns>
        public override string Greet()
        {
            return $"Привет, {name}!";
        }
    }
}
