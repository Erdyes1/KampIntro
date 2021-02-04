using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            // Bunu Kullanmak icin Basvuru Managerde birden fazla Krediyi göster demem gerekiyor.ayni Logger servicede.
            // List<IKrediManager> krediler = new List<IKrediManager> { new IhtiyacKrediManager(), new TasitKrediManager(), new KonutKrediManager() }   ;

            //ILoggerService databaseLoggerservice = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };
            
            
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager , loggers );

           
           // basvuruManager.krediOnBilgilendirmesiyap(krediler);

        }
    }
}
