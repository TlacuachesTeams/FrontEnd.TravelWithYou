using FrontEnd.TravelWithYou.Entities.Common.Countries;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Catalogs.Countries
{
    /// <summary>
    /// Catalog Countries
    /// </summary>
    public class CatalogCountriesRS
    {
        /// <summary>
        /// Countries
        /// </summary>
        public List<BaseCountry> Countries { get; set; }
    }
}
