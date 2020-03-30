using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dzis = DateTime.Now;
            Calendar kalendarz = CultureInfo.InvariantCulture.Calendar;
            int rok = kalendarz.GetYear(dzis);
            int miesiac = kalendarz.GetMonth(dzis);
            int liczbaDni = kalendarz.GetDaysInMonth(rok, miesiac);
            DateTime dzienMiesiaca;
            DayOfWeek dzienTygodnia;

            Console.WriteLine(miesiac + "." + rok + "\n");
            for (int i=0; i<liczbaDni; i++)
            {
                dzienMiesiaca = new DateTime(rok, miesiac, i + 1);
                dzienTygodnia = kalendarz.GetDayOfWeek(dzienMiesiaca);
                Console.WriteLine((i + 1) + " - " + dzienTygodnia);
            }


            Console.ReadKey();
        }
    }
}
