using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Spot : BaseModel  
    {
        public string Difficulty { get; set; }
        public ICollection<IntersectionGameSpot> IntersectionGameSpots { get; set; }
    }
}
