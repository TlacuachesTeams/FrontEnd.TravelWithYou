using System;

namespace FrontEnd.TravelWithYou.Entities.Common.Hotels.Rooms.Rates
{

    /// <summary>
    /// Daily Rate
    /// </summary>
    public class DailyRate
    {
        /// <summary>
        /// Day
        /// </summary>
        public DateTime Day { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }
    }
}
