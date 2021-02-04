using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (var item in loggerService)
            {
                item.Log();

            }
        }

        public void krediOnBilgilendirmesiyap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();

            }
        }

    }
}
