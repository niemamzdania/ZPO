using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar kalendarz = CultureInfo.InvariantCulture.Calendar;
            DateTime teraz = DateTime.Now;
            int godzina = kalendarz.GetHour(teraz);
            int minuta = kalendarz.GetMinute(teraz);
            int liczbaMinut = godzina * 60 + minuta;
            Console.WriteLine("Godzina: {0}, minuta: {1}", godzina, minuta);
            Console.WriteLine("Liczba minut od początku dnia: " + liczbaMinut);
            Console.ReadKey();
        }
    }
}
