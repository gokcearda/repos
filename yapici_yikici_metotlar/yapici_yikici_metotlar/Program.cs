using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapici_yikici_metotlar
{
    public class Personel
    {
        public string Ad;
        public string Soyad;
        private int _yas;
        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value < 0 || value > 150)
                {
                    value = 0;
                }
                else
                {
                    _yas = value;
                }
            }
        }

        public int Maas;

        public void BilgileriYazdir()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Yas: " + Yas);
            Console.WriteLine("Maaş: " + Maas);
        }

        public int MaasZamYap(int zamMiktari)
        {
            Maas = Maas + zamMiktari;
            return Maas;
        }

        public Personel()//Yapıcı (Constructor) Metot
        {
            Ad = "xxx";
            Soyad = "yyy";
            Yas = 0;
            Maas = 0;
        }
        public Personel(string ad, string soyad, int yas, int maas)//Yapıcı metoda aşırı yükleme yapılması
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Maas = maas;
        }

        ~Personel()
        {
            Console.WriteLine("Burası yıkıcı metottur.");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Personel personel = new Personel();
            personel.Ad = "Rabia";
            personel.Soyad = "Baştan";
            personel.Yas = 27;
            personel.Maas = 20000;

            //personel.BilgileriYazdir();

            //personel.MaasZamYap(5000);
            //Console.WriteLine("----------------");

            //personel.BilgileriYazdir();

            Console.WriteLine("Personel Adı: " + personel.Ad);
            Console.WriteLine("Personel Soyadı: " + personel.Soyad);
            Console.WriteLine("Personel Yas: " + personel.Yas);
            Console.WriteLine("Personel Maas: " + personel.Maas);
            Console.ReadLine();
        }
    }
}
