using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" Yeni Müsteri eklenmistir");

        }
        public void Liste(int Id, string Name, string Soyadi, double Bakiye, bool Kredikart)
        {
            Console.WriteLine(Id + Name +" "+ Soyadi + " "+Bakiye+" " +Kredikart );

        }
        public void Sil(int Id)
        {
            Console.WriteLine("Isimli Müsteri Listeden Cikartilmistir");
        }


          

    }
}
