using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkBorc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int araba, saat, ödeme ;
            Console.WriteLine("Araç türünü yazınız:");
            Console.ReadLine();
            Console.WriteLine("Kaç saat park edildiğini yazın");
            saat = Convert.ToInt32(Console.ReadLine());
                    if (saat <= 2)
                    {
                        ödeme = 5;
                        Console.WriteLine("Toplam Borç= " + ödeme + "Tl");
                    }
                    if (saat > 2 && saat <= 10)
                    {
                    saat = saat - 2;
                    ödeme = 5 + saat;
                        Console.WriteLine("Toplam Borç= " + ödeme + "Tl");
                    }
                    if (saat >= 11 && saat <= 24)
                    {
                        Console.WriteLine("Toplam Borç 18 Tl");
                    }
            Console.ReadKey();
            
                       // Araba İlk2saat = 5, sonraki saatler
                      //10a kadar saat başı 1 TL = (10 - 2) * 1 = 8TL TOPLAM = 13 TL öder.
             }
       }
}
