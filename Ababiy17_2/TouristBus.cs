using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy17_2
{
    // Потомок класса Автобус - Туристический автобус
    class TouristBus : Bus
    {
        // Дополнительное поле потомка
        public double ExcursionPrice { get; set; }

        // Конструктор с параметрами
        public TouristBus(string brand, int seatsCount, double ticketPrice, double excursionPrice)
            : base(brand, seatsCount, ticketPrice)
        {
            ExcursionPrice = excursionPrice;
        }

        // Переопределение метода для расчета общей стоимости всех мест с учетом увеличения цены за экскурсию
        public override double CalculateTotalCost()
        {
            double baseCost = base.CalculateTotalCost(); // Расчет базовой стоимости
            return baseCost + SeatsCount * ExcursionPrice; // Учет стоимости экскурсии
        }
    }
}
