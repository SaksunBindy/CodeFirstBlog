using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Models
{
    public class AddGameViewModel
    {
        public GameModel GameModel { get; set; }
        public List<Spot> Spots { get; set; }
        public List<Reward> Rewards { get; set; }
    }
}
