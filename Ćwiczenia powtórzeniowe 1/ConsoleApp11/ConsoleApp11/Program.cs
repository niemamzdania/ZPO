using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg wejściowy");
            string a = Console.ReadLine();
            Console.WriteLine("Ciąg jako małe litery: \n" + a.ToLower());
            Console.ReadKey();
        }
    }
}
