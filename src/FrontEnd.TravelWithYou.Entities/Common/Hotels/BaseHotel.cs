using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.TravelWithYou.Entities.Common.Hotels
{
    /// <summary>
    /// Base Hotel
    /// </summary>
    public class BaseHotel
    {
        /// <summary>
        /// Hotel ID
        /// </summary>
        public int HotelId { get; set; }

        /// <summary>
        /// Hotel Name
        /// </summary>
        public string HotelName { get; set; }
    }
}
