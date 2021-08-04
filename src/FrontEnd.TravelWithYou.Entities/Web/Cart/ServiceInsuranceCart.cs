
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Service Insurance Cart
    /// </summary>
    public class ServiceInsuranceCart
    {
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Insurances
        /// </summary>
        public List<InsuranceCart> Insurances { get; set; }

    }
}
