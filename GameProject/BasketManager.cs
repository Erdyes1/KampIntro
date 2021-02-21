using System;
using System.Collections.Generic;

namespace GameProject
{
    class BasketManager : IBasketService 
    {
        Game _game;
        Gamer _gamer;
        SalesCampaign _salesCampaign;

        public BasketManager(Game game, Gamer Gamer, SalesCampaign salesCampaig)
        {
            _salesCampaign = salesCampaig;
            _game = game;
            _gamer = Gamer;
        }

        public void Add(Basket basket)
        { 
            Console.WriteLine( _gamer.FirstName + " icin " + _game.GameName + " oyunu sepetinize eklenmistir");
            Console.WriteLine(  );
         }

        public void Delete(Basket basket)
        {
            Console.WriteLine(" Sepetiniz güncellenmistir"); ;
        }
        
        public void Update(Basket basket)
        {
            Console.WriteLine(" Ürün Sepetinizden silinmistir"); ;
        }

        
    }
}
