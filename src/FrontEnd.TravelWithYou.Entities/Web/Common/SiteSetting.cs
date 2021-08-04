using System.Collections.Generic;

namespace FrontEnd.TravelWithYou.Entities.Web.Common
{
    /// <summary>
    /// Global uri info class
    /// </summary>
    public class SiteSetting
    {
        /// <summary>
        /// Gets or sets the domain Id
        /// </summary>
        public int DomainId { get; set; }

        /// <summary>
        /// Gets or sets  the complete uri
        /// </summary>
        public List<string> Uri { get; set; }

        /// <summary>
        /// Gets or sets the uri Payment
        /// </summary>
        public string UriPayment { get; set; }

        /// <summary>
        /// Gets or sets the Uri Api for general requests.
        /// </summary>
        public string UriApi { get; set; }

        /// <summary>
        /// Gets or sets the authorization string
        /// </summary>
        public string Authorization { get; set; }

        /// <summary>
        /// Gets or sets the api key string
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the affiliate Id for request
        /// </summary>
        public string AffiliateId { get; set; }

        /// <summary>
        /// Gets or sets the market Id
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// Gets or sets the language Id for requests
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the currency Id for requests
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the channel sale id
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// Gets or sets the channel sell Id Domain
        /// </summary>
        public string ChannelSell { get; set; }

        /// <summary>
        /// Gets or sets the geolocalisation
        /// </summary>
        public string GTM { get; set; }

        /// <summary>
        /// Gets or sets the user Id for request
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the spanish domain
        /// </summary>
        public string DomainSpanish { get; set; }

        /// <summary>
        /// Gets or sets the english domain
        /// </summary>
        public string DomainEnglish { get; set; }

        /// <summary>
        /// Gets or sets the actual host
        /// </summary>
        public string Host { get; set; } = "";
    }
}
