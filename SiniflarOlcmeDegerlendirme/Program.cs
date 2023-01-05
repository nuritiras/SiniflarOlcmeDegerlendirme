using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarOlcmeDegerlendirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AkilliTelevizyon akilliTelevizyon = new AkilliTelevizyon();
            akilliTelevizyon.ses_seviyesi = 5;
            Console.WriteLine(AkilliTelevizyon.Marka);
            Televizyon televizyon = new Televizyon();          
            Console.WriteLine(Televizyon.Marka);
            
          
        }
    }

    public class Televizyon
    {
        protected internal ushort ses_seviyesi;
        public double ekran_boyutu;
        public string goruntu_teknolojisi;
        public const string Marka = "Samsung";
        public int kanal_no = 0;
        public virtual void guc_ac_kapat()
        {

        }
        public void kanal_degistir() 
        {
            KanalNoArtir();
        }

        public void ses_seviyesi_oku()
        {

        }

        public void KanalNoArtir()
        {
            kanal_no++;
        }

        public void KanalNoAzalt()
        {
            kanal_no--;
        }

        public void KanalNoArtir(int sayi)
        {
            kanal_no+= sayi;
        }

        public void KanalNoAzalt(int sayi)
        {
            kanal_no -= sayi;
        }

    }

    public class Bilgisayar
    {
        string RAM;
        string CPU;
        string HDD;
    }

    public class TelevizyonOzellik
    {
        public ushort ses_seviyesi { get; set; }
        public double ekran_boyutu { get; set; }
        public string goruntu_teknolojisi { get; set; }
    }

    public class BilgisayarOzellik
    {
        public string RAM { get; set; }
        public string CPU { get; set; }
        public string HDD { get; set; }
    }

    public class AkilliTelevizyon : Televizyon
    {
        public string isletim_sistemi { get; set; }
        public override void guc_ac_kapat()
        {

        }
    }
}
