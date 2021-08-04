using FrontEnd.TravelWithYou.Entities.Web.Shuttles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class ShuttlesController: BaseController
    {

        private readonly ILogger<ShuttlesController> _logger;

        public ShuttlesController(ILogger<ShuttlesController> logger) : base()
        {
            _logger = logger;
        }

        [Route("transportacion/{destinatonuri}/")]
        [Route("transportacion/{destinatonuri}/{checkin}/{checkout}")]
        [Route("transportacion/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("transportacion/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        [Route("shuttles/{destinatonuri}/")]
        [Route("shuttles/{destinatonuri}/{checkin}/{checkout}")]
        [Route("shuttles/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("shuttles/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        public IActionResult Index([FromRoute] ShuttlesRQ request, [FromQuery] string sid)
        {
            return View();
        }
    }
}
