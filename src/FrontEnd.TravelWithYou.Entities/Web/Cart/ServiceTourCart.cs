using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Service Tours Cart
    /// </summary>
    public class ServiceTourCart
    {
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Tours
        /// </summary>
        public List<TourCart> Tours { get; set; }

    }
}
