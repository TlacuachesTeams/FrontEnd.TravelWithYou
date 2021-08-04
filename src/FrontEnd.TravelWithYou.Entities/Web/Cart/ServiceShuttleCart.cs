
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Service Shuttle Cart
    /// </summary>
    public class ServiceShuttleCart
    {
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Shuttles
        /// </summary>
        public List<ShuttleCart> Shuttles { get; set; }

    }
}
