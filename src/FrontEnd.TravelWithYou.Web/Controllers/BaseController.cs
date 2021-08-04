using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class BaseController : Controller
    {

        public BaseController() { 
        
        }

        /// <summary>
        /// Get Configuration Site
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetConfigurationSite()
        {
            return await Task.FromResult<string>("");
        }
    }
}
