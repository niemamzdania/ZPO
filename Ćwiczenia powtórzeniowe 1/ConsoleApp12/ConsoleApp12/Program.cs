using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg wejściowy");
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            string c = b.OrderByDescending(e => e.Length).First();
            Console.WriteLine("Najdłuższy wyraz: " + c);
            Console.ReadKey();
        }
    }
}
