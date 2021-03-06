using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.Shuttles
{
    /// <summary>
    /// Shuttle
    /// </summary>
    public class Shuttle: BaseShuttle
    {
       
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

    }
}
