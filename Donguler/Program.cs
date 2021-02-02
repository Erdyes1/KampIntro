using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazilim Gelistirme ";
            //string kurs2 = "programlamaya baslama ";
            //string kurs3 = "Java Baslangic ";
            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);

            //Console.WriteLine("xxxxxxxxxxxxxxx");

            string[] kurslar = new string[] { "Java", "Pyhton", "sharp", "c++" };

            //for (int i = 0; i < kurslar.Length ; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            //Console.WriteLine("xxxxxxxxxxx");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("xxxxxxxxxxx");
            
        }
    }
}
