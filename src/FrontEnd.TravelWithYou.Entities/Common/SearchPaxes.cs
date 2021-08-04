using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common
{
    public class SearchPaxes
    {
        /// <summary>
        /// Total Rooms
        /// </summary>
        public int TotalRooms { get; set; }

        /// <summary>
        /// Total Paxes
        /// </summary>
        public int TotalAdults { get; set; }

        /// <summary>
        /// Total Children
        /// </summary>
        public int TotalChildren { get; set; }

        /// <summary>
        /// Child Ages (All  Children)
        /// </summary>
        public string ChildrenAges { get; set; }

        /// <summary>
        /// Paxes Occupancy
        /// </summary>
        public List<Occupancy> PaxesOccupancy { get; set; }
    }
}
