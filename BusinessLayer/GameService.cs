using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class GameService
    {
        public GameRepository GameRepository { get; set; }
        public GameService(GameRepository gameRepository)
        {
            GameRepository = gameRepository;
        }

        public void AddGame(GameModel game)
        {
            GameRepository.AddGame(game);
        }
        public void DeleteGame(Guid Id)
        {
            GameModel gameFromId = GetGameFromGameId(Id);
            GameRepository.DeleteGame(gameFromId);
        }
        public List<GameModel> GetAllGames()
        {
            List<GameModel> allGames = GameRepository.GetAllGames();
            return allGames;
        }

        public GameModel GetGameFromGameId(Guid Id)
        {
            List<GameModel> allGames = GetAllGames();
            GameModel gameFromId = allGames.FirstOrDefault(g => g.Id == Id);
            return gameFromId;
        }
    }
}
