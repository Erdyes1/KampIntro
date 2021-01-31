using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
                      
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(0,"Amet", "Yildiz", 32.28 , false);
            musteriManager.Ekle(1,"Bura", "Yildiz", 132.28, true);
            musteriManager.Ekle(2,"Cem", "Yildiz", 1132.28, false);
            musteriManager.Ekle(3,"Derya", "Yildiz", 2325.28, true);
            musteriManager.Ekle(4,"Erol", "Yildiz", 5000, false);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            foreach (var item in musteriManager)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Musteri ID 2 ");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            











        }







    }
}
