using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar kalendarz = CultureInfo.InvariantCulture.Calendar;
            DateTime teraz = DateTime.Now;
            int godzina = kalendarz.GetHour(teraz);
            int minuta = kalendarz.GetMinute(teraz);
            int sekunda = kalendarz.GetSecond(teraz);
            int liczbaSekund = godzina * 3600 + minuta * 60 + sekunda;
            Console.WriteLine("Godzina: {0}, minuta: {1}, sekunda: {2}", godzina, minuta, sekunda);
            Console.WriteLine("Liczba sekund od początku dnia: " + liczbaSekund);
            Console.ReadKey();
        }
    }
}
