using BusinessLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace PresentationLayer.Views.Game
{
    public class RewardController : Controller
    {
        public RewardService RewardService { get; set; }
        public RewardController(RewardService rewardService)
        {
            RewardService = rewardService;
        }
        public IActionResult Index()
        {
            List<Reward> allRewards = RewardService.GetAllRewards();
            return View(allRewards);
        }


        public IActionResult AddReward()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddReward(Reward reward)
        {
            RewardService.AddReward(reward);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(Guid Id)
        {
            Reward RewardToBeEdited = RewardService.GetRewardFromId(Id);
            return View(RewardToBeEdited);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirmed(Reward newReward)
        {
            RewardService.DeleteReward(newReward.Id);
            AddReward(newReward);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(Guid Id)
        {
            Reward RewardToBeDeleted = RewardService.GetRewardFromId(Id);
            return View(RewardToBeDeleted);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid Id)
        {
            Reward RewardToBeDeleted = RewardService.GetRewardFromId(Id);
            RewardService.DeleteReward(Id);
            return RedirectToAction(nameof(Index));
        }



    }
}
