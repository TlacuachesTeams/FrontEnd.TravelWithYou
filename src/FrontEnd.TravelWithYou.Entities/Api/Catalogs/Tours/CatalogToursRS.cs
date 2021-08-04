using FrontEnd.TravelWithYou.Entities.Common.Tours;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Catalogs.Tours
{
    /// <summary>
    /// Catalog Tours
    /// </summary>
    public class CatalogToursRS
    {
        /// <summary>
        /// Tours
        /// </summary>
        public List<BaseTour> Tours { get; set; }
    }
}
