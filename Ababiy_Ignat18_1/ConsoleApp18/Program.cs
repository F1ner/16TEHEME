using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {


            /////обьект класса Russian
            //var person1 = new Russian("Иван");
            /////вызов метода вывода из абстрактного класса, переменных name и nationality
            //Console.WriteLine($"{person1.Greet()}\tName: {person1.Name}, Nationality: {person1.Nationality}");
            /////обьект класса American
            //var person2 = new American("John");
            /////вызов метода вывода из абстрактного класса, переменных name и nationality
            //Console.WriteLine($"{person2.Greet()}\tName: {person2.Name}, Nationality: {person2.Nationality}");
            /////обьект класса German
            //var person3 = new German("Hans");
            /////вызов метода вывода из абстрактного класса, переменных name и nationality
            //Console.WriteLine($"{person3.Greet()}\tName: {person3.Name}, Nationality: {person3.Nationality}");



            var people = new List<Human>
                {
                new Russian("Иван"),
                new American("John"),
                new German("Hans"),
                 new Russian("Илюша"),
                  new Russian("Масик"),
                  new American("Jack"),
                  new American("Will"),
                    new German("Hansa"),
                      new German("Ubershturm"),
           };
        

                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Greet()}\t");
                }

                Console.ReadKey();
        }
    }
}
