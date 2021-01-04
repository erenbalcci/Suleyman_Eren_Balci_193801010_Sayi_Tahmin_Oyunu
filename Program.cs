using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayi_Tahmin_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Bir Seviye Seçiniz:Kolay-Orta-Zor");
            string level = Console.ReadLine();
            if (level == "kolay")
            {
                int sayac = 6;
                int random = rnd.Next(1, 10);

                for (; ; )
                {

                    Console.WriteLine("bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    sayac--;
                    if (random == tahmin)
                    {
                        Console.WriteLine("Tebrikler:bildiniz");
                        break;
                    }
                    else if (sayac == 0)
                    {
                        Console.WriteLine("kaybettiniz:hakkınız bitti");
                        break;
                    }

                    Console.WriteLine($"kalan hak:{sayac}");
                }
            }
            else if (level == "orta")
            {
                int sayac = 4;
                int random = rnd.Next(1, 25);

                for (; ; )
                {
                    Console.WriteLine("bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    sayac--;
                    if (random == tahmin)
                    {
                        Console.WriteLine("Tebrikler:bildiniz");
                        break;
                    }
                    else if (sayac == 0)
                    {
                        Console.WriteLine("kaybettiniz:hakkınız bitti");
                        break;
                    }
                    Console.WriteLine($"kalan hak:{sayac}");
                }
            }
            else if (level == "zor")
            {
                int sayac = 2;
                int random = rnd.Next(1, 50);

                for (; ; )
                {
                    Console.WriteLine("bir tahmin yapınız:");
                    int tahmin = int.Parse(Console.ReadLine());
                    sayac--;
                    if (random == tahmin)
                    {
                        Console.WriteLine("Tebrikler:bildiniz");
                        break;
                    }
                    else if (sayac == 0)
                    {
                        Console.WriteLine("kaybettiniz:hakkınız bitti");
                        break;
                    }

                    Console.WriteLine($"kalan hak:{sayac}");
                }
            }
            else
            {
                Console.WriteLine("lütfen doğru bir seviye seçiniz");
            }
            Console.ReadKey();
        }
    }
}
