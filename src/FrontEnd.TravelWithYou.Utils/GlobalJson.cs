using FrontEnd.TravelWithYou.Entities.Web.Common;
using FrontEnd.TravelWithYou.Utils.Interfaz;
using Microsoft.AspNetCore.Http;

namespace FrontEnd.TravelWithYou.Utils
{
    /// <summary>
    /// Global json class
    /// </summary>
    public class GlobalJson : IGlobalJson
    {
        private readonly IHttpContextAccessor context;

        /// <summary>
        /// GlobalJson constructor
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="_options"></param>
        public GlobalJson(IHttpContextAccessor _context)
        {
            context = _context;
        }

        /// <summary>
        /// Get the global uri info.
        /// </summary>
        public SiteSetting GlobalUriInfo(GlobalSetting global)
        {           
            SiteSetting siteSetting = null;
            try
            {
                //Intenta buscarlo el sitio en el JSON
                if (global != null)
                {
                    var urlHost = context.HttpContext.Request.Host.Host;
                    siteSetting = global.Site.Find(s => s.Uri.Contains(urlHost));
                }
            }
            finally {
                //El sitio no fue encontrado en globales
                if (siteSetting == null)
                {
                    siteSetting = new SiteSetting
                    {
                        Host = "unknown",
                        Language = "es-MX",
                        Channel = "ON",
                        ChannelSell = "WEB",
                        Currency = "MXN"
                    };
                }
            }
            return siteSetting;
        }
    }
}
