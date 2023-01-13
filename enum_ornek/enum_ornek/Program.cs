using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_ornek
{
    internal class Program
    {
        enum Seviye
        {
            baslangic,
            orta,
            ileri
        }
        static void Main(string[] args)
        {
            Seviye level;//enum nesnesini oluşturur.
            level=Seviye.baslangic;//oluşturulan enum değişkenine classtan değer atama.
            int index = (int)level;
            Console.WriteLine(index);
            Console.WriteLine(level);
            Console.ReadLine();


            level =Seviye.orta;
            index = (int)level;
            Console.WriteLine(index);
            Console.WriteLine(level);





            Console.ReadLine() ;
        }
    }
}
