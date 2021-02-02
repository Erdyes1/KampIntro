using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ogrenci ogrenci1 = new Ogrenci();
            //ogrenci1.Id = 1;
            //ogrenci1.Name = "Zeki";

            //Ogrenci ogrenci2 = new Ogrenci() { Id = 2, Name = "Ali" };
            //Ogrenci ogrenci3 = new Ogrenci() { Id = 3, Name = "Bekir" };
            //Ogrenci ogrenci4 = new Ogrenci() { Id = 4, Name = "Cem" };
            //Ogrenci ogrenci5 = new Ogrenci() { Id = 5, Name = "Davut" };

            //List<Dictionary<int, string>> ogrenci = new List<Dictionary<int, string> >() 
            //{   {2,Ali},{ 3, "Bekir" },{ 4, "Cem" },{ 5, "Davut" }  };
            // ogrenci.Add(ogrenci);

            Dictionary<int, string> xl = new Dictionary<int, string>();
            xl.Add(2, "Ali"     );
            xl.Add(3, "Bekir"   );
            xl.Add(4, "Cem"     );
            xl.Add(5, "Davut"   );

           

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");


            foreach (var item in xl)
            {
                Console.WriteLine(item);
            }
            
            





         
           



            //Dictionary<int, String> dictionary1 = new Dictionary<int, String>();



            //    dictionary1.Add(ogrenci1.Id, ogrenci1.Name);







            //ProductManager productManager = new ProductManager();
            //productManager.Add(product1);
            //productManager.Add(product2);
            //productManager.Add(product3);
            //productManager.Add(product4);
            //productManager.Add(product5);

        }
    }
}
