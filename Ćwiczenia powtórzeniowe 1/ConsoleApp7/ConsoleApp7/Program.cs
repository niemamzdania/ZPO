using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 liczby");
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Średnia arytmetyczna tych liczb to: " + (a + b + c) / 3);
            Console.WriteLine("Średnia geometryczna tych liczb to: " + Math.Pow(a * b * c, (1.0 / 3.0)));
            Console.ReadKey();
        }
    }
}
