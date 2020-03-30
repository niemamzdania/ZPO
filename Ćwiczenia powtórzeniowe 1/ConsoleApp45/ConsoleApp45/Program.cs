using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double a = double.Parse(Console.ReadLine());
            double[] dniMiesiaca = new double[31];
            for (int i = 0; i < 31; i++)
                dniMiesiaca[i] = i + 1;
            if (dniMiesiaca.Contains(a))
                Console.WriteLine("Liczba {0} może być dniem miesiąca.", a);
            else Console.WriteLine("Liczba {0} nie może być dniem miesiąca.", a);
            Console.ReadKey();
        }
    }
}
