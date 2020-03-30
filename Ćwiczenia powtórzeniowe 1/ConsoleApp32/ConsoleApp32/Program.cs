using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        protected class Stozek
        {
            private float promien, wysokosc;

            public Stozek(float a, float b)
            {
                this.promien = a;
                this.wysokosc = b;
            }

            public float ObliczPole()
            {
                float s = (float)Math.Sqrt(Math.Pow(wysokosc, 2) + Math.Pow(promien, 2));

                return (float)Math.PI * (float)Math.Pow(promien, 2) + (float)Math.PI * promien * s;
            }

            public float ObliczObjetosc()
            {
                return ((float)1 / 3) * (float)Math.PI * (float)Math.Pow(promien, 2) * wysokosc;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień i wysokość stożka");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Podano ujemną wartość boku. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
                //Environment.Exit(1);
            }

            Stozek pro = new Stozek(a, b);
            float pole = pro.ObliczPole();
            float obj = pro.ObliczObjetosc();

            Console.WriteLine("Pole: {0}, objętość: {1}", pole, obj);
            Console.ReadKey();
        }
    }
}

