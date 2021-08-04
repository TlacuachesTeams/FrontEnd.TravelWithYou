using FrontEnd.TravelWithYou.Entities.Web.Tours;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontEnd.TravelWithYou.Web.Controllers
{
    public class ToursController: BaseController
    {

        private readonly ILogger<ToursController> _logger;

        public ToursController(ILogger<ToursController> logger) : base()
        {
            _logger = logger;
        }

        [Route("tours/{destinatonuri}/")]
        [Route("tours/{destinatonuri}/{checkin}/{checkout}")]
        [Route("tours/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("tours/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        [Route("activities/{destinatonuri}/")]
        [Route("activities/{destinatonuri}/{checkin}/{checkout}")]
        [Route("activities/{destinatonuri}/{checkin}/{checkout}/{occupancy}")]
        [Route("activities/{destinatonuri}/{checkin}/{checkout}/{occupancy}/{hash}")]
        public IActionResult Index([FromRoute] ToursRQ request, [FromQuery] string sid)
        {
            return View();
        }
    }
}
