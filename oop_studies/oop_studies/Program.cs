using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_studies
{

    class KisiOzellikleri
    {
        public int Id;
        public string Name;
        public string Surname;
        public string City;
        public int Age;
    }

    class Ogretmen:KisiOzellikleri //child
    {
        public string BitirdigiUniv;

        public string Alani;
    }

    class Ogrenci : KisiOzellikleri
    {
        public string Bolum;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen = new Ogretmen();
            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Öğretmen Bilgileri");
            
            ogretmen.Id = 1;
            ogretmen.Name = "Arda";
            ogretmen.Surname = "Gökçe";
            ogretmen.Age = 28;
            ogretmen.Alani = "Enerji";
            ogretmen.BitirdigiUniv = "Kırklareli Üniversitesi";
            ogretmen.City = "İstanbul";

            Console.WriteLine(ogretmen.Id+"\n"+ogretmen.Name+"\n"+ogretmen.Surname+"\n"+ogretmen.Age+"\n"+ogretmen.Alani+"\n"+ogretmen.BitirdigiUniv+"\n"+ogretmen.City);


            Console.WriteLine("----------------------------------");

            Console.WriteLine("Öğrenci Bilgileri");
            ogrenci.Id = 1;
            ogrenci.Name = "Ertem";
            ogrenci.Surname = "Şener";
            ogrenci.Age = 8;
            ogrenci.Bolum = "yatış";
            ogrenci.City = "istanbul";
            

            Console.WriteLine(ogrenci.Id + "\n"+ ogrenci.Name+ "\n"+ ogrenci.Surname + "\n"+ ogrenci.Age+ "\n"+ ogrenci.Bolum+ "\n"+ ogrenci.City);
            Console.ReadLine();
        }
    }
}
