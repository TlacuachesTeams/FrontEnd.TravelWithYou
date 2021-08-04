
using FrontEnd.TravelWithYou.Entities.Common.Hotels;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Hotels
{

    /// <summary>
    /// Hotel List
    /// </summary>
    public class HotelsListRS
    {
        /// <summary>
        /// Hotels
        /// </summary>
        public List<Hotel> Hotels { get; set; }

        /// <summary>
        /// Hotel List Filters
        /// </summary>
        public HotelsListFilters Filters { get; set; }
    }
}
