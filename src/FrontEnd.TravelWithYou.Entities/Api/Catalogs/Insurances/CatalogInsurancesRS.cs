using FrontEnd.TravelWithYou.Entities.Common.Insurances;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Catalogs.Insurances
{
    /// <summary>
    /// Catalog Insurances
    /// </summary>
    public class CatalogInsurancesRS
    {

        /// <summary>
        /// Insurances
        /// </summary>
        public List<BaseInsurance> Insurances { get; set; }
    }
}
