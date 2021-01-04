using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seviye Seçiniz (kolay,orta,zor)");
            string secim = (Console.ReadLine());

            Console.WriteLine("Bir tahmin yapınız");



            if (secim == "kolay")
            {
                Console.WriteLine("Can Sayısı:5 Tahmin Aralığı:1-10");
                Random rnd = new Random();
                int sayi = rnd.Next(1, 10);





                for (int can = 5; can > 0;)
                {



                    int tahmin = int.Parse(Console.ReadLine());


                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler Bildiniz");
                        break;
                    }
                    else if (can == 1)
                    {

                        Console.WriteLine("Oyun Bitti");
                        Console.WriteLine($"Doğru Cevap:{sayi}");
                        break;
                    }
                    else
                    {
                        can--;
                        Console.WriteLine($"Kalan Hakkınız:{can} Tekrar Deneyiniz");
                    }
                }
            }

            if (secim == "orta")
            {
                Console.WriteLine("Can Sayısı:7 Tahmin Aralığı:1-25");
                Random rnd = new Random();
                int sayi = rnd.Next(1, 25);





                for (int can = 7; can > 0;)
                {



                    int tahmin = int.Parse(Console.ReadLine());


                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler Bildiniz");
                        break;
                    }
                    else if (can == 1)
                    {

                        Console.WriteLine("Oyun Bitti");
                        Console.WriteLine($"Doğru Cevap:{sayi}");
                        break;
                    }
                    else
                    {
                        can--;
                        Console.WriteLine($"Kalan Hakkınız:{can} Tekrar Deneyiniz");
                    }
                }

            }
            if (secim == "zor")
            {
                Console.WriteLine("Can Sayısı:9 Tahmin Aralığı:1-50");
                Random rnd = new Random();
                int sayi = rnd.Next(1, 50);





                for (int can = 9; can > 0;)
                {




                    int tahmin = int.Parse(Console.ReadLine());


                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler Bildiniz");
                        break;
                    }
                    else if (can == 1)
                    {

                        Console.WriteLine("Oyun Bitti");
                        Console.WriteLine($"Doğru Cevap:{sayi}");
                        break;
                    }
                    else
                    {
                        can--;
                        Console.WriteLine($"Kalan Hakkınız:{can} Tekrar Deneyiniz");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
