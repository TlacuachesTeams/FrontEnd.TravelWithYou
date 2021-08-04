
using FrontEnd.TravelWithYou.Entities.Web.Common;

namespace FrontEnd.TravelWithYou.Utils.Interfaz
{
    /// <summary>
    /// Global Json interface
    /// </summary>
    public interface IGlobalJson
    {
        /// <summary>
        /// Get the global uri info
        /// </summary>
        SiteSetting GlobalUriInfo(GlobalSetting global);
    }
}
