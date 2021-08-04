using FrontEnd.TravelWithYou.Entities.Common.Categories;
using FrontEnd.TravelWithYou.Entities.Common.Destinations;
using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using FrontEnd.TravelWithYou.Entities.Common.Hotels.Rooms;
using FrontEnd.TravelWithYou.Entities.Common.Hotels.Texts;
using FrontEnd.TravelWithYou.Entities.Common.Zones;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.Hotels
{
    public class Hotel: BaseHotel
    {
        /// <summary>
        /// Hotel City
        /// </summary>
        public BaseDestination Destination { get; set; }

        /// <summary>
        /// Hotel Zone
        /// </summary>
        public BaseZone Zone { get; set; }

        /// <summary>
        /// Hotel Category
        /// </summary>
        public BaseCategory Category { get; set; }

        /// <summary>
        /// Short Description
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Long Description
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// Hotel Galleries
        /// </summary>
        public List<Gallery> Galleries { get; set; }

        /// <summary>
        /// Hotel Galleries
        /// </summary>
        public List<Content> Texts { get; set; }

        /// <summary>
        /// Rooms
        /// </summary>
        public List<Room> Rooms { get; set; }

    }
}
