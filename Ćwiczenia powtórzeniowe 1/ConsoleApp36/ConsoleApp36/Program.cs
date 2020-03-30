using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar kalendarz = CultureInfo.InvariantCulture.Calendar;
            DateTime teraz = DateTime.Now;
            int liczbaDniOdPoczatkuRoku = kalendarz.GetDayOfYear(teraz);

            Console.WriteLine("Liczba dni od początku roku: " + liczbaDniOdPoczatkuRoku);
            Console.ReadKey();
        }
    }
}
