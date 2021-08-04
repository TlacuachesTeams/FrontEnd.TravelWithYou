using FrontEnd.TravelWithYou.Entities.Web.Packages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class PackagesController: BaseController
    {

        private readonly ILogger<PackagesController> _logger;

        public PackagesController(ILogger<PackagesController> logger) : base()
        {
            _logger = logger;
        }

        [Route("paquetes/{origen}/{destination}/")]
        [Route("paquetes/{origen}/{destination}/{checkin}/{checkout}")]
        [Route("paquetes/{origen}/{destination}/{checkin}/{checkout}/{occupancy}")]
        [Route("paquetes/{origen}/{destination}/{checkin}/{checkout}/{occupancy}/{hash}")]
        [Route("packages/{origen}/{destination}/")]
        [Route("packages/{origen}/{destination}/{checkin}/{checkout}")]
        [Route("packages/{origen}/{destination}/{checkin}/{checkout}/{occupancy}")]
        [Route("packages/{origen}/{destination}/{checkin}/{checkout}/{occupancy}/{hash}")]
        public IActionResult List([FromRoute] PackagesRQ request, [FromQuery] string sid)
        {
            return View();
        }
    }
}
