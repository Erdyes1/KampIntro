using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary
    {
        //string name = gibi düsün!!!!
        public void Add(Ogrenci ogrenci)        
                { Console.WriteLine(ogrenci.Name+ "  eklendi. ");       }
        public void Update(Ogrenci ogrenci)     
                { Console.WriteLine(ogrenci.Name+ "  güncellendi. ");   }
        public void Remove(Ogrenci ogrenci)     
                { Console.WriteLine(ogrenci.Name+ "  silindi.");        }

    }
}
