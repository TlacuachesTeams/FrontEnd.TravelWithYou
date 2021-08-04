
using FrontEnd.TravelWithYou.Entities.Common.Cars;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Cars
{

    /// <summary>
    /// Cars List
    /// </summary>
    public class CarsListRS
    {
        /// <summary>
        /// Cars
        /// </summary>
        public List<Car> Cars { get; set; }

        /// <summary>
        /// Car List Filters
        /// </summary>
        public CarsListFilters Filters { get; set; }
    }
}
