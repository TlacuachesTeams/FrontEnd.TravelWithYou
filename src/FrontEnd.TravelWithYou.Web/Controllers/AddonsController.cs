using FrontEnd.TravelWithYou.Entities.Web.Hotels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class AddonsController : BaseController
    {

        private readonly ILogger<AddonsController> _logger;

        public AddonsController(ILogger<AddonsController> logger) : base()
        {
            _logger = logger;
        }

        [Route("addons/{hash}/")]        
        [Route("serviciosadicionales/{hash}/")]       
        public IActionResult Index([FromRoute] HotelsRQ request, [FromQuery] string sid)
        {
            return View();
        }


    }
}
