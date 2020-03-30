using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków");
            string a = Console.ReadLine();
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                    b += a[a.Length - 1];
                else if (i == a.Length - 1)
                    b += a[0];
                else b += a[i];
            }

            Console.WriteLine("Wynikowy ciąg znaków to: " + b);
            Console.ReadKey();
        }
    }
}
