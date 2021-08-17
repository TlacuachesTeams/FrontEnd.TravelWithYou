using FrontEnd.TravelWithYou.Entities.Common.AboutUs;
using FrontEnd.TravelWithYou.Entities.Common.Metas;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Destinations 
{
    public class DestinationRS 
    {        
        public bool ReadFile { get; set; }
        public AboutUs AboutUs { get; set; }
        public MetaInfo Metas { get; set; }
        public List<Country> Countries { get; set; }
    }
}
