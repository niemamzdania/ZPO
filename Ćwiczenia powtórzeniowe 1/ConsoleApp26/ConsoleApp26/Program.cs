using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        protected class Prostokat
        {
            private float a, b;

            public Prostokat(float a, float b)
            {
                this.a = a;
                this.b = b;
            }

            public float ObliczObwod()
            {
                return 2 * this.a + 2 * this.b;
            }

            public float ObliczPole()
            {
                return this.a * this.b;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 boki prostokąta");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Podano ujemną wartość boku. Wciśnij przycisk, aby zakończyć.");
                Console.ReadKey();
                return;
                //Environment.Exit(1);
            }

            Prostokat pro = new Prostokat(a, b);
            float obw = pro.ObliczObwod();
            float pole = pro.ObliczPole();

            Console.WriteLine("Obwód: {0}, pole: {1}", obw, pole);
            Console.ReadKey();
        }
    }
}
