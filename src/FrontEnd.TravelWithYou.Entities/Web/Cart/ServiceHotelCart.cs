using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Service Hotels Cart
    /// </summary>
    public class ServiceHotelCart
    {
        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Hotels
        /// </summary>
        public List<HotelCart> Hotels { get; set; }

    }
}
