﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;Console.WriteLine(sayilar1[0]);
            sayilar2[0] = 999;
         //   Console.WriteLine(sayilar1[]);
         //   Console.WriteLine(sayilar2[]);
            
            Console.WriteLine(sayilar1[0]);
        }
    }
}
