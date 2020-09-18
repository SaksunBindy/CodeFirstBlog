using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Models
{
    public class IntersectionGameSpot
    {
        public GameModel GameModel { get; set; }
        public Guid GameId { get; set; }
        public Spot Spot { get; set; }
        public Guid SpotId{ get; set; }
    }
}