using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        protected class Prostopadloscian
        {
            private float a, b, c;

            public Prostopadloscian(float a, float b, float c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public float ObliczPole()
            {
                return 2 * a * b + 2 * a * c + 2 * b * c;
            }

            public float ObliczObjetosc()
            {
                return a * b * c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 boki podstawy i wysokość prostopadłościanu");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Podano ujemną wartość boku. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
                //Environment.Exit(1);
            }

            Prostopadloscian pro = new Prostopadloscian(a, b, c);
            float pole = pro.ObliczPole();
            float obj = pro.ObliczObjetosc();

            Console.WriteLine("Pole: {0}, objętość: {1}", pole, obj);
            Console.ReadKey();
        }
    }
}

