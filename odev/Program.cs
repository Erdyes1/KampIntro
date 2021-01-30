using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {


            double dolarDün = 7.45;
            double dolarBugun = 7.45;
            string durum = "";

            if (dolarBugun < dolarDün)
            {
                durum = "Dolar Yükselmis";
            }
            else
            {
                durum = "Dolar Yükselmemis";
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            durum = (dolarBugun < dolarDün) ? "Dolar Yükselmis" : "Dolar Yükselmemis ";
            Console.WriteLine(durum);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"); Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            int x = 4;
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int eleman in dizi)
            {
                if (eleman == x + 6)
                {
                    Console.WriteLine(eleman);
                }
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            int Sayi = 1;
            //for (int i = 1; i < 6; i++)
            //{   
            //    Random rd = new Random();
            //    int Rakam = rd.Next(0, 5);
            //    if (Rakam == )
            //        Console.WriteLine(rand_num);
            //}
            //////////////////////////////////////////////////////////
            Product Product1 = new Product();
            Product1.Name = "laciSaat";
            Product1.Category = "Hediyelik ";
            Product1.ID = 10025   ;
            //////////////////////////////////////////////////////////
            Product Product2 = new Product();
            Product2.Name = "Kitap";
            Product2.Category = "Kirtasiye ";
            Product2.ID = 10045;
            //////////////////////////////////////////////////////////
            Product Product3 = new Product();
            Product3.Name = "Mala";
            Product3.Category = "Nalbur ";
            Product3.ID = 10085;
            ///////////////////////////////////////////////
            Product[] Products = new Product[] { Product1, Product2, Product3 };
            /////////////////////////////////////////////////////////////
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("xx------FOREACH------xx");
            foreach (var List in Products)
            {
                
                Console.WriteLine(List.Name + " -- " + List.Category + " -- " + List.ID);
            }
            Console.WriteLine("xx------FOR------xx");
            
            
            for (int i = 0; i <= Products.Length; i++)
            {
                Console.WriteLine(Products[i].Name + " -- " + Products[i].Category + " -- " + Products[i].ID);
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        }
        class Product
        {
            public string Name  { get; set; }
            public string Category { get; set; }
            public int ID { get; set; }

        }


    
    }
}
