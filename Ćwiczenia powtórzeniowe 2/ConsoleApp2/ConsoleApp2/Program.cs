using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Wycieczka
    {
        private int cena;
        private bool allInclusive;
        public string kraj;
        public int hotelGwiazdki;

        public Wycieczka(bool czyAllInclusive)
        {
            allInclusive = czyAllInclusive;
        }

        public void ObliczCene()
        {
            cena = 2500;
            if (allInclusive == true)
                cena += 300;
            if (kraj != "Polska")
                cena += 200;
            cena += 100 * hotelGwiazdki;

            WyswietlCene();
        }

        protected void WyswietlCene()
        {
            Console.Write("Cena: " + cena + "\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wycieczka taniaWycieczka = new Wycieczka(false);
            taniaWycieczka.kraj = "Polska";
            taniaWycieczka.hotelGwiazdki = 3;
            Console.Write("Tania wycieczka. ");
            taniaWycieczka.ObliczCene();

            Wycieczka sredniaWycieczka = new Wycieczka(true);
            sredniaWycieczka.kraj = "Polska";
            sredniaWycieczka.hotelGwiazdki = 4;
            Console.Write("Średnia wycieczka. ");
            sredniaWycieczka.ObliczCene();

            Wycieczka drogaWycieczka = new Wycieczka(true);
            drogaWycieczka.kraj = "Francja";
            drogaWycieczka.hotelGwiazdki = 5;
            Console.Write("Droga wycieczka. ");
            drogaWycieczka.ObliczCene();

            Console.ReadKey();
        }
    }
}
