using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj po 3 wspolrzedne dwoch wektorów. Współrzędne oddziel spacjami, wektory enterem.");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string[] a2 = a.Split(' ');
            string[] b2 = b.Split(' ');
            int[] a3 = Array.ConvertAll(a2, int.Parse);
            int[] b3 = Array.ConvertAll(b2, int.Parse);
            
            int iloczynSkalarny = 0;
            for (int i = 0; i < a3.Length; i++)
                iloczynSkalarny += a3[i] * b3[i];
            Console.WriteLine("Iloczyn skalarny: " + iloczynSkalarny);

            Console.ReadKey();
        }
    }
}
