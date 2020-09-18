using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class SpotService
    {
        public SpotRepository SpotRepository { get; set; }
        public SpotService(SpotRepository spotRepository)
        {
            SpotRepository = spotRepository;
        }
        public void AddSpot(Spot spot)
        {
            SpotRepository.AddSpot(spot);
        }
        public List<Spot> GetAllSpots()
        {
            List<Spot> allSpots = SpotRepository.GetAllSpots();
            return allSpots;
        }
        public Spot GetSpotFromId(Guid Id)
        {
            List<Spot> allSpots = GetAllSpots();
            Spot spot = allSpots.FirstOrDefault(m => m.Id == Id);
            return spot;
        }

        public void DeleteSpot(Guid Id)
        {
            Spot spotToBeDeleted = GetSpotFromId(Id);
            SpotRepository.DeleteSpot(spotToBeDeleted);
        }
    }
}
