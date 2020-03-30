using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 liczby, odzdzielając je przecinkiem");
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            int[] c = Array.ConvertAll(b, int.Parse);
            Console.WriteLine("Max: {1}, min: {0}", c.Min(), c.Max());

            Console.ReadKey();
        }
    }
}
