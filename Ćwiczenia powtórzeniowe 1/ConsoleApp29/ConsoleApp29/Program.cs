using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        protected class Szescian
        {
            private float bok;

            public Szescian(float a)
            {
                this.bok = a;
            }

            public float ObliczPole()
            {
                return 6 * (float)Math.Pow(bok, 2);
            }

            public float ObliczObjetosc()
            {
                return (float)Math.Pow(bok, 3);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok sześcianu");
            float a = float.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Podano ujemną wartość boku. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
            }

            Szescian sze = new Szescian(a);
            float pole = sze.ObliczPole();
            float obj = sze.ObliczObjetosc();

            Console.WriteLine("Pole: {0}, objętość: {1}", pole, obj);
            Console.ReadKey();
        }
    }
}

