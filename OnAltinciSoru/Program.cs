using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnAltinciSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            int kare = 0, kup = 0;
            Hesapla(sayi, kare, ref kup);
            Console.WriteLine(kare + " & " +kup);
            Console.ReadLine();
        }
        static void Hesapla(int sayi, int kare, ref int kup)
        {
            kare = sayi * sayi;
            kup = kare * sayi;
        }
    }
}
