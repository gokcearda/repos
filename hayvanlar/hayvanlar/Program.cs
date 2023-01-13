using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayvanlar
{
    class Hayvanlar //Parent
    {
        public virtual void HayvanSesleri()
        {
            Console.WriteLine("Hayvanlar farklı sesler çıkartır.");
        }
    }
    class Kedi : Hayvanlar //Child
    {
        public override void HayvanSesleri()
        {
            //base.HayvanSesleri();
            Console.WriteLine("Kediler Miyavlar");
        }
    }
    class Kopek : Hayvanlar //Child
    {
        public override void HayvanSesleri()
        {
            //base.HayvanSesleri(); //base default olarak parent clasında olan metodu çalıştırır.
            Console.WriteLine("Köpekler Havlar");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Hayvanlar canli = new Hayvanlar();
            Hayvanlar kedi = new Kedi();
            //Kedi kedi1 = new Kedi();
            Hayvanlar kopek = new Kopek();

            canli.HayvanSesleri();

            kedi.HayvanSesleri();

            kopek.HayvanSesleri();

            Console.ReadLine();
        }
    }
}
