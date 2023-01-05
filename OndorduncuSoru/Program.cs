using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndorduncuSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            Fonk1(ref num);
            Console.WriteLine(num);
        }
        static void Fonk1(ref int num)
        {
            num = num * num * num;
        }
    }
}
