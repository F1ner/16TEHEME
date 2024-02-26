using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class German : Human
    {
        // Конструктор класса German с одним параметром name для установки имени экземпляра класса German.

        public German(string name) : base(name, "German")
        {
        }

        /// <summary>
        /// метод вывода приветсвия с использованием переменной  name
        /// </summary>
        /// <returns></returns>
        public override string Greet()
        {
            return $"Hallo, {name}!";
        }
    }
}
