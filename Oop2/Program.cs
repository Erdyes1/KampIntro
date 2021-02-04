using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerId = 125 ;
            musteri1.Name = "Erdal" ;
            musteri1.LastName = "Yesilyurt";
            musteri1.TcId = "99999999999 ";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id         = 2             ;
            musteri2.CustomerId = 54321         ;
            musteri2.SirketAdi  = "EYBEE"       ;
            musteri2.VatId      = "156626566"   ;

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
        }
    }
}
