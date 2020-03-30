using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double liczba = double.Parse(Console.ReadLine());
            double pierwiastek = Math.Sqrt(liczba);
            if (Double.IsNaN(pierwiastek))
                Console.WriteLine("Nie można obliczyć pierwiastka kwadratowego z liczby ujemnej.");
            else Console.WriteLine("Pierwiastek kwadratowy z tej liczby to: " + pierwiastek);

            Console.ReadKey();
        }
    }
}
