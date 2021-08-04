using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using FrontEnd.TravelWithYou.Entities.Common.Hotels.Rooms.Rates;
using FrontEnd.TravelWithYou.Entities.Common.Hotels.Rooms.Texts;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.Hotels.Rooms
{
    /// <summary>
    /// Room
    /// </summary>
    public class Room
    {
        /// <summary>
        /// Room Id
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// Room Name
        /// </summary>
        public int RoomName { get; set; }

        /// <summary>
        /// Short Description
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Long Description
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// Room Galleries
        /// </summary>
        public List<Gallery> Galleries { get; set; }

        /// <summary>
        /// Room Contents
        /// </summary>
        public List<Content> Texts { get; set; }

        /// <summary>
        /// Room Rates
        /// </summary>
        public List<RoomRate> Rates { get; set; }

    }
}
