using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Telefon : ICloneable
    {
        public string marka;
        public int model;

        public Telefon()
        {
            marka = "Skoda";
            model = 1;
        }

        public Object Clone()
        {
            return MemberwiseClone();
        }

        public Telefon GlebokaKopia()
        {
            Telefon temp = new Telefon();
            temp.marka = this.marka;
            temp.model = this.model;
            return temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon1 = new Telefon();
            Telefon telefon2 = (Telefon)telefon1.Clone();
            Telefon telefon3 = telefon1.GlebokaKopia();

            if (Object.ReferenceEquals(telefon1, telefon2))
                Console.WriteLine("Referencje płytkiej kopii odwołuja się do tego samego obiektu");
            else Console.WriteLine("Referencje płytkiej kopii nie odwołuja się do tego samego obiektu");

            if (Object.ReferenceEquals(telefon1, telefon3))
                Console.WriteLine("Referencje głębokiej kopii odwołuja się do tego samego obiektu");
            else Console.WriteLine("Referencje głębokiej kopii nie odwołuja się do tego samego obiektu");



            Console.ReadKey();
        }
    }
}
