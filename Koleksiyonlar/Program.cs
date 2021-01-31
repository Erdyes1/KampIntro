using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil","Bilal" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            
            List<string> isimler2 = new List<string>(){ "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            isimler2.Add("Ilker");
            Console.WriteLine(isimler2[4]);
            //Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            foreach (string item in isimler2)
            {
                Console.WriteLine(item);
            }
             
            


        }

    }
}
