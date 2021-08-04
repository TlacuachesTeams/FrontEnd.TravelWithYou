using FrontEnd.TravelWithYou.Entities.Common.Categories;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Api.Catalogs.Categories
{
    /// <summary>
    /// Catalog Categories
    /// </summary>
    public class CatalogCategoriesRS
    {
        /// <summary>
        /// Categories
        /// </summary>
        public List<BaseCategory> Categories { get; set; }
    }
}
