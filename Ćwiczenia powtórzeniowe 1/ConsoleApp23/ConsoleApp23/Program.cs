using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miasta = new Dictionary<string, int>();
            miasta.Add("Białystok", 297459);
            miasta.Add("Bydgoszcz", 350178);
            miasta.Add("Gdańsk", 466631);
            miasta.Add("Gorzów Wielkopolski", 124295);
            miasta.Add("Katowice", 294510);
            miasta.Add("Kielce", 195774);
            miasta.Add("Lublin", 339682);
            miasta.Add("Łódź", 682679);
            miasta.Add("Olsztyn", 173125);
            miasta.Add("Opole", 128208);
            miasta.Add("Poznań", 535802);
            miasta.Add("Rzeszów", 195734);
            miasta.Add("Szczecin", 402100);
            miasta.Add("Toruń", 201798);
            miasta.Add("Warszawa", 1777972);
            miasta.Add("Wrocław", 641607);
            miasta.Add("Zielona Góra", 140874);
            Console.WriteLine("Liczba ludności miast wojewódzkich\n");
            foreach (var miasto in miasta)
                Console.WriteLine(miasto.Key + ", " + miasto.Value);

            Console.ReadKey();
        }
    }
}
