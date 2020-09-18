using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class GameModel : BaseModel
    {
        public GameModel()
        {
        }
        public string City { get; set; }
        public ICollection<IntersectionGameSpot> IntersectionGameSpots { get; set; }
        public ICollection<IntersectionGameReward> IntersectionGameRewards { get; set; }
    }
}
