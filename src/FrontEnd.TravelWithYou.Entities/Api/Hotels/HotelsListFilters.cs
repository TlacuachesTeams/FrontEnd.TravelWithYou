
using FrontEnd.TravelWithYou.Entities.Common;
using FrontEnd.TravelWithYou.Entities.Common.Categories;
using FrontEnd.TravelWithYou.Entities.Common.Cities;
using FrontEnd.TravelWithYou.Entities.Common.Zones;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Hotels
{

    /// <summary>
    /// Hotel List Catalog
    /// </summary>
    public class HotelsListFilters
    {
        /// <summary>
        /// Range Rate (Minimum and Maximum)
        /// </summary>
        public RangePrice RangePrice { get; set; }

        /// <summary>
        /// Hotel Categories
        /// </summary>
        public List<BaseCategory> Categories { get; set; }

        /// <summary>
        /// Hotel Zones
        /// </summary>
        public List<BaseZone> Zones { get; set; }

        /// <summary>
        /// Hotel Cities
        /// </summary>
        public List<BaseCity> Cities { get; set; }

    }
}
