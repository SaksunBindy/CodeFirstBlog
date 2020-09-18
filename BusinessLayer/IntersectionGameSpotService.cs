using DataLayer.Models;
using DataLayer.Repository;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class IntersectionGameSpotService
    {
        public IntersectionGameSpotRepository IntersectionGameSpotRepository { get; set; }
        public IntersectionGameSpotService(IntersectionGameSpotRepository intersectionGameSpotRepository)
        {
            IntersectionGameSpotRepository = intersectionGameSpotRepository;
        }
        public List<IntersectionGameSpot> GetAllIntersections()
        {
            List<IntersectionGameSpot> allIntersections = IntersectionGameSpotRepository.GetAllIntersections();
            return allIntersections;
        }
        public void AddIntersection(IntersectionGameSpot intersectionGameSpot)
        {
            IntersectionGameSpotRepository.AddIntersection(intersectionGameSpot);
        }
    }
}