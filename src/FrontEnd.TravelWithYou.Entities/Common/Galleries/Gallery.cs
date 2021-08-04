using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.TravelWithYou.Entities.Common.Galleries
{
   public class Gallery: BaseGallery
    {
        /// <summary>
        /// Image Path
        /// </summary>
        public string ImagePathLarge { get; set; }

        /// <summary>
        /// Image Path
        /// </summary>
        public string ImagePathSmall { get; set; }

        /// <summary>
        /// Is Principal Image
        /// </summary>
        public bool IsPrincipal { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// Image Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Image Description
        /// </summary>
        public string Description { get; set; }
    }
}
