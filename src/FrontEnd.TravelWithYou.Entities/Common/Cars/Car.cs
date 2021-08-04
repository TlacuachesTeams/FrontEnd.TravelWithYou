using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.Cars
{
    /// <summary>
    /// Car
    /// </summary>
    public class Car: BaseCar
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
        /// Car Galleries
        /// </summary>
        public List<Gallery> Galleries { get; set; }

    }
}
