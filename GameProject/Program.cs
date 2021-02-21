using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------OYUNCU EKLEME
            GamerManager gamerManager = new GamerManager(new UservalidationManager()) ;
            gamerManager.Add(new Gamer { Id = 1, FirstName = "ENGİN", LastName = "DEMİROĞ", BirtYear = 1985, IdentityNumber = 12345678910 });
            gamerManager.Add(new Gamer { Id = 2, FirstName = "Bülent", LastName = "VELI", BirtYear = 1995, IdentityNumber = 123456 });
            gamerManager.Add(new Gamer { Id = 3, FirstName = "Cemil", LastName = "VELI", BirtYear = 2000, IdentityNumber = 123456 });
            gamerManager.Add(new Gamer { Id = 4, FirstName = "Davut", LastName = "VELI", BirtYear = 2001, IdentityNumber = 123456 });
            gamerManager.Add(new Gamer { Id = 5, FirstName = "Erdem", LastName = "VELI", BirtYear = 2002, IdentityNumber = 123456 });
            //-------------OYUN EKLEME
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game() { Id = 1, GameName = "Call of Duty: Black Ops: Cold War", Publisher = "Activision Blizzard", UnitPrice = 49, UnitInStock = 10 });
            gameManager.Add(new Game() { Id = 2, GameName = "Assassin's Creed: Valhalla", Publisher = "Ubisoft", UnitPrice = 29, UnitInStock = 15 });
            gameManager.Add(new Game() { Id = 3, GameName = "Marvel's Spider-Man: Miles Morales", Publisher = "Sony (Corp)", UnitPrice = 59, UnitInStock = 0 });
            //-------------KAMPANYA EKLEME
            SalesCaampaignManager salesCaampaignManager = new SalesCaampaignManager();
            salesCaampaignManager.Add(new SalesCampaign() { Id = 0, SalesCampaignName = "Yilbasi", Discount = 15 });
            //-------------SEPET EKLEME
            //  --- Yapamadim
            BasketManager basketManager = new BasketManager(Gamer, game, salesCampaig );
            
            basketManager.Add(new Basket() { Id = 1, GamerId = 1   , GameId = 2 , Quantity = 3});
            // 
           




            //List<GameManager> gameManagers = new List<GameManager> { };
            //Console.WriteLine(gameManager);
            //Console.WriteLine(gamerManager.ToString());











        }
    }
}
