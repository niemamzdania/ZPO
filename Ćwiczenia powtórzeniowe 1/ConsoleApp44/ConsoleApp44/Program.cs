using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynniki a, b, c równania ax^2+bx+c=0");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a == 0 && b == 0 && c == 0)
                Console.WriteLine("Równanie nieoznaczone");
            else if (a == 0 && b == 0)
                Console.WriteLine("Równanie sprzeczne");
            else if ((a == 0 && c == 0) || (b == 0 && c == 0))
                Console.WriteLine("x=0");
            else if (a == 0)
                Console.WriteLine("x={0}", (-c) / b);
            else if (b == 0)
            {
                if ((-c) / a < 0)
                    Console.WriteLine("Brak rozwiązań");
                else Console.WriteLine("x={0} lub x={1}", Math.Sqrt((-c) / a), -Math.Sqrt((-c) / a));
            }
            else if (c == 0)
                Console.WriteLine("x=0 lub x=", (-b) / a);
            else
            {
                float delta = (float)Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Brak rozwiązań");
                if (delta == 0)
                    Console.WriteLine("x={0}", (-b) / (2 * a));
                if (delta > 0)
                    Console.WriteLine("x1={0}, x2=={1}", ((-b) - Math.Sqrt(delta)) / (2 * a), ((-b) + Math.Sqrt(delta)) / (2 * a));
            }
            Console.ReadKey();
        }
    }
}
