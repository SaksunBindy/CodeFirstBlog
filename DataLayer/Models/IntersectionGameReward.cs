using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class IntersectionGameReward
    {
        public GameModel GameModel { get; set; }

        public Guid GameId { get; set; }
        public Reward Reward { get; set; }
        public Guid RewardId{ get; set; }
    }
}