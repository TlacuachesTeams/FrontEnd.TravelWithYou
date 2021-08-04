
namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Package Cart
    /// </summary>
   public class PackageCart
    {
        /// <summary>
        /// Hash Code
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Service Hotel
        /// </summary>
        public HotelCart Hotel { get; set; }

        /// <summary>
        /// Service Flight
        /// </summary>
        public FlightCart Flight { get; set; }
    }
}
