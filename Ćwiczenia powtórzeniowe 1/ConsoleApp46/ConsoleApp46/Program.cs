using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            double a = double.Parse(Console.ReadLine());
            double[] numeryMiesiecy = new double[12];
            for (int i = 0; i < 12; i++)
                numeryMiesiecy[i] = i + 1;
            if (numeryMiesiecy.Contains(a))
                Console.WriteLine("Liczba {0} może być numerem miesiąca.", a);
            else Console.WriteLine("Liczba {0} nie może być numerem miesiąca.", a);
            Console.ReadKey();
        }
    }
}
