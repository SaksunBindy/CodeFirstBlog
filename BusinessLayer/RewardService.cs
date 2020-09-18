using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class RewardService
    {
        public RewardRepository RewardRepository { get; set; }
        public RewardService(RewardRepository rewardRepository)
        {
            RewardRepository = rewardRepository;
        }
        public void AddReward(Reward reward)
        {
            RewardRepository.AddReward(reward);
        }
        public List<Reward> GetAllRewards()
        {
            List<Reward> allRewards = RewardRepository.GetAllRewards();
            return allRewards;
        }
        public Reward GetRewardFromId(Guid Id)
        {
            List<Reward> allRewards = GetAllRewards();
            Reward reward = allRewards.FirstOrDefault(m => m.Id == Id);
            return reward;
        }

        public void DeleteReward(Guid Id)
        {
            Reward rewardToBeDeleted = GetRewardFromId(Id);
            RewardRepository.DeleteReward(rewardToBeDeleted);
        }
    }
}