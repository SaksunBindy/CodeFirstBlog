using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class SpotRepository
    {
        public GameContext GameContext { get; set; }
        public SpotRepository(GameContext gameContext)
        {
            GameContext = gameContext;
        }

        public void AddSpot(Spot spot)
        {
            GameContext.Add(spot);
            GameContext.SaveChanges();
        }
        public void DeleteSpot(Spot spot)
        {
            GameContext.Remove(spot);
            GameContext.SaveChanges();
        }
        public List<Spot> GetAllSpots()
        {
            List<Spot> allSpots = GameContext.Spots.ToList();
            return allSpots;
        }
    }
}
