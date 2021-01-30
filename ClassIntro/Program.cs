using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Engin";
            int Yas = 36;
 
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Erdal";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ali";
            kurs2.IzlenmeOrani = 25;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Ziya";
            kurs3.IzlenmeOrani = 11;

           Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (var alias in kurslar)
            {
                Console.WriteLine(alias.KursAdi + "  -  " + alias.Egitmen + "  -  " + alias.IzlenmeOrani);
            }



           

        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }

        }
    }
}
