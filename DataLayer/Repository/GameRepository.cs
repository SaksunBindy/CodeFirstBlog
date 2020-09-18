using DataLayer.Context;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class GameRepository
    {
        public GameContext GameContext { get; set; }
        public GameRepository(GameContext gameContext)
        {
            GameContext = gameContext;
        }

        public void AddGame(GameModel game)
        {
            GameContext.Add(game);
            GameContext.SaveChanges();
        }
        public void DeleteGame(GameModel game)
        {
            GameContext.Remove(game);
            GameContext.SaveChanges();
        }
        public List<GameModel> GetAllGames()
        {
            List<GameModel> allGames = GameContext.Games.Include(m => m.IntersectionGameSpots).Include(m => m.IntersectionGameRewards).OrderBy(m=>m.Name).ToList();
            return allGames;
        }
    }
}
