using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę stopni Celsjusza");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("W stopniach Fahrenheita: " + (f * 1.8 + 32));
            Console.WriteLine("W stopniach Kelvina: " + (f + 273.15));
            Console.ReadKey();
        }
    }
}
