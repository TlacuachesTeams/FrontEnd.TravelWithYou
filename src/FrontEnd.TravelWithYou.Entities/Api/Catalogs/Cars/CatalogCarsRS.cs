using FrontEnd.TravelWithYou.Entities.Common.Cars;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Catalogs.Cars
{
    /// <summary>
    /// Catalog Cars
    /// </summary>
    public class CatalogCarsRS
    {
        /// <summary>
        /// Cars
        /// </summary>
        public List<BaseCar> Cars { get; set; }
    }
}
