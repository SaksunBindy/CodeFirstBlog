using DataLayer.Context;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class IntersectionGameRewardRepository
    {
        public GameContext GameContext { get; set; }
        public IntersectionGameRewardRepository(GameContext gameContext)
        {
            GameContext = gameContext;
        }
        public void AddIntersection(IntersectionGameReward intersectionGameReward)
        {
            GameContext.Add(intersectionGameReward);
            GameContext.SaveChanges();
        }
        public List<IntersectionGameReward> GetAllIntersections()
        {
            List<IntersectionGameReward> allIntersections = GameContext.IntersectionGameRewards.ToList();
            return allIntersections;
        }
    }
}