using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("-Ekle methodu Urün urün-");
            Console.WriteLine("Sepete eklendi");
            Console.WriteLine("-------------");
        }

        public  void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)
        {
            Console.WriteLine("EKLE Tebrikler Sepete eklendi  : " + urunAdi);



        }
        

    }
}
