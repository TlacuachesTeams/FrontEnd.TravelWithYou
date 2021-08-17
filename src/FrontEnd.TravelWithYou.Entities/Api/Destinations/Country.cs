using FrontEnd.TravelWithYou.Entities.Destinations;
using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Destinations
{
    public class Country
    {
        public string CountryName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Gallery> Galleries { get; set; }        
        public List<Destination> Destinations { get; set; }
    }
}
