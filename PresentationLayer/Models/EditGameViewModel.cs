using DataLayer.Models;
using System.Collections.Generic;

namespace PresentationLayer.Models
{
    public class EditGameViewModel
    {
        public GameModel GameModel { get; set; }
        public List<IntersectionGameSpot> IntersectionGameSpots { get; set; }
        public List<IntersectionGameReward> IntersectionGameRewards { get; set; }
        public List<Spot> Spots { get; set; }
        public List<Reward> Rewards { get; set; }
    }
}
