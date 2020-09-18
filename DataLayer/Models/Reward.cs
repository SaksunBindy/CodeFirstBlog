using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Reward : BaseModel
    {
        public string Rank { get; set; }
        public ICollection<IntersectionGameReward> IntersectionGameRewards { get; set; }
    }
}
