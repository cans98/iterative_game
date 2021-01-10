using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterative_game
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rastgeleSayi = new Random(); // random sayı uretilir
            int uretilenSayi = rastgeleSayi.Next(1, 100);

            bool tekrarla = false;
            while (!tekrarla)
            {
                
                while (true) // sonsuz dongu cunku devamlılık kullanıcıya bağlı
                {
                    Console.WriteLine("Tahmininizi giriniz");
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    if (uretilenSayi > tahmin)
                    {
                        Console.WriteLine("Yukari");
                    }
                    else if (uretilenSayi < tahmin)
                    {
                        Console.WriteLine("Asagı");
                    }
                    else
                    {
                        Console.WriteLine("Esittir");
                        break; // donguden cıkılır
                    }

                }
                Console.WriteLine("Tekrar oynamak ister misiniz");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.Clear();
                    uretilenSayi = rastgeleSayi.Next(1, 100);
                }
                else if(cevap == "hayir")
                {
                    tekrarla = true;
                    break; // bastaki while sonlanır
                }
            }
            Console.ReadLine();


        }
    }
}
