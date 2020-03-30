using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        protected class Kula
        {
            private float promien;

            public Kula(float a)
            {
                this.promien = a;
            }

            public float ObliczPole()
            {
                return 4 * Convert.ToSingle(Math.PI) * Convert.ToSingle(Math.Pow(this.promien, 2));
            }

            public float ObliczObjetosc()
            {
                return ((float)4 / 3) * Convert.ToSingle(Math.PI) * Convert.ToSingle(Math.Pow(this.promien, 3));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień kuli");
            float a = float.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Podano ujemną wartość promienia. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
            }

            Kula kula = new Kula(a);
            float pole = kula.ObliczPole();
            float obj = kula.ObliczObjetosc();

            Console.WriteLine("Pole: {0}, objętość: {1}", pole, obj);
            Console.ReadKey();
        }
    }
}
