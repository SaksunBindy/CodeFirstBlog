using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class IntersectionGameRewardService
    {
        public IntersectionGameRewardRepository IntersectionGameRewardRepository { get; set; }
        public IntersectionGameRewardService(IntersectionGameRewardRepository intersectionGameRewardRepository)
        {
            IntersectionGameRewardRepository = intersectionGameRewardRepository;
        }
        public List<IntersectionGameReward> GetAllIntersections()
        {
            List<IntersectionGameReward> allIntersections = IntersectionGameRewardRepository.GetAllIntersections();
            return allIntersections;
        }
        public void AddIntersection(IntersectionGameReward intersectionGameReward)
        {
            IntersectionGameRewardRepository.AddIntersection(intersectionGameReward);
        }
    }
}