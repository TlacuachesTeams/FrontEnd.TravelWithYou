
using FrontEnd.TravelWithYou.Entities.Common.Shuttles;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Shuttles
{

    /// <summary>
    /// Shuttles List
    /// </summary>
    public class ShuttlesListRS
    {
        /// <summary>
        /// Shuttles
        /// </summary>
        public List<Shuttle> Shuttles { get; set; }

        /// <summary>
        /// Shuttles List Filters
        /// </summary>
        public ShuttlesListFilters Filters { get; set; }
    }
}
