using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar kalendarz = CultureInfo.InvariantCulture.Calendar;
            DateTime teraz = DateTime.Now;
            int liczbaDniOdPoczatkuRoku = kalendarz.GetDayOfYear(teraz);
            int godzina = kalendarz.GetHour(teraz);
            int liczbaGodzinOdPoczatkuRoku = (liczbaDniOdPoczatkuRoku - 1) * 24 + godzina;
            Console.WriteLine("Liczba godzin od początku roku: " + liczbaGodzinOdPoczatkuRoku);
            Console.ReadKey();
        }
    }
}
