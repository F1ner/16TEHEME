using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public abstract class Human
    {
        /// <summary>
        /// поля абстрактного класса человек с модификатором доступа protected 
        /// </summary>
        protected string name;
        protected string nationality;


        /// Метод для инициализации экземпляра класса Human с указанным именем и национальностью.
        /// Этот метод используется для инициализации экземпляра класса Human в классах-наследниках.
        protected Human(string name, string nationality)
        {
            this.name = name;
            this.nationality = nationality;
        }

        /// <summary>
        /// свойство поля Name
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// свойство поля Nationality
        /// </summary>
        public string Nationality
        {
            get { return nationality; }
        }
    
        /// <summary>
        /// вызов метода вывода из производных классов
        /// </summary>
        /// <returns></returns>
    public abstract string Greet();
    }
}
