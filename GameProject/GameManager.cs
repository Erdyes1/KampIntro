using System;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun  " + "---  " + game.GameName + "  ---" + " kayit oldu");
            Console.WriteLine();
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun " + "-- - " + game.GameName + "-- - " + " güncellendi");
            Console.WriteLine();
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun" + "---  " + game.GameName + "  ---" + " silindi");
            Console.WriteLine();
        }
    }
}
