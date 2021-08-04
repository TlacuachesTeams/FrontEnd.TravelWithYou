using FrontEnd.TravelWithYou.Entities.Common.Cancellations;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.Hotels.Rooms.Rates
{
    /// <summary>
    /// Room Rate
    /// </summary>
    public class RoomRate
    {
        /// <summary>
        /// Meal Plan Id
        /// </summary>
        public int MealPlanId { get; set; }

        /// <summary>
        /// Meal Plan Name
        /// </summary>
        public string MealPlanName { get; set; }

        /// <summary>
        /// Total Public
        /// </summary>
        public decimal TotalPublic { get; set; }

        /// <summary>
        /// Net Rate
        /// </summary>
        public decimal NetRate { get; set; }

        /// <summary>
        /// Daily Rates
        /// </summary>
        public List<DailyRate> Days { get; set; }

        /// <summary>
        /// Cancellation Policies
        /// </summary>
        public List<Cancellation> Cancellations { get; set; }
    }
}
