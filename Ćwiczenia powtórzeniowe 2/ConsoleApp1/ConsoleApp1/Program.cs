using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pies
    {
        private int czasPosilku;

        public void UstawCzasPosilku(int ileGodzin)
        {
            czasPosilku = ileGodzin;
        }

        public int PobierzCzasPosilku()
        {
            return czasPosilku;
        }

        public bool PotrzebnySpacer()
        {
            if (czasPosilku > 5)
                return true;
            return false;
        }
    }

    class WlascicielPsa
    {
        public bool ZabierzNaSpacer(Pies piesek)
        {
            if (piesek.PotrzebnySpacer() == true)
                return true;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pies piesek = new Pies();
            WlascicielPsa wlasciciel = new WlascicielPsa();

            piesek.UstawCzasPosilku(6);
            Console.WriteLine("Czas posilku: {0}. Czy potrzebny spacer?: {1}", piesek.PobierzCzasPosilku(), piesek.PotrzebnySpacer());
            Console.WriteLine("Wlaściciel: Czy zabrać psa na spacer?:" + wlasciciel.ZabierzNaSpacer(piesek));

            piesek.UstawCzasPosilku(3);
            Console.WriteLine("\nCzas posilku: {0}. Czy potrzebny spacer?: {1}", piesek.PobierzCzasPosilku(), piesek.PotrzebnySpacer());
            Console.WriteLine("Wlaściciel: Czy zabrać psa na spacer?:" + wlasciciel.ZabierzNaSpacer(piesek));

            Console.ReadKey();
        }
    }
}
