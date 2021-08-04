using FrontEnd.TravelWithYou.Entities.Web.Cart;
using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Common
{
    /// <summary>
    /// Global Setting
    /// </summary>
    public class GlobalSetting
    {
        /// <summary>
        /// Gets or sets the site list. (Glbobal Setting Json Sites)
        /// </summary>
        public List<SiteSetting> Site { get; set; }

        /// <summary>
        /// Cart
        /// </summary>
        public ServicesCart Cart { get; set; }
    }
}
