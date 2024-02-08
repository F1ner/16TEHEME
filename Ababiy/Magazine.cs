using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy
{
    //class Magazine : Press
    //{
    //    public string Quality { get; set; } // качество бумаги

    //    // Конструктор класса
    //    public Magazine(int copies, string name, double price, string quality) : base(copies, name, price)
    //    {
    //        Quality = quality;
    //    }

    //    // Переопределение метода для вычисления стоимости тиража
    //    public override double Cost()
    //    {
    //        double cost = base.Cost(); // вызов метода базового класса для вычисления стоимости

    //        // Изменение стоимости в зависимости от качества бумаги
    //        switch (Quality)
    //        {
    //            case "высокое":
    //                cost *= 1.1; // увеличение на 10%
    //                break;
    //            case "среднее":
    //                // стоимость остается без изменений
    //                break;
    //            case "низкое":
    //                cost *= 0.9; // уменьшение на 10%
    //                break;
    //        }
    //        return cost;
    //    }

    //    // Переопределение метода для вывода состояния объекта
    //    public new void Output()
    //    {
    //        base.Output(); // вызов метода базового класса для вывода основной информации
    //        Console.WriteLine($"Качество бумаги: {Quality}");
    //    }
    //}

}
