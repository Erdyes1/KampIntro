using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi";


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";
            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir  Karpzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun aliasurun  in urunler)
            {
                Console.WriteLine(aliasurun.Adi);
                Console.WriteLine(aliasurun.Fiyati);
                Console.WriteLine(aliasurun.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("--------------Metotlar--------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armit", "Yesil Armit",12,2);
            sepetManager.Ekle2("Elma", "Yesil Elma",10,3);
            sepetManager.Ekle2("Karpuz", "Adana karpuzu",50,125);




        }
    }
}
