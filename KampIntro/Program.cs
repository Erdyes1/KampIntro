using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string katagoriEtiketi = "Katagoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDün = 7.65;
            double dolarBugun = 7.45;


            if (dolarDün>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDün<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }


            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");

            }
            else
            {
                Console.WriteLine("Giris Yap Butonunu");
            }

            Console.WriteLine(katagoriEtiketi);
        }
    }
}
