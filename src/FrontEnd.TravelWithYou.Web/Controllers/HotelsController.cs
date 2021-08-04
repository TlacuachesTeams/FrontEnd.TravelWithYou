using FrontEnd.TravelWithYou.Entities.Web.Hotels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class HotelsController: BaseController
    {

        private readonly ILogger<HotelsController> _logger;

        public HotelsController(ILogger<HotelsController> logger) : base()
        {
            _logger = logger;
        }

        [Route("hoteles/{destinatonuri}/")]
        [Route("hoteles/{destinatonuri}/{checkin}/{checkout}")]
        [Route("hoteles/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("hoteles/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        [Route("hotels/{destinatonuri}/")]
        [Route("hotels/{destinatonuri}/{checkin}/{checkout}")]
        [Route("hotels/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("hotels/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]     
        public IActionResult Index([FromRoute] HotelsRQ request,  [FromQuery] string sid)
        {
            return View();
        }

        [Route("hoteles/{destinatonuri}/{hoteluri}/")]
        [Route("hoteles/{destinatonuri}/{hoteluri}/{checkin}/{checkout}")]
        [Route("hoteles/{destinatonuri}/{hoteluri}/{checkin}/{checkout}/{occupancy}")]
        [Route("hoteles/{destinatonuri}/{hoteluri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        [Route("hotels/{destinatonuri}/{hoteluri}/")]
        [Route("hotels/{destinatonuri}/{hoteluri}/{checkin}/{checkout}")]
        [Route("hotels/{destinatonuri}/{hoteluri}/{checkin}/{checkout}/{occupancy}")]
        [Route("hotels/{destinatonuri}/{hoteluri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        public IActionResult Detail([FromRoute] HotelsRQ request, [FromQuery] string sid)
        {
            return View();
        }

    }
}
