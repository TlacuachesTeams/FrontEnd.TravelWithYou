using FrontEnd.TravelWithYou.Entities.Common.Galleries;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Common.Insurances
{
    /// <summary>
    /// Insurance
    /// </summary>
    public class Insurance: BaseInsurance
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
        /// Insurance Galleries
        /// </summary>
        public List<Gallery> Galleries { get; set; }

    }
}
