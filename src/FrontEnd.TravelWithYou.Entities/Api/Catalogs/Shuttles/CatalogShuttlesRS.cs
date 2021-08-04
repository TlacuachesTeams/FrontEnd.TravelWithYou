using FrontEnd.TravelWithYou.Entities.Common.Shuttles;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Catalogs.Shuttles
{
    /// <summary>
    /// Catalog Shuttles
    /// </summary>
    public class CatalogShuttlesRS
    {

        /// <summary>
        /// Shuttles
        /// </summary>
        public List<BaseShuttle> Shuttles { get; set; }
    }
}
