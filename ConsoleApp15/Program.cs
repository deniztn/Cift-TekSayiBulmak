using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayi giriniz:");
            int sayi = Convert.ToInt16(Console.ReadLine());
            int mod = sayi % 2;
            if (mod == 0)
                Console.Write("sayi çift.");
            else
                Console.Write("sayi tek.");
            Console.ReadKey();
        }
    }
}
