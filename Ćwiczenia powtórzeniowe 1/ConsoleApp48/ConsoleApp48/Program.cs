using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj datę w formacie dzień.miesiąc.rok");
            double[] data = Array.ConvertAll(Console.ReadLine().Split('.'), double.Parse);
            double[] dniMiesiaca = new double[31];
            for (int i = 0; i < 31; i++)
                dniMiesiaca[i] = i + 1;
            double[] numeryMiesiecy = new double[12];
            for (int i = 0; i < 12; i++)
                numeryMiesiecy[i] = i + 1;
            if (dniMiesiaca.Contains(data[0]) && numeryMiesiecy.Contains(data[1]) && data[2] % 1 == 0 && data[2] != 0){
                if (data[0] == 29)
                {
                    if (data[1] == 2 && data[2] % 4 != 0)
                        Console.WriteLine("Wejście {0}.{1}.{2} nie może być datą.", data[0], data[1], data[2]);
                    else Console.WriteLine("Wejście {0}.{1}.{2} może być datą.", data[0], data[1], data[2]);
                }
                else if(data[0] == 30)
                {
                    if (data[1] == 2)
                        Console.WriteLine("Wejście {0}.{1}.{2} nie może być datą.", data[0], data[1], data[2]);
                    else Console.WriteLine("Wejście {0}.{1}.{2} może być datą.", data[0], data[1], data[2]);
                }
                else if(data[0] > 30)
                {
                    if(data[1] == 2 || data[1] == 4 || data[1] == 6 || data[1] == 9 || data[1] == 11)
                        Console.WriteLine("Wejście {0}.{1}.{2} nie może być datą.", data[0], data[1], data[2]);
                    else Console.WriteLine("Wejście {0}.{1}.{2} może być datą.", data[0], data[1], data[2]);
                }
                else Console.WriteLine("Wejście {0}.{1}.{2} może być datą.", data[0], data[1], data[2]);
            }
            else Console.WriteLine("Wejście {0}.{1}.{2} nie może być datą.", data[0], data[1], data[2]);
            Console.ReadKey();
        }
    }
}
