using System;

namespace FrontEnd.TravelWithYou.Entities.Common.Cancellations
{

    /// <summary>
    /// Cancellation
    /// </summary>
    public class Cancellation
    {

        /// <summary>
        /// Cancellation Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Cancellation Day
        /// </summary>
        public DateTime Day { get; set; }

        /// <summary>
        /// Cancellation Total
        /// </summary>
        public decimal Total { get; set; }
    }
}
