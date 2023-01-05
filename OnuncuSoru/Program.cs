using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnuncuSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public sealed class Televizyon
    {
        //MÜHÜRLÜ SINIFLAR (SEALED CLASSES)
        //Bir sınıftan bir başka sınıf türetilmek istenmediğinde bu
        //sınıfı sealed anahtar kelimesiyle mühürlü tanımlamak
        //gerekir.
    }

    public class AkilliTelevizyon : Televizyon // HATA !!!
    {
        
    }
}
