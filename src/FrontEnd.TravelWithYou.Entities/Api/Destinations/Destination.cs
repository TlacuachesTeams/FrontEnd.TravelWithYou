using FrontEnd.TravelWithYou.Entities.Common.Destinations;
using System.Collections.Generic;
using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using FrontEnd.TravelWithYou.Entities.Common.PointsInterest;

namespace FrontEnd.TravelWithYou.Entities.Destinations 
{
    public class Destination : BaseDestination
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string DestinationUri {get;set;}
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public List<Gallery> Galleries {get;set;}

        public List<PointInterest> PointsInterest { get; set; }

    }



}
