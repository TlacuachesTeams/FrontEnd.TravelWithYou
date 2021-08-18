using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.PointsInterest
{
    public class PointInterest
    {
        public int InterestPointId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public List<Gallery> Galleries { get; set; }
    }
}
