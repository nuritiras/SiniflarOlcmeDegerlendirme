using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YirminciSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IGuc
    {
        void GucAc();
        void GucKapa();
    }

    public class Televizyon : IGuc
    {
        public void GucAc()
        {
            // Güç açma işlemini gerçekleştirecek kodlar.
            Console.WriteLine("Güç açma metodu çalıştı.");
        }
        public void GucKapa()
        {
            // Güç kapama işlemini gerçekleştirecek kodlar.
            Console.WriteLine("Güç kapama metodu çalıştı.");
        }
    }
    public class Bilgisayar : IGuc
    {
        public void GucAc()
        {
            // Güç açma işlemini gerçekleştirecek kodlar.
            Console.WriteLine("Güç açma metodu çalıştı.");
        }
        public void GucKapa()
        {
            // Güç kapama işlemini gerçekleştirecek kodlar.
            Console.WriteLine("Güç kapama metodu çalıştı.");
        }
    }
}
