using FrontEnd.TravelWithYou.Entities.Flights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class FlightsController: BaseController
    {

        private readonly ILogger<FlightsController> _logger;

        public FlightsController(ILogger<FlightsController> logger) : base()
        {
            _logger = logger;
        }

        [Route("vuelos/{origen}/{destination}/")]
        [Route("vuelos/{origen}/{destination}/{checkin}/{checkout}")]
        [Route("vuelos/{origen}/{destination}/{checkin}/{checkout}/{occupancy}")]
        [Route("vuelos/{origen}/{destination}/{checkin}/{checkout}/{occupancy}/{hash}")]
        [Route("flights/{origen}/{destination}/")]
        [Route("flights/{origen}/{destination}/{checkin}/{checkout}")]
        [Route("flights/{origen}/{destination}/{checkin}/{checkout}/{occupancy}")]
        [Route("flights/{origen}/{destination}/{checkin}/{checkout}/{occupancy}/{hash}")]        
        public IActionResult Index([FromRoute] FlightsRQ request, [FromQuery] string sid)
        {
            return View();
        }
    }
}
