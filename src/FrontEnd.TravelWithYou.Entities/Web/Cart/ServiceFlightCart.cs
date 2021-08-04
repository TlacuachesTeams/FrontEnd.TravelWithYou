
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Service Flight Cart
    /// </summary>
    public class ServiceFlightCart
    {
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Flights
        /// </summary>
        public List<FlightCart> Flights { get; set; }

    }
}
