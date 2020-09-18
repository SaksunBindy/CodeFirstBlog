using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class RewardRepository
    {
        public GameContext GameContext { get; set; }
        public RewardRepository(GameContext gameContext)
        {
            GameContext = gameContext;
        }
        public void AddReward(Reward reward)
        {
            GameContext.Add(reward);
            GameContext.SaveChanges();
        }

        public List<Reward> GetAllRewards()
        {
            List<Reward> allRewards = GameContext.Rewards.ToList();
            return allRewards;
        }

        public void DeleteReward(Reward rewardToBeDeleted)
        {
            GameContext.Remove(rewardToBeDeleted);
            GameContext.SaveChanges();
        }
    }
}
