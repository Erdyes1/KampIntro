namespace GameProject
{
    class GameUnitInStockManager : IGameUnitInStockService
    {
        public bool GameUnitInStock(Game game)
        {
            if (game.UnitInStock > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
