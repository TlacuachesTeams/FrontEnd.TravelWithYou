
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Service Package Cart
    /// </summary>
    public class ServicePackageCart
    {
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Packages
        /// </summary>
        public List<PackageCart> Packages { get; set; }

    }
}
