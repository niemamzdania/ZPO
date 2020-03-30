using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        protected class Walec
        {
            private float promien, wysokosc;

            public Walec(float a, float b)
            {
                this.promien = a;
                this.wysokosc = b;
            }

            public float ObliczPole()
            {
                return 2 * (float)Math.PI * (float)Math.Pow(promien, 2) + 2 * (float)Math.PI * promien * wysokosc;
            }

            public float ObliczObjetosc()
            {
                return (float)Math.PI * (float)Math.Pow(promien, 2) * wysokosc;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień i wysokość walca");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Podano ujemną wartość boku. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
                //Environment.Exit(1);
            }

            Walec wal = new Walec(a, b);
            float obj = wal.ObliczObjetosc();
            float pole = wal.ObliczPole();

            Console.WriteLine("Objętość: {0}, pole: {1}", obj, pole);
            Console.ReadKey();
        }
    }
}
