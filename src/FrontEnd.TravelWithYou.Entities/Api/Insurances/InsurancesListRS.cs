
using FrontEnd.TravelWithYou.Entities.Common.Insurances;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Insurances
{

    /// <summary>
    /// Tours List
    /// </summary>
    public class InsurancesListRS
    {
        /// <summary>
        /// Hotels
        /// </summary>
        public List<Insurance> Insurances { get; set; }

        /// <summary>
        /// Insurances List Filters
        /// </summary>
        public InsurancesListFilters Filters { get; set; }
    }
}
