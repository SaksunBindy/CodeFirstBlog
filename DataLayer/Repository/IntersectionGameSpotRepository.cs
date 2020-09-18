using DataLayer.Context;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class IntersectionGameSpotRepository
    {
        public GameContext GameContext { get; set; }
        public IntersectionGameSpotRepository(GameContext gameContext)
        {
            GameContext = gameContext;
        }
        public void AddIntersection(IntersectionGameSpot intersectionGameSpot)
        {
            GameContext.Add(intersectionGameSpot);
            GameContext.SaveChanges();
        }
        public List<IntersectionGameSpot> GetAllIntersections()
        {
            List<IntersectionGameSpot> allIntersections = GameContext.IntersectionGameSpots.ToList();
            return allIntersections;
        }
    }
}