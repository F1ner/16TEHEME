using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy17_2
{
    class Bus
    {
        // Поля/свойства базового класса
        public string Brand { get; set; }
        public int SeatsCount { get; set; }
        public double TicketPrice { get; set; }

        // Конструктор с параметрами
        public Bus(string brand, int seatsCount, double ticketPrice)
        {
            Brand = brand;
            SeatsCount = seatsCount;
            TicketPrice = ticketPrice;
        }

        // Виртуальный метод для расчета общей стоимости всех мест
        public virtual double CalculateTotalCost()
        {
            return SeatsCount * TicketPrice; // Расчет общей стоимости
        }
    }
}
