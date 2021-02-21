using System;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationServicee _userValidationServicee;

        public GamerManager(IUserValidationServicee userValidationServicee)
        {
            _userValidationServicee = userValidationServicee;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationServicee.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu " + "---  " + gamer.FirstName + " " + gamer.LastName + "  ---" + " kayit oldu");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Dogrulama basarizis,Kayit BASARISIZ");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu " + "---  " + gamer.FirstName + " " + gamer.LastName + "  ---" + " güncellendi");
            Console.WriteLine();
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu " + "---  " + gamer.FirstName + " " + gamer.LastName + "  ---" + " silindi");
            Console.WriteLine();
        }
    }
}
