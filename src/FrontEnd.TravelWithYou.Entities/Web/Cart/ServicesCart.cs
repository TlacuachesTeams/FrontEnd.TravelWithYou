using FrontEnd.TravelWithYou.Entities.Common;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// Services Cart
    /// </summary>
    public class ServicesCart
    {
        /// <summary>
        /// Search Client
        /// </summary>
        public ServiceTypeEnum ServiceType { get; set; }

        /// <summary>
        /// Hotel
        /// </summary>
        public ServiceHotelCart Hotel { get; set; }

        /// <summary>
        /// Tour
        /// </summary>
        public ServiceTourCart Tour { get; set; }

        /// <summary>
        /// Insurance
        /// </summary>
        public ServiceInsuranceCart Insurance { get; set; }

        /// <summary>
        /// Shuttle
        /// </summary>
        public ServiceShuttleCart Shuttle { get; set; }

        /// <summary>
        /// Car
        /// </summary>
        public ServiceHotelCart Car { get; set; }

        /// <summary>
        /// Flight
        /// </summary>
        public ServiceFlightCart Flight { get; set; }

        /// <summary>
        /// Package
        /// </summary>
        public ServicePackageCart Package { get; set; }

    }
}
