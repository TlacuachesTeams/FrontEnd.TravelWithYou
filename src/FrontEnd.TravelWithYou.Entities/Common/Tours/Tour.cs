using FrontEnd.TravelWithYou.Entities.Common.Categories;
using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.Tours
{
    public class Tour: BaseTour
    {
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

    }
}
