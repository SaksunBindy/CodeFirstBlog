using BusinessLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;

namespace PresentationLayer.Views.Game
{
    public class GameController : Controller
    {
        public GameService GameService { get; set; }
        public SpotService SpotService { get; set; }
        public RewardService RewardService { get; set; }
        public IntersectionGameSpotService IntersectionGameSpotService { get; set; }
        public IntersectionGameRewardService IntersectionGameRewardService { get; set; }
        public GameController(GameService gameService, SpotService spotService, RewardService rewardService, IntersectionGameSpotService intersectionGameSpotService, IntersectionGameRewardService intersectionGameRewardService)
        {
            GameService = gameService;
            SpotService = spotService;
            RewardService = rewardService;
            IntersectionGameSpotService = intersectionGameSpotService;
            IntersectionGameRewardService = intersectionGameRewardService;
        }
        public IActionResult Index()
        {
            List<GameModel> allGames = GameService.GetAllGames();
            return View(allGames);
        }

        public IActionResult Edit(Guid Id)
        {
            EditGameViewModel EditGameViewModel = new EditGameViewModel
            {
                Spots = SpotService.GetAllSpots(),
                Rewards = RewardService.GetAllRewards(),
                IntersectionGameSpots = IntersectionGameSpotService.GetAllIntersections(),
                IntersectionGameRewards = IntersectionGameRewardService.GetAllIntersections(),
                GameModel = GameService.GetGameFromGameId(Id)
            };
            return View(EditGameViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AddGameViewModel addGameViewModel, IFormCollection form, Guid Id)
        {
            GameService.DeleteGame(Id);
            AddGame(addGameViewModel, form);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(Guid Id)
        {
            GameModel gameToBeDeleted = GameService.GetGameFromGameId(Id);
            return View(gameToBeDeleted);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid Id)
        {
            GameModel gameToBeDeleted = GameService.GetGameFromGameId(Id);
            GameService.DeleteGame(Id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddGame()
        {
            AddGameViewModel addGameViewModel = new AddGameViewModel
            {
                Spots = SpotService.GetAllSpots(),
                Rewards = RewardService.GetAllRewards(),
            };
            return View(addGameViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGame(AddGameViewModel addGameViewModel, IFormCollection form)
        {
            GameModel gameModel = addGameViewModel.GameModel;
            gameModel.Id = Guid.NewGuid();
            GameService.AddGame(gameModel);
            LinkGameToSpots(form.Keys, gameModel);
            LinkGameToRewards(form.Keys, gameModel);

            return RedirectToAction(nameof(Index));
        }
        private void LinkGameToSpots(ICollection<string> formKeys, GameModel game)
        {
            List<Spot> allSpots = SpotService.GetAllSpots();
            foreach (string key in formKeys)
            {
                foreach (Spot spot in allSpots)
                {
                    if (spot.Id.ToString() == key)
                    {
                        IntersectionGameSpot intersectionGameSpot = new IntersectionGameSpot
                        {
                            GameId = game.Id,
                            SpotId = spot.Id
                        };
                        IntersectionGameSpotService.AddIntersection(intersectionGameSpot);
                    }
                }
            }
        }
        private void LinkGameToRewards(ICollection<string> formKeys, GameModel game)
        {
            List<Reward> allRewards = RewardService.GetAllRewards();
            foreach (string key in formKeys)
            {
                foreach (Reward reward in allRewards)
                {
                    if (reward.Id.ToString() == key)
                    {
                        IntersectionGameReward intersectionGameReward = new IntersectionGameReward
                        {
                            GameId = game.Id,
                            RewardId = reward.Id
                        };
                        IntersectionGameRewardService.AddIntersection(intersectionGameReward);
                    }
                }
            }
        }

    }
}
