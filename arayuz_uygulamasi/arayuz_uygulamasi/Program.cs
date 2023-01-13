using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuz_uygulamasi
{
    class Kare : Interface1
    {

        private int kenar;

        public int uzunluk
        {
            get { return kenar; }
            set { kenar = value; }
        }
       

        public double AlanHesaplama()
        {
            return 4 * kenar;
        }

        public double CevreHesaplama()
        {
            return Math.Pow(kenar,kenar);
        }
    }

    class Daire : Interface1
    {
        private int yaricap;
        public int uzunluk
        {
            get { return yaricap; }
            set { yaricap = value; }
        }

        public double AlanHesaplama()
        {
            return (yaricap^2)*Math.PI;
        }

        public double CevreHesaplama()
        {
            return 2*Math.PI*yaricap;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare();
            kare.uzunluk = 5;
            double sonuc1 = kare.AlanHesaplama();
            double sonuc2 = kare.CevreHesaplama();
            Console.WriteLine("Kare Alan Hesaplama: " + sonuc1);
            Console.WriteLine("Kare Çevre Hesaplama: " + sonuc2);
            Console.WriteLine("--------------------------");

            Daire daire = new Daire();
            daire.uzunluk = 3;
            double sonuc3 = daire.AlanHesaplama();
            double sonuc4 = daire.CevreHesaplama();
            Console.WriteLine("Daire Alan Hesaplama: " + sonuc3);
            Console.WriteLine("Daire Çevre Hesaplama: " + sonuc4);
            Console.ReadLine();
        }
    }
}
