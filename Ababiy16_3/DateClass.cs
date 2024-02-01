using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy16_3
{
    internal class DateClass
    {
        // a. поле DateTime data;
        private DateTime data;

        // b. конструктор без параметров;
        public DateClass()
        {
            data = DateTime.Now;
        }

        // c. конструктор, позволяющий установить заданную дату;
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        // d. свойство, позволяющее установить или получить значение поля класса (доступно для чтения и записи);
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // e. методы, позволяющие:
        //    • вычислить дату предыдущего дня;
        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        //    • вычислить дату следующего дня;
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }

        //    • определить сколько дней осталось до конца месяца.
        public int DaysLeftInMonth()
        {
            DateTime lastDayOfMonth = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            return (lastDayOfMonth - data).Days;
        }
    }
}
