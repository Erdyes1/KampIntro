using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
                      
            MusteriManager[] musteriManager = new MusteriManager { };
            musteriManager.Ekle2(0,"Amet", "Yildiz", 32.28 , false);
            musteriManager.Ekle2(1,"Bura", "Yildiz", 132.28, true);
            musteriManager.Ekle2(2,"Cem", "Yildiz", 1132.28, false);
            musteriManager.Ekle2(3,"Derya", "Yildiz", 2325.28, true);
            musteriManager.Ekle2(4,"Erol", "Yildiz", 5000, false);

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            Console.WriteLine("Musteri ID 2 ");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            musteriManager.Sil.re(2);
            musteriManager.re

            Console.WriteLine("Isimli Müsteri Listeden Cikartilmistir" + musteriManager.Sil );










        }







    }
}
