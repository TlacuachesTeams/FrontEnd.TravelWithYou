using FrontEnd.TravelWithYou.Entities.Common.Destinations;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Catalogs.Destinations
{
    /// <summary>
    /// Catalog Destinations
    /// </summary>
    public class CatalogDestinationsRS
    {
        /// <summary>
        /// Destinations
        /// </summary>
        public List<BaseDestination> Destinations { get; set; }
    }
}
