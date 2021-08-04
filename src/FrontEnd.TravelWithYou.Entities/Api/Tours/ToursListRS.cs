
using FrontEnd.TravelWithYou.Entities.Common.Tours;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Tours
{

    /// <summary>
    /// Tours List
    /// </summary>
    public class ToursListRS
    {
        /// <summary>
        /// Tours
        /// </summary>
        public List<Tour> Tours { get; set; }

        /// <summary>
        /// Tours List Filters
        /// </summary>
        public ToursListFilters Filters { get; set; }
    }
}
