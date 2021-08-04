
using FrontEnd.TravelWithYou.Entities.Web.Common;

namespace FrontEnd.TravelWithYou.Entities.Web.Cart
{
    /// <summary>
    /// The session cart class
    /// </summary>
    public class SessionCart
    {        
        /// <summary>
        /// Site Setting (Sepcific Host)
        /// </summary>
        public SiteSetting Site { get; set; }

        /// <summary>
        /// Cart
        /// </summary>
        public ServicesCart Cart { get; set; }
       
    }
}
